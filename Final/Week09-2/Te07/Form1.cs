namespace Te07;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    private void FixedSingle_Click(System.Object? sender, System.EventArgs e)
    {
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.Text = "FixedSingle";
    }
    private void None_Click(System.Object? sender, System.EventArgs e)
    {
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        this.Text = "None";
    }
    private void FixedDialog_Click(System.Object? sender, System.EventArgs e)
    {
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.Text = "FixedDialog";
    }
    private void FixedToolWindow_Click(System.Object? sender, System.EventArgs e)
    {
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
        this.Text = "FixedToolWindow";
    }
}
