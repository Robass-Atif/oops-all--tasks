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
    public partial class frmPatientViewPrescription : Form
    {
        public frmPatientViewPrescription(PatientBL p)
        {
            InitializeComponent();
            patient = p;
        }

        PatientBL patient;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPatientInterface a = new frmPatientInterface(patient);
            a.Show();
        }

        private void frmPatientViewPrescription_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = patient.getPrescription();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
