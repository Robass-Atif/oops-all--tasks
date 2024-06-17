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
    public partial class signIn : Form
    {
        public signIn()
        {
            InitializeComponent();
        }
        public AdminBL inputAdmin()
        {
            string name = txtname.Text;
            string password = Password.Text;
            AdminBL p1;
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(password))
            {
                p1 = new AdminBL(name, password);
                return p1;
            }
            return null;
        }

        
        private void signIn_Load(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin a = new Admin();
            a.Show();
        }

        private void front_Click(object sender, EventArgs e)
        {
            AdminBL b1 = inputAdmin();
            if(b1!=null)
            {
                bool flag = AdminDL.checkAdmin(b1);
                if(flag)
                {
                    this.Close();
                    frmAdminInterface f = new frmAdminInterface();
                    f.Show();
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
        public void emptyInput()
        {
            txtname.Text = "";
            Password.Text = "";
        }

        
    }
}
