namespace Re01;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    private void CheckBoxA_CheckedChanged(System.Object? sender, System.EventArgs e)
    {
        CheckBox box = (CheckBox)sender;
        string msg = $"{box.Text} is ";
        msg += box.Checked?"checked":"unchecked";
        MessageBox.Show(msg);
    }
    private void CheckBoxB_CheckedChanged(System.Object? sender, System.EventArgs e)
    {
        CheckBox box = (CheckBox)sender;
        string msg = $"{box.Text} is ";
        msg += box.Checked?"checked":"unchecked";
        MessageBox.Show(msg);
    }
    private void CheckBoxG_CheckedChanged(System.Object? sender, System.EventArgs e)
    {
        CheckBox box = (CheckBox)sender;
        string msg = $"{box.Text} is ";
        msg += box.Checked?"checked":"unchecked";
        MessageBox.Show(msg);
    }
    private void CheckBoxD_CheckedChanged(System.Object? sender, System.EventArgs e)
    {
        CheckBox box = (CheckBox)sender;
        string msg = $"{box.Text} is ";
        msg += box.Checked?"checked":"unchecked";
        MessageBox.Show(msg);
    }
    private void ButtonConfirm_Click(System.Object? sender, System.EventArgs e)
    {
        string check_result = $"";
        CheckBox[] boxes = {CheckBoxA, CheckBoxB, CheckBoxD, CheckBoxG};
        foreach(var element in boxes){
            check_result += $"{element.Text} : {element.Checked}\n";
        }
        MessageBox.Show(check_result);
        string select = $"Result : ";
        foreach(var element in boxes){
            if(element.Checked){
                select += $"{element.Text}, ";
            }
        }
        MessageBox.Show(select);
    }
}
