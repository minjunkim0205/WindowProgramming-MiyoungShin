using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Te03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.Label[] LabelColor = { labelRedValue, labelGreenValue, labelBlueValue };
            System.Windows.Forms.TrackBar[] TrackBarColor = { trackBarRed, trackBarGreen, trackBarBlue };
            for (int i = 0; i < 3; i++)
            {
                LabelColor[i].Text = $"{TrackBarColor[i].Value}";
            }
            labelShowColor.BackColor = Color.FromArgb(TrackBarColor[0].Value, TrackBarColor[1].Value, TrackBarColor[2].Value);
        }
    }
}
