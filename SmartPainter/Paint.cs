﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace SmartPainter
{
    internal class Paint
    {
        /**Enum*/
        enum ToolType : int
        {
            Pencil, 
            Eraser, 
            Line, Pail, 
            Square, 
            Circle, 
            Pipette
        };
        /**Field*/
        private const int WIDTH = 429;
        private const int HEIGHT = 240;
        private Color backgroundColor;
        private Color toolColor;
        private ToolType toolType;
        private float toolSize;
        private Panel panel;
        private PictureBox pictureBox;
        private Bitmap bitmap;
        private Graphics graphics;
        private Pen pen;
        private Pen eraser;
        private Brush brush;
        private bool penDown;
        private Point pointPrev, pointCur;
        private Point pointStart, pointEnd;
        /**Construct*/
        public Paint(Panel panel, PictureBox pictureBox)
        {
            this.panel = panel;
            this.pictureBox = pictureBox;
            this.backgroundColor = Color.White;
            this.toolColor = Color.Black;
            this.toolType = ToolType.Pencil;
            this.toolSize = 2;
            this.pen = new Pen(this.toolColor, this.toolSize);
            this.brush = new SolidBrush(this.toolColor);
            this.penDown = false;
            this.reset(WIDTH, HEIGHT, this.backgroundColor);
        }
        /**Method*/
        public void reset(in int _width, in int _height, in Color _backgroundColor)
        {
            this.bitmap = new Bitmap(_width, _height);
            this.graphics = Graphics.FromImage(this.bitmap);
            this.graphics.Clear(_backgroundColor);
            this.panel.Size = new Size(_width, _height);
            this.pictureBox.Size = new Size(_width, _height);
            this.pictureBox.Image = this.bitmap;
            this.eraser = new Pen(this.backgroundColor, this.toolSize);
            this.pictureBox.Refresh();
            return;
        }
        public void reset()
        {
            this.graphics.Clear(this.backgroundColor);
            this.pictureBox.Refresh();
            return;
        }
        // Tool
        public void setTool(in int _tool)
        {
            this.toolType = (ToolType)_tool;
            return;
        }
        public void setToolSize(in float _toolSize)
        {
            this.toolSize = _toolSize;
            this.pen.Width = this.toolSize;
            this.eraser.Width = this.toolSize;
            return;
        }
        public float getToolSize()
        {
            return this.toolSize;
        }
        public void setToolColor(in Color _color)
        {
            this.toolColor = _color;
            this.pen.Color = this.toolColor;
            return;
        }
        public void setPenDown(in MouseEventArgs _event)
        {
            this.pointPrev = _event.Location;
            this.pointStart = _event.Location;
            this.penDown = true;
            return;
        }
        public void setPenUp(in MouseEventArgs _event)
        {
            this.pointEnd = _event.Location;
            this.penDown = false;
            if (this.toolType == ToolType.Line)
            {
                graphics.DrawLine(pen, this.pointStart.X, this.pointStart.Y, this.pointEnd.X, this.pointEnd.Y);
            }
            else if (this.toolType == ToolType.Square)
            {
                graphics.DrawRectangle(pen, new Rectangle(this.pointStart.X, this.pointStart.Y, this.pointEnd.X - this.pointStart.X, this.pointEnd.Y - this.pointStart.Y));
            }
            else if (this.toolType == ToolType.Circle)
            {
                graphics.DrawEllipse(pen, new Rectangle(this.pointStart.X, this.pointStart.Y, this.pointEnd.X - this.pointStart.X, this.pointEnd.Y - this.pointStart.Y));
            }
            return;
        }
        public void setPenMove(in MouseEventArgs _event)
        {
            this.pointCur = _event.Location;
            Console.WriteLine("d");
            if(this.penDown)
            {
                if(this.toolType == ToolType.Pencil)
                {
                    graphics.DrawLine(this.pen, this.pointPrev, this.pointCur);
                    pointPrev = pointCur;
                    /* [This is new version of ToolType.Pencile but, it dosent work zzz]
                     * 타원 그리기로 기존 방식의 티어링 문제를 해결하려 했으나 귀찮으니... 나중에
                     * int r = (int)(this.toolSize / 2);
                     * Rectangle rect = new Rectangle(this.pointCur.X - r, this.pointCur.Y - r, r*2, r*2);
                     * graphics.DrawEllipse(this.pen, rect);
                    */
                }
                else if(this.toolType == ToolType.Eraser)
                {
                    graphics.DrawLine(this.eraser, this.pointPrev, this.pointCur);
                    this.pointPrev = this.pointCur;
                }
            }
            this.pictureBox.Refresh();
            return;
        }
        public void setPenMove(in PaintEventArgs _event)
        {
            Graphics graphicsPreview = _event.Graphics;
            if (this.penDown)
            {
                if (this.toolType == ToolType.Line)
                {
                    graphicsPreview.DrawLine(pen, this.pointStart.X, this.pointStart.Y, this.pointCur.X, this.pointCur.Y);
                }
                else if (this.toolType == ToolType.Square)
                {
                    graphicsPreview.DrawRectangle(pen, new Rectangle(this.pointStart.X, this.pointStart.Y, this.pointCur.X - this.pointStart.X, this.pointCur.Y - this.pointStart.Y));
                }
                else if (this.toolType == ToolType.Circle)
                {
                    graphicsPreview.DrawEllipse(pen, new Rectangle(this.pointStart.X, this.pointStart.Y, this.pointCur.X - this.pointStart.X, this.pointCur.Y - this.pointStart.Y));
                }
            }
            return;
        }
        public void load()
        {
            // TODO 여기 고쳐야 함.
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.bitmap = new Bitmap(openFileDialog.FileName);
                this.pictureBox.Image = Bitmap.FromFile(openFileDialog.FileName);
            }
        }
        public void save()
        {
            // TODO 여기 고쳐야 함.
            this.saveAs();
            return;
        }
        public void saveAs()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Image(*.jpg)|*.jpg|(*.*|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap b = bitmap.Clone(new Rectangle(0, 0, pictureBox.Width, pictureBox.Height), bitmap.PixelFormat);
                b.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                MessageBox.Show("Image saved!");
            }
            return;
        }
        public void print()
        {
            // TODO 여기 고쳐야 함.
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Print succese!");
            }
            return;
        }
    }
}
