using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.Text;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Muser> list = new List<Muser>();

            list.Add(new Muser { Id = "ad", Name = "robass" });
            list.Add(new Muser { Id = "a", Name = "robss" });
            list.Add(new Muser { Id = "d", Name = "roba" });
            comboBox2.DataSource = list;
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Id";

        }
    }
}
