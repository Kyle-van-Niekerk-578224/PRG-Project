using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Project.BusinessLogicLayer;

namespace Project.DataAccessLayer
{
    class txtFileHandler
    {
        //public const string path = @"F:\PRG Project\Project\DataLayer\Employees.txt"; //Absolute Path to txt data file
        //public const string path = @".\Project\DataLayer\Employees.txt"; //Finds Path + File, but does not work

        static string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location); //Relative Path to txt data file
        string path = dir + @"..\..\..\..\DataLayer\Employees.txt";

        public List<Employee> EmpList = new List<Employee>();
        public List<string> readList = new List<string> ();

        //Add Employee to List
        public void addEmployee(string name, string pass)
        {
            readList.Add(new Employee(name, pass).ToString());
            EmpList.Add(new Employee(name, pass));
        }
        
        //Write contents from a list to a txt file
        public void writeFile()
        {
            StreamWriter myWriter = new StreamWriter(path, true); //append, not overwrite
            foreach (var employee in EmpList)
            {
                myWriter.WriteLine(employee.ToString());
            }
            myWriter.Close();

        }

        //Reading from txt File to a list
        public List<Employee> readFile()
        {
            FileStream myStream = new FileStream(path, FileMode.OpenOrCreate);
            StreamReader myReader = new StreamReader(myStream);

            string line, name, pass;

            while ((line = myReader.ReadLine()) != null)
            {
                name = line.Split(new Char[] { ',' })[0];
                pass = line.Substring(line.LastIndexOf(',') + 1);
                EmpList.Add(new Employee(name, pass));
                readList.Add(new Employee(name,pass).ToString());
            }
            myReader.Close();
            myStream.Close();
            
            return EmpList;
        }
    }


}
