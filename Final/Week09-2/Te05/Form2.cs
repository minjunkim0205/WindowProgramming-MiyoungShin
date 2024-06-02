namespace Te05;

public partial class Form2 : Form
{
    public Form2()
    {
        InitializeComponent();
    }
    private void Form2_Closing(System.Object? sender, System.ComponentModel.CancelEventArgs e)
    {
        e.Cancel = true;
        this.Hide();
    }
}
