namespace Te01
{
    public partial class Form2 : Form
    {
        // Start
        public Form2()
        {
            InitializeComponent();
        }
        // Function
        private bool CheckAllFilled(params System.Object[] objects_list)
        {
            foreach (TextBox element in objects_list)
            {
                if (element.Text == $"")
                {
                    return false;
                }
            }
            return true;
        }
        // Event
        private void ButtonConfirm_Click(System.Object? sender, System.EventArgs e)
        {
            MessageBox.Show("Confirm button", "Confirm");
            if (CheckAllFilled(TextBoxId, TextBoxPw, TextBoxTel))
            {
                Form1 form1 = (Form1)this.Owner;
                form1.LabelIdResultText = TextBoxId.Text;
                form1.LabelPwResultText = TextBoxPw.Text;
                form1.LabelTelResultText =TextBoxTel.Text;
                this.Close();
            }
        }
        private void ButtonCancel_Click(System.Object? sender, System.EventArgs e)
        {
            MessageBox.Show("Cancel button", "Cancel");
            this.Close();
        }
        private void ButtonCheck_Click(System.Object? sender, System.EventArgs e)
        {
            MessageBox.Show("Check button", "Check");
            if (TextBoxId.Text == $"")
            {
                TextBoxId.Focus();
            }
            else if (TextBoxPw.Text == $"")
            {
                TextBoxPw.Focus();
            }
            else if (TextBoxTel.Text == $"")
            {
                TextBoxTel.Focus();
            }
        }
    }
}