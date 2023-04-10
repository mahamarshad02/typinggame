using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace oop_project2
{
    public partial class fast : Form
    {
        public fast()
        {
            InitializeComponent();
        }

        private void fast_Load(object sender, EventArgs e)
        {
            SoundPlayer s1 = new SoundPlayer(@"C:\Users\VC\Desktop\Children Yay.wav");
            s1.Play();
            this.Size = new Size(550, 400);
            this.Location = new Point(450, 150);
            button1.Location = new Point(150, 280);

            PictureBox p = new PictureBox();
            p.ImageLocation = @"C:\Users\VC\Desktop\face (2).png";
            p.SizeMode = PictureBoxSizeMode.StretchImage;
            p.BackColor = Color.Transparent;
            p.Size = new Size(150, 150);
            p.Location = new Point(200, 40);
            this.Controls.Add(p);

            Label l = new Label();
            l.Text = "WELL DONE ! Your typing speed is fast." ;
            l.TextAlign = ContentAlignment.MiddleCenter;
            l.BackColor = Color.Transparent;
            l.Size = new Size(400, 100);
            l.Location = new Point(90, 180);
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
