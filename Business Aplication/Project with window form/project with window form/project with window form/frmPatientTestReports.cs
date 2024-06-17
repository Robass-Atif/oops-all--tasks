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
    public partial class frmPatientTestReports : Form
    {
        public frmPatientTestReports(PatientBL p)
        {
            InitializeComponent();
            patient = p;
        }
        PatientBL patient;
        DataTable table = new DataTable();

        private void frmPatientTestReports_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Test Name");
            table.Columns.Add("Test Result");
            printTestReport(patient);
            dataGridView1.DataSource = table;


        }
        public  void printTestReport(PatientBL p)
        {
            foreach (TestReport t in p.getTestReport())
            {
                table.Rows.Add(t.getTestName(), t.getResult());

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPatientInterface a = new frmPatientInterface(patient);
            a.Show();
        }
    }
}
