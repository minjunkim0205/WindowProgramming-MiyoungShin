namespace Re02;

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
        this.LabelId = new System.Windows.Forms.Label();
        this.LabelPassword = new System.Windows.Forms.Label();
        this.TextBoxId = new System.Windows.Forms.TextBox();
        this.TextBoxPassword = new System.Windows.Forms.TextBox();
        this.TextBoxResult = new System.Windows.Forms.TextBox();
        this.ButtonConfirm = new System.Windows.Forms.Button();
        this.SuspendLayout();
        //
        // LabelId
        //
        this.LabelId.AutoSize =  true;
        this.LabelId.Text =  "Enter your id";
        this.LabelId.Location = new System.Drawing.Point(40,40);
        this.LabelId.Size = new System.Drawing.Size(74,15);
        //
        // LabelPassword
        //
        this.LabelPassword.AutoSize =  true;
        this.LabelPassword.Text =  "Enter your password";
        this.LabelPassword.Location = new System.Drawing.Point(40,68);
        this.LabelPassword.Size = new System.Drawing.Size(114,15);
        this.LabelPassword.TabIndex = 1;
        //
        // TextBoxId
        //
        this.TextBoxId.Location = new System.Drawing.Point(188,36);
        this.TextBoxId.Size = new System.Drawing.Size(184,23);
        this.TextBoxId.TabIndex = 2;
        //
        // TextBoxPassword
        //
        this.TextBoxPassword.Location = new System.Drawing.Point(188,64);
        this.TextBoxPassword.Size = new System.Drawing.Size(184,23);
        this.TextBoxPassword.TabIndex = 3;
        //
        // TextBoxResult
        //
        this.TextBoxResult.BackColor = System.Drawing.SystemColors.Control;
        this.TextBoxResult.ReadOnly =  true;
        this.TextBoxResult.Location = new System.Drawing.Point(40,100);
        this.TextBoxResult.Size = new System.Drawing.Size(332,23);
        this.TextBoxResult.TabIndex = 4;
        //
        // ButtonConfirm
        //
        this.ButtonConfirm.Text =  "Confirm";
        this.ButtonConfirm.Location = new System.Drawing.Point(320,164);
        this.ButtonConfirm.TabIndex = 5;
        this.ButtonConfirm.Click += new System.EventHandler(ButtonConfirm_Click);
     //
     // form
     //
        this.Size = new System.Drawing.Size(429,240);
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text =  "Form1";
        this.Controls.Add(this.LabelId);
        this.Controls.Add(this.LabelPassword);
        this.Controls.Add(this.TextBoxId);
        this.Controls.Add(this.TextBoxPassword);
        this.Controls.Add(this.TextBoxResult);
        this.Controls.Add(this.ButtonConfirm);
        this.ResumeLayout(false);
    } 

    #endregion 

    private System.Windows.Forms.Label LabelId;
    private System.Windows.Forms.Label LabelPassword;
    private System.Windows.Forms.TextBox TextBoxId;
    private System.Windows.Forms.TextBox TextBoxPassword;
    private System.Windows.Forms.TextBox TextBoxResult;
    private System.Windows.Forms.Button ButtonConfirm;
}

// private void ButtonConfirm_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

