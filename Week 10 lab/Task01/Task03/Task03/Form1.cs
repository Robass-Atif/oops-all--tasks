using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Next_Click(object sender, EventArgs e)
        {

            currentColorIndex++;
            
            if (currentColorIndex >= 3)
            {
                currentColorIndex = 0;
            }
            textBox1.BackColor = colors[currentColorIndex];
        }
        private Color[] colors = { Color.Green, Color.Blue ,Color.Red};
        private int currentColorIndex = 0;


        private void back_Click(object sender, EventArgs e)
        {
            currentColorIndex--;
            if(currentColorIndex<0)
            {
                currentColorIndex = 0;
            }
            textBox1.BackColor=colors[currentColorIndex];
        }
    }
}
