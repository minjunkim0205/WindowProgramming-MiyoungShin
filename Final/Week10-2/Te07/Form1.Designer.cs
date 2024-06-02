namespace Te07;

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
        this.TextBoxUrl = new System.Windows.Forms.TextBox();
        this.ButtonConfirm = new System.Windows.Forms.Button();
        this.LinkLabelUrl = new System.Windows.Forms.LinkLabel();
        this.SuspendLayout();
        //
        // TextBoxUrl
        //
        this.TextBoxUrl.Text =  "https://";
        this.TextBoxUrl.Location = new System.Drawing.Point(40,40);
        this.TextBoxUrl.Size = new System.Drawing.Size(248,23);
        //
        // ButtonConfirm
        //
        this.ButtonConfirm.Text =  "Confirm";
        this.ButtonConfirm.Location = new System.Drawing.Point(300,40);
        this.ButtonConfirm.TabIndex = 1;
        this.ButtonConfirm.Click += new System.EventHandler(ButtonConfirm_Click);
        //
        // LinkLabelUrl
        //
        this.LinkLabelUrl.TabStop =  true;
        this.LinkLabelUrl.Text =  "https://";
        this.LinkLabelUrl.AutoSize =  true;
        this.LinkLabelUrl.Location = new System.Drawing.Point(40,80);
        this.LinkLabelUrl.Size = new System.Drawing.Size(47,15);
        this.LinkLabelUrl.TabIndex = 3;
        this.LinkLabelUrl.Click += new System.EventHandler(LinkLabelUrl_Click);
     //
     // form
     //
        this.Size = new System.Drawing.Size(429,240);
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text =  "Form1";
        this.Controls.Add(this.TextBoxUrl);
        this.Controls.Add(this.ButtonConfirm);
        this.Controls.Add(this.LinkLabelUrl);
        this.ResumeLayout(false);
    } 

    #endregion 

    private System.Windows.Forms.TextBox TextBoxUrl;
    private System.Windows.Forms.Button ButtonConfirm;
    private System.Windows.Forms.LinkLabel LinkLabelUrl;
}

// private void ButtonConfirm_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void LinkLabelUrl_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

