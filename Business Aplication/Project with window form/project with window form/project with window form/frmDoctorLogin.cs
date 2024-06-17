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
    public partial class frmDoctorLogin : Form
    {
        public frmDoctorLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu m = new MainMenu();
            m.Show();
        }

        private void front_Click(object sender, EventArgs e)
        {
            DoctorBL b1 = inputAdmin();
            if (b1 != null)
            {
                 b1 = DoctorDL.checkDoctor(b1);
                if (b1 != null)
                {
                    this.Close();
                    frmDoctorInterface a = new frmDoctorInterface(b1);
                    a.Show();
                    
                
                }
                else
                {
                    result.ForeColor = Color.Red;
                    emptyInput();

                    result.Text = "You have enter wrong input";



                }

            }
            else

            {
                emptyInput();
                result.ForeColor = Color.Red;
                result.Text = "You have enter wrong input";

            }
        }
        private void emptyInput()
        {
            txtname.Text = "";
            Password.Text = "";
        }

        private void frmDoctorLogin_Load(object sender, EventArgs e)
        {

        }
        private DoctorBL inputAdmin()
        {
            string name = txtname.Text;
            string password = Password.Text;
            DoctorBL p1;
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(password))
            {
                p1 = new DoctorBL(name, password);
                return p1;
            }
            return null;
        }
    }
}
