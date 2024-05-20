namespace Te02;

public partial class Form1 : Form
{
    // Start
    public Form1()
    {
        InitializeComponent();
    }
    // Event
    private void ButtonDeparture_Click(System.Object? sender, System.EventArgs e)
    {
        Form2 form2 = new Form2("Departure");
        this.AddOwnedForm(form2);
        form2.ShowDialog();
    }
    private void ButtonArrival_Click(System.Object? sender, System.EventArgs e)
    {
        Form2 form2 = new Form2("Arrival");
        this.AddOwnedForm(form2);
        form2.ShowDialog();
    }
    private void ButtonReset_Click(System.Object? sender, System.EventArgs e)
    {
        TextBoxDeparture.Text = $"";
        TextBoxArrival.Text = $"";
    }
    // Public properties to allow Form2 to access the labels
        public string TextBoxDepartureText
        {
            get { return TextBoxDeparture.Text; }
            set { TextBoxDeparture.Text = value; }
        }
        public string TextBoxArrivalText
        {
            get { return TextBoxArrival.Text; }
            set { TextBoxArrival.Text = value; }
        }
}
