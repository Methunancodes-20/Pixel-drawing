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

namespace PixelAssignment
{ // https://stackoverflow.com/questions/6036881/c-sharp-drawing-by-mouse
    public partial class Form1 : Form
    {
        public Form1()
        {
             InitializeComponent();
        }
  
        private void picBox1_MouseMove(object sender, MouseEventArgs e)
        {
                int radius = 500;

                Bitmap bmp = new Bitmap(picBox1.Width, picBox1.Height);

                for (int y = e.Y - radius; y < e.Y + radius; y++)
                {
                    for (int x = e.X - radius; x < e.X + radius; x++)
                    {
                        if (((x - e.X) * (x - e.X)) + ((y - e.Y) * (y - e.Y)) < radius)
                        {
                            bmp.SetPixel(x, y, Color.Yellow);
                        }
                    }
                }

                picBox1.Image = bmp;
                picBox1.BackColor = Color.Black;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }







        private void picBox1_MouseDown(object sender, MouseEventArgs e)
        {
        }
        private void picBox1_MouseUp(object sender, MouseEventArgs e)
        {   
        }
        private void picBox1_Click(object sender, EventArgs e)
        {
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void picBox1_Paint(object sender, PaintEventArgs e)
        {
        }

    }
}

