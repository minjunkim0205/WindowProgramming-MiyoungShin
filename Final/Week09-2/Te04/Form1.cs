namespace Te04;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    private void Form1_Load(System.Object? sender, System.EventArgs e)
    {
        MessageBox.Show($"This form is loaded", $"Load event");
    }
    private void Form1_FormClosing(System.Object? sender, System.Windows.Forms.FormClosingEventArgs e)
    {
        DialogResult result = MessageBox.Show($"Do you want to close?", $"FormClosing event", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.No)
        {
            e.Cancel = true;
        }
    }
}
