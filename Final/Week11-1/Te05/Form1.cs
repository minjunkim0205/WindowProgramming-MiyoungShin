namespace Te05;

public partial class Form1 : Form
{
    // Start
    public Form1()
    {
        InitializeComponent();
    }
    // Field
    private int START_YEAR = 2000;
    private int END_YEAR = 2024;
    // Event
    private void Form1_Load(System.Object? sender, System.EventArgs e)
    {
        for(int year = START_YEAR; year <= END_YEAR; year++)
        {
            ComboBoxAdmission.Items.Add($"{year}");
        }
    }
    private void ButtonAdd_Click(System.Object? sender, System.EventArgs e)
    {
        if(TextBoxName.Text == $"" || ComboBoxAdmission.Text == $"")
        {
            MessageBox.Show("Please enter a value.", "Button Add");
        }
        else
        {
            string element = $"Name : {TextBoxName.Text}, Grade : ";
            foreach (RadioButton radio_button in GroupBoxGrade.Controls)
            {
                if(radio_button.Checked)
                {
                    element += $"{radio_button.Text}";
                }
            }
            element += $", Admission : {ComboBoxAdmission.Text}, Subject : [ ";
            foreach (CheckBox check_box in GroupBoxSubject.Controls)
            {
                if(check_box.Checked)
                {
                    element += $"{check_box.Text} ";
                }
            }
            element += $"]";
            ListBoxResult.Items.Add(element);
            TextBoxName.Text = $"";
            ComboBoxAdmission.Text = $"";
            foreach(CheckBox check_box in GroupBoxSubject.Controls)
            {
                check_box.Checked = false;
            }
        }
    }
    private void ButtonDelete_Click(System.Object? sender, System.EventArgs e)
    {
        if (ListBoxResult.SelectedIndex != -1)
        {
            ListBoxResult.Items.RemoveAt(ListBoxResult.SelectedIndex);
        }
        else
        {
            MessageBox.Show("No item selected.", "Button Delete");
        }
    }
    private void ButtonExit_Click(System.Object? sender, System.EventArgs e)
    {
        this.Close();
    }
}
