namespace Te04;

public partial class Form1 : Form
{
    // Start
    public Form1()
    {
        InitializeComponent();
    }
    // Event
    private void ButtonAdd_Click(System.Object? sender, System.EventArgs e)
    {
        DateTime selectedDate = MonthCalendarInput.SelectionStart;
        ListBoxResult.Items.Add($"{selectedDate} : {TextBoxInput.Text}");
        TextBoxInput.Text = "";
    }
}
