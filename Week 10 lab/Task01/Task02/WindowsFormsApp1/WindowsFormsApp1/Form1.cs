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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void clearDataFromForm()
        {
            username.Text = "";
            password.Text = "";
            
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = username.Text;
            string pass = password.Text;
            MUser m1 = new MUser(name, pass);
          MUser m=  MUserDL.SignIn(m1);
            if(m!=null)
            {
                MessageBox.Show("User is valid");
            }
            else
            {
                MessageBox.Show("User is unvalid");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Close();
           
            Form f = new First(); 
            f.Show();
            this.Hide();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
