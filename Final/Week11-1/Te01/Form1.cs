namespace Te01;

public partial class Form1 : Form
{
    // Field
    Calculator calculator = new Calculator();
    // Function
    private bool CheckTextBoxValueIsNone(System.Windows.Forms.TextBox a, System.Windows.Forms.TextBox b)
    {
        if (a.Text == "" || b.Text == "")
        {
            return (true);
        }
        else
        {
            return (false);
        }
    }
    // Event
    public Form1()
    {
        InitializeComponent();
    }
    private void ButtonExit_Click(System.Object? sender, System.EventArgs e)
    {
        this.Close();
    }
    private void ButtonReset_Click(System.Object? sender, System.EventArgs e)
    {
        TextBoxDataA.Text = $"";
        TextBoxDataB.Text = $"";
        TextBoxResult.Text = $"";
    }
    private void ButtonOperation_Click(System.Object? sender, System.EventArgs e)
    {
        Button button = (Button)sender;
        string operation = $"{button.Text}";
        if (CheckTextBoxValueIsNone(TextBoxDataA, TextBoxDataB))
        {
            MessageBox.Show($"Err : Enter value in text box first.");
        }
        else
        {
            switch (operation)
            {
                case "+":
                    TextBoxResult.Text = $"{calculator.plus(double.Parse(TextBoxDataA.Text), double.Parse(TextBoxDataB.Text))}";
                    break;
                case "-":
                    TextBoxResult.Text = $"{calculator.minus(double.Parse(TextBoxDataA.Text), double.Parse(TextBoxDataB.Text))}";
                    break;
                case "*":
                    TextBoxResult.Text = $"{calculator.multiply(double.Parse(TextBoxDataA.Text), double.Parse(TextBoxDataB.Text))}";
                    break;
                case "/":
                    if (double.Parse(TextBoxDataB.Text) == 0)
                    {
                        MessageBox.Show($"Err : Cannot divide by zero.");
                    }
                    else
                    {
                        TextBoxResult.Text = $"{calculator.divide(double.Parse(TextBoxDataA.Text), double.Parse(TextBoxDataB.Text))}";
                    }
                    break;
            }
        }
    }
}
