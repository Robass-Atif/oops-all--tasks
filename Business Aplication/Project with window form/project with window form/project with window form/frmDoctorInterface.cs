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
    public partial class frmDoctorInterface : Form
    {
        public frmDoctorInterface(DoctorBL d)
        {
            InitializeComponent();
            doctor = d;
        }
        DoctorBL doctor;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu m = new MainMenu();
            m.Show();
        }

        private void viewRecordAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDoctorAddPatient a = new frmDoctorAddPatient(doctor);
            a.Show();
        }

        private void AdminUpdateFee_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDoctorDeletePatient a = new frmDoctorDeletePatient(doctor);
            a.Show();
           
        }

        private void AddDoctor_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDoctorViewAppointment a = new frmDoctorViewAppointment(doctor);
            a.Show();
        }

        private void AdminViewPatient_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDoctorCancelAppointment a = new frmDoctorCancelAppointment(doctor);
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDoctorAddAppointment a = new frmDoctorAddAppointment(doctor);
            a.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDoctorAddPrescription a = new frmDoctorAddPrescription(doctor);
            a.Show();
        }

        private void AdminBillPAyment_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDoctorAddBillPayment a = new frmDoctorAddBillPayment(doctor);
            a.Show();
        }

        private void AdminUpdateSalary_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDoctorAddTestReports a = new frmDoctorAddTestReports(doctor);
            a.Show();
               
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDoctorViewRecords a = new frmDoctorViewRecords(doctor);
            a.Show();
        }

        private void frmDoctorInterface_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
