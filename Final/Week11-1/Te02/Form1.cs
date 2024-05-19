namespace Te02;

public partial class Form1 : Form
{
    // Field
    // Form
    public Form1()
    {
        InitializeComponent();
    }
    // Event
    private void ButtonExit_Click(System.Object? sender, System.EventArgs e)
    {
        this.Close();
    }
    private void ButtonReset_Click(System.Object? sender, System.EventArgs e)
    {
        TextBoxName.Text = "";
        ComboBoxResidence.Text = "";
        TextBoxPassword.Text = "";
        foreach (CheckBox check_box in GroupBoxLanguage.Controls)
        {
            check_box.Checked = false;
        }
    }
    private void ButtonAdd_Click(System.Object? sender, System.EventArgs e)
    {
        string element = $"Name : {TextBoxName.Text}, Residence : {ComboBoxResidence.Text}, Password : {TextBoxPassword.Text}, Language : [ ";
        foreach (CheckBox check_box in GroupBoxLanguage.Controls)
        {
            if(check_box.Checked)
            {
                element += $"{check_box.Text} ";
            }
        }
        element += $"]";
        ListBoxData.Items.Add(element);
    }
    private void ButtonDelete_Click(System.Object? sender, System.EventArgs e)
    {
        if (ListBoxData.SelectedIndex != -1)
        {
            ListBoxData.Items.RemoveAt(ListBoxData.SelectedIndex);
        }
        else
        {
            MessageBox.Show("No item selected.", "Delete Result");
        }
    }
    private void ButtonFind_Click(System.Object? sender, System.EventArgs e)
    {
        string searchText = TextBoxName.Text;
        int index = ListBoxData.FindString(searchText, -1);
        if (index != ListBox.NoMatches)
        {
            ListBoxData.SetSelected(index, true);
        }
        else
        {
            MessageBox.Show("Item not found.", "Search Result");
        }
    }
}
