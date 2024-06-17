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
    public partial class frmDoctorAddPrescription : Form
    {
        public frmDoctorAddPrescription(DoctorBL d)
        {
            InitializeComponent();
            doctor = d;
        }
        DoctorBL doctor;
        DataTable table = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDoctorInterface a = new frmDoctorInterface(doctor);
            a.Show();
        }

        private void frmDoctorAddPrescription_Load(object sender, EventArgs e)
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
        public void printPatientOfDoctor(DoctorBL d)
        {

            foreach (PatientBL x in d.getList())
            {
                table.Rows.Add(x.getName(), x.getPassword(), x.getAge(), x.getDisease(), x.getMedicine(), x.getContact());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string name = textBox1.Text;

            string prescription = richTextBox1.Text;
            bool flag = doctor.addPrescription(name, prescription);
            if (flag)
            {
                PatientDL.reWriteData();
                label3.Text=("SUcessfully added!"); ;
                label3.ForeColor = Color.Green;

            }
            else
            {
                label3.Text=("Sorry you enter wrong patient!");
                label3.ForeColor = Color.Red;
            }

        }
    }
}
