using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_4
{
    public partial class Form1 : Form
    {

        Graphics g;
        GraphicsPath path;
        SolidBrush br;
        int y;
        int x;
        bool ok = false;
        List<Point> list;
        Ell l;
        List<Ell> ell;
        
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            br = new SolidBrush(Color.Red);
            timer1.Enabled = true;
            timer1.Interval = 100;
            path = new GraphicsPath();
            list = new List<Point>();
            ell = new List<Ell>();
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (ok)
            {
               
                foreach(Ell l in ell)
                {
                    l.Draw();
                }
                
                i++;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ok = true;
            
            
            l = new Ell(g, br, e.Location.X, e.Location.Y);
           ell.Add(l);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
                if (ell.Count != null)
                    {
                        foreach (Ell l in ell)

                         {
                            l.Move(l);
                    
                         }
                }
            
            Refresh();
        }
    }
}
