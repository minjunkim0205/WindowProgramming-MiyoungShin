namespace Te05;

public partial class Form1 : Form
{
    // Start
    public Form1()
    {
        InitializeComponent();
    }
    // Event
    private void ButtonSaveFile_Click(System.Object? sender, System.EventArgs e)
    {
        SaveFileDialogTxt.AddExtension = true;
        SaveFileDialogTxt.DefaultExt = "txt";
        SaveFileDialogTxt.OverwritePrompt = true;
        SaveFileDialogTxt.InitialDirectory = Environment.CurrentDirectory;

        if (SaveFileDialogTxt.ShowDialog() == DialogResult.OK)
        {
            this.Text = SaveFileDialogTxt.FileName;
            using (StreamWriter sw = new StreamWriter(SaveFileDialogTxt.FileName))
            {
                sw.Write(TextBoxResult.Text);
            }
        }
    }
    private void ButtonLoadFile_Click(System.Object? sender, System.EventArgs e)
    {
        String file_path = null;
        OpenFileDialogTxt.InitialDirectory = Environment.CurrentDirectory;
        //openFileDialog의 시작 위치를 C:\\ 로 설정     
        if (OpenFileDialogTxt.ShowDialog() == DialogResult.OK)
        {
            file_path = OpenFileDialogTxt.FileName;
            this.Text = file_path;
            TextBoxResult.Text = File.ReadAllText(OpenFileDialogTxt.FileName);
        }
    }
    private void ButtonReset_Click(System.Object? sender, System.EventArgs e)
    {
        TextBoxResult.Text = "";
        this.Text = "Form1";
    }
    private void ButtonExit_Click(System.Object? sender, System.EventArgs e)
    {
        this.Close();
    }
}
