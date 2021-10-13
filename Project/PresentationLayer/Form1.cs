using Project.BusinessLogicLayer;
using Project.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
//using Microsoft.VisualBasic;

namespace Project
{
    public partial class Form1 : Form
    {
        public List<Employee> myEmployees = new List<Employee>();
        public txtFileHandler fh = new txtFileHandler();
        public Form1()
        {
            InitializeComponent();
            //DEBUG STUFF
            //Displays all registered users in a listbox
            /*
            for (int i = 0; i < myEmployees.Count; i++)
            {
                listBox1.Items.Add(myEmployees[i].ToString());
            }
            */
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
                int loginCode = fh.login(name, pass); 

                switch (loginCode)
                {
                    case 1:
                        {
                            MessageBox.Show("Welcome " + name);

                            //Change active Form to Form2
                            Form2 f2 = new Form2();
                            f2.Show();
                            this.Hide();
                        }
                        break;
                    case 2:
                        MessageBox.Show("Incorrect password for " + name);
                        break;
                    case 3:
                        MessageBox.Show("A user with these details does not exist");
                        break;
                    default:
                        MessageBox.Show("An error has occurred");
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

        private void Form1_Load(object sender, EventArgs e)
        {
            //Initialises list of employees from a text file
            myEmployees = fh.readFile();
        }

        private void btnUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Inputbox does not exist 
            //string input = Microsoft.VisualBasic.Interaction.InputBox("Enter you Username", "Forgot Password", "Default", 0, 0);
            string name = tbxName.Text;
            MessageBox.Show(fh.viewPassword(name));
        }
    }
}
