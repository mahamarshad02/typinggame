﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_project2
{
    public partial class instruction : Form
    {
        public instruction()
        {
            InitializeComponent();
        }

        private void instruction_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1370, 800);
            this.Location = new Point(0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            typinginterface t = new typinginterface();
            t.ShowDialog();
        }
    }
}
