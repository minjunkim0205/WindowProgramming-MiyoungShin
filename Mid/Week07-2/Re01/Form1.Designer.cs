namespace Re01;

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
        this.Test_Button = new System.Windows.Forms.Button();
        this.SuspendLayout();
        //
        // Test_Button
        //
        this.Test_Button.Text =  "Click here";
        this.Test_Button.Location = new System.Drawing.Point(372,324);
        this.Test_Button.Click += new System.EventHandler(Test_Button_Click);
     //
     // form
     //
        this.Size = new System.Drawing.Size(480,400);
        this.Text =  "WinformTest-Re01";
        this.Controls.Add(this.Test_Button);
        this.ResumeLayout(false);
    } 

    #endregion 

    private System.Windows.Forms.Button Test_Button;
}

// private void Test_Button_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

