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
    public partial class gameover : Form
    {
        public gameover()
        {
            InitializeComponent();
        }

        private void gameover_Load(object sender, EventArgs e)
        {
            SoundPlayer s1 = new SoundPlayer(@"C:\Users\VC\Desktop\Sad Trombone.wav");
            s1.Play();
            this.Size = new Size(550, 400);
            this.Location = new Point(450, 150);
            button1.Location = new Point(120, 230);
            Label l1 = new Label();
            l1.Text = "GAME  OVER!";
            l1.BackColor = Color.Transparent;
            l1.Size = new Size(400, 40);
            l1.Location = new Point(80, 180);
            l1.ForeColor = Color.Black;
            l1.Font = new Font("Lucida Handwriting", 22, FontStyle.Bold);
            this.Controls.Add(l1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            typinginterface t = new typinginterface();
            t.ShowDialog();
        }
    }
}
