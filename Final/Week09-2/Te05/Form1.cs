namespace Te05;

public partial class Form1 : Form
{
    private Form? form2;
    private System.Drawing.Color[] colors = {Color.Brown, Color.Green, Color.Red, Color.Yellow, Color.BurlyWood, Color.Coral}; 
    private Random random = new Random();
    public Form1()
    {
        InitializeComponent();
    }
    private void ShowHide_Click(System.Object? sender, System.EventArgs e)
    {
        if(form2 == null){
            MessageBox.Show($"Please create the object first.", $"Error");
        }else{
            if(form2.Visible){
                form2.Hide();
            }else{
                form2.Show();
            }
        }
    }
    private void FormCreate_Click(System.Object? sender, System.EventArgs e)
    {
        if(form2 == null){
            form2 = new Form2();
            form2.Show();
        }else{
            MessageBox.Show($"Object has already been created.", $"Error");
        }
    }
    private void FormBackgroundColor_Click(System.Object? sender, System.EventArgs e)
    {
        this.BackColor = colors[random.Next(0, colors.Length)];
    }
}
