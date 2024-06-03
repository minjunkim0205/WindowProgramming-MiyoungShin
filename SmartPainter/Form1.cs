using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartPainter
{
    public partial class Form1 : Form
    {
        /*Field*/
        private Bitmap bitmap;
        private Graphics graphics;
        private int pen_type = 0;
        private bool paint = false;
        private Point point_x, point_y;
        private Pen pen = new Pen(Color.Black, 2);
        private Pen erase = new Pen(Color.White, 2);
        private int x, y, s_x, s_y, c_x, c_y;
        /*Start*/
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBoxPaint.Width, pictureBoxPaint.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            pictureBoxPaint.Image = bitmap;
        }
        /*Method*/
        private void changePenSize(double size)
        {
            pen.Width = (float)size;
            erase.Width = (float)size;
            textBoxSize.Text = $"{size}";
        }
        /*Event*/
        private void pictureBoxPaint_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            point_y = e.Location;

            c_x = e.X;
            c_y = e.Y;
        }

        private void pictureBoxPaint_MouseMove(object sender, MouseEventArgs e)
        {
            if(paint)
            {
                if(pen_type == 1)
                {
                    point_x = e.Location;
                    graphics.DrawLine(pen, point_x, point_y);
                    point_y = point_x;
                }
                else if(pen_type == 2)
                {
                    point_x = e.Location;
                    graphics.DrawLine(erase, point_x, point_y);
                    point_y = point_x;
                }
            }
            pictureBoxPaint.Refresh();
            x = e.X;
            y = e.Y;
            s_x = e.X - c_x;
            s_y = e.Y - c_y;
        }
        private void pictureBoxPaint_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            s_x = x - c_x; 
            s_y = y - c_y;

            if(pen_type == 3)
            {
                graphics.DrawEllipse(pen, c_x, c_y, s_x, s_y);
            }
            else if(pen_type == 4)
            {
                graphics.DrawRectangle(pen, c_x, c_y, s_x, s_y);
            }
            else if (pen_type == 5)
            {
                graphics.DrawLine(pen, c_x, c_y, x, y);
            }
        }

        private void buttonSize_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(button.Name == $"buttonSizeS")
            {
                changePenSize(1.0);
            }
            else if(button.Name == $"buttonSizeM")
            {
                changePenSize(2.0);
            }
            else if (button.Name == $"buttonSizeL")
            {
                changePenSize(3.0);
            }
        }

        private void textBoxSize_TextChanged(object sender, EventArgs e)
        {
            if(double.TryParse(textBoxSize.Text, out double value))
            {
                changePenSize(value);
            }
            else
            {
                MessageBox.Show($"Size can be only number.");
                textBoxSize.Text = $"{pen.Width}";
            }
        }

        private void buttonToolPencil_Click(object sender, EventArgs e)
        {
            pen_type = 1;
        }

        private void buttonToolEraser_Click(object sender, EventArgs e)
        {
            pen_type = 2;
        }

        private void buttonToolLine_Click(object sender, EventArgs e)
        {
            pen_type = 5;
        }

        private void buttonToolPail_Click(object sender, EventArgs e)
        {

        }

        private void buttonShapeCircle_Click(object sender, EventArgs e)
        {
            pen_type = 3;
        }

        private void buttonShapeSquare_Click(object sender, EventArgs e)
        {
            pen_type = 4;
        }
    }
}
