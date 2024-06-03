using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Te02
{
    public partial class Form2 : Form
    {
        private bool checkTextBoxFilled()
        {
            TextBox[] textBoxes = {
                textBoxName,
                textBoxNumber,
                textBoxId,
                textBoxPw
            };
            foreach(TextBox element in textBoxes)
            {
                if(element.Text == $"")
                {
                    return false;
                }
            }
            return true;
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(checkTextBoxFilled())
            {
                Form1 form1 = (Form1)this.Owner;
                string value = $"";
                value += $"name:{textBoxName.Text}, ";
                value += $"number:{textBoxNumber.Text}, ";
                value += $"id:{textBoxId.Text}, ";
                value += $"pw:{textBoxPw.Text}, ";
                form1.listBoxAddValue(value);
                this.Close();
            }
            else
            {
                MessageBox.Show($"Fill text box first.");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxAll_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = $"";
        }
    }
}
