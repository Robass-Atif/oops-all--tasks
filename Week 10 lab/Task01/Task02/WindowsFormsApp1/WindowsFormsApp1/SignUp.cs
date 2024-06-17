using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        private void clearDataFromForm()
        {
            username.Text = "";
            password.Text = "";
            role.Text = "";
        }
        private void CLearDataFromForm()
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            string name = username.Text;
            string password1 =password.Text;
            string Role = role.Text;
            string path = "data.txt";
            MUser s1 = new MUser(name,password1,Role);
            MUserDL.addInList(s1);
            MUserDL.writeData(s1,path);
            MessageBox.Show("Add sucessfully");
            clearDataFromForm();

        }
    }
}
