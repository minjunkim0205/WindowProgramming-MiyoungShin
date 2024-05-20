namespace Te01;

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
        this.ButtonConfirm = new System.Windows.Forms.Button();
        this.ButtonCancel = new System.Windows.Forms.Button();
        this.ButtonCheck = new System.Windows.Forms.Button();
        this.LabelId = new System.Windows.Forms.Label();
        this.LabelPw = new System.Windows.Forms.Label();
        this.LabelTel = new System.Windows.Forms.Label();
        this.TextBoxId = new System.Windows.Forms.TextBox();
        this.TextBoxPw = new System.Windows.Forms.TextBox();
        this.TextBoxTel = new System.Windows.Forms.TextBox();
        this.SuspendLayout();
        //
        // ButtonConfirm
        //
        this.ButtonConfirm.Text =  "Confirm";
        this.ButtonConfirm.Location = new System.Drawing.Point(288,40);
        this.ButtonConfirm.Click += new System.EventHandler(ButtonConfirm_Click);
        //
        // ButtonCancel
        //
        this.ButtonCancel.Text =  "Cancel";
        this.ButtonCancel.Location = new System.Drawing.Point(288,80);
        this.ButtonCancel.TabIndex = 1;
        this.ButtonCancel.Click += new System.EventHandler(ButtonCancel_Click);
        //
        // ButtonCheck
        //
        this.ButtonCheck.Text =  "Check";
        this.ButtonCheck.Location = new System.Drawing.Point(288,120);
        this.ButtonCheck.TabIndex = 2;
        this.ButtonCheck.Click += new System.EventHandler(ButtonCheck_Click);
        //
        // LabelId
        //
        this.LabelId.AutoSize =  true;
        this.LabelId.Text =  "ID";
        this.LabelId.Location = new System.Drawing.Point(44,44);
        this.LabelId.Size = new System.Drawing.Size(18,15);
        this.LabelId.TabIndex = 3;
        //
        // LabelPw
        //
        this.LabelPw.AutoSize =  true;
        this.LabelPw.Text =  "PW";
        this.LabelPw.Location = new System.Drawing.Point(44,84);
        this.LabelPw.Size = new System.Drawing.Size(25,15);
        this.LabelPw.TabIndex = 4;
        //
        // LabelTel
        //
        this.LabelTel.AutoSize =  true;
        this.LabelTel.Text =  "Tel";
        this.LabelTel.Location = new System.Drawing.Point(44,124);
        this.LabelTel.Size = new System.Drawing.Size(21,15);
        this.LabelTel.TabIndex = 5;
        //
        // TextBoxId
        //
        this.TextBoxId.Text =  "";
        this.TextBoxId.Location = new System.Drawing.Point(96,40);
        this.TextBoxId.Size = new System.Drawing.Size(168,23);
        this.TextBoxId.TabIndex = 6;
        //
        // TextBoxPw
        //
        this.TextBoxPw.Text =  "";
        this.TextBoxPw.Location = new System.Drawing.Point(96,80);
        this.TextBoxPw.PasswordChar = '*';
        this.TextBoxPw.Size = new System.Drawing.Size(168,23);
        this.TextBoxPw.TabIndex = 7;
        //
        // TextBoxTel
        //
        this.TextBoxTel.Text =  "";
        this.TextBoxTel.Location = new System.Drawing.Point(96,120);
        this.TextBoxTel.Size = new System.Drawing.Size(168,23);
        this.TextBoxTel.TabIndex = 8;
     //
     // form
     //
        this.Size = new System.Drawing.Size(429,240);
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text =  "Form1";
        this.Controls.Add(this.ButtonConfirm);
        this.Controls.Add(this.ButtonCancel);
        this.Controls.Add(this.ButtonCheck);
        this.Controls.Add(this.LabelId);
        this.Controls.Add(this.LabelPw);
        this.Controls.Add(this.LabelTel);
        this.Controls.Add(this.TextBoxId);
        this.Controls.Add(this.TextBoxPw);
        this.Controls.Add(this.TextBoxTel);
        this.ResumeLayout(false);
    } 

    #endregion 

    private System.Windows.Forms.Button ButtonConfirm;
    private System.Windows.Forms.Button ButtonCancel;
    private System.Windows.Forms.Button ButtonCheck;
    private System.Windows.Forms.Label LabelId;
    private System.Windows.Forms.Label LabelPw;
    private System.Windows.Forms.Label LabelTel;
    private System.Windows.Forms.TextBox TextBoxId;
    private System.Windows.Forms.TextBox TextBoxPw;
    private System.Windows.Forms.TextBox TextBoxTel;
}

// private void ButtonConfirm_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void ButtonCancel_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void ButtonCheck_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

