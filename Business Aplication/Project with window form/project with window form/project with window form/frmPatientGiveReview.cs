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
    public partial class frmPatientGiveReview : Form
    {
        public frmPatientGiveReview(PatientBL p)
        {
            InitializeComponent();
            patient = p;
        }
        PatientBL patient;

        private void frmPatientGiveReview_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(patient.getReview()))
            {
                


            }
            else
            {
                richTextBox1.Visible = false;
                button2.Visible = false;
                label1.Visible = false;
                label2.Text = ("You already given your review!");
                label2.ForeColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string review1 = richTextBox1.Text;
            patient.setReview(review1);
            label2.Text = "Review added SuccessFully";
            label2.ForeColor = Color.Green;
            PatientDL.reWriteData();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPatientInterface a = new frmPatientInterface(patient);
            a.Show();
        }
    }
}
