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
        List<Student> s = new List<Student>();

        private void Form1_Load(object sender, EventArgs e)
        {
             
            
            s.Add(new Student { Id = 1, Name = "robass Butt", Passowrd = "kajshd " });
            s.Add(new Student { Id = 3, Name = "ali", Passowrd = "123 " });
            s.Add(new Student { Id = 2, Name = "hassan  ", Passowrd = "kajshd " });
            dataGridView1.DataSource = s;
            //dataGridView1.Columns["Id"].Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Student student = (Student)dataGridView1.CurrentRow.DataBoundItem;

            s.Remove(student);

            dataGridView1.DataSource = null;


            dataGridView1.DataSource = s;

            dataGridView1.Refresh();
        }
    }
}
