using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace project_with_window_form
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmDoctorLogin s = new frmDoctorLogin();
            s.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmPatientLogin p = new frmPatientLogin();
            p.Show();  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Admin a = new Admin();
            a.Show();
        }       
    }
}
