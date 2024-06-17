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
    public partial class frmAdminUpdateFee : Form
    {
        public frmAdminUpdateFee()
        {
            InitializeComponent();
        }
        public void emptyInput()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        DataTable table = new DataTable();
        private void frmAdminUpdateFee_Load(object sender, EventArgs e)
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
        public void printDoctor()
        {
            foreach (DoctorBL d in DoctorDL.doctors)
            {
                table.Rows.Add(d.getName(), d.getPassword(), d.getSalary(), d.getFee());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string name = textBox1.Text;
            bool flag1 = AdminDL.validationOfAlphabet(name);
           
            string fee = textBox2.Text;
            bool flag2 = AdminDL.validationOfNumber(fee);
            if (flag1 && flag2)
            {
                bool flag = DoctorDL.updateDoctor(name, fee);
                if (flag == true)
                {
                    DoctorDL.rewriteData();
                    updataGrid();
                    label3.Text="Fee update sucessfully!";
                    label3.ForeColor = Color.Green;
                }
                else
                {
                    label3.Text="You  enter wrong data";
                    label3.ForeColor = Color.Red;
                }
            }
            else
            {
                label3.Text = "You  enter wrong data";
                label3.ForeColor = Color.Red;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAdminInterface a = new frmAdminInterface();
            a.Show();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
