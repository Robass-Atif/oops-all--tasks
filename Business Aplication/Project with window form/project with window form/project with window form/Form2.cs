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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SignUp s = new SignUp();
            s.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu m = new MainMenu();
            m.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            signIn s = new signIn();

            s.Show();
            this.Close();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
