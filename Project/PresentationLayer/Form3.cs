using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form3 : Form
    {
        List<Module> s = new List<Module>();
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 nf = new Form2();
            nf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 nf = new Form5();
            nf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 nf = new Form5();
            nf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataHandler dh = new DataHandler();
            string msg = dh.Delete(int.Parse(textBox1.Text));
            MessageBox.Show(msg);
        }
    }
}
