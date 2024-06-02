namespace Te04;

public partial class Form1 : Form
{
    // Start
    public Form1()
    {
        InitializeComponent();
    }
    // Event
    private void ButtonLeft_Click(System.Object? sender, System.EventArgs e)
    {

    }
    private void ButtonRight_Click(System.Object? sender, System.EventArgs e)
    {

    }
    private void ButtonAddComboBox_Click(System.Object? sender, System.EventArgs e)
    {
        if(TextBoxItem.Text == $"")
        {
            MessageBox.Show($"입력 데이터가 없습니다");
        }
        else
        {
            ComboBoxItem.Items.Add($"{TextBoxItem.Text}");
            MessageBox.Show($"{TextBoxItem.Text}\n콤보 상자에 추가");
        }
    }
    private void ButtonAddList_Click(System.Object? sender, System.EventArgs e)
    {
        string msg = $"";
        foreach(string element in CheckedListBoxItem.CheckedItems)
        {
            ListBoxItem.Items.Add($"{element}");
            msg += element;
        }
        if(msg == $"")
        {
            MessageBox.Show($"입력 데이터가 없습니다");
        }
        else
        {
            MessageBox.Show($"{msg}\n리스트 상자에 추가");
        }
    }
}
