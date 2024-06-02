namespace Te07;

using System.Diagnostics;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    private void ButtonConfirm_Click(System.Object? sender, System.EventArgs e)
    {
        LinkLabelUrl.Text = $"{TextBoxUrl.Text}";
        Process.Start(LinkLabelUrl.Text);
    }
    private void LinkLabelUrl_Click(System.Object? sender, System.EventArgs e)
    {
        LinkLabel hyper = (LinkLabel)sender;
        Process.Start(hyper.Text);
    }
}
