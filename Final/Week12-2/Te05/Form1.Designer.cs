namespace Te05;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.ButtonSaveFile = new System.Windows.Forms.Button();
        this.ButtonLoadFile = new System.Windows.Forms.Button();
        this.TextBoxResult = new System.Windows.Forms.TextBox();
        this.ButtonReset = new System.Windows.Forms.Button();
        this.ButtonExit = new System.Windows.Forms.Button();
        this.SaveFileDialogTxt = new System.Windows.Forms.SaveFileDialog();
        this.OpenFileDialogTxt = new System.Windows.Forms.OpenFileDialog();
        this.SuspendLayout();
        //
        // ButtonSaveFile
        //
        this.ButtonSaveFile.Text =  "SaveFile";
        this.ButtonSaveFile.Location = new System.Drawing.Point(4,4);
        this.ButtonSaveFile.Size = new System.Drawing.Size(200,23);
        this.ButtonSaveFile.Click += new System.EventHandler(ButtonSaveFile_Click);
        //
        // ButtonLoadFile
        //
        this.ButtonLoadFile.Text =  "LoadFile";
        this.ButtonLoadFile.Location = new System.Drawing.Point(208,4);
        this.ButtonLoadFile.Size = new System.Drawing.Size(200,23);
        this.ButtonLoadFile.TabIndex = 1;
        this.ButtonLoadFile.Click += new System.EventHandler(ButtonLoadFile_Click);
        //
        // TextBoxResult
        //
        this.TextBoxResult.AutoSize =  false;
        this.TextBoxResult.Location = new System.Drawing.Point(4,32);
        this.TextBoxResult.Size = new System.Drawing.Size(404,138);
        this.TextBoxResult.TabIndex = 2;
        //
        // ButtonReset
        //
        this.ButtonReset.Text =  "Reset";
        this.ButtonReset.Location = new System.Drawing.Point(4,175);
        this.ButtonReset.Size = new System.Drawing.Size(200,23);
        this.ButtonReset.TabIndex = 3;
        this.ButtonReset.Click += new System.EventHandler(ButtonReset_Click);
        //
        // ButtonExit
        //
        this.ButtonExit.Text =  "Exit";
        this.ButtonExit.Location = new System.Drawing.Point(208,176);
        this.ButtonExit.Size = new System.Drawing.Size(200,23);
        this.ButtonExit.TabIndex = 4;
        this.ButtonExit.Click += new System.EventHandler(ButtonExit_Click);
        //
        // SaveFileDialogTxt
        //
        //
        // OpenFileDialogTxt
        //
     //
     // form
     //
        this.Size = new System.Drawing.Size(429,240);
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text =  "Form1";
        this.Controls.Add(this.ButtonSaveFile);
        this.Controls.Add(this.ButtonLoadFile);
        this.Controls.Add(this.TextBoxResult);
        this.Controls.Add(this.ButtonReset);
        this.Controls.Add(this.ButtonExit);
        this.ResumeLayout(false);
    } 

    #endregion 

    private System.Windows.Forms.Button ButtonSaveFile;
    private System.Windows.Forms.Button ButtonLoadFile;
    private System.Windows.Forms.TextBox TextBoxResult;
    private System.Windows.Forms.Button ButtonReset;
    private System.Windows.Forms.Button ButtonExit;
    private System.Windows.Forms.SaveFileDialog SaveFileDialogTxt;
    private System.Windows.Forms.OpenFileDialog OpenFileDialogTxt;
}

// private void ButtonSaveFile_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void ButtonLoadFile_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void ButtonReset_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void ButtonExit_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

