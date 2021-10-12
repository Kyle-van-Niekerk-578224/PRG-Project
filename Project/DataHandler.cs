using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class DataHandler
    {
        static string connectionString = "Data Source=LAPTOP-AFJTMQS9;Initial Catalog=BelgiumCampusDataBase;Integrated Security=True";
        SqlConnection sqlConnection;


        List<Module> ls = new List<Module>();
        public List<Module> getModule()
        {
            sqlConnection = new SqlConnection(connectionString);
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
                Console.WriteLine("Connection is opened");
                string qyery1 = "Select * from Students";

                SqlCommand cmd = new SqlCommand(qyery1, sqlConnection);
                Console.WriteLine("In getStudent()");
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ls.Add(new Module(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString()));
                    }
                }
            }
            else
                Console.WriteLine("Check the connection");

            return ls;
        }
        public string Delete(int num)
        {
            sqlConnection = new SqlConnection(connectionString);


            try
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand("ProcedureDelete", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id_delete", num);

                command.ExecuteNonQuery();
            }

            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
            return "Successfully Deleted";
        }

        public string update(int num)
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string name = "Doodu";
            string query2 = "UPDATE Students SET LastName='" + name + "' WHERE StudentID='" + num + "'";
            SqlCommand command = new SqlCommand(query2, sqlConnection);
            command.ExecuteNonQuery();
            return "Successfully updated";
        }
    }
}
