using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Project.BusinessLogicLayer;
using System.Runtime.InteropServices;

namespace Project.DataAccessLayer
{
    public class txtFileHandler
    {
        //public const string path = @"F:\PRG Project\Project\DataLayer\Employees.txt"; //Absolute Path to txt data file
        //public const string path = @".\Project\DataLayer\Employees.txt"; //Finds Path + File, but does not work

        static string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location); //Relative Path to txt data file
        string path = dir + @"..\..\..\..\DataLayer\Employees.txt";

        public List<Employee> EmpList = new List<Employee>();   //For using in program
        public List<string> readList = new List<string> ();     //For Saving to file, updated alongside EmpList

        //Add Employee to List
        public void addEmployee(string name, string pass)
        {
            readList.Add(new Employee(name, pass).ToString());
            EmpList.Add(new Employee(name, pass));
        }

        //Write contents from a list to a txt file
        public void writeFile()
        {
            StreamWriter myWriter = new StreamWriter(path);
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
                readList.Add(line);   //Is a list of strings
                name = line.Split(new Char[] { ',' })[0];
                pass = line.Substring(line.LastIndexOf(',') + 1);
                addEmployee(name, pass);//Is a list of employees
            }
           
            myReader.Close();
            myStream.Close();
            
            return EmpList;
        }


        public int login(string name, string pass) // always 4, outputs " , "
        {
                        bool flagName = false;
                        bool flagPass = false;

                        string testName ="never", testPass = "changed";    //  <------------For Debugging, indicates if strings change from initial value

            //List Operator Iteration
            /*
            Employee search = searchByName(name);
            string realName = search.Username;
            string realPass = search.Password;

            if(search == null || realName == "" && realPass == "")
            {
                return 3;
            }
            else if (string.Equals(testName, name))
            {
                flagName = true;
                if (string.Equals(testPass, pass))
                {
                    flagPass = true;
                    return 1;
                }
                else if ((flagName == true) && (flagPass == false))
                {
                    return 2;
                }
            }
            */


            //For List iteration
            for (int i = 0; i < EmpList.Count; i++)
                        {
                            testName = EmpList[i].Username;
                            testPass = EmpList[i].Password;
                            if (string.Equals(testName, name))
                            {
                                flagName = true;
                                if (string.Equals(testPass, pass))
                                {
                                    flagPass = true;
                                    return 1;   // Valid username and password -> Login successful
                                }
                            }
                        }
 
                        if (flagPass == true && flagName == true)
                        {
                            return 1;   // Valid username and password -> Login successful
            }
                        else
                        if ((flagName == true) && (flagPass == false))
                        {
                            return 2;   // Valid username and wrong password -> Login fail, display message
            }
                        else
                            return 3;   // Invalid username and invalid password -> Login fail, display message
        }

        //Search for employees by Username
        public Employee searchByName(string name)
        {
            Employee result = EmpList.Find(obj => obj.Username == name);
            return result;
        }

        //Retrieve a password for a user by username
        public string viewPassword(string name)
        {
            string testName = "";

            for (int i = 0; i < EmpList.Count; i++)
            {
                testName = EmpList[i].Username;
                if (string.Equals(testName, name))
                {
                    return "The password for " +name+ " is: " + EmpList[i].Password;
                }
            }

            if (name == "")
            {
                return "Please enter the Username to retieve your password";
            }
            return "No user with the name " + name + " exists";
        }
    }

}
