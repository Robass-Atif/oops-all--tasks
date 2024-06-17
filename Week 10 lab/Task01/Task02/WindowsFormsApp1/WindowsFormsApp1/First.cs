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
    public partial class First : Form
    {
        public First()
        {
            InitializeComponent();
            string path = "data.txt";
            if(MUserDL.ReadData(path))
            {
                MessageBox.Show ( "data loaded sucessfully");

            }
            else
            {
                MessageBox.Show("data not loaded");
            }
        }

        private void First_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                Form f1 = new Form1();
                f1.Show();
                checkBox1.Checked = false;
            }
            if (checkBox2.Checked)
            {
                Form f1 = new SignUp();
                f1.Show();
                checkBox2.Checked = false;
            }
        }
    }
}
