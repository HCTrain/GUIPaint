using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Paint : Form
    {
        int brushSize = 10;
        int red = 250;
        int green = 0;
        int blue = 0;
        bool redcycle = true;
        
        public Paint()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Paint_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left )
            {
                if (redcycle == true)
                {
                    red = red + 5;
                    if (red > 255)
                    {
                        red = 0;
                    }

                    System.Drawing.SolidBrush brush = new System.Drawing.SolidBrush(Color.FromArgb(255, red, 0, 0));
                    this.CreateGraphics().FillEllipse(brush, e.X, e.Y, brushSize, brushSize);
                } 
                else
                {
                    System.Drawing.SolidBrush brush = new System.Drawing.SolidBrush(Color.FromArgb(255, red, 0, 0));
                    this.CreateGraphics().FillEllipse(brush, e.X, e.Y, brushSize, brushSize);
              }
            }
        }

        private void btnSizeSmall_Click(object sender, EventArgs e)
        {
            brushSize = 10;
        }

        private void btnSizeBig_Click(object sender, EventArgs e)
        {
            brushSize = 30;
        }

        private void btnChangeColour_Click(object sender, EventArgs e)
        {
            
                Random r = new Random(256);
                red = r.Next(0, 256);
                blue = r.Next(0, 256);
                green = r.Next(0, 256);  
        }

        private void trckbarChangeSize_Scroll(object sender, EventArgs e)
        {
            brushSize = trckbarChangeSize.Value;
        }
    }
}
