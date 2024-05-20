namespace Te02;

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
        this.ButtonExit = new System.Windows.Forms.Button();
        this.MonthCalendar = new System.Windows.Forms.MonthCalendar();
        this.SuspendLayout();
        //
        // ButtonExit
        //
        this.ButtonExit.Text =  "Exit";
        this.ButtonExit.Location = new System.Drawing.Point(168,176);
        this.ButtonExit.TabIndex = 4;
        this.ButtonExit.Click += new System.EventHandler(ButtonExit_Click);
        //
        // MonthCalendar
        //
        //this.MonthCalendar.SingleMonthSize = new System.Drawing.Size(225,160);
        this.MonthCalendar.Size = new System.Drawing.Size(227,162);
        this.MonthCalendar.Text =  "MonthCalendar";
        this.MonthCalendar.Location = new System.Drawing.Point(92,8);
        this.MonthCalendar.TabIndex = 6;
     //
     // form
     //
        this.Size = new System.Drawing.Size(429,240);
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text =  "Form2";
        this.Controls.Add(this.ButtonExit);
        this.Controls.Add(this.MonthCalendar);
        this.ResumeLayout(false);
    } 

    #endregion 

    private System.Windows.Forms.Button ButtonExit;
    private System.Windows.Forms.MonthCalendar MonthCalendar;
}

// private void ButtonExit_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

