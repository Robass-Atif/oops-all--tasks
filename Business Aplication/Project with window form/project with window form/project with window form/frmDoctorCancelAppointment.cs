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
    public partial class frmDoctorCancelAppointment : Form
    {
        public frmDoctorCancelAppointment(DoctorBL d)
        {
            doctor = d;
            InitializeComponent();
        }
        DoctorBL doctor;
        DataTable table = new DataTable();

        private void frmDoctorCancelAppointment_Load(object sender, EventArgs e)
        {

            table.Columns.Add("Name");
            table.Columns.Add("Appointments");
            printAppointment(doctor);
            dataGridView1.DataSource = table;
            dataGridView1.Columns[1].Width = 500;
        }
        public void printAppointment(DoctorBL d1)
        {
            foreach (PatientBL y in d1.getList())
            {
                if (y.getAppointment().getDay() != "" && y.getAppointment().getDay() != "")
                {

                    string line = " has appointment with you at that " + y.getAppointment().getDay() + " and " + y.getAppointment().getTime();
                    table.Rows.Add(y.getName(), line);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string name = textBox1.Text;
            PatientBL p1 = DoctorDL.deleteAppointment(doctor, name);
            if (p1 != null)
            {

                bool flag = DoctorDL.deletePatientAppointment(p1);
                if (flag)
                {
                    PatientDL.reWriteData();

                    emptyInput();
                    updataGrid();
                    label3.Text="Appointment delete succesfully!";
                    label3.ForeColor = Color.Green;
                }
                else
                {
                    emptyInput();

                    label3.Text="this patient has no appointment";
                    label3.ForeColor = Color.Red;
                }
            }
            else
            {
                emptyInput();
                label3.ForeColor = Color.Red;
                label3.Text=("sorry there is no such type of patient!");
            }
        }
        public void emptyInput()
        {
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDoctorInterface d = new frmDoctorInterface(doctor);
            d.Show();
        }
        private void updataGrid()
        {
            dataGridView1.DataSource = null;
            table.Rows.Clear();
            printAppointment(doctor);
            dataGridView1.DataSource = table;
            dataGridView1.Refresh();
        }
    }
}
