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

namespace Te05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (treeViewShow.SelectedNode == null)
            {
                MessageBox.Show("Please select a node to add the subject to.");
            }
            else if (textBoxInput.Text == $"")
            {
                MessageBox.Show("Please enter a subject.");
            }
            else
            {
                treeViewShow.SelectedNode.Nodes.Add(textBoxInput.Text);
                treeViewShow.SelectedNode.Expand();
                textBoxInput.Clear();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (treeViewShow.SelectedNode == null)
            {
                MessageBox.Show("Please select a node to delete.");
            }
            else
            {
                treeViewShow.SelectedNode.Remove();
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (treeViewShow.SelectedNode == null)
            {
                MessageBox.Show("Please select a node to print its relatives.");
            }
            else
            {
                listBoxShow.Items.Clear();
                TreeNode target = treeViewShow.SelectedNode;
                if(target.Parent != null)
                {
                    listBoxShow.Items.Add($"{target.Parent.Text}");
                }
                listBoxShow.Items.Add($"{treeViewShow.SelectedNode.Text}");
                if (target.Nodes.Count > 0)
                {
                    foreach (TreeNode element in target.Nodes)
                    {
                        listBoxShow.Items.Add($"{element.Text}");
                    }
                }
            }
        }
    }
}
