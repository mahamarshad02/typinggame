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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1370, 800);
            this.Location = new Point(0, 0);
            label2.Text = a[rnd.Next(0, a.Length)];
            label2.Size = new Size(700, 100);
            textBox1.Size = new Size(1000, 100);
        }

        string[] a =
        {
            "Simplicity is the ultimate sophistication.",
            "Don't you know your imperfections are a blessing?",
            "Never let your emotions overpower your intelligence.",
            "There is no saint without a past, no sinner without a future.",
            "Persistence guarantees that results are inevitable.",
            "I'd rather be an optimistic and a fool, than pessimistic and right.",
            "Wake up with determination. Go to bed with satisfaction.",
            "Never give in except to convictions of honor and good sense.",
            "Success is walking from failure to failure with no loss of enthusiasm.",
            "The sky grew darker, painted blue on blue, into deeper shades of night.",
            "The soul becomes dyed with the color of its own thoughts.",
            "People often believe they are safer in the lights, thinking monsters only came out at night.",
            "Success is not final; failure is not fatal: it is the courage to continue that counts.",
            "Failure is the condiment that gives success its flavor.",
            "There are two ways of spreading light: to be the candle oe the mirror that reflects it.",
            "Bitterness in your heart contaminates love in your soul.",
            "Life is like riding a bicycle. To keep your balance, you must keep moving.",
            "Your friends are many when you count on them, but in hardships they become few.",
            "Your medicine is in you, and you don't observe it.",
            "Sometimes the darkest challenges, the most difficult lessons, hold the greatest gems of light."
        };
        Random rnd = new Random();
        int score = 0;
        int incorrect = 0; //to keep track of no of incorrect moves
        int timeleft = 0; // to keep track of remaining time
        int count = 0; //to count no times timer has ticked
        


        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = a[rnd.Next(0, a.Length)];
            textBox1.Text = null;
            timeleft = 30;
            timer2.Start();
            
            count++;
            if (count == 10)
            {
                timer1.Stop();
                timer2.Stop();
                count = 0;
                if(score >=8 && score <=10)
                {
                    label4.Text = "Final score " + score;
                    fast f1 = new fast();
                    f1.ShowDialog();
                }
                else if(score >= 5 && score <= 7)
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
            timeleft = 30;
            timer2.Start(); //countdown timer
            timer1.Start();//timer for changing words
            
            
        }

        int j = 0;

        private void checker(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //detects if enter key is pressed
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
                    if (incorrect <= 3)
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

                timeleft = 30;
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
