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
    public partial class frmDoctorViewRecords : Form
    {
        public frmDoctorViewRecords(DoctorBL d)
        {
            InitializeComponent();
             doctor = d;
        }
        DoctorBL doctor;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDoctorInterface a = new frmDoctorInterface(doctor);
            a.Show();
        }
        DataTable table = new DataTable();
        private void frmDoctorViewRecords_Load(object sender, EventArgs e)
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
        public  void printPatientOfDoctor(DoctorBL d)
        {
            
            foreach (PatientBL x in d.getList())
            {
               table.Rows.Add(x.getName(), x.getPassword(), x.getAge(), x.getDisease(), x.getMedicine() , x.getContact());
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
