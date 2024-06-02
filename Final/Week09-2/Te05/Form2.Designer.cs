namespace Te05;

partial class Form2
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
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text =  "Second Form";
        this.Closing += new System.ComponentModel.CancelEventHandler(Form2_Closing);
        this.ResumeLayout(false);
    } 

    #endregion 

}

// private void Form2_Closing(System.Object? sender, System.ComponentModel.CancelEventArgs e)
// {
//
// }

