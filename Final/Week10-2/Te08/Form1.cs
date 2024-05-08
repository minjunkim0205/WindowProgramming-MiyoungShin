namespace Te08;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    private void Form1_Resize(System.Object? sender, System.EventArgs e)
    {
        this.Width = this.Width<300?300:(this.Width>500?500:this.Width);
        this.Height = this.Height<300?300:(this.Height>700?700:this.Height);
    }
}
