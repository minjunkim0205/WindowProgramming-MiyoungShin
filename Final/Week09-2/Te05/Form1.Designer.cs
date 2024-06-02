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
        this.ShowHide = new System.Windows.Forms.Button();
        this.FormCreate = new System.Windows.Forms.Button();
        this.FormBackgroundColor = new System.Windows.Forms.Button();
        this.SuspendLayout();
        //
        // ShowHide
        //
        this.ShowHide.BackColor = System.Drawing.Color.White;
        this.ShowHide.Text =  "Show/Hide";
        this.ShowHide.Location = new System.Drawing.Point(32,20);
        this.ShowHide.Size = new System.Drawing.Size(344,48);
        this.ShowHide.Click += new System.EventHandler(ShowHide_Click);
        //
        // FormCreate
        //
        this.FormCreate.BackColor = System.Drawing.Color.White;
        this.FormCreate.Text =  "Form Create";
        this.FormCreate.Location = new System.Drawing.Point(32,76);
        this.FormCreate.Size = new System.Drawing.Size(344,48);
        this.FormCreate.TabIndex = 1;
        this.FormCreate.Click += new System.EventHandler(FormCreate_Click);
        //
        // FormBackgroundColor
        //
        this.FormBackgroundColor.BackColor = System.Drawing.Color.White;
        this.FormBackgroundColor.Text =  "Form Background Color";
        this.FormBackgroundColor.Location = new System.Drawing.Point(32,132);
        this.FormBackgroundColor.Size = new System.Drawing.Size(344,48);
        this.FormBackgroundColor.TabIndex = 2;
        this.FormBackgroundColor.Click += new System.EventHandler(FormBackgroundColor_Click);
     //
     // form
     //
        this.Size = new System.Drawing.Size(426,240);
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text =  "Form Method";
        this.Controls.Add(this.ShowHide);
        this.Controls.Add(this.FormCreate);
        this.Controls.Add(this.FormBackgroundColor);
        this.ResumeLayout(false);
    } 

    #endregion 

    private System.Windows.Forms.Button ShowHide;
    private System.Windows.Forms.Button FormCreate;
    private System.Windows.Forms.Button FormBackgroundColor;
}

// private void ShowHide_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void FormCreate_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void FormBackgroundColor_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

