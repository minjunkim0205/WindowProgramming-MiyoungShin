namespace Te06;

public partial class Form1 : Form
{
    private DateTime? form_load_date_time;
    private DateTime? form_close_date_time;
    public Form1()
    {
        InitializeComponent();
    }
    private void Form1_Load(System.Object? sender, System.EventArgs e)
    {
        this.form_load_date_time = DateTime.Now;
        ActivationTimer.Start();
    }
    private void Form1_Shown(System.Object? sender, System.EventArgs e)
    {
        MessageBox.Show($"{this.form_load_date_time}", $"Form load time");
    }
    private void Form1_FormClosed(System.Object? sender, System.Windows.Forms.FormClosedEventArgs e)
    {
        this.form_close_date_time = DateTime.Now;
        ActivationTimer.Stop();
        MessageBox.Show($"{this.form_close_date_time}", $"Form close time");
    }
    private void ActivationTimer_Tick(System.Object? sender, System.EventArgs e)
    {
        ActivationTimeLabel.Text = $"{DateTime.Now - this.form_load_date_time}";
    }
}
