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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        public void emptyInput()
        {
            txtname.Text = "";
            Password.Text = "";
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
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin a = new Admin();
            a.Show();
        }

        private void front_Click(object sender, EventArgs e)
        {
            AdminBL b1 = inputAdmin();
            if (b1 != null)
            {
                bool flag = AdminDL.sameAdmin(b1);
                if (flag)
                {
                    AdminDL.storeData(b1);
                    AdminDL.addIntoList(b1);
                    emptyInput();
                    result.Text = "Admin is added";
                    result.ForeColor = Color.Black; 
                }
                else
                {
                    emptyInput();
                    result.Text = "already ths admin is exist";
                    result.ForeColor = Color.Red;
                }
            }
            else
            {
                emptyInput();
                result.Text = "you have enter wrong input";
                result.ForeColor = Color.Red;

            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void result1_Click(object sender, EventArgs e)
        {

        }
    }
}
