using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static List<Muser> user = new List<Muser>();
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns["delete"].Index == e.ColumnIndex)
            {

                Muser m = (Muser)dataGridView1.CurrentRow.DataBoundItem;
                user.Remove(m);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = user;
                dataGridView1.Refresh();
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            user.Add(new Muser { Name = "robass", Password = "ad", Role = "asdad" });
            user.Add(new Muser { Name = "rasfass", Password = "ad", Role = "asdad" });
            user.Add(new Muser { Name = "robasdaass", Password = "ad", Role = "asdad" });
            dataGridView1.DataSource = user;
            dataGridView1.Columns["Password"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = false;
            for(int i=0;i<user.Count;i++)
            {
                if(textBox1.Text==user[i].Name)
                {
                    flag = true;
                    break;
                }
            }
            if(flag)
            {
                MessageBox.Show("user is present");
            }
            else
            {
                MessageBox.Show("user is not present");
            }
        }
        

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
