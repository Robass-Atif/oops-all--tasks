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
    public partial class frmPatientLogin : Form
    {
        public frmPatientLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu m = new MainMenu();
            m.Show();
        }
        public void emptyInput()
        {
            txtname.Text = "";
            Password.Text = "";

        }

        public PatientBL takeInput()
        {

            string name = txtname.Text;

            string password = Password.Text;
            PatientBL p1 = new PatientBL(name, password);
            return p1;
        }
        private void front_Click(object sender, EventArgs e)
        {
            PatientBL d1 = takeInput();
            d1 = PatientDL.isPatientExist(d1);

            if (d1 != null)
            {
                bool flag = PatientDL.checkPatient(d1);
                if (flag)
                {
                    this.Close();
                    frmPatientInterface p = new frmPatientInterface(d1);
                    p.Show();
                }
                else
                {
                    emptyInput();
                    result.Text=("You enter wrong crendential!");
                    result.ForeColor = Color.Red;
                }
            }
            else
            {
                emptyInput();

                result.Text=("You enter wrong credential!");
                result.ForeColor = Color.Red;

            }
        }

        private void frmPatientLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
