using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BusinessLogicLayer
{
    public class Employee
    {
        private string username, password;

        public Employee(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public override string ToString()
        {
            string result = username + "," + password;
            return result;
        }
    }
}
