namespace Re02;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    private void ButtonConfirm_Click(System.Object? sender, System.EventArgs e)
    {
        MessageBox.Show($"Confirm!");
        TextBoxResult.Text = $"ID : {TextBoxId.Text}\t\nPW : {TextBoxPassword.Text}";
    }
}
