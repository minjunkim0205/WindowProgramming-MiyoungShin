namespace Te09;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    private void ButtonBringToFront_Click(System.Object? sender, System.EventArgs e)
    {
        ButtonB.BringToFront();
        this.Text = $"Bring To Front";
    }
    private void ButtonSendToBack_Click(System.Object? sender, System.EventArgs e)
    {
        ButtonB.SendToBack();
        this.Text = $"Send To Back";
    }
    private void ButtonDisable_Click(System.Object? sender, System.EventArgs e)
    {
        ButtonA.Enabled = false;
        this.Text = $"Disable";
    }
    private void ButtonEnable_Click(System.Object? sender, System.EventArgs e)
    {
        ButtonA.Enabled = true;
        this.Text = $"Enable";
    }
    private void ButtonShow_Click(System.Object? sender, System.EventArgs e)
    {
        ButtonC.Show();
        this.Text = $"Show";
    }
    private void ButtonHide_Click(System.Object? sender, System.EventArgs e)
    {
        ButtonC.Hide();
        this.Text = $"Hide";
    }
}
