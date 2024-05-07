namespace Re04;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    private void ButtonAdd_Click(System.Object? sender, System.EventArgs e)
    {
        if(TextBox.Text == ""){
            MessageBox.Show($"Err : Enter text box first.");
        }else{
            ListBox.Items.Add(TextBox.Text);
            TextBox.Clear();
        }
    }
    private void ButtonRemove_Click(System.Object? sender, System.EventArgs e)
    {
        if(ListBox.SelectedIndex > -1){
            ListBox.Items.RemoveAt(ListBox.SelectedIndex);
        }
    }
}
