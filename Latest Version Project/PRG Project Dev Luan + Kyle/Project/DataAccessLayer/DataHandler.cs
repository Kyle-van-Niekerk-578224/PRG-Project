using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project
{
    class DataHandler
    {
        static string ConnectionString = "Server=.;Initial Catalog=ModulesDB;Integrated Security=True";

        public DataHandler() { }

        public DataTable GetModule()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("You are connected!");
            }
            string querry = "SELECT * FROM tblmodules";
            SqlDataAdapter adapter = new SqlDataAdapter(querry, connection);

            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public void DeleteModule(string code)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            string delete = $"DELETE tblmodules WHERE ModuleCode={code}";

            try
            {
                string message = "Are you sure you want to delete this module?";
                string title = "DELETE";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    SqlCommand deletecommand = new SqlCommand(delete, connection);
                    deletecommand.ExecuteNonQuery();
                    MessageBox.Show(code + " deleted successfully!");
                }
                else
                {
                    MessageBox.Show("Delete was aborted!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable SearchModule(string code)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("You are not connected!");
            }
            string querry = $"Select * From tblmodules Where ModuleCode = {code}";
            SqlDataAdapter adapter = new SqlDataAdapter(querry, connection);

            DataTable table = new DataTable();
            adapter.Fill(table);
            return (table);
        }

        public void AddModule(string code, string name, string links, string description)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            string addmodule = $"Insert Into tblmodules Values('{code}', '{name}', '{links}', '{description}')";
            SqlCommand addcommand = new SqlCommand(addmodule, connection);

            try
            {
                addcommand.ExecuteNonQuery();
                MessageBox.Show(name + " added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void UpdateModule(string code, string name, string links, string description)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            string updatemodule = $"Update tblmodules Set ModuleCode='{code}', ModuleName='{name}', ModuleLinks='{links}', ModuleDescription='{description}'";
            SqlCommand updatecommand = new SqlCommand(updatemodule, connection);
            try
            {
                updatecommand.ExecuteNonQuery();
                MessageBox.Show(name + " updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
