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
    public partial class frmDoctorAddPatient : Form
    {
        public frmDoctorAddPatient(DoctorBL d)
        {
            InitializeComponent();
            doctor = d;
        }
        DoctorBL doctor;

        private void frmDoctorAddPatient_Load(object sender, EventArgs e)
        {

        }
        private void emptyData()
        {
            txtName.Text = "";
            Password.Text = "";
            salary.Text = "";
            fee.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";

        }
        private PatientBL takeInput()
        {

            string name = txtName.Text;
            bool checkName = AdminDL.validationOfAlphabet(name);

            string password = Password.Text;
            bool checkPassword = AdminDL.validationOfPassword(password);

            string age = salary.Text;
            bool checkAge = AdminDL.validationOfNumber(age);

            string disease = fee.Text;

            string medicine = textBox2.Text;

            string contact = textBox1.Text;
            bool checkContact = AdminDL.validationOfNumber(contact);
            bool contactLength = PatientDL.validationOfContactLength(contact);
            if (checkName && checkAge && checkContact && contactLength && checkPassword)
            {
                if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(age) && !string.IsNullOrEmpty(disease) && !string.IsNullOrEmpty(medicine) && !string.IsNullOrEmpty(contact))
                {
                    PatientBL p1;
                    p1 = new PatientBL(name, password, age, disease, medicine, contact);
                    return p1;
                }
            }
            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PatientBL p1 =takeInput();
            if (p1 != null)
            {
                bool flag = PatientDL.samePatient(p1);
                if (!flag)
                {
                    doctor.addPatientList(p1);
                    PatientDL.addIntoList(p1);

                    p1.setBill(doctor.getFee() + 100);

                    PatientDL.storeData(p1);
                    DoctorDL.rewriteData();
                    emptyData();
                    label4.Text=("Patient sucessfully login");
                    label4.ForeColor = Color.Green;
                }
                else
                {
                    emptyData();

                    label4.Text=("this patient under another doctor custidiy");
                    label4.ForeColor = Color.Red;
                }
            }
            else
            {
                emptyData();
                label4.Text=("you enter wrong input");
                label4.ForeColor = Color.Red;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDoctorInterface a = new frmDoctorInterface(doctor);
            a.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
