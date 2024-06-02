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
        this.MonthCalendarInput = new System.Windows.Forms.MonthCalendar();
        this.ButtonAdd = new System.Windows.Forms.Button();
        this.TextBoxInput = new System.Windows.Forms.TextBox();
        this.ListBoxResult = new System.Windows.Forms.ListBox();
        this.SuspendLayout();
        //
        // MonthCalendarInput
        //
        //this.MonthCalendarInput.SingleMonthSize = new System.Drawing.Size(225,160);
        this.MonthCalendarInput.Size = new System.Drawing.Size(227,162);
        this.MonthCalendarInput.Text =  "";
        this.MonthCalendarInput.Location = new System.Drawing.Point(4,4);
        //
        // ButtonAdd
        //
        this.ButtonAdd.Text =  "Add";
        this.ButtonAdd.Location = new System.Drawing.Point(188,172);
        this.ButtonAdd.Size = new System.Drawing.Size(43,23);
        this.ButtonAdd.TabIndex = 1;
        this.ButtonAdd.Click += new System.EventHandler(ButtonAdd_Click);
        //
        // TextBoxInput
        //
        this.TextBoxInput.Text =  "";
        this.TextBoxInput.Location = new System.Drawing.Point(4,172);
        this.TextBoxInput.Size = new System.Drawing.Size(180,23);
        this.TextBoxInput.TabIndex = 2;
        //
        // ListBoxResult
        //
        this.ListBoxResult.ItemHeight = 15;
        this.ListBoxResult.Text =  "";
        this.ListBoxResult.Location = new System.Drawing.Point(236,8);
        this.ListBoxResult.Size = new System.Drawing.Size(172,184);
        this.ListBoxResult.TabIndex = 3;
     //
     // form
     //
        this.Size = new System.Drawing.Size(429,240);
        this.Text =  "Form1";
        this.Controls.Add(this.MonthCalendarInput);
        this.Controls.Add(this.ButtonAdd);
        this.Controls.Add(this.TextBoxInput);
        this.Controls.Add(this.ListBoxResult);
        this.ResumeLayout(false);
    } 

    #endregion 

    private System.Windows.Forms.MonthCalendar MonthCalendarInput;
    private System.Windows.Forms.Button ButtonAdd;
    private System.Windows.Forms.TextBox TextBoxInput;
    private System.Windows.Forms.ListBox ListBoxResult;
}

// private void ButtonAdd_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

