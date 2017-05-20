using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_4
{
    class Ell
    {

        public Graphics g;
        public int x;
        public int y;
        SolidBrush br;

        public Ell(Graphics g, SolidBrush br, int x, int y )
        {
            this.g = g;
            this.br = br;
            this.x = x;
            this.y = y;
        }


        public void Draw()
        {
            g.FillEllipse(br, x-20, y-20, 40, 40);
        }

        public void Move(Ell l)
        {
            if(l == this)
            {
                y+=10;
                
            }
        }

    }
}
