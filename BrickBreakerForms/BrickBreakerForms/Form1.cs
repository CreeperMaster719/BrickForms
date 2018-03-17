using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrickBreakerForms
{
    public partial class Form1 : Form
    {
        bouncyball brickBall;
        bouncePaddles trampoline;

        List<heavyBricks> bricks = new List<heavyBricks>();
        
        Graphics gfx;
        int x = 300;
        int y = 400;
        int cw;
        int ch;
        int score;
        int lives = 5;
        public Form1()
        {
            InitializeComponent();
             cw = ClientSize.Width;
             ch = ClientSize.Height;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            brickBall = new bouncyball(Brushes.White, x, y, 20, 20, 5, 5);
            trampoline = new bouncePaddles(Brushes.White, 445, 625, 200, 14, 2);

            int numberColumns = 10;
            int widthGap = 5;
            int brickWidth = ClientSize.Width / numberColumns;
            int numberRows = 4;
            int heightGap = 3;
            int brickHeight = 50;


            for (int i = 0; i < numberRows; i++)
            {
                for (int j = 0; j < numberColumns; j++)
                {
                    bricks.Add(new heavyBricks(Brushes.Black, j * brickWidth + widthGap, i * brickHeight + heightGap, brickWidth - (widthGap * 2), brickHeight - (heightGap * 2)));
                }
            }

            gfx = CreateGraphics();
        }

        private void GameRun_Tick(object sender, EventArgs e)
        {
            gfx.Clear(BackColor);
            brickBall.Move(cw, ch);
            brickBall.Draw(gfx);
            trampoline.Draw(gfx);

            foreach(heavyBricks brick in bricks)
            {
                brick.Draw(gfx);
            }
            
            
            if (brickBall.HitBox.IntersectsWith(trampoline.HitBox))
            {
                brickBall.ySpeed *= -1;
            }
            if(trampoline.movingLeft)
            {
                trampoline.CheckSides(cw);
                trampoline.X -= 5;
            }
            if(trampoline.movingRight)
            {
                trampoline.CheckSides(cw);
                trampoline.X += 5;
            }
            if(brickBall.y > 650)
            {
                brickBall.Reset(x, y);
                lives--;
            }
            
            LivesLabel.Text = $"{lives}";
            if (lives == 0)
            {
                GameRun.Enabled = false;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                trampoline.movingLeft = true;
            }
            if(e.KeyCode == Keys.Right)
            {
                trampoline.movingRight = true;
            }
         
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                trampoline.movingLeft = false;
            }
            if(e.KeyCode == Keys.Right)
            {
                trampoline.movingRight = false;
            }
        }

        private void unusedLabel_Click(object sender, EventArgs e)
        {

        }

        private void LivesLabel_Click(object sender, EventArgs e)
        {

        }

        private void scoreLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
