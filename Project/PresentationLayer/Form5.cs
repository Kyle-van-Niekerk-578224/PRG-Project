using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class Form5 : Form
    {
        List<string> modules = new List<string>();
        BindingSource bs = new BindingSource();
        DataHandler dh = new DataHandler();
        public static string code, name, links, descriptions;
        public Form5()
        {
            InitializeComponent();
            bs.DataSource = modules;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Module md = new Module((textBox1.Text), (textBox2.Text), (textBox8.Text),(richTextBox1.Text));  
            if (Form3.InsertOrUpdate == true)
            {
                dh.AddModule(Form5.code, Form5.name, Form5.links, Form5.descriptions);
            }
            else
            {
                dh.UpdateModule(Form5.code, Form5.name, Form5.links, Form5.descriptions);
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
           
        }

        private void Form5_Shown(object sender, EventArgs e)
        {
            code = textBox1.Text;
            name = textBox2.Text;
            links = textBox8.Text;
            descriptions = richTextBox1.Text;
        }
    }
}
