namespace Te08;

public partial class Form1 : Form
{
    private DateTime today;
    public Form1()
    {
        InitializeComponent();
    }
    private void Form1_Load(System.Object? sender, System.EventArgs e)
    {
        today = DateTime.Today;
        day.Text = today.ToString("D");
    }
    private void DaysAgo_Click(System.Object? sender, System.EventArgs e)
    {
        MessageBox.Show($"{today.AddDays(-10).ToString("D")}", "10 Days ago");
    }
    private void DaysLater_Click(System.Object? sender, System.EventArgs e)
    {
        MessageBox.Show($"{today.AddDays(10).ToString("D")}", "10 Days laster");
    }
}
