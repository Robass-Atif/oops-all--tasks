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
    public partial class frmPatientInterface : Form
    {
        public frmPatientInterface(PatientBL p)
        {
            InitializeComponent();
            patient = p;
        }
        PatientBL patient;
        private void frmPatientInterface_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu m = new MainMenu();
            m.Show();
        }

        private void viewRecordAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPatientViewPrescription a = new frmPatientViewPrescription(patient);
            a.Show();

        }

        private void AdminUpdateFee_Click(object sender, EventArgs e)
        {

            this.Close();
            frmPatientBillPayment a = new frmPatientBillPayment(patient);
            a.Show();
        }

        private void AddDoctor_Click(object sender, EventArgs e)
        {

            this.Close();
            frmPatientCheckupFee a = new frmPatientCheckupFee(patient);
            a.Show();
        }

        private void AdminViewPatient_Click(object sender, EventArgs e)
        {

            this.Close();
            frmPatientViewAppointment a = new frmPatientViewAppointment(patient);
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Close();
            frmPatientGiveReview a = new frmPatientGiveReview(patient);
            a.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            this.Close();
            frmPatientTestReports a = new frmPatientTestReports(patient);
            a.Show();
        }
    }
}
