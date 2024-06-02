namespace Te03;

public partial class Form1 : Form
{
    // Start
    public Form1()
    {
        InitializeComponent();
    }
    // Field
    private int color_index = 0;
    // Event
    private void CheckBoxAlign_Click(System.Object? sender, System.EventArgs e)
    {
        CheckBox check_box = (CheckBox)sender;
        string operation = $"{check_box.Text}";
        CheckBox[] check_boxes = {
            CheckBoxLeft, 
            CheckBoxCenter, 
            CheckBoxRight
        };
        foreach(CheckBox element in check_boxes){
            element.Checked = false;
        }
        check_box.Checked = true;
        switch (operation)
        {
            case "Left":
                LabelTarget.TextAlign = ContentAlignment.MiddleLeft;
                break;
            case "Center":
                LabelTarget.TextAlign = ContentAlignment.MiddleCenter;
                break;
            case "Right":
                LabelTarget.TextAlign = ContentAlignment.MiddleRight;
                break;
        }
    }
    private void CheckBoxStyle_Click(System.Object? sender, System.EventArgs e)
    {
        CheckBox check_box = (CheckBox)sender;
        string operation = $"{check_box.Text}";
        CheckBox[] check_boxes = {
            CheckBoxBold, 
            CheckBoxUnderscore, 
            CheckBoxItalic, 
            CheckBoxStrikethrough
        };
        foreach(CheckBox element in check_boxes){
            element.Checked = false;
        }
        check_box.Checked = true;
        switch (operation)
        {
            case "Bold":
                LabelTarget.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
                break;
            case "Underscore":
                LabelTarget.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
                break;
            case "Italic":
                LabelTarget.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
                break;
            case "Strikethrough":
                LabelTarget.Font = new Font("Segoe UI", 9F, FontStyle.Strikeout, GraphicsUnit.Point);
                break;
        }
    }
    private void ButtonChangeColor_Click(System.Object? sender, System.EventArgs e)
    {
        Color[] colors = {
            Color.DarkOrange,
            Color.Blue,
            Color.Brown,
            Color.DarkGreen,
            Color.Cyan
        };
        color_index++;
        LabelTarget.BackColor = colors[color_index % (colors.Length)];
    }
    private void ButtonExit_Click(System.Object? sender, System.EventArgs e)
    {
        this.Close();
    }
}
