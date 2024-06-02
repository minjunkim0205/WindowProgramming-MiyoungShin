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
        this.ButtonCheckState = new System.Windows.Forms.Button();
        this.SuspendLayout();
        //
        // ButtonCheckState
        //
        this.ButtonCheckState.Text =  "Check state";
        this.ButtonCheckState.Location = new System.Drawing.Point(8,8);
        this.ButtonCheckState.Size = new System.Drawing.Size(396,184);
        this.ButtonCheckState.Click += new System.EventHandler(ButtonCheckState_Click);
     //
     // form
     //
        this.Size = new System.Drawing.Size(429,240);
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text =  "Form1";
        this.Controls.Add(this.ButtonCheckState);
        this.ResumeLayout(false);
    } 

    #endregion 

    private System.Windows.Forms.Button ButtonCheckState;
}

// private void ButtonCheckState_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

