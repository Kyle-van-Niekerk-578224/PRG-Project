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
        DataHandler dh = new DataHandler();
        public static string code;
        public static bool InsertOrUpdate;
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
            InsertOrUpdate = true;           
            Form5 nf = new Form5();
            nf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InsertOrUpdate = false;
            Form5 nf = new Form5();
            nf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dh.DeleteModule(code);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow r = this.dataGridView1.Rows[e.RowIndex];
                code = r.Cells["ModuleCode"].Value.ToString();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dh.GetModule();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dh.SearchModule(code);
        }
    }
}
