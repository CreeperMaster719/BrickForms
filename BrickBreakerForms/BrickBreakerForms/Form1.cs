using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrickBreakerForms
{
    public partial class Form1 : Form
    {
        bouncyball brickBall;
        bouncePaddles trampoline;
        Random brickMaker;
        
        List<heavyBricks> bricks = new List<heavyBricks>();
        Bitmap canvas;
        Graphics gfx;
        SoundPlayer meme;
        int x = 300;
        int y = 400;
        int cw;
        int ch;
        int score;
        int lives = 5;
        int tw = 200;
        int tx = 445;
        int trampolineSupersize;
        bool spacialSpace;
        bool spaceDown;
        public Form1()
        {
            InitializeComponent();
             cw = ClientSize.Width;
             ch = ClientSize.Height;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            meme = new SoundPlayer();
            canvas = new Bitmap(mainPictureBox.Width, mainPictureBox.Height);
            spacialSpace = true;
            brickBall = new bouncyball(Brushes.White, x, y, 20, 20, 5, 5, spacialSpace);
            trampoline = new bouncePaddles(Brushes.White, tx, 625, tw, 14, 2);
            brickMaker = new Random();

            int numberColumns = brickMaker.Next(10, 25);
            int widthGap = 5;
            int brickWidth = ClientSize.Width / numberColumns;
            int numberRows = brickMaker.Next(25, 25);
            int heightGap = 3;
            int brickHeight = 30;
            int brickHealth = numberRows / 2;
            int hCounter = 0;

            for (int i = 0; i < numberRows; i++)
            {
                for (int j = 0; j < numberColumns; j++)
                {
                    bricks.Add(new heavyBricks( j * brickWidth + widthGap, i * brickHeight + heightGap, brickWidth - (widthGap * 2), brickHeight - (heightGap * 2), brickHealth));
                }
                hCounter++;
                if(hCounter == 2)
                {
                    if(brickHealth > 1)
                    {
                        brickHealth--;
                    }
                    
                    hCounter = 0;
                }
            }

            gfx = Graphics.FromImage(canvas);
        }

        private void GameRun_Tick(object sender, EventArgs e)
        {
            gfx.Clear(BackColor);
            brickBall.Move(cw, ch, spacialSpace);
            brickBall.Draw(gfx);
            trampoline.Draw(gfx);

            foreach(heavyBricks brick in bricks)
            {
                brick.Update();
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
                lives--;
                spacialSpace = false;

            }
            if (!spacialSpace)
            {
                brickBall.Reset(trampoline.X, trampoline.W, trampoline.Y);
                
            }

            LivesLabel.Text = $"{lives}";
            if (lives == 0)
            {
                GameRun.Enabled = false;
            }
            if(spaceDown)
            {
                spacialSpace = spaceDown;
            }
            mainPictureBox.Image = canvas;
            for(int i = 0; i < bricks.Count; i++)
            {
                if (brickBall.HitBox.IntersectsWith(bricks[i].Hitbox))
                {
                    score += 1000;
                    meme.Play();
                    
                    brickBall.ySpeed *= -1;
                    if(bricks[i].health > 1)
                    {
                        bricks[i].health -= 1;
                    }
                    else
                    {
                        bricks.Remove(bricks[i]);
                    }
                }
            }
            trampolineSupersize = score / 1000;
            trampoline.W = trampolineSupersize + tw;
            scoreLabel.Text = $"{score}";
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
            if (e.KeyCode == Keys.Space)
            {
                spaceDown = true;
            }
            else
            {
                spaceDown = false;
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

        private void mainPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
