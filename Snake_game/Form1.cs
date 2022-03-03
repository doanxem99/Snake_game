using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_game
{
    public partial class Form1 : Form
    {
        private int score =  0, time1 = 0, time2 = 0, time3 = 0, temp = 0, speed;
        private string space = "";
        private List<Circle> snake = new List<Circle> ();
        private Circle food = new Circle ();
        private Timer timer = new Timer();
        private List<string> keys = new List<string> ();
        private List<PictureBox> box = new List<PictureBox> ();
        public Form1()
        {
            InitializeComponent();
            box.Add(BOX1_picture);
            box.Add(BOX2_picture);
            box.Add(BOX3_picture);
            box.Add(BOX4_picture);
            box.Add(BOX5_picture);
            new Settings();
            Start_Game();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                Play_Game();
            }
            else
            if (keyData == Keys.Escape)
            {
                Application.Exit();
            }
            else
            if (keyData == Keys.P)
            {
                Pause_Game();
            }
            else
            if (keyData == Keys.N)
            {
                Init_Game();
            }
            else 
            if (keyData == Keys.Up && ((keys.Count == 0) || (keys[keys.Count - 1] != "Down")))
            {
                keys.Add("Up");
                return true;
            }
            else
            if (keyData == Keys.Down && ((keys.Count == 0) || (keys[keys.Count - 1] != "Up")))
            {
                keys.Add("Down");
                return true;
            }
            else
            if (keyData == Keys.Right && ((keys.Count == 0) || (keys[keys.Count - 1] != "Left")))
            {
                keys.Add("Right");
                return true;
            }
            else
            if (keyData == Keys.Left && ((keys.Count == 0) || (keys[keys.Count - 1] != "Right")))
            {
                keys.Add("Left");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void Start_Game()
        {
            timer = new Timer();
            if (speed == 0) speed = Settings.speed;
            timer.Interval = 1000 / speed;
            timer.Tick += Run_Game;
            timer.Start();
            Init_Game();
        }
        private void Run_Game(object sender, EventArgs e)
        {
            //TIMELINE_label.Text = score2.ToString();
            if (!Settings.game_pause)
            {
                time1 += (int)(1000 / speed);
                if (time1 / 1000 > time2) time2++;
                if (time2 > 59)
                {
                    time3++;
                    time2 = 0;
                    time1 = time1 % 1000;
                }
                TIME2_label.Text = (time2 < 10) ? "0" + time2.ToString() : time2.ToString();
                TIME3_label.Text = (time3 < 10) ? "0" + time3.ToString() : time3.ToString();
            }
            if (temp <= keys.Count - 1)
            {
                switch (keys[temp])
                {
                    case "Up":
                        Settings.direction = "Up";
                        break;
                    case "Down":
                        Settings.direction = "Down";
                        break;
                    case "Right":
                        Settings.direction = "Right";
                        break;
                    case "Left":
                        Settings.direction = "Left";
                        break;

                }
                temp++;
            }
            Move_Player();
            pbCanvas.Invalidate(); //Erasing the snake and redrawing
        }
        private void updateGraphics(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            if (Settings.game_over == false)
            {
                Brush snakecolor;
                for (int i = 0; i < snake.Count; i++)
                {
                    if (i == 0)
                    {
                        snakecolor = Brushes.Red;
                    }
                    else
                    {
                        snakecolor = Brushes.Black;
                    }
                    canvas.FillEllipse(snakecolor,
                                       new Rectangle(
                                           snake[i].X * Settings.width,
                                           snake[i].Y * Settings.height,
                                           Settings.width,
                                           Settings.height));
                    canvas.FillEllipse(Brushes.Yellow,
                                        new Rectangle(
                                            food.X * Settings.width,
                                            food.Y * Settings.height,
                                            Settings.width,
                                            Settings.height
                                            ));
                }
            }
        }
        private void Move_Player()
        {
            int temp1 = snake[snake.Count - 1].X;
            int temp2 = snake[snake.Count - 1].Y;
            for (int i = snake.Count - 1; i >= 0; i--)
            {
                if (i == 0) // head
                {
                    switch (Settings.direction)
                    {
                        case "Right":
                            snake[i].X += Settings.distance;
                            break;
                        case "Left":
                            snake[i].X -= Settings.distance;
                            break;
                        case "Up":
                            snake[i].Y -= Settings.distance;
                            break;
                        case "Down":
                            snake[i].Y += Settings.distance;
                            break;
                    }
                    //snake reachs edge
                    if (Game_Over(snake[i].X, snake[i].Y))
                    {
                        End_Game();
                        return;
                    }
                    //snake reachs his body
                    for (int j = 1; j <= snake.Count - 1; j++)
                    {
                        if (snake[j].X == snake[i].X && snake[j].Y == snake[i].Y)
                        {
                            End_Game();
                            return;
                        }
                    }
                    //snake reachs food
                    if (snake[i].X == food.X && snake[i].Y == food.Y)
                    {
                        Snake_Eating(temp1, temp2);
                    }
                }
                else
                {
                    snake[i].X = snake[i - 1].X;
                    snake[i].Y = snake[i - 1].Y;
                }
            }
        }

        private void Init_Game()
        {
            new Settings();
            snake.Clear();
            keys.Clear();
            SCORE_label.Text = "    0";
            TIME2_label.Text = TIME3_label.Text = "00";
            score = time1 = time2 = temp = 0;
            Circle head = new Circle();
            head.X = 0;
            head.Y = 0;
            snake.Add(head);
            Generate_Food();
            pbCanvas.Invalidate();
        }
        private void End_Game()
        {
            timer.Stop();
            MessageBox.Show(" Dont be sad!!!, you can try again ", "Game_Over", MessageBoxButtons.OK,
                MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
            Settings.game_over = true;
            return;
        }
        private bool Game_Over(int x, int y)
        {
            int maxXpos = pbCanvas.Size.Width / Settings.width;
            int maxYpos = pbCanvas.Size.Height / Settings.height;
            return (x < 0 || y < 0 || x >= maxXpos || y >= maxYpos) ;
        }
        private void Snake_Eating(int temp1, int temp2)
        {
            Circle part = new Circle();
            part.X = temp1;
            part.Y = temp2;
            snake.Add(part);
            score += Settings.point;
            if (score >= 1000) space = " ";
            else
            if (score >= 100) space = "  ";
            else
            if (score >= 10) space = "   ";
            SCORE_label.Text = space + score.ToString();
            Generate_Food();
        }
        private void Generate_Food()
        {
            int maxXpos = pbCanvas.Size.Width / Settings.width;
            int maxYpos = pbCanvas.Size.Height / Settings.height;
            Random random = new Random();
            int tempX, tempY;
            bool ok;
            do
            {
                ok = true;
                tempX = random.Next(0, maxXpos);
                tempY = random.Next(0, maxYpos);
                for (int i = 0; i < snake.Count; i++)
                {
                    if (snake[i].X == tempX && snake[i].Y == tempY)
                    {
                        ok = false;
                        break;
                    }
                }
            } while (!ok);

            food = new Circle { X = tempX, Y = tempY };
        }
        private void Play_Game()
        {
            if (Settings.direction == "")
            {
                Settings.direction = "Right";
            }
            if (!Settings.game_over && Settings.game_pause)
            {
                Settings.game_pause = false;
                timer.Start();
            }
        }
        private void Pause_Game()
        {
            if (Settings.game_pause == false)
            {
                timer.Stop();
                Settings.game_pause = true;
            }
        }
        private void PAUSE_button_Click(object sender, EventArgs e)
        {
            Pause_Game();
        }
        private void PLAY_button_Click(object sender, EventArgs e)
        {
            Play_Game();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           MessageBox.Show(" SNAKE GAME | Create by MDZ ", "About", MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Settings.game_pause)
            {
                if (BLOCK_checkbox.Checked == true)
                {
                    for (int i = 0; i < box.Count; i++)
                    {
                        box[i].Visible = true;
                    }
                }
                else
                {
                    for (int i = 0; i < box.Count; i++)
                    {
                        box[i].Visible = false;
                    }
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Init_Game();
        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Settings.game_pause)
            {
                speed = 10;
                Start_Game();
            }
        }
        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Settings.game_pause)
            {
                speed = 15;
                Start_Game();
            }
        }
        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Settings.game_pause)
            {
                speed = 20;
                Start_Game();
            }
        }
        private void extremeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Settings.game_pause)
            {
                speed = 25;
                Start_Game();
            }
        }
    }
}
