namespace Te02;

public partial class Form2 : Form
{
    // Field
    private string type = $"";
    // Start
    public Form2(string type)
    {
        InitializeComponent();
        this.type = type;
        this.Text = this.type;
    }
    // Event
    private void ButtonExit_Click(System.Object? sender, System.EventArgs e)
    {
        Form1 form1 = (Form1)this.Owner;
        if(type == "Departure")
        {
            form1.TextBoxDepartureText = MonthCalendar.Value.ToString("yyyy-MM-dd"); //TODO!!
        }
        else if(type == "Arrival")
        {
            form1.TextBoxArrivalText = MonthCalendar.Text;
        }
        this.Close();
    }
}
