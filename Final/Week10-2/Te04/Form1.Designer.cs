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
        this.ButtonEnable = new System.Windows.Forms.Button();
        this.ButtonCursor = new System.Windows.Forms.Button();
        this.ButtonClose = new System.Windows.Forms.Button();
        this.ButtonTitle = new System.Windows.Forms.Button();
        this.SuspendLayout();
        //
        // ButtonEnable
        //
        this.ButtonEnable.Text =  "Enable";
        this.ButtonEnable.Location = new System.Drawing.Point(48,44);
        this.ButtonEnable.Size = new System.Drawing.Size(136,40);
        this.ButtonEnable.Click += new System.EventHandler(ButtonEnable_Click);
        //
        // ButtonCursor
        //
        this.ButtonCursor.Text =  "Cursor";
        this.ButtonCursor.Location = new System.Drawing.Point(220,44);
        this.ButtonCursor.Size = new System.Drawing.Size(136,40);
        this.ButtonCursor.TabIndex = 1;
        this.ButtonCursor.Click += new System.EventHandler(ButtonCursor_Click);
        //
        // ButtonClose
        //
        this.ButtonClose.Text =  "Close";
        this.ButtonClose.Location = new System.Drawing.Point(48,108);
        this.ButtonClose.Size = new System.Drawing.Size(136,40);
        this.ButtonClose.TabIndex = 2;
        this.ButtonClose.Click += new System.EventHandler(ButtonClose_Click);
        //
        // ButtonTitle
        //
        this.ButtonTitle.Text =  "Title";
        this.ButtonTitle.Location = new System.Drawing.Point(220,108);
        this.ButtonTitle.Size = new System.Drawing.Size(136,40);
        this.ButtonTitle.TabIndex = 3;
        this.ButtonTitle.Click += new System.EventHandler(ButtonTitle_Click);
     //
     // form
     //
        this.Size = new System.Drawing.Size(429,240);
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text =  "Form1";
        this.Controls.Add(this.ButtonEnable);
        this.Controls.Add(this.ButtonCursor);
        this.Controls.Add(this.ButtonClose);
        this.Controls.Add(this.ButtonTitle);
        this.ResumeLayout(false);
    } 

    #endregion 

    private System.Windows.Forms.Button ButtonEnable;
    private System.Windows.Forms.Button ButtonCursor;
    private System.Windows.Forms.Button ButtonClose;
    private System.Windows.Forms.Button ButtonTitle;
}

// private void ButtonEnable_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void ButtonCursor_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void ButtonClose_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void ButtonTitle_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

