using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Te04
{
    public partial class Form1 : Form
    {
        private bool checkValueFilled()
        {
            TextBox[] values = {
                textBoxType,
                textBoxAmount,
                textBoxCost
            };
            foreach (TextBox element in values)
            {
                if (element.Text == $"")
                {
                    return false;
                }
            }
            return true;
        }
        private void valueReset()
        {
            TextBox[] values = {
                textBoxType,
                textBoxAmount,
                textBoxCost
            };
            foreach (TextBox element in values)
            {
                element.Text = $"";
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (checkValueFilled())
            {
                ListViewItem add = new ListViewItem($"{textBoxType.Text}");
                add.SubItems.Add($"{textBoxAmount.Text}");
                add.SubItems.Add($"{textBoxCost.Text}");
                add.SubItems.Add($"{(int.Parse(textBoxAmount.Text) * int.Parse(textBoxCost.Text))}");
                listViewShow.Items.Add(add);
                valueReset();
            }
            else
            {
                MessageBox.Show($"Fill value first");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem element in listViewShow.SelectedItems)
            {
                listViewShow.Items.Remove(element);
            }
            listViewShow.SelectedItems.Clear();
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            textBoxAmount.Text = $"{numericUpDown.Value}";
        }

        private void domainUpDown_TextChanged(object sender, EventArgs e)
        {
            textBoxType.Text = domainUpDown.Text;
        }
    }
}
