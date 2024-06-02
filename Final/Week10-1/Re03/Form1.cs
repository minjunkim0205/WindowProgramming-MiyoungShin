namespace Re03;

public partial class Form1 : Form
{
    Calculator calculator = new Calculator();
    public Form1()
    {
        InitializeComponent();
    }
    // Function
    private bool CheckTextBoxValueIsNone(System.Windows.Forms.TextBox a, System.Windows.Forms.TextBox b)
    {
        if(a.Text == "" || b.Text == ""){
            return (true);
        }else{
            return (false);
        }
    }
    // Event
    private void ButtonPlus_Click(System.Object? sender, System.EventArgs e)
    {
        if(CheckTextBoxValueIsNone(TextBoxValueA, TextBoxValueB)){
            MessageBox.Show($"Err : Enter Value text box first.");
        }else{
            TextBoxResult.Text = calculator.plus(double.Parse(TextBoxValueA.Text), double.Parse(TextBoxValueB.Text)).ToString();
        }
    }
    private void ButtonMinus_Click(System.Object? sender, System.EventArgs e)
    {
        if(CheckTextBoxValueIsNone(TextBoxValueA, TextBoxValueB)){
            MessageBox.Show($"Err : Enter Value text box first.");
        }else{
            TextBoxResult.Text = calculator.minus(double.Parse(TextBoxValueA.Text), double.Parse(TextBoxValueB.Text)).ToString();
        }
    }
    private void ButtonMultiply_Click(System.Object? sender, System.EventArgs e)
    {
        if(CheckTextBoxValueIsNone(TextBoxValueA, TextBoxValueB)){
            MessageBox.Show($"Err : Enter Value text box first.");
        }else{
            TextBoxResult.Text = calculator.multiply(double.Parse(TextBoxValueA.Text), double.Parse(TextBoxValueB.Text)).ToString();
        }
    }
    private void ButtonDivide_Click(System.Object? sender, System.EventArgs e)
    {
        if(CheckTextBoxValueIsNone(TextBoxValueA, TextBoxValueB)){
            MessageBox.Show($"Err : Enter Value text box first.");
        }else{
            TextBoxResult.Text = calculator.divide(double.Parse(TextBoxValueA.Text), double.Parse(TextBoxValueB.Text)).ToString();
        }
    }
    private void ButtonExit_Click(System.Object? sender, System.EventArgs e)
    {
        this.Close();
    }
    private void ButtonReset_Click(System.Object? sender, System.EventArgs e)
    {
        TextBoxValueA.Clear();
        TextBoxValueB.Clear();
        TextBoxResult.Clear();
    }
}
