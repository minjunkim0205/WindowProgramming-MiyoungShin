using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Te01
{
    public partial class Form1 : Form
    {
        private int tick = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            tick = 0;
            labelCount.Text = $"{tick}";
            progressBarShow.Value = tick;
            timerMain.Enabled = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timerMain.Enabled = false;
            labelColor.BackColor = Color.Gray;
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            Color color = Color.FromArgb(random.Next(0, 255 + 1), random.Next(0, 255 + 1), random.Next(0, 255 + 1));
            tick += 1;
            progressBarShow.Value = tick>progressBarShow.Maximum? progressBarShow.Maximum : tick;
            labelColor.BackColor = color;
            labelCount.Text = $"{tick}";
        }
    }
}