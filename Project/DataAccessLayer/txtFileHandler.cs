using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Project.BusinessLogicLayer;

namespace Project.DataAccessLayer
{
    class txtFileHandler
    {
        public const string path = @"F:\PRG Project\Project\DataLayer\Employees.txt"; //Absolute Path to txt data file
        public List<string> EmpList = new List<string>();
        public List<Employee> readList = new List<Employee>();

        //Add Employee to List
        public void addEmployee(string name, string pass)
        {
            EmpList.Add(new Employee(name, pass).ToString());
            readList.Add(new Employee(name, pass));
        }
        
        //Write contents from a list to a txt file
        public void writeFile()
        {
            FileStream myStream = new FileStream(path, FileMode.OpenOrCreate);
            StreamReader myReader = new StreamReader(myStream);

            StreamWriter myWriter = new StreamWriter(path); // FILE IN USE
            foreach (var employee in EmpList)
            {
                myWriter.WriteLine(employee.ToString());
            }
            myWriter.Close();
        }

        //Reading from txt File to a list
        public List<string> readFile()
        {
            FileStream myStream = new FileStream(path, FileMode.OpenOrCreate);
            StreamReader myReader = new StreamReader(myStream);

            string line, name, pass;

            while ((line = myReader.ReadLine()) != null)
            {
                name = line.Split(new Char[] { ',' })[0];
                pass = line.Substring(line.LastIndexOf(',') + 1);
                readList.Add(new Employee(name,pass));
            }
            myReader.Close();
            myStream.Close();
            
            return EmpList;
        }
    }


}
