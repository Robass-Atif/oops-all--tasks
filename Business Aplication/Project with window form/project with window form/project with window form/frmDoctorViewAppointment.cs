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
    public partial class frmDoctorViewAppointment : Form
    {
        public frmDoctorViewAppointment(DoctorBL d)
        {
            InitializeComponent();
            doctor = d;
        }
        DoctorBL doctor;
        DataTable table = new DataTable();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmDoctorViewAppointment_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Patient");
            table.Columns.Add("Appointments");
            printAppointment(doctor);
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].Width = 200;


        }
        public  void printAppointment(DoctorBL d1)
        {
            foreach (PatientBL y in d1.getList())
            {
                if (y.getAppointment().getDay() != "" && y.getAppointment().getDay() != "")
                {

                    string line = " has appointment with you at that " + y.getAppointment().getDay() + " and " + y.getAppointment().getTime();
                    table.Rows.Add(y.getName(),line);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDoctorInterface a = new frmDoctorInterface(doctor);
            a.Show();
        }
    }
}
