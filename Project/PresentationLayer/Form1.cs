using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.DataAccessLayer;
using Project.BusinessLogicLayer;
using System.Text.RegularExpressions;

namespace Project
{
    public partial class Form1 : Form
    {
        List<Employee> myEmployees = new List<Employee>();

        public Form1()
        {
            InitializeComponent();

            //Read File
            txtFileHandler fh = new txtFileHandler();
            myEmployees = fh.readFile();
            //DEBUG STUFF
            /*
            for (int i = 0; i < myEmployees.Count; i++)
            {
                listBox1.Items.Add(myEmployees[i].ToString());
            }
            */
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flagValid = true;
            string name = tbxName.Text, pass = tbxPass.Text;

            if ((name == "") &&(pass == ""))
            {
                MessageBox.Show("Please enter a username and password");
                flagValid = false;
            }
            else if (name == "")
            {
                MessageBox.Show("Please enter a username");
                flagValid = false;
            }
            else if (pass == "")
            {
                MessageBox.Show("Please enter a password");
                flagValid = false;
            }
            if (flagValid == true)
            {
                txtFileHandler fh = new txtFileHandler();

                int loginCode = fh.login(name, pass);   //<-----------ALWAYS RETURNS 4
                label1.Text = name; // FOR DEBUGGING
                label2.Text = pass; // FOR DEBUGGING

                switch (loginCode)
                {
                    case 1:
                        {
                            MessageBox.Show("Welcome " + name);
                            //change form--------------------------------
                            
                        }
                        break;
                    case 2:
                        MessageBox.Show("Incorrect password for " + name);
                        break;
                    case 3:
                        MessageBox.Show("Incorrect login details"); //For testing only, will not happen in final
                        break;
                    case 4:
                        MessageBox.Show("A user with these details does not exist");
                        break;
                    default:
                        // code block
                        break;
                }
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bool flagValid = true;
            string name = tbxName.Text, pass = tbxPass.Text;

            //Validation - Ensures fields are not null, only contain letters, numbers and "_"

            if(Regex.IsMatch(name, @"^[a-zA-Z0-9_]+$")) //Only letters + numbers + "_"
            {
                if ((name == "") && (pass == ""))
                {
                    MessageBox.Show("Please enter a username and password");
                    flagValid = false;
                }
                else if (name == "")
                {
                    MessageBox.Show("Please enter a username");
                    flagValid = false;
                }
                else if (pass == "")
                {
                    MessageBox.Show("Please enter a password");
                    flagValid = false;
                }

                //If all inputs are valid, message displays and employee is saved to file
                if (flagValid == true)
                {
                    txtFileHandler fh = new txtFileHandler();
                    fh.addEmployee(tbxName.Text, tbxPass.Text);
                    fh.writeFile();
                    MessageBox.Show("Successfully registered user " + tbxName.Text);
                    //tbxName.Text = ""; //text will stay for debugging
                    //tbxPass.Text = "";
                }
            }
            else
                MessageBox.Show("Your username should only contain letters, numbers, and aunderscores");
        }
    }
}
