using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace MAD_MAN_Ping_Pong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        //P1 move
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse == 1)
            {
                if (Cursor.Position.Y > 60 && Cursor.Position.Y < this.Size.Height - panel3.Size.Height - 50)
                {
                    P1.Location = new Point(P1.Location.X, Cursor.Position.Y - 45);
                }
            }
            else
            {
                if (mouse == 2)
                {
                    if (Cursor.Position.Y > 60 && Cursor.Position.Y < this.Size.Height - panel3.Size.Height - 50)
                    {
                        P2.Location = new Point(P2.Location.X, Cursor.Position.Y - 45);
                    }
                }
            }
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse == 1)
            {
                if (Cursor.Position.Y > 60 && Cursor.Position.Y < this.Size.Height - panel3.Size.Height - 50)
                {
                    P1.Location = new Point(P1.Location.X, Cursor.Position.Y - 45);
                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse == 1)
            {
                if (Cursor.Position.Y > 60 && Cursor.Position.Y < this.Size.Height - panel3.Size.Height - 50)
                {
                    P1.Location = new Point(P1.Location.X, Cursor.Position.Y - 45);
                }
            }
        }

        //P1 move end

        private void Form1_Load(object sender, EventArgs e)
        {
            Ball.Location = new Point(panel2.Size.Width / 2 - 5, panel3.Location.Y / 2 - panel2.Size.Height);
            pict.Location = new Point(panel2.Size.Width / 2 + (pict.Size.Width / 2), pict.Location.Y);
        }

        int p1_score, p2_score, wall, accept = 0,regulate=0,again=0,part=1,gx,gy,first=0;
        double x, y, x1, y1, a, b, speed = 5, x2, y2, x0, y0;
        Random rand = new Random();

        private void Start_Click(object sender, EventArgs e)
        {
            first++;
            if (first == 1)
            {
                gx = Score.Location.X;
                gy = Score.Location.Y;
            }
            Start.Text = "RESTART";
            Score.Location = new Point(gx, gy);
            Score.Text = "0 : 0";
            p1_score = 0;
            p2_score = 0;
            Ball.Location = new Point(panel2.Size.Width / 2 - 5, panel3.Location.Y / 2 - panel2.Size.Height);
            x = Ball.Location.X;
            y = Ball.Location.Y;
            x1 = 0;
            y1 = 0;
            int ok = 0;
            while (ok == 0)
            {
                wall = rand.Next(1, 4);
                if (wall == 1)
                {
                    y1 = panel2.Size.Height;
                    x1 = rand.Next(P1.Size.Width + P1.Location.X, panel2.Size.Width / 2 - 100);
                }
                if (wall == 2)
                {
                    x1 = P1.Size.Width + P1.Location.X;
                    y1 = rand.Next(panel2.Size.Height, panel3.Location.Y + 1 - Ball.Size.Height);
                }
                if (wall == 3)
                {
                    y1 = panel3.Location.Y - Ball.Size.Height;
                    x1 = rand.Next(P1.Size.Width + P1.Location.X, panel2.Size.Width / 2 - 100);
                }

                if (x1 != x && y1 != y)
                {
                    a = (y1 - y) / (x1 - x);
                    b = y1 - (a * x1);
                    speed = 5;
                    P2_GUI.Enabled = false;
                    Ball_Move.Enabled = true;
                    ok = 1;
                    accept = 0;
                    regulate = 0;
                    again = 0;
                }
            }
            
            
        }
        private void Ball_Move_Tick(object sender, EventArgs e)
        {
            if (accept == 0 && again==0)
            {
                if (x1 < x)
                {
                    if (x - speed > x1)
                    {
                        x -= speed;
                        y = a * x + b;
                        Ball.Location = new Point((int)x, (int)y);
                    }
                    else
                    {
                        x = x1;
                        y = y1;
                        Ball.Location = new Point((int)x, (int)y);
                        //respingere
                        accept = 1;
                        Respingere();
                    }

                }
                else
                {
                    if (x1 > x)
                    {
                        if (x + speed < x1)
                        {
                            x += speed;
                            y = a * x + b;
                            Ball.Location = new Point((int)x, (int)y);
                        }
                        else
                        {
                            x = x1;
                            y = y1;
                            Ball.Location = new Point((int)x, (int)y);
                            //respingere
                            accept = 1;
                            Respingere();
                        }
                    }
                    else
                    {
                        if (x1 == x)
                        {
                            Ball.Location = new Point((int)x, (int)y);
                            //respingere
                            accept = 1;
                            Respingere();
                        }
                    }
                }
                if (_command == 1)
                {

                    if (Level.Text == "IMPOSSIBLE")
                    {
                        if (y <= panel3.Location.Y - P2.Size.Height)
                        {
                            P2.Location = new Point(P2.Location.X, (int)y);
                        }
                        else
                        {
                            P2.Location = new Point(P2.Location.X, panel3.Location.Y - P2.Size.Height - 5);
                        }
                    }
                }
                
            }
        }

        private void Respingere()
        {
            if (again == 0)
            {
                regulate++;
                if (wall == 1)
                {
                    y2 = y + 10;
                    x2 = (y2 - b) / a;
                    y1 = y2;
                    x1 = 2 * x - x2;
                    a = (y1 - y) / (x1 - x);
                    b = y - (a * x);

                    x0 = P1.Location.X + P1.Size.Width;
                    y0 = a * x0 + b;
                    wall = 2;
                    if (y0 < panel2.Size.Height || y0 > panel3.Location.Y - Ball.Size.Height)
                    {
                        y0 = panel3.Location.Y - Ball.Size.Height;
                        x0 = (y0 - b) / a;
                        wall = 3;
                        if (x0 < P1.Location.X + P1.Size.Width || x0 > P2.Location.X - Ball.Size.Width)
                        {
                            x0 = P2.Location.X - Ball.Size.Width;
                            y0 = a * x0 + b;
                            wall = 4;
                            if (_command == 1)
                            {
                                if (y0 < panel3.Location.Y - P2.Size.Height - 5)
                                {
                                    sy = (int)y0;
                                }
                                else
                                {
                                    if (y0 >= panel3.Location.Y - P2.Size.Height - 5)
                                    {
                                        sy = panel3.Location.Y - P2.Size.Height - 5;
                                    }
                                }
                                P2_GUI.Enabled = true;

                            }
                        }
                    }
                    x1 = x0;
                    y1 = y0;
                }
                else
                {
                    if (wall == 2)
                    {
                        if (y <= P1.Size.Height + P1.Location.Y && y >= P1.Location.Y - Ball.Size.Height)
                        {
                            x2 = x + 10;
                            y2 = x2 * a + b;
                            x1 = x2;
                            y1 = 2 * y - y2;
                            a = (y1 - y) / (x1 - x);
                            b = y1 - (a * x1);

                            y0 = panel2.Size.Height;
                            x0 = (y0 - b) / a;
                            wall = 1;
                            if (x0 < P1.Location.X + P1.Size.Width || x0 > P2.Location.X - Ball.Size.Width)
                            {
                                y0 = panel3.Location.Y - Ball.Size.Height;
                                x0 = (y0 - b) / a;
                                wall = 3;
                                if (x0 < P1.Location.X + P1.Size.Width || x0 > P2.Location.X - Ball.Size.Width)
                                {
                                    x0 = P2.Location.X - Ball.Size.Width;
                                    y0 = a * x0 + b;
                                    wall = 4;
                                    if (_command == 1)
                                    {
                                        if (y0 < panel3.Location.Y - P2.Size.Height - 5)
                                        {
                                            sy = (int)y0;
                                        }
                                        else
                                        {
                                            if (y0 >= panel3.Location.Y - P2.Size.Height - 5)
                                            {
                                                sy = panel3.Location.Y - P2.Size.Height - 5;
                                            }
                                        }
                                        P2_GUI.Enabled = true;
                                    }
                                }
                            }
                            x1 = x0;
                            y1 = y0;
                        }
                        else
                        {

                            p2_score++;
                            if (p2_score < 7)
                            {
                                again = 1;
                                Score.Text = "" + p1_score + " : " + p2_score;
                                part = 1;
                                //refresh
                                refresh();
                            }
                            else
                            {
                                if (p2_score == 7)
                                {
                                    Ball_Move.Enabled = false;
                                    Score.Location = new Point(Score.Location.X-100,Score.Location.Y);
                                    if (_command == 1)
                                    {
                                        Score.Text = "CPU win!";
                                    }
                                    else
                                    {
                                        Score.Text = "P2 win!";
                                    }
                                    Ball.Location = new Point(panel2.Size.Width / 2 - 5, panel3.Location.Y / 2 - panel2.Size.Height);

                                }
                            }
                        }
                    }
                    else
                    {
                        if (wall == 3)
                        {
                            y2 = y - 10;
                            x2 = (y2 - b) / a;
                            y1 = y2;
                            x1 = 2 * x - x2;
                            a = (y1 - y) / (x1 - x);
                            b = y - (a * x);

                            x0 = P1.Location.X + P1.Size.Width;
                            y0 = a * x0 + b;
                            wall = 2;
                            if (y0 < panel2.Size.Height || y0 > panel3.Location.Y - Ball.Size.Height)
                            {
                                y0 = panel2.Size.Height;
                                x0 = (y0 - b) / a;
                                wall = 1;
                                if (x0 < P1.Location.X + P1.Size.Width || x0 > P2.Location.X - Ball.Size.Width)
                                {
                                    x0 = P2.Location.X - Ball.Size.Width;
                                    y0 = a * x0 + b;
                                    wall = 4;
                                    if (_command == 1)
                                    {
                                        if (y0 < panel3.Location.Y - P2.Size.Height - 5)
                                        {
                                            sy = (int)y0;
                                        }
                                        else
                                        {
                                            if (y0 >= panel3.Location.Y - P2.Size.Height - 5)
                                            {
                                                sy = panel3.Location.Y - P2.Size.Height - 5;
                                            }
                                        }
                                        P2_GUI.Enabled = true;

                                    }
                                }
                            }
                            x1 = x0;
                            y1 = y0;
                        }
                        else
                        {
                            if (wall == 4)
                            {
                                if (y <= P2.Size.Height + P2.Location.Y && y >= P2.Location.Y - Ball.Size.Height)
                                {
                                    x2 = x - 10;
                                    y2 = x2 * a + b;
                                    x1 = x2;
                                    y1 = 2 * y - y2;

                                    a = (y1 - y) / (x1 - x);
                                    b = y1 - (a * x1);
                                    y0 = panel2.Size.Height;
                                    x0 = (y0 - b) / a;
                                    wall = 1;
                                    if (x0 < P1.Location.X + P1.Size.Width || x0 > P2.Location.X - Ball.Size.Width)
                                    {
                                        y0 = panel3.Location.Y - Ball.Size.Height;
                                        x0 = (y0 - b) / a;
                                        wall = 3;
                                        if (x0 < P1.Location.X + P1.Size.Width || x0 > P2.Location.X - Ball.Size.Width)
                                        {
                                            x0 = P1.Location.X + P1.Size.Width;
                                            y0 = a * x0 + b;
                                            wall = 2;
                                        }
                                    }
                                    x1 = x0;
                                    y1 = y0;
                                }
                                else
                                {

                                    p1_score++;
                                    if (p1_score < 7)
                                    {
                                        again = 1;
                                        Score.Text = "" + p1_score + " : " + p2_score;
                                        part = 2;
                                        //refresh
                                        refresh();
                                    }
                                    else
                                    {
                                        if (p1_score == 7)
                                        {
                                            Ball_Move.Enabled = false;
                                            Score.Location = new Point(Score.Location.X - 100, Score.Location.Y);
                                            Score.Text = "P1 win!";
                                            Ball.Location = new Point(panel2.Size.Width / 2 - 5, panel3.Location.Y / 2 - panel2.Size.Height);

                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (Level.Text == "HARD")
                    {
                        double _x1 = x1, _y1 = y1, _x2 = x2, _y2 = y2, _x = x1,_y=y1,_a=a,_b=b;
                        if (wall == 1)
                        {
                            _y2 = _y + 10;
                            _x2 = (_y2 - _b) / _a;
                            _y1 = _y2;
                            _x1 = 2 * _x - _x2;
                            _a = (_y1 - _y) / (_x1 - _x);
                            _b = _y - (_a * _x);

                            x0 = P1.Location.X + P1.Size.Width;
                            y0 = _a * x0 + _b;
                            if (y0 < panel2.Size.Height || y0 > panel3.Location.Y - Ball.Size.Height)
                            {
                                y0 = panel3.Location.Y - Ball.Size.Height;
                                x0 = (y0 - _b) / _a;
                                if (x0 < P1.Location.X + P1.Size.Width || x0 > P2.Location.X - Ball.Size.Width)
                                {
                                    x0 = P2.Location.X - Ball.Size.Width;
                                    y0 = _a * x0 + _b;
                                    if (_command == 1)
                                    {
                                        if (y0 < panel3.Location.Y - P2.Size.Height - 5)
                                        {
                                            sy = (int)y0;
                                        }
                                        else
                                        {
                                            if (y0 >= panel3.Location.Y - P2.Size.Height - 5)
                                            {
                                                sy = panel3.Location.Y - P2.Size.Height - 5;
                                            }
                                        }
                                        P2_GUI.Enabled = true;
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (wall == 2)
                            {
                                _x2 = _x + 10;
                                _y2 = _x2 * _a + _b;
                                _x1 = _x2;
                                _y1 = 2 * _y - _y2;
                                _a = (_y1 - _y) / (_x1 - _x);
                                _b = _y1 - (_a * _x1);

                                y0 = panel2.Size.Height;
                                x0 = (y0 - _b) / _a;
                                if (x0 < P1.Location.X + P1.Size.Width || x0 > P2.Location.X - Ball.Size.Width)
                                {
                                    y0 = panel3.Location.Y - Ball.Size.Height;
                                    x0 = (y0 - _b) / _a;
                                    if (x0 < P1.Location.X + P1.Size.Width || x0 > P2.Location.X - Ball.Size.Width)
                                    {
                                        x0 = P2.Location.X - Ball.Size.Width;
                                        y0 = _a * x0 + _b;
                                        if (_command == 1)
                                        {
                                            if (y0 < panel3.Location.Y - P2.Size.Height - 5)
                                            {
                                                sy = (int)y0;
                                            }
                                            else
                                            {
                                                if (y0 >= panel3.Location.Y - P2.Size.Height - 5)
                                                {
                                                    sy = panel3.Location.Y - P2.Size.Height - 5;
                                                }
                                            }
                                            P2_GUI.Enabled = true;
                                        }
                                    }
                                }

                            }
                            else
                            {
                                if (wall == 3)
                                {
                                    _y2 = _y - 10;
                                    _x2 = (_y2 - _b) / _a;
                                    _y1 = _y2;
                                    _x1 = 2 * _x - _x2;
                                    _a = (_y1 - _y) / (_x1 - _x);
                                    _b = _y - (_a * _x);

                                    x0 = P1.Location.X + P1.Size.Width;
                                    y0 = _a * x0 + _b;
                                    if (y0 < panel2.Size.Height || y0 > panel3.Location.Y - Ball.Size.Height)
                                    {
                                        y0 = panel2.Size.Height;
                                        x0 = (y0 - _b) / _a;
                                        if (x0 < P1.Location.X + P1.Size.Width || x0 > P2.Location.X - Ball.Size.Width)
                                        {
                                            x0 = P2.Location.X - Ball.Size.Width;
                                            y0 = _a * x0 + _b;
                                            if (_command == 1)
                                            {
                                                if (y0 < panel3.Location.Y - P2.Size.Height - 5)
                                                {
                                                    sy = (int)y0;
                                                }
                                                else
                                                {
                                                    if (y0 >= panel3.Location.Y - P2.Size.Height - 5)
                                                    {
                                                        sy = panel3.Location.Y - P2.Size.Height - 5;
                                                    }
                                                }
                                                P2_GUI.Enabled = true;
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (wall == 4)
                                    {
                                        if (_y <= P2.Size.Height + P2.Location.Y && _y >= P2.Location.Y - Ball.Size.Height)
                                        {
                                            _x2 = _x - 10;
                                            _y2 = _x2 * _a + _b;
                                            _x1 = _x2;
                                            _y1 = 2 * _y - _y2;

                                            _a = (_y1 - _y) / (_x1 - _x);
                                            _b = _y1 - (_a * _x1);
                                            y0 = panel2.Size.Height;
                                            x0 = (y0 - _b) / _a;
                                            if (x0 < P1.Location.X + P1.Size.Width || x0 > P2.Location.X - Ball.Size.Width)
                                            {
                                                y0 = panel3.Location.Y - Ball.Size.Height;
                                                x0 = (y0 -_b) / _a;
                                                if (x0 < P1.Location.X + P1.Size.Width || x0 > P2.Location.X - Ball.Size.Width)
                                                {
                                                    x0 = P1.Location.X + P1.Size.Width;
                                                    y0 = _a * x0 + _b;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
                if (regulate == 10)
                {
                    speed++;
                    regulate = 0;
                }
                accept = 0;
            }

        }
    

    

        private void refresh()
        {
            Ball.Location = new Point(panel2.Size.Width / 2 - 5, panel3.Location.Y / 2 - panel2.Size.Height);
            x = Ball.Location.X;
            y = Ball.Location.Y;
            x1 = 0;
            y1 = 0;
            int ok = 0;
            while (ok == 0)
            {
                wall = rand.Next(1, 4);
                if (wall == 1)
                {
                    if (part == 1)
                    {
                        y1 = panel2.Size.Height;
                        x1 = rand.Next(P1.Size.Width + P1.Location.X, panel2.Size.Width / 2 - 100);
                    }
                    else
                    {
                        if (part == 2)
                        {
                            y1 = panel2.Size.Height;
                            x1 = rand.Next(panel2.Size.Width / 2 + 100, P2.Location.X - Ball.Size.Width + 1);
                        }
                    }
                }
                if (wall == 2)
                {
                    if (part == 1)
                    {
                        x1 = P1.Size.Width + P1.Location.X;
                        y1 = rand.Next(panel2.Size.Height, panel3.Location.Y + 1 - Ball.Size.Height);
                    }
                    else
                    {
                        if (part == 2)
                        {
                            x1 = P2.Location.X - Ball.Size.Width;
                            y1 = rand.Next(panel2.Size.Height, panel3.Location.Y + 1 - Ball.Size.Height);
                            wall = 4;
                        }
                    }
                }
                if (wall == 3)
                {
                    if (part == 1)
                    {
                        y1 = panel3.Location.Y - Ball.Size.Height;
                        x1 = rand.Next(P1.Size.Width + P1.Location.X, panel2.Size.Width / 2 - 100);
                    }
                    else
                    {
                        if (part == 2)
                        {
                            y1 = panel3.Location.Y - Ball.Size.Height;
                            x1 = rand.Next(panel2.Size.Width / 2 + 100, P2.Location.X - Ball.Size.Width + 1);
                        }
                    }

                }
                
                if (x1 != x && y1 != y)
                {
                    a = (y1 - y) / (x1 - x);
                    b = y1 - (a * x1);
                    speed = 5;
                    ok = 1;
                    accept = 0;
                    regulate = 0;
                    again = 0;
                    if(_command==1)
                    {
                        if (part == 2)
                        {

                            if (y1 < panel3.Location.Y - P2.Size.Height - 5)
                            {
                                sy = (int)y1;
                            }
                            else
                            {
                                if (y1 >= panel3.Location.Y - P2.Size.Height - 5)
                                {
                                    sy = panel3.Location.Y - P2.Size.Height - 5;
                                }
                            }
                            P2_GUI.Enabled = true;
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int sy;
        private void P2_GUI_Tick(object sender, EventArgs e)
        {
            if (Level.Text != "IMPOSSIBLE")
            {
                if (P2.Location.Y < sy)
                {
                    if (P2.Location.Y + pspeed < sy)
                    {
                        P2.Location = new Point(P2.Location.X, P2.Location.Y + pspeed);
                    }
                    else
                    {
                        P2.Location = new Point(P2.Location.X, sy);
                        P2_GUI.Enabled = false;
                    }
                }
                else
                {
                    if (P2.Location.Y > sy)
                    {
                        if (P2.Location.Y - pspeed > sy)
                        {
                            P2.Location = new Point(P2.Location.X, P2.Location.Y - pspeed);
                        }
                        else
                        {
                            P2.Location = new Point(P2.Location.X, sy);
                            P2_GUI.Enabled = false;
                        }

                    }
                    else
                    {
                        if (P2.Location.Y == sy)
                        {
                            P2.Location = new Point(P2.Location.X, sy);
                            P2_GUI.Enabled = false;
                        }
                    }
                }
            }

                

                

            
        }
        int pspeed = 1;
        private void Level_Click(object sender, EventArgs e)
        {
            if (_command == 1)
            {
                if (Level.Text == "EASY")
                {
                    Level.Text = "NORMAL";
                    pspeed = 5;
                }
                else
                {
                    if (Level.Text == "NORMAL")
                    {
                        Level.Text = "HARD";
                        pspeed = 10;
                    }
                    else
                    {
                        if (Level.Text == "HARD")
                        {
                            Level.Text = "IMPOSSIBLE";
                        }
                        else
                        {
                            if (Level.Text == "IMPOSSIBLE")
                            {
                                Level.Text = "EASY";
                                pspeed = 1;
                            }
                        }
                    }
                }
                first++;
                if (first == 1)
                {
                    gx = Score.Location.X;
                    gy = Score.Location.Y;
                }
                Start.Text = "RESTART";
                Score.Location = new Point(gx, gy);
                Score.Text = "0 : 0";
                p1_score = 0;
                p2_score = 0;
                Ball.Location = new Point(panel2.Size.Width / 2 - 5, panel3.Location.Y / 2 - panel2.Size.Height);
                x = Ball.Location.X;
                y = Ball.Location.Y;
                x1 = 0;
                y1 = 0;
                int ok = 0;
                while (ok == 0)
                {
                    wall = rand.Next(1, 4);
                    if (wall == 1)
                    {
                        y1 = panel2.Size.Height;
                        x1 = rand.Next(P1.Size.Width + P1.Location.X, panel2.Size.Width / 2 - 100);
                    }
                    if (wall == 2)
                    {
                        x1 = P1.Size.Width + P1.Location.X;
                        y1 = rand.Next(panel2.Size.Height, panel3.Location.Y + 1 - Ball.Size.Height);
                    }
                    if (wall == 3)
                    {
                        y1 = panel3.Location.Y - Ball.Size.Height;
                        x1 = rand.Next(P1.Size.Width + P1.Location.X, panel2.Size.Width / 2 - 100);
                    }

                    if (x1 != x && y1 != y)
                    {
                        a = (y1 - y) / (x1 - x);
                        b = y1 - (a * x1);
                        speed = 5;
                        P2_GUI.Enabled = false;
                        Ball_Move.Enabled = true;
                        ok = 1;
                        accept = 0;
                        regulate = 0;
                        again = 0;
                    }
                }
            }
            

        }
        int _command = 1;
        string msg = "P1 controls : W-up , S-down" + '\n' + "P2 controls : O-up , L-down";

        private void Player_Command_Click(object sender, EventArgs e)
        {
            if (_command == 1)
            {
                Player_Command.Text = "MULTI PLAYER";
                MessageBox.Show(msg);
                _command = 2;
                C1.Checked = false;
                C2.Checked = false;
                mouse = 0;
                C2.Text = "USING MOUSE";
            }
            else
            {
                if (_command == 2)
                {
                    Player_Command.Text = "SINGLE PLAYER";
                    _command = 1;
                    C1.Checked = true;
                    C2.Checked = false;
                    mouse = 1;
                    C2.Text = "USING WS MOVING";
                }
            } first++;
            if (first == 1)
            {
                gx = Score.Location.X;
                gy = Score.Location.Y;
            }
            Start.Text = "RESTART";
            Score.Location = new Point(gx, gy);
            Score.Text = "0 : 0";
            p1_score = 0;
            p2_score = 0;
            Ball.Location = new Point(panel2.Size.Width / 2 - 5, panel3.Location.Y / 2 - panel2.Size.Height);
            x = Ball.Location.X;
            y = Ball.Location.Y;
            x1 = 0;
            y1 = 0;
            int ok = 0;
            while (ok == 0)
            {
                wall = rand.Next(1, 4);
                if (wall == 1)
                {
                    y1 = panel2.Size.Height;
                    x1 = rand.Next(P1.Size.Width + P1.Location.X, panel2.Size.Width / 2 - 100);
                }
                if (wall == 2)
                {
                    x1 = P1.Size.Width + P1.Location.X;
                    y1 = rand.Next(panel2.Size.Height, panel3.Location.Y + 1 - Ball.Size.Height);
                }
                if (wall == 3)
                {
                    y1 = panel3.Location.Y - Ball.Size.Height;
                    x1 = rand.Next(P1.Size.Width + P1.Location.X, panel2.Size.Width / 2 - 100);
                }

                if (x1 != x && y1 != y)
                {
                    a = (y1 - y) / (x1 - x);
                    b = y1 - (a * x1);
                    speed = 5;
                    P2_GUI.Enabled = false;
                    Ball_Move.Enabled = true;
                    ok = 1;
                    accept = 0;
                    regulate = 0;
                    again = 0;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((mouse == 0 && _command == 1) || mouse == 2 || (mouse == 0 && _command == 2))
            {
                if (e.KeyCode == Keys.W)
                {
                    p1_move = 1;
                    _p1tm.Enabled = true;
                }
                else
                {

                    if (e.KeyCode == Keys.S)
                    {
                        p1_move = 2;
                        _p1tm.Enabled = true;
                    }
                }
            }
            if ((mouse == 1 || mouse == 0) && _command == 2)
            {
                if (e.KeyCode == Keys.O)
                {
                    p2_move = 1;
                    _p2tm.Enabled = true;
                }
                else
                {

                    if (e.KeyCode == Keys.L)
                    {
                        p2_move = 2;
                        _p2tm.Enabled = true;
                    }
                }
            }
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.S)
            {
                p1_move = 0;
            }
            if (e.KeyCode == Keys.O || e.KeyCode == Keys.L)
            {
                p2_move = 0;
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        int p1_move=0,p2_move=0;

        private void _p1tm_Tick(object sender, EventArgs e)
        {
            if (p1_move != 0)
            {
                if (p1_move == 1)
                {
                    if (P1.Location.Y - 10 >= panel2.Size.Height + 5)
                    {
                        P1.Location = new Point(P1.Location.X, P1.Location.Y - 10);
                    }
                    else
                    {
                        P1.Location = new Point(P1.Location.X, panel2.Size.Height + 5);
                    }
                }
                else
                {
                    if (p1_move == 2)
                    {
                        if (P1.Location.Y + 10 <= panel3.Location.Y - 5 - P1.Size.Height)
                        {
                            P1.Location = new Point(P1.Location.X, P1.Location.Y + 10);
                        }
                        else
                        {
                            P1.Location = new Point(P1.Location.X, panel3.Location.Y - 5 - P1.Size.Height);
                        }
                    }
                }
            }
            else
            {
                _p1tm.Enabled = false;
            }
            
        }

        private void _p2tm_Tick(object sender, EventArgs e)
        {
            if (p2_move != 0)
            {
                if (p2_move == 1)
                {
                    if (P2.Location.Y - 10 >= panel2.Size.Height + 5)
                    {
                        P2.Location = new Point(P2.Location.X, P2.Location.Y - 10);
                    }
                    else
                    {
                        P2.Location = new Point(P2.Location.X, panel2.Size.Height + 5);
                    }
                }
                else
                {
                    if (p2_move == 2)
                    {
                        if (P2.Location.Y + 10 <= panel3.Location.Y - 5 - P2.Size.Height)
                        {
                            P2.Location = new Point(P2.Location.X, P2.Location.Y + 10);
                        }
                        else
                        {
                            P2.Location = new Point(P2.Location.X, panel3.Location.Y - 5 - P2.Size.Height);
                        }
                    }
                }
            }
            else
            {
                _p2tm.Enabled = false;
            }
        }

        private void C2_KeyDown(object sender, KeyEventArgs e)
        {
            if ((mouse == 0 && _command == 1) || mouse == 2 || (mouse == 0 && _command == 2))
            {
                if (e.KeyCode == Keys.W)
                {
                    p1_move = 1;
                    _p1tm.Enabled = true;
                }
                else
                {

                    if (e.KeyCode == Keys.S)
                    {
                        p1_move = 2;
                        _p1tm.Enabled = true;
                    }
                }
            }
            if ((mouse == 1 || mouse == 0) && _command == 2)
            {
                if (e.KeyCode == Keys.O)
                {
                    p2_move = 1;
                    _p2tm.Enabled = true;
                }
                else
                {

                    if (e.KeyCode == Keys.L)
                    {
                        p2_move = 2;
                        _p2tm.Enabled = true;
                    }
                }
            }
        }

        private void C2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.S)
            {
                p1_move = 0;
            }
            if (e.KeyCode == Keys.O || e.KeyCode == Keys.L)
            {
                p2_move = 0;
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void C1_CheckedChanged(object sender, EventArgs e)
        {
            if (_command == 1)
            {
                if (C1.Checked == false)
                {
                    C2.Checked = true;
                    mouse = 0;
                }
                else
                {
                    if (C1.Checked == true)
                    {
                        C2.Checked = false;
                        mouse = 1;
                    }
                }
            }
            else
            {
                if (_command == 2)
                {
                    if (C1.Checked == true)
                    {
                        if (C2.Checked == false)
                        {
                            mouse = 1;
                        }
                        else
                        {
                            C1.Checked = false;
                        }
                    }
                    else
                    {
                        if (C2.Checked == false)
                        {
                            mouse = 0;
                        }
                        else
                        {
                            mouse = 2; ;
                        }
                    }
                }

            }
        }
        int mouse = 1;
        private void C2_CheckedChanged(object sender, EventArgs e)
        {
            if (_command == 1)
            {
                if (C2.Checked == false)
                {
                    C1.Checked = true;
                    mouse = 1;
                }
                else
                {
                    if (C2.Checked == true)
                    {
                        C1.Checked = false;
                        mouse = 0;
                    }
                }
            }
            else
            {
                if (_command == 2)
                {
                    if (C2.Checked == true)
                    {
                        if (C1.Checked == false)
                        {
                            mouse = 2;
                        }
                        else
                        {
                            C2.Checked = false;
                        }
                    }
                    else
                    {
                        if (C1.Checked == false)
                        {
                            mouse = 0;
                        }
                        else
                        {
                            mouse = 1; ;
                        }
                    }
                }
                
            }
        }

        

        



        

       
       



      
    }
}
