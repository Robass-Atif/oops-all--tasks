﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman_Game
{
    public partial class EndGame : Form
    {
        public EndGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.DialogResult  = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           this.DialogResult = DialogResult.No;

        }

        private void EndGame_Load(object sender, EventArgs e)
        {

        }
    }
}
