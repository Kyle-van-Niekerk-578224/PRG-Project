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
//using Project.BusinessLogicLayer;

namespace Project
{
    public partial class Form1 : Form
    {
        List<string> myEmployees = new List<string>();

        public Form1()
        {
            InitializeComponent();

            //Read File
            txtFileHandler fh = new txtFileHandler();
            myEmployees = fh.readFile();
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
            if ((tbxName.Text == null) &&(tbxName.Text == null))
            {
                MessageBox.Show("Please enter a username and password");
                flagValid = false;
            }
            else if (tbxName.Text == null)
            {
                MessageBox.Show("Please enter a username");
                flagValid = false;
            }
            else if (tbxName.Text == null)
            {
                MessageBox.Show("Please enter a password");
                flagValid = false;
            }
            if (flagValid == true)
            {
                txtFileHandler fh = new txtFileHandler();
                //fh.addEmployee(tbxName.Text, tbxPass.Text);
                //fh.writeFile();
                //MessageBox.Show("Successfully registered user " + tbxName.Text);
                tbxName.Text = "";
                tbxPass.Text = "";
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bool flagValid = true;
            if ((tbxName.Text == null) && (tbxName.Text == null))
            {
                MessageBox.Show("Please enter a username and password");
                flagValid = false;
            }
            else if (tbxName.Text == null)
            {
                MessageBox.Show("Please enter a username");
                flagValid = false;
            }
            else if (tbxName.Text == null)
            {
                MessageBox.Show("Please enter a password");
                flagValid = false;
            }
            if (flagValid == true)
            {
                txtFileHandler fh = new txtFileHandler();
                fh.addEmployee(tbxName.Text, tbxPass.Text);
                fh.writeFile();
                MessageBox.Show("Successfully registered user " + tbxName.Text);
                tbxName.Text = "";
                tbxPass.Text = "";
            }
        }
    }
}
