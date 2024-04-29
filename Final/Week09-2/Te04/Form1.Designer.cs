namespace Te04;

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
        this.SuspendLayout();
     //
     // form
     //
        this.Size = new System.Drawing.Size(426,240);
        this.Text =  "Form event";
        this.Load += new System.EventHandler(Form1_Load);
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(Form1_FormClosing);
        this.ResumeLayout(false);
    } 

    #endregion 

}

// private void Form1_Load(System.Object? sender, System.EventArgs e)
// {
//
// }

// private void Form1_FormClosing(System.Object? sender, System.Windows.Forms.FormClosingEventArgs e)
// {
//
// }

