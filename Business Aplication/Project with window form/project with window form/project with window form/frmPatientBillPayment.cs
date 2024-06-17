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
    public partial class frmPatientBillPayment : Form
    {
        public frmPatientBillPayment(PatientBL p)
        {
            InitializeComponent();
            patient = p;
        }
        PatientBL patient;

        private void frmPatientBillPayment_Load(object sender, EventArgs e)
        {
            if (patient.getBill() != 0)
            {
                label2.Text = patient.getBill().ToString();
                label2.ForeColor = Color.Red;
            }
            else
            {
                label2.Text=("you have no dues!");
                label2.ForeColor = Color.Green;

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
