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
    public partial class frmAdminViewReviews : Form
    {
        public frmAdminViewReviews()
        {
            InitializeComponent();
        }

      private  DataTable table1 = new DataTable("table");
        private void frmAdminViewReviews_Load(object sender, EventArgs e)
        {
            table1.Columns.Add("Name");
            table1.Columns.Add("Reviews");
            printReview();
            dataGridView1.DataSource = table1;
            dataGridView1.Columns["Reviews"].Width = 1000;
        }
        public void printReview()
        {

            string line; 
            foreach (PatientBL x in PatientDL.patient)
            {
              line  = x.getReview() ;
                if (line != "")
                {
                    table1.Rows.Add(x.getName(), line);
                }  
            }
        }
        private void updataGrid()
        {
            dataGridView1.DataSource = null;
            table1.Rows.Clear();
            dataGridView1.DataSource = table1;
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAdminInterface a = new frmAdminInterface();
            a.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
