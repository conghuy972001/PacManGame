using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacManGame
{
    public partial class Form1 : Form
    {


        bool goup, godown, goleft, goright, isGameOver;
        int score, playerSpeed, redGhostSpeed, blueGhostSpeed, yellowGhostX, yellowGhostY;

        private void labelScore_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();

            resetGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                goup = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
        }


        private void mainGameTime(object sender, EventArgs e)
        {
            labelScore.Text = "Diem " + score;

            if (goleft == true)
            {
                pacman.Left -= playerSpeed;
                pacman.Image = Properties.Resources.ghost_red1;
            }
            if (goright == true)
            {
                pacman.Left += playerSpeed;
                pacman.Image = Properties.Resources.ghost_blue;
            }
            if (godown == true)
            {
                pacman.Top += playerSpeed;
                pacman.Image = Properties.Resources.ghost_green;
            }
            if (goup == true)
            {
                pacman.Top -= playerSpeed;
                pacman.Image = Properties.Resources.ghost_yellow;
            }


            if (pacman.Left < -10)
            {
                pacman.Left = 910;
            }
            if (pacman.Left > 910 )
            {
                pacman.Left = -10;
            }


        }

        private void resetGame()
        {
            labelScore.Text = "Diem: 0";
            score = 0;

            playerSpeed = 8;

            redGhostSpeed = 5;
            blueGhostSpeed = 5;
            yellowGhostX = 5;
            yellowGhostY = 5;

            isGameOver = false;

            pacman.Left = 12;
            pacman.Top = 200;

            redGhost.Left = 418;
            redGhost.Top = 250;

            TimeGame.Start();

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox)
                {
                    //x.Visible = false;
                }
            }

        }

        private void gameOver(string message)
        {

        }
    }
}
