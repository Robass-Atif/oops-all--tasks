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
    public partial class frmAddDoctor : Form
    {
        public frmAddDoctor()
        {
            InitializeComponent();
        }
       public void emptyInput()
        {

        }

        private void frmAddDoctor_Load(object sender, EventArgs e)
        {
            txtName.Text = "";
            password.Text = "";
            salary.Text = "";
            fee.Text = "";
        }
        public DoctorBL inputDoctor()
        {
            string name = txtName.Text;
            string password1 = password.Text;
            string salary1 = salary.Text;
            string fee1 = fee.Text;

            
                DoctorBL d;
                if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(password1) && !string.IsNullOrEmpty(salary1) && !string.IsNullOrEmpty(fee1))
                {
                    int s = int.Parse(salary1);
                    int f = int.Parse(fee1);
                    d = new DoctorBL(name, password1, s, f);
                    return d;
                }
            
            return null;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoctorBL s1 = inputDoctor();
            if (s1 != null)
            {
                bool flag = DoctorDL.sameDoctor(s1);
                if (flag)
                {
                    DoctorDL.addIntolist(s1);
                    DoctorDL.storeData(s1);
                    label4.Text = "Doctor Added Successfully";
                    label4.ForeColor = Color.Green;
                    emptyInput();
                }
                else
                {
                    emptyInput();

                    label4.Text="this Doctor already Exist";
                    label4.ForeColor = Color.Red;

                }
            }
            else
            {
                emptyInput();

                label4.Text="you enter wrong input!";
                label4.ForeColor = Color.Red;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAdminInterface a = new frmAdminInterface();
            a.Show();
        }
    }
}
