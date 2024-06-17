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
    public partial class frmPatientCheckupFee : Form
    {
        public frmPatientCheckupFee(PatientBL p)
        {
            InitializeComponent();
            patient = p;
        }
        PatientBL patient;

        private void frmPatientCheckupFee_Load(object sender, EventArgs e)
        {
            DoctorBL d = PatientDL.patientDoctor(patient);
            label2.Text = d.getFee().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPatientInterface a = new frmPatientInterface(patient);
            a.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }
    }
}
