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
    public partial class frmDoctorAddTestReports : Form
    {
        public frmDoctorAddTestReports(DoctorBL d)
        {
            InitializeComponent();
            doctor = d;
        }
        DoctorBL doctor;
        DataTable table = new DataTable();
        private void button2_Click(object sender, EventArgs e)
        {

            string name = textBox1.Text;
            string testNAme = textBox2.Text;
            string resul = textBox3.Text;
            TestReport t = new TestReport(testNAme, resul);
           
            bool flag = PatientDL.checkTestReport(t, name, doctor);
            if (flag)
            {
                PatientDL.reWriteData();
                emptyInput();
                label3.Text="Add sucessFully";
                label3.ForeColor = Color.Green;
            }
            else
            {
                emptyInput();

                label3.Text=("You enter wrong input!");
                label3.ForeColor = Color.Red;
            }
        }
        public void emptyInput()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }
        private void frmDoctorAddTestReports_Load(object sender, EventArgs e)
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
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDoctorInterface d = new frmDoctorInterface(doctor);
            d.Show();
        }
    }
}
