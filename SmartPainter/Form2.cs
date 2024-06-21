using SmartPainter;
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
    public partial class Form2 : Form
    {
        /**Init*/
        public Form2()
        {
            InitializeComponent();
        }
        /**Event*/
        private void buttonColorBackground_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            this.buttonColorBackground.BackColor = colorDialog.Color;
        }

        private void textBoxWidth_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxWidth.Text, out int temp))
            {
                MessageBox.Show($"Size can be only number.");
                textBoxWidth.Text = $"{429}";
            }
        }

        private void textBoxHeight_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxHeight.Text, out int temp))
            {
                MessageBox.Show($"Size can be only number.");
                textBoxHeight.Text = $"{240}";
            }
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)this.Owner;
            form1.resetWidth = int.Parse(textBoxWidth.Text);
            form1.resetHeight = int.Parse(textBoxHeight.Text);
            form1.resetColor = this.buttonColorBackground.BackColor;
            this.Close();
        }
    }
}
