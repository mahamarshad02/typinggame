﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1370, 800);
            this.Location = new Point(0, 0);
            label2.Text = a[rnd.Next(0, a.Length)];
        }

        string[] a = { "Enormity Atrociousness", "Serendipity Catastrophe", "Milennial Chiliadale", "Flabbergasted Bewildered", "Legerdemain Presdetigitation", "Superfluous Supererogatory", "Maelstrom Turbulence", "Obstreperous Unrestrained", "Indefatigable Inexhaustible", "Penchant Preference", "Corroborate Substantiate", "Prevaricate Equivocate", "Punctilious Conscientious", "Adumbrate Harbinger", "Recalcitrant Intractable", "Ephemeral Evanescent", "Quixotic Extravagant", "Juxtaposition Collocation", "Unctuous Sanctimonious", "Convalescence Relapse" };
        Random rnd = new Random();
        int score = 0; // to keep track of no of correct moves
        int incorrect = 0; //to keep track of no of incorrect moves
        int timeleft = 0; // to keep track of remaining time
        int count = 0; //to count no times timer has ticked

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = a[rnd.Next(0, a.Length)];
            textBox1.Text = null;
            timeleft = 15;
            timer2.Start();

            count++;
            if (count == 10)
            {
                timer1.Stop();
                timer2.Stop();
                count = 0;
                if (score >= 8 && score <= 10)
                {
                    label4.Text = "Final score " + score;
                    fast f1 = new fast();
                    f1.ShowDialog();
                }
                else if (score >= 5 && score <= 7)
                {
                    label4.Text = "Final score " + score;
                    average a1 = new average();
                    a1.ShowDialog();
                }
                else
                {
                    label4.Text = "Final score " + score;
                    poor p1 = new poor();
                    p1.ShowDialog();
                }
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            label6.Text = timeleft--.ToString() + " second(s)";
            if (timeleft < 0)
            {
                timer2.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timeleft = 15;
            timer2.Start(); //countdown timer
            timer1.Start(); //timer for changing words
        }

        int j = 0;
        private void checker(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == label2.Text)
                {
                    SoundPlayer s1 = new SoundPlayer(@"C:\Users\VC\Desktop\Correct Answer.wav");
                    s1.Play();
                    score++;
                    label1.Text = "score : " + score;
                }
                else
                {
                    incorrect++;
                    label1.Text = "score : " + score;
                    if (incorrect<=3)
                    {
                        SoundPlayer s1 = new SoundPlayer(@"C:\Users\VC\Desktop\Wrong buzzer.wav");
                        s1.Play();
                        PictureBox p = new PictureBox();
                        p.ImageLocation = @"C:\Users\VC\Desktop\cross1.png";
                        p.SizeMode = PictureBoxSizeMode.StretchImage;
                        p.BackColor = Color.Transparent;
                        p.Size = new Size(100, 100);
                        p.Location = new Point(1100 - j, 75);
                        j = j + 100;
                        this.Controls.Add(p);
                    }
                    if (incorrect == 3)
                    {
                        timer1.Stop();
                        timer2.Stop();
                        this.Close();
                        gameover g = new gameover();
                        g.ShowDialog();

                    }
                    
                }

                timeleft = 15;
                timer1.Stop();
                timer2.Stop();
                timer2.Start();
                timer1.Start();
                label2.Text = a[rnd.Next(0, a.Length)];
                textBox1.Text = null;

                count++;

                if (count == 10)
                {
                    timer1.Stop();
                    timer2.Stop();
                    count = 0;
                    if (score >= 8 && score <= 10)
                    {
                        label4.Text = "Final score " + score;
                        fast f1 = new fast();
                        f1.ShowDialog();
                    }
                    else if (score >= 5 && score <= 7)
                    {
                        label4.Text = "Final score " + score;
                        average a1 = new average();
                        a1.ShowDialog();
                    }
                    else
                    {
                        label4.Text = "Final score " + score;
                        poor p1 = new poor();
                        p1.ShowDialog();
                    }
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            typinginterface t = new typinginterface();
            t.ShowDialog();
        }
    }
}
