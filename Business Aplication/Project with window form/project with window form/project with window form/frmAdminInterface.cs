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
    public partial class frmAdminInterface : Form
    {
        public frmAdminInterface()
        {
            InitializeComponent();
        }
        


        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin s = new Admin();
            s.Show();

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAdminViewRecord r = new frmAdminViewRecord();
            r.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAdminViewPatient p = new frmAdminViewPatient();
            p.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAdminViewBill a = new frmAdminViewBill();
            a.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAdminUpdateSalary s = new frmAdminUpdateSalary();
            s.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDeleteDoctor a = new frmDeleteDoctor();
            a.Show();
        }

        private void AddDoctor_Click(object sender, EventArgs e)
        {
            frmAddDoctor dot = new frmAddDoctor();
            dot.Show();
            this.Close();
        }

        private void AdminUpdateFee_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAdminUpdateFee f = new frmAdminUpdateFee();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAdminViewReviews a = new frmAdminViewReviews();
            a.Show();
        }

        private void frmAdminInterface_Load(object sender, EventArgs e)
        {

        }
    }
}
