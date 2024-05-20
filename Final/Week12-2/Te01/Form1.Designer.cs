namespace Te01;

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
        this.LabelPw = new System.Windows.Forms.Label();
        this.LabelTel = new System.Windows.Forms.Label();
        this.ButtonRegister = new System.Windows.Forms.Button();
        this.LabelIdResult = new System.Windows.Forms.Label();
        this.LabelPwResult = new System.Windows.Forms.Label();
        this.LabelTelResult = new System.Windows.Forms.Label();
        this.SuspendLayout();
        //
        // LabelId
        //
        this.LabelId.AutoSize =  true;
        this.LabelId.Text =  "ID";
        this.LabelId.Location = new System.Drawing.Point(48,32);
        this.LabelId.Size = new System.Drawing.Size(18,15);
        //
        // LabelPw
        //
        this.LabelPw.AutoSize =  true;
        this.LabelPw.Text =  "PW";
        this.LabelPw.Location = new System.Drawing.Point(48,68);
        this.LabelPw.Size = new System.Drawing.Size(25,15);
        this.LabelPw.TabIndex = 1;
        //
        // LabelTel
        //
        this.LabelTel.AutoSize =  true;
        this.LabelTel.Text =  "Tel";
        this.LabelTel.Location = new System.Drawing.Point(48,104);
        this.LabelTel.Size = new System.Drawing.Size(21,15);
        this.LabelTel.TabIndex = 2;
        //
        // ButtonRegister
        //
        this.ButtonRegister.Text =  "Register";
        this.ButtonRegister.Location = new System.Drawing.Point(0,144);
        this.ButtonRegister.Size = new System.Drawing.Size(412,56);
        this.ButtonRegister.TabIndex = 6;
        this.ButtonRegister.Click += new System.EventHandler(ButtonRegister_Click);
        //
        // LabelIdResult
        //
        this.LabelIdResult.Text =  "";
        this.LabelIdResult.BorderStyle = BorderStyle.FixedSingle;
        this.LabelIdResult.Location = new System.Drawing.Point(120,32);
        this.LabelIdResult.Size = new System.Drawing.Size(212,16);
        this.LabelIdResult.TabIndex = 7;
        //
        // LabelPwResult
        //
        this.LabelPwResult.Text =  "";
        this.LabelPwResult.BorderStyle = BorderStyle.FixedSingle;
        this.LabelPwResult.Location = new System.Drawing.Point(120,68);
        this.LabelPwResult.Size = new System.Drawing.Size(212,16);
        this.LabelPwResult.TabIndex = 8;
        //
        // LabelTelResult
        //
        this.LabelTelResult.Text =  "";
        this.LabelTelResult.BorderStyle = BorderStyle.FixedSingle;
        this.LabelTelResult.Location = new System.Drawing.Point(120,104);
        this.LabelTelResult.Size = new System.Drawing.Size(212,16);
        this.LabelTelResult.TabIndex = 9;
     //
     // form
     //
        this.Size = new System.Drawing.Size(429,240);
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text =  "Form1";
        this.Controls.Add(this.LabelId);
        this.Controls.Add(this.LabelPw);
        this.Controls.Add(this.LabelTel);
        this.Controls.Add(this.ButtonRegister);
        this.Controls.Add(this.LabelIdResult);
        this.Controls.Add(this.LabelPwResult);
        this.Controls.Add(this.LabelTelResult);
        this.ResumeLayout(false);
    } 

    #endregion 

    private System.Windows.Forms.Label LabelId;
    private System.Windows.Forms.Label LabelPw;
    private System.Windows.Forms.Label LabelTel;
    private System.Windows.Forms.Button ButtonRegister;
    private System.Windows.Forms.Label LabelIdResult;
    private System.Windows.Forms.Label LabelPwResult;
    private System.Windows.Forms.Label LabelTelResult;
}

// private void ButtonRegister_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

