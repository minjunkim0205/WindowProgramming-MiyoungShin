namespace Te03;

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
        this.PrintDateButton = new System.Windows.Forms.Button();
        this.SuspendLayout();
        //
        // PrintDateButton
        //
        this.PrintDateButton.Text =  "Date Time";
        this.PrintDateButton.Location = new System.Drawing.Point(312,160);
        this.PrintDateButton.Size = new System.Drawing.Size(84,32);
        this.PrintDateButton.Click += new System.EventHandler(PrintDateButton_Click);
        //
        // form
        //
        this.Size = new System.Drawing.Size(426,240);
        this.Text =  "Date Display";
        this.Controls.Add(this.PrintDateButton);
        this.ResumeLayout(false);
    } 

    #endregion 

    private System.Windows.Forms.Button PrintDateButton;
}

// private void PrintDateButton_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

