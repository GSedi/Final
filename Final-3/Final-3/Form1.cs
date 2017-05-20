using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_3
{
    public partial class Form1 : Form
    {

        static int cnt = 0;
        public Form1()
        {
            InitializeComponent();
            button1.BackColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnt++;
            if(cnt == 1)
            {
                button1.BackColor = Color.Yellow;
            }
            if(cnt == 2)
            {
                button1.BackColor = Color.Blue;
            }
            if(cnt == 3)
            {
                button1.BackColor = Color.Red;
                cnt = 0;
            }
            
            
        }
    }
}
