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
    public partial class frmPatientViewAppointment : Form
    {
        public frmPatientViewAppointment(PatientBL p1)
        {
            InitializeComponent();
            p= p1;
        }
        PatientBL p;

        private void frmPatientViewAppointment_Load(object sender, EventArgs e)
        {
            DoctorBL d = PatientDL.patientDoctor(p);
            if (p.getAppointment().getDay() != "" && p.getAppointment().getTime() != "")
            {
                label2.Text=(p.getAppointment().getDay() + " day and time " + p.getAppointment().getTime() + " and the doctor name is : " + d.getName());

            }
            else
            {
                label2.Text = "there is no appointment  now";
                label2.ForeColor = Color.Red;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPatientInterface a = new frmPatientInterface(p);
            a.Show();
        }
    }
}
