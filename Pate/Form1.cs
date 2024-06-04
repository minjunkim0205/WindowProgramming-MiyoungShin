using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pate
{
    public partial class Form1 : Form
    {
        /**Field*/
        private Paint paint;
        /**Init*/
        public Form1()
        {
            InitializeComponent();
        }
        /**Event*/
        private void Form1_Load(object sender, EventArgs e)
        {
            this.paint = new Paint(this.panelPaint, this.pictureBoxPaint);
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
                this.paint.setToolSize(2.5f);
            }
            else if (tag == "l")
            {
                this.paint.setToolSize(4.0f);
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
        }

        private void pictureBoxPaint_Paint(object sender, PaintEventArgs e)
        {
            this.paint.setPenMove(e);
        }

        private void buttonColorPicker_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            this.panelColor.BackColor = colorDialog.Color;
            this.paint.setToolColor(colorDialog.Color);
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            this.panelColor.BackColor = button.BackColor;
            this.paint.setToolColor(button.BackColor);
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
                this.paint.load();
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
            this.paint.print();
        }
    }
}
