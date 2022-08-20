using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basketball_OOP
{
    public partial class Form1 : Form
    {
        Balls balls = new Balls();
        bool track = false;
        int moveFlag = 0;
        int tick = 0;

        Point[] apt = new Point[] { new Point(455, 151), new Point(470, 220),
                                    new Point(520, 151), new Point(510, 220),
                                    new Point(470, 220), new Point(510, 220),
                                    new Point(455, 151), new Point(510, 220),
                                    new Point(520, 151), new Point(470, 220)};
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            accept_button.Enabled = false;
            sider_track.Enabled = false;
            power_track.Enabled = false;
        }
        
        private void sider_thread_Tick(object sender, EventArgs e)
        {
                if (track == true)
                {
                    if (sider_track.Value < 10)
                    {
                        sider_track.Value++;
                        balls.sider(1);
                        Invalidate();
                    }
                    else track = false;
                }
                else
                {
                    if (sider_track.Value >= 1)
                    {
                        sider_track.Value--;
                        balls.sider(0);
                        Invalidate();
         
                    }
                    else track = true;
                } 
        } // отрисовка сторон удара
        
        private void power_thread_Tick(object sender, EventArgs e)
        {
            if (track == true)
            {
                if (power_track.Value < 10)
                {
                    power_track.Value++;
                    balls.power(1);
                    Invalidate();
                }
                else track = false;
            }
            else
            {
                if (power_track.Value >= 1)
                {
                    power_track.Value--;
                    balls.power(0);
                    Invalidate();
                }
                else track = true;
            }

        } // отрисовка силы удара

        void def()
        {
            label1.Text = " ";
            sider_track.Enabled = true;
            sider_thread.Start();
            move_thread.Stop();
            sider_track.Value = 0;
            power_track.Value = 0;
            balls.defolt();
            tick = 0;
        } // пресет дефолтных значений для новой игры
        void def_2()
        {
            user1.Enabled = false;
            user2.Enabled = false;
            accept_button.Enabled = true;
        }
        void def_show()
        {
            user1.Enabled = true;
            user2.Enabled = true;
        }
        private void user1_MouseClick(object sender, MouseEventArgs e)
        {
            balls.User_game= 0;
            def();
            def_2();
        }// нажатие на табло юзер 1
        
        private void user2_MouseClick(object sender, MouseEventArgs e)
        {
            balls.User_game = 1;
            def();
            def_2();
        } // нажатие на табло юзер 2
       
        private void accept_button_Click(object sender, EventArgs e)
        {
            sider_thread.Stop();
            if (power_thread.Enabled != true) { power_thread.Start(); sider_track.Enabled = false;}
            else
            {
                power_thread.Stop();
                move_thread.Start();
                accept_button.Enabled = false;
            }
        } // кнопка принять

        public void move_thread_Tick(object sender, EventArgs e)
        {
            tick++;
            moveFlag = balls.move(tick);
            if (moveFlag == 0)
            {
                move_thread.Stop();
                //MessageBox.Show("Поздравляем, Вы забили", "Сообщение");
                def_show();

                label1.Text = $"Ура! Игрок {balls.User_game + 1} забил";
                if (balls.User_game == 0) user1.Text = $"{balls.get_score()}";
                else user2.Text = $"{balls.get_score()}";
            }
            else if (moveFlag == 2)
            {
                move_thread.Stop();
                label1.Text = $"Игрок {balls.User_game+1} не забил!";
                //MessageBox.Show("К сожалению, Вы не забили", "Сообщение");
                def_show();

            }
            else Invalidate();


        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(new SolidBrush(Color.OrangeRed), balls.X_default, balls.Y_default, 50, 50);
            e.Graphics.FillRectangle(new SolidBrush(Color.OrangeRed), 450, 140, 80, 12);
            e.Graphics.DrawLine(Pens.Gray, apt[0], apt[1]);
            e.Graphics.DrawLine(Pens.Gray, apt[2], apt[3]);
            e.Graphics.DrawLine(Pens.Gray, apt[4], apt[5]);
            e.Graphics.DrawLine(Pens.Gray, apt[6], apt[7]);
            e.Graphics.DrawLine(Pens.Gray, apt[8], apt[9]);
            e.Graphics.FillRectangle(new SolidBrush(Color.OrangeRed), 530, 140, 20, 7);
            e.Graphics.FillRectangle(new SolidBrush(Color.OrangeRed), 545, 50, 15, 150);
            e.Graphics.FillRectangle(new SolidBrush(Color.Gray), 570, 140, 20, 300);
            e.Graphics.FillRectangle(new SolidBrush(Color.Gray), 560, 140, 20, 20);
        }
    }
}
