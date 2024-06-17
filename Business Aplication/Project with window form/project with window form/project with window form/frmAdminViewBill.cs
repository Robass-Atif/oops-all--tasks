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
    public partial class frmAdminViewBill : Form
    {
        public frmAdminViewBill()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();

        private void frmAdminViewBill_Load(object sender, EventArgs e)
        {

            table.Columns.Add("Patient");
            table.Columns.Add("Bill Payment");
            printBillPayment();
            dataGridView1.DataSource = table;

        }
        public void printBillPayment()
        {
            foreach (DoctorBL y in DoctorDL.doctors)
            {
                foreach (string x in y.getTransiction())
                {
                    table.Rows.Add(y.getName() , x);
                }
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
