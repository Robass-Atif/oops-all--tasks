using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_with_window_form
{
    public partial class frmDeleteDoctor : Form
    {
        public frmDeleteDoctor()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAdminInterface a = new frmAdminInterface();
            a.Show();
        }
        public void printDoctor()
        {
            foreach (DoctorBL d in DoctorDL.doctors)
            {
                table.Rows.Add(d.getName(), d.getPassword(), d.getSalary(), d.getFee());
            }
        }
        public void emptyInput()
        {
            textBox1.Text = "";
        }
        private void updataGrid()
        {


            dataGridView1.DataSource = null;

            table.Rows.Clear();

            printDoctor();
            dataGridView1.DataSource = table;



            dataGridView1.Refresh();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string name = textBox1.Text;
            bool flag = DoctorDL.deleteDoctor(name);
            if (flag)
            {
                DoctorDL.rewriteData();
                emptyInput();
                updataGrid();
                label3.Text="Doctor delete sucesfully";
                label3.ForeColor = Color.Green;
            }
            else
            {
                emptyInput();

                label3.Text="sorry you enter wrong data!";
                label3.ForeColor = Color.Red;
            }
        }

        private void frmDeleteDoctor_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Name");
            table.Columns.Add("Password");
            table.Columns.Add("salary");
            table.Columns.Add("Fee");
            printDoctor();
            dataGridView1.DataSource = table;
        }
    }
}
