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
    public partial class frmAdminViewPatient : Form
    {
        public frmAdminViewPatient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAdminInterface a = new frmAdminInterface();
            a.Show();

        }
        DataTable table = new DataTable();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmAdminViewPatient_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Doctor");
            table.Columns.Add("Patient");
            printPatientData();
            dataGridView1.DataSource = table;

        }
        public  void printPatientData()
        {
            foreach (DoctorBL y in DoctorDL.doctors)
            {
                string doctor = y.getName();
                foreach (PatientBL x in y.getList())
                {
                    table.Rows.Add(doctor,x.getName());
                }
                
            }
        }
        
    }
}
