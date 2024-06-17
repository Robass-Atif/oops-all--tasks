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
    public partial class frmDoctorAddBillPayment : Form
    {
        public frmDoctorAddBillPayment(DoctorBL d)
        {
            doctor = d;
            InitializeComponent();
        }
        DoctorBL doctor;
        private void label4_Click(object sender, EventArgs e)
        {

        }
        DataTable table = new DataTable();
        private void frmDoctorAddBillPayment_Load(object sender, EventArgs e)
        {
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            textBox2.Visible = false;
            button3.Visible = false;
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
             name = textBox1.Text;
             flag = PatientDL.addBillPayment(name, doctor);
            if (flag != 0)
            {
                Start();
            }
            else
            {
                label3.Text = ("this client has given hhis money");
                label3.ForeColor = Color.Red;

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDoctorInterface a = new frmDoctorInterface(doctor);
            a.Show();

        }
        string name;
        int flag;
        string amount;
        public void Start()
        {
            label4.Visible = true;
            label5.Visible = true;
            label5.Text = flag.ToString();
            label6.Visible = true;
            textBox2.Visible = true;
            button2.Visible = false;
            button3.Visible = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
             amount = textBox2.Text;  
            bool check = PatientDL.validationOfBill(amount);
            if (check)
            {  
                if (flag == int.Parse(amount))
                { 
                    doctor.getTransiction().Add(amount.ToString());
                    foreach (PatientBL p in doctor.getList())
                    {
                        if (name == p.getName())
                        {
                            p.setBill(0);
                            PatientDL.reWriteData();
                            break;
                        }
                    }
                    label3.Text = ("payment transfererd");
                    label3.ForeColor = Color.Green;
                }
                else
                {
                    label3.Text = "Please enter correct input";
                    label3.ForeColor = Color.Red;
                }
            }
            else
            {
                label3.Text = ("wrong input!");
                label3.ForeColor = Color.Red;
            }
        }
    }
}

