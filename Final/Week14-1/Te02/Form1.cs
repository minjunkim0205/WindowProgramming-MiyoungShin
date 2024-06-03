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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.AddOwnedForm(form2);
            form2.ShowDialog();
        }

        public void listBoxAddValue(string value)
        {
            listBoxShow.Items.Add(value);
        }

        private void deleteAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBoxShow.Items.Clear();
            listBoxShow.SelectedItem = null;
        }

        private void deleteSelectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBoxShow.SelectedItems == null)
            {
                MessageBox.Show($"Select items first.");
            }
            else
            {
                listBoxShow.Items.Remove(listBoxShow.SelectedItem);
            }
            listBoxShow.SelectedItem = null;
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((Keys)e == Keys.Escape)
            {
                Dispose();
                // TODO !!
            }
        }
    }
}
