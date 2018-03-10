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
    class bouncePaddles
    {
        public int X;
        public int Y;
        public int W;
        public int H;
        public int Speed;
        Brush color;
        public bool movingLeft = false;
        public bool movingRight = false;        

        public Rectangle HitBox
        {
            get
            {
                return new Rectangle(X, Y, W, H);
            }
        }
       public int paddleSpeed = 10;

        public bouncePaddles(Brush color, int X, int Y, int W, int H, int Speed)
        {
            this.X = X;
            this.Y = Y;
            this.W = W;
            this.H = H;
            this.Speed = Speed;
            this.color = color;
        }

        public void Draw(Graphics gfx)
        {
            gfx.FillRectangle(color, HitBox);
        }
        public void CheckSides(int ClinetWidth)
        {
            if( X + W <= ClinetWidth)
            {
                Speed *= -1;
            }
            if(X >= 0)
            {
                Speed *= -1;
            }
        }

    }
}
