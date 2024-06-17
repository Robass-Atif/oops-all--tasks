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
    public partial class frmAdminUpdateSalary : Form
    {
        public frmAdminUpdateSalary()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            table.Columns.Add("Name");
            table.Columns.Add("Password");
            table.Columns.Add("salary");
            table.Columns.Add("Fee");
            printDoctor();
            dataGridView1.DataSource = table;
        }
        public void printDoctor()
        {
            foreach (DoctorBL d in DoctorDL.doctors)
            {
                table.Rows.Add(d.getName(), d.getPassword(), d.getSalary(), d.getFee());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAdminInterface a = new frmAdminInterface();
            a.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void emptyInput()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
        

        private void button2_Click(object sender, EventArgs e)
        {

            string name = textBox1.Text; 
            bool flag1 = AdminDL.validationOfAlphabet(name);

            string salary = textBox2.Text;
            bool flag2 = AdminDL.validationOfNumber(salary);
            if (flag1 && flag2)
            {
                bool flag = DoctorDL.updateSalary(name, salary);
                if (flag)
                {
                    DoctorDL.rewriteData();
                    emptyInput();
                    label3.Text="SucessFully updated !";
                    label3.ForeColor = Color.Green;
                    updataGrid();
                }
                else
                {
                    emptyInput();

                    label3.Text= "You enter wrong Data";
                    label3.ForeColor = Color.Red;
                }
            }
            else
            {
                emptyInput();
                label3.Text = "You enter wrong Data";
                label3.ForeColor = Color.Red;

            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmAdminUpdateSalary_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Name");
            table.Columns.Add("Password");
            table.Columns.Add("salary");
            table.Columns.Add("Fee");
            printDoctor();
            dataGridView1.DataSource = table;
        }
        private void updataGrid()
        {
            dataGridView1.DataSource = null;
            table.Rows.Clear();
            printDoctor();
            dataGridView1.DataSource = table;
            dataGridView1.Refresh();
        }
    }
}
