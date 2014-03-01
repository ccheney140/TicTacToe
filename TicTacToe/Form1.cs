using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        Graphics canvas = null;
        Bitmap X = new Bitmap("X.bmp");
        Bitmap O = new Bitmap("Circle.bmp");

        Font newfont = new Font("Times New Roman", 50);

        string turn = "X";

        string box1 = "";
        string box2 = "";
        string box3 = "";
        string box4 = "";
        string box5 = "";
        string box6 = "";
        string box7 = "";
        string box8 = "";
        string box9 = "";

        Brush gBrush = new LinearGradientBrush(new Rectangle(0, 0, 640, 480), Color.Aquamarine, Color.Purple, LinearGradientMode.ForwardDiagonal);


        public Form1()
        {
            InitializeComponent();
            canvas = this.CreateGraphics();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            btnStart.Visible = false;
            btnStart.Enabled = false;

            X.MakeTransparent(Color.White);
            O.MakeTransparent(Color.White);

            canvas.DrawLine(Pens.Black, 200, 0, 200, 600);
            canvas.DrawLine(Pens.Black, 400, 0, 400, 600);
            canvas.DrawLine(Pens.Black, 0, 200, 600, 200);
            canvas.DrawLine(Pens.Black, 0, 400, 600, 400);



        }


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            int mousex = e.X;
            int mousey = e.Y;
            bool success = false;

            Bitmap PlayerImage = X;

            if (turn == "O")
            {
                PlayerImage = O;
            }


            if (mousex >= 0 && mousex < 200 && mousey >= 0 && mousey < 200 && box1 == "")
            {
                canvas.DrawImage(PlayerImage, 0, 0, 197, 197);
                success = true;
                box1 = turn;
            }

            if (mousex >= 0 && mousex < 200 && mousey > 200 && mousey < 400 && box2 == "")
            {
                canvas.DrawImage(PlayerImage, 0, 200, 197, 197);
                success = true;
                box2 = turn;
            }

            if (mousex >= 0 && mousex < 200 && mousey > 400 && mousey < 600 && box3 == "")
            {
                canvas.DrawImage(PlayerImage, 0, 400, 197, 197);
                success = true;
                box3 = turn;
            }

            if (mousex > 200 && mousex < 400 && mousey >= 0 && mousey < 200 && box4 == "")
            {
                canvas.DrawImage(PlayerImage, 200, 0, 197, 197);
                success = true;
                box4 = turn;
            }

            if (mousex > 200 && mousex < 400 && mousey > 200 && mousey < 400 && box5 == "")
            {
                canvas.DrawImage(PlayerImage, 200, 200, 197, 197);
                success = true;
                box5 = turn;
            }

            if (mousex > 200 && mousex < 400 && mousey > 400 && mousey < 600 && box6 == "")
            {
                canvas.DrawImage(PlayerImage, 200, 400, 197, 197);
                success = true;
                box6 = turn;
            }

            if (mousex > 400 && mousex < 600 && mousey >= 0 && mousey < 200 && box7 == "")
            {
                canvas.DrawImage(PlayerImage, 400, 0, 197, 197);
                success = true;
                box7 = turn;
            }

            if (mousex > 400 && mousex < 600 && mousey > 200 && mousey < 400 && box8 == "")
            {
                canvas.DrawImage(PlayerImage, 400, 200, 197, 197);
                success = true;
                box8 = turn;
            }

            if (mousex > 400 && mousex < 600 && mousey > 400 && mousey < 600 && box9 == "")
            {
                canvas.DrawImage(PlayerImage, 400, 400, 197, 197);
                success = true;
                box9 = turn;
            }

            if (success == true)
            {
                CheckScore();
                if (turn == "X")
                    turn = "O";
                else
                    turn = "X";
            }

        }
        private void CheckScore()
        {
            //first collum straight down
            if (box1 == turn && box2 == turn && box3 == turn)
            {
                if (MessageBox.Show(turn + " " + "Wins!!", "Play again?", MessageBoxButtons.YesNo)
                    == DialogResult.No)
                {
                    Application.Exit();
                }
                else
                {
                    restart();
                }
            }
            //top collum straight over
            if (box1 == "X" && box4 == "X" && box7 == "X")
            {

                if (MessageBox.Show(turn + " " + "Wins!!", "Play again?", MessageBoxButtons.YesNo)
                    == DialogResult.No)
                {
                    Application.Exit();
                }
                else
                {
                    restart();
                }

            }
            //one down straight over
            if (box2 == turn && box5 == turn && box8 == turn)
            {
                if (MessageBox.Show(turn + " " + "Wins!!", "Play again?", MessageBoxButtons.YesNo)
                    == DialogResult.No)
                {
                    Application.Exit();
                }
                else
                {
                    restart();
                }

            }
                // two down straight over
            if (box3 == turn && box6 == turn && box9 == turn)
            {
                if (MessageBox.Show(turn + " " + "Wins!!", "Play again?", MessageBoxButtons.YesNo)
                    == DialogResult.No)
                {
                    Application.Exit();
                }
                else
                {
                    restart();
                }

            }
             //one over down
            if (box4 == turn && box5 == turn && box6 == turn)
            {
                if (MessageBox.Show(turn + " " + "Wins!!", "Play again?", MessageBoxButtons.YesNo)
                    == DialogResult.No)
                {
                    Application.Exit();
                }
                else
                {
                    restart();
                }

            }
            //two over down
            if (box7 == turn && box8 == turn && box9 == turn)
            {
                if (MessageBox.Show(turn + " " + "Wins!!", "Play again?", MessageBoxButtons.YesNo)
                    == DialogResult.No)
                {
                    Application.Exit();
                }
                else
                {
                    restart();
                }

            }

            if (box1 == turn && box5 == turn && box9 == turn)
            {
                if (MessageBox.Show(turn + " " + "Wins!!", "Play again?", MessageBoxButtons.YesNo)
                    == DialogResult.No)
                {
                    Application.Exit();
                }
                else
                {
                    restart();
                }

            }

            if (box3 == turn && box5 == turn && box7 == turn)
            {
                if (MessageBox.Show(turn + " " + "Wins!!", "Play again?", MessageBoxButtons.YesNo)
                    == DialogResult.No)
                {
                    Application.Exit();
                }
                else
                {
                    restart();
                }

            }
            //Ask Mrs. Olsen about this
            if (box1 == turn && box2 == turn && box3 == turn && box4 == turn && box5 == turn && box6 == turn && box7 == turn && box8 == turn && box9 == turn)
            {
                if (MessageBox.Show("It's a Tie!!", "Play again?", MessageBoxButtons.YesNo)
                    == DialogResult.No)
                {
                    Application.Exit();
                }
                else
                {
                    restart();
                }
            }

        }
            private void restart()
            {

                turn = "X";

                box1 = "";
                box2 = "";
                box3 = "";
                box4 = "";
                box5 = "";
                box6 = "";
                box7 = "";
                box8 = "";
                box9 = "";

                canvas.Clear(Color.White);

                canvas.DrawLine(Pens.Black, 200, 0, 200, 600);
                canvas.DrawLine(Pens.Black, 400, 0, 400, 600);
                canvas.DrawLine(Pens.Black, 0, 200, 600, 200);
                canvas.DrawLine(Pens.Black, 0, 400, 600, 400);
            }

            private void Form1_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
            }
        
        
    }
}
