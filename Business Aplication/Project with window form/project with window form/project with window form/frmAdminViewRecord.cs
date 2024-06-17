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
    public partial class frmAdminViewRecord : Form
    {
        public frmAdminViewRecord()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void updataGrid()
        {


            dataGridView1.DataSource = null;

            table.Rows.Clear();

            printDoctor();
            dataGridView1.DataSource = table;



            dataGridView1.Refresh();

        }

        private void frmAdminViewRecord_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Name");
            table.Columns.Add("Password");
            table.Columns.Add("salary");
            table.Columns.Add("Fee");
            updataGrid();
        }
        public void printDoctor()
        {
            foreach(DoctorBL d in DoctorDL.doctors)
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
    }
}
