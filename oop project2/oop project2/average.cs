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
    public partial class average : Form
    {
       
        public average()
        {
            InitializeComponent();
        }

        private void average_Load(object sender, EventArgs e)
        {
            this.Size = new Size(550, 400);
            this.Location = new Point(450, 150);
            button1.Location = new Point(150, 280);

            PictureBox p = new PictureBox();
            p.ImageLocation = @"C:\Users\VC\Desktop\yellowface.png";
            p.SizeMode = PictureBoxSizeMode.StretchImage;
            p.BackColor = Color.Transparent;
            p.Size = new Size(150, 150);
            p.Location = new Point(200, 40);
            this.Controls.Add(p);

            Label l = new Label();
            l.Text = "EH ! Your typing speed is satisfactory.";
            l.TextAlign = ContentAlignment.MiddleCenter;
            l.BackColor = Color.Transparent;
            l.Size = new Size(400, 100);
            l.Location = new Point(70, 180);
            l.ForeColor = Color.Black;
            l.Font = new Font("Times New Roman", 22, FontStyle.Bold);
            this.Controls.Add(l);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            typinginterface t = new typinginterface();
            t.ShowDialog();
        }
    }
}
