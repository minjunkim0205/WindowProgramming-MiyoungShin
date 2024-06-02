namespace Te05;

public partial class Form1 : Form
{
    private int count = 0; 

    public Form1()
    {
        InitializeComponent();
    }
    private void ButtonCheckState_Click(System.Object? sender, System.EventArgs e)
    {
        FormBorderStyle[] form_border_Styles = {
            FormBorderStyle.FixedSingle,
            FormBorderStyle.None,
            FormBorderStyle.FixedDialog,
            FormBorderStyle.FixedToolWindow
        };
        this.FormBorderStyle = form_border_Styles[count%form_border_Styles.Length];
        this.Text = $"{this.FormBorderStyle}";
        string msg = $"";
        msg += $"Form.FormBorderStyle = {this.FormBorderStyle}\n";
        msg += $"Form.Size = {this.Size}\n";
        msg += $"Form.ClientSize = {this.ClientSize}\n";
        ButtonCheckState.Text = msg;
        count++;
    }   
}
