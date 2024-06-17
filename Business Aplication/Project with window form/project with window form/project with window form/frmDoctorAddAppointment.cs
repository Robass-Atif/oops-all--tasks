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
    public partial class frmDoctorAddAppointment : Form
    {
        public frmDoctorAddAppointment(DoctorBL d)

        {
            doctor = d;
            InitializeComponent();
           
        }
        DataTable table = new DataTable();
        DoctorBL doctor;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDoctorInterface a = new frmDoctorInterface(doctor);
            a.Show();
        }
        public void printPatientOfDoctor(DoctorBL d)
        {
            foreach (PatientBL x in d.getList())
            {
                table.Rows.Add(x.getName(), x.getPassword(), x.getAge(), x.getDisease(), x.getMedicine(), x.getContact());
            }
        }
        private void frmDoctorAddAppointment_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Name");
            table.Columns.Add("Password");
            table.Columns.Add("Age");
            table.Columns.Add("Disease");
            table.Columns.Add("Medicine");
            table.Columns.Add("Contact");
            printPatientOfDoctor(doctor);
            dataGridView1.DataSource = table;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            PatientBL p = PatientDL.Patient(name, doctor);
            if (p != null)
            {

                if (p.getAppointment().getDay() == "" && p.getAppointment().getTime() == "")
                {

                    string date = dateTimePicker1.Value.DayOfWeek.ToString();
                    string time= dateTimePicker1.Value.TimeOfDay.ToString();
                    AppointmentBL a1 = new AppointmentBL(date,time);
                    bool flag = DoctorDL.addappointmemt(name, a1, doctor);
                    if (flag)
                    {
                        PatientDL.reWriteData();
                        label3.Text=("Appointment added successfully!");
                        label3.ForeColor = Color.Green;
                    }
                    else
                    {
                        label3.Text=("You enter wrong input!");
                        label3.ForeColor = Color.Red;
                    }
                }
                else
                {
                    label3.Text=("this patient has already has assignment!");
                    label3.ForeColor = Color.Red;
                }
            }
            else
            {
                label3.Text=("You enter wrong input !");
                label3.ForeColor = Color.Red;

            }
        }
    }
}
