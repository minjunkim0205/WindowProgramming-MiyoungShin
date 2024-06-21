using SmartPainter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartPainter
{
    public partial class Form1 : Form
    {
        /**Field*/
        private Paint paint;
        private int width;
        private int height;
        private Color color;
        /**Init*/
        public Form1()
        {
            InitializeComponent();
        }
        /**Event*/
        private void Form1_Load(object sender, EventArgs e)
        {
            this.paint = new Paint(this.panelPaint, this.pictureBoxPaint, this.panelColor);
        }

        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"비트맵이 수정 되었다면 경고후 종료와 취소 알림창을 만들어야 함.");
            this.Close();
        }

        private void buttonTool_Click(object sender, EventArgs e)
        {
            this.paint.setTool(int.Parse((sender as Button).Tag.ToString()));
        }

        private void buttonSize_Click(object sender, EventArgs e)
        {
            string tag = (sender as Button).Tag.ToString();
            if (tag == "s")
            {
                this.paint.setToolSize(1.0f);
            }
            else if (tag == "m")
            {
                this.paint.setToolSize(5.0f);
            }
            else if (tag == "l")
            {
                this.paint.setToolSize(10.0f);
            }
            else if (tag == "+")
            {
                this.paint.setToolSize(this.paint.getToolSize() + 1);
            }
            else if (tag == "-")
            {
                this.paint.setToolSize(this.paint.getToolSize() - 1);
            }
            textBoxSize.Text = this.paint.getToolSize().ToString();
        }

        private void textBoxSize_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(textBoxSize.Text, out float size))
            {
                this.paint.setToolSize(size);
            }
            else
            {
                MessageBox.Show($"Size can be only number.");
                textBoxSize.Text = $"{this.paint.getToolSize()}";
            }
        }

        private void pictureBoxPaint_MouseDown(object sender, MouseEventArgs e)
        {
            this.paint.setPenDown(e);
        }

        private void pictureBoxPaint_MouseUp(object sender, MouseEventArgs e)
        {
            this.paint.setPenUp(e);
        }

        private void pictureBoxPaint_MouseMove(object sender, MouseEventArgs e)
        {
            this.paint.setPenMove(e);
            this.toolStripStatusLabelMousePos.Text = $"{e.Location.X}, {e.Location.Y}";
        }

        private void pictureBoxPaint_Paint(object sender, PaintEventArgs e)
        {
            this.paint.setPenMove(e);
        }

        private void buttonColorPicker_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            this.paint.setToolColor(colorDialog.Color);
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            this.paint.setToolColor(button.BackColor);
        }

        public int resetWidth
        {
            get { return width; }
            set { width = value; }
        }
        public int resetHeight
        {
            get { return height; }
            set { height = value; }
        }
        public Color resetColor
        {
            get { return color; }
            set { color = value; }
        }
        private void buttonSetting_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.AddOwnedForm(form2);
            form2.ShowDialog();
            this.paint.reset(width, height, color);
        }

        private void toolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tag = (sender as ToolStripMenuItem).Tag.ToString();
            if (tag == "new")
            {
                this.paint.reset();
            }
            else if (tag == "load")
            {
                //this.paint.load();
            }
            else if (tag == "save")
            {
                this.paint.save();
            }
            else if (tag == "save_as")
            {
                this.paint.saveAs();
            }
        }

        private void toolStripMenuItemPrint_Click(object sender, EventArgs e)
        {
            //String pageSettingArgs;
            PageSettings pageSettings = new PageSettings();
            pageSetupDialog.PageSettings = pageSettings;
            printDialog.PrinterSettings = new PrinterSettings();
            printDialog.Document = printDocument;

            DialogResult result = pageSetupDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pageSettings = pageSetupDialog.PageSettings;
                //pageSettingArgs = $"\nMargins: {pageSettings.Margins}\nPaperSize: {pageSettings.PaperSize}";
                result = printDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }
            //this.paint.print();
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap target = this.paint.getBitmap();
            if (target != null)
            {
                int x = e.MarginBounds.X;
                int y = e.MarginBounds.Y;
                int width = target.Width;
                int height = target.Height;
                if ((width / (double)height) > (e.MarginBounds.Width / (double)e.MarginBounds.Height))
                {
                    width = e.MarginBounds.Width;
                    height = (target.Height * e.MarginBounds.Width) / target.Width;
                }
                else
                {
                    height = e.MarginBounds.Height;
                    width = (target.Width * e.MarginBounds.Height) / target.Height;
                }
                e.Graphics.DrawImage(target, x, y, width, height);
            }
        }
    }
}
