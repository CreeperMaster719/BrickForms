using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace BrickBreakerForms
{
    class heavyBricks
    {
        public int x;
        public int y;
        public int w;
        public int h;
        public int health;
///~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Brush color;
///~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        public Rectangle Hitbox
        {
            get
            {
                return new Rectangle(x, y, w, h);
            }
        }
///~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        public heavyBricks(int x, int y, int w, int h, int health)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
            
            this.health = health;
        }

        public void Update()
        {
            if (health == 1)
            {
                color = Brushes.Red;
            }
            else if (health == 2)
            {
                color = Brushes.OrangeRed;
            }
            else if (health == 3)
            {
                color = Brushes.Orange;
            }
            else if (health == 4)
            {
                color = Brushes.Yellow;
            }
            else if (health == 5)
            {
                color = Brushes.YellowGreen;
            }
            else if (health == 6)
            {
                color = Brushes.Green;
            }
            else if (health == 7)
            {
                color = Brushes.Cyan;
            }
            else if (health == 8)
            {
                color = Brushes.Blue;
            }
            else if (health == 9)
            {
                color = Brushes.BlueViolet;
            }
            else if (health == 10)
            {
                color = Brushes.Purple;
            }
            else if (health == 11)
            {
                color = Brushes.Pink;
            }
            else if (health == 12)
            {
                color = Brushes.Gray;
            }
            else if (health == 13)
            {
                color = Brushes.White;
            }
            else if (health == 14)
            {
                color = Brushes.Beige;
            }
            else if (health == 15)
            {
                color = Brushes.PaleGoldenrod;
            }
            else if (health == 16)
            {
                color = Brushes.Gold;
            }
            else
            {
                color = Brushes.RosyBrown;
            }

        }

///~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
public void Draw(Graphics gfx)
        {
            gfx.FillRectangle(color, Hitbox);
        }
///~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    }
}
