namespace Te06;

public partial class Form1 : Form
{
    private int count = 0;
    public Form1()
    {
        InitializeComponent();
    }
    private void ButtonChangeColor_Click(System.Object? sender, System.EventArgs e)
    {
        Color[] colors = {Color.Yellow, Color.Red, Color.Green};
        PanelColor.BackColor = colors[count%colors.Length];
        count++;
    }
}
