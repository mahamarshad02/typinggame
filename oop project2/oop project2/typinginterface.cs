using System;
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
    public partial class typinginterface : Form
    {
        public typinginterface()
        {
            InitializeComponent();
        }

        private void typinginterface_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1370, 800);
            this.Location = new Point(0, 0);
            button5.Location = new Point(10, 620);
            
            Label l1 = new Label();
            l1.Text = "TYPING  MASTER";
            l1.BackColor = Color.Transparent;
            l1.Size = new Size(400, 50);
            l1.Location = new Point(530, 20);
            l1.ForeColor = Color.Black;
            l1.Font = new Font("Showcard Gothic", 30);
            this.Controls.Add(l1);

            Label l2 = new Label();
            l2.Text = "BECOME  A  'TEXPERT' ";
            l2.BackColor = Color.Transparent;
            l2.Size = new Size(400, 40);
            l2.Location = new Point(500, 80);
            l2.ForeColor = Color.Black;
            l2.Font = new Font("Lucida Handwriting", 22,FontStyle.Italic);
            this.Controls.Add(l2);

            Label l3 = new Label();
            l3.Text = "LET'S  TYPE ! ";
            l3.BackColor = Color.Transparent;
            l3.Size = new Size(400, 40);
            l3.Location = new Point(550, 160);
            l3.ForeColor = Color.Black;
            l3.Font = new Font("Showcard Gothic", 22, FontStyle.Italic);
            this.Controls.Add(l3);

            Label l4 = new Label();
            l4.Text = "SELECT  DIFFICULTY  LEVEL ";
            l4.BackColor = Color.Transparent;
            l4.Size = new Size(600, 50);
            l4.Location = new Point(400, 200);
            l4.ForeColor = Color.Black;
            l4.Font = new Font("Showcard Gothic", 30, FontStyle.Bold);
            this.Controls.Add(l4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 easy = new Form1();
            easy.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 medium = new Form2();
            medium.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 difficult = new Form3();
            difficult.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            instruction i = new instruction();
            i.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
