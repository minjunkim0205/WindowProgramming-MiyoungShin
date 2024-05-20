namespace Te01
{
    public partial class Form1 : Form
    {
        // Start
        public Form1()
        {
            InitializeComponent();
        }
        // Event
        private void ButtonRegister_Click(System.Object? sender, System.EventArgs e)
        {
            Form2 form2 = new Form2();
            this.AddOwnedForm(form2);
            form2.ShowDialog();
        }
        // Public properties to allow Form2 to access the labels
        public string LabelIdResultText
        {
            get { return LabelIdResult.Text; }
            set { LabelIdResult.Text = value; }
        }

        public string LabelPwResultText
        {
            get { return LabelPwResult.Text; }
            set { LabelPwResult.Text = value; }
        }

        public string LabelTelResultText
        {
            get { return LabelTelResult.Text; }
            set { LabelTelResult.Text = value; }
        }
    }
}