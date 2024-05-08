namespace Te04;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    private void ButtonEnable_Click(System.Object? sender, System.EventArgs e)
    {
        ButtonCursor.Enabled = ButtonCursor.Enabled?false:true;
    }
    private void ButtonCursor_Click(System.Object? sender, System.EventArgs e)
    {
        if(ButtonCursor.Cursor == Cursors.Default){
            ButtonCursor.Cursor = Cursors.Help;
        }else{
            ButtonCursor.Cursor = Cursors.Default;
        }
    }
    private void ButtonClose_Click(System.Object? sender, System.EventArgs e)
    {
        this.Close();
    }
    private void ButtonTitle_Click(System.Object? sender, System.EventArgs e)
    {
        if(this.Text == "Form1"){
            this.Text =  "Form1 !!!";
        }else{
            this.Text =  "Form1";
        }
    }
}
