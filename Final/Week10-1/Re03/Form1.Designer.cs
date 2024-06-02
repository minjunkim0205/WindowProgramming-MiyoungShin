namespace Re03;

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
        this.LabelValueA = new System.Windows.Forms.Label();
        this.LabelValueB = new System.Windows.Forms.Label();
        this.LabelResult = new System.Windows.Forms.Label();
        this.TextBoxValueA = new System.Windows.Forms.TextBox();
        this.TextBoxValueB = new System.Windows.Forms.TextBox();
        this.TextBoxResult = new System.Windows.Forms.TextBox();
        this.ButtonPlus = new System.Windows.Forms.Button();
        this.ButtonMinus = new System.Windows.Forms.Button();
        this.ButtonMultiply = new System.Windows.Forms.Button();
        this.ButtonDivide = new System.Windows.Forms.Button();
        this.ButtonExit = new System.Windows.Forms.Button();
        this.ButtonReset = new System.Windows.Forms.Button();
        this.SuspendLayout();
        //
        // LabelValueA
        //
        this.LabelValueA.AutoSize =  true;
        this.LabelValueA.Text =  "Value A";
        this.LabelValueA.Location = new System.Drawing.Point(36,28);
        this.LabelValueA.Size = new System.Drawing.Size(46,15);
        //
        // LabelValueB
        //
        this.LabelValueB.AutoSize =  true;
        this.LabelValueB.Text =  "Value B";
        this.LabelValueB.Location = new System.Drawing.Point(36,60);
        this.LabelValueB.Size = new System.Drawing.Size(45,15);
        this.LabelValueB.TabIndex = 1;
        //
        // LabelResult
        //
        this.LabelResult.AutoSize =  true;
        this.LabelResult.Text =  "Result";
        this.LabelResult.Location = new System.Drawing.Point(36,92);
        this.LabelResult.Size = new System.Drawing.Size(39,15);
        this.LabelResult.TabIndex = 2;
        //
        // TextBoxValueA
        //
        this.TextBoxValueA.Location = new System.Drawing.Point(112,24);
        this.TextBoxValueA.Size = new System.Drawing.Size(140,23);
        this.TextBoxValueA.TabIndex = 3;
        //
        // TextBoxValueB
        //
        this.TextBoxValueB.Location = new System.Drawing.Point(112,56);
        this.TextBoxValueB.Size = new System.Drawing.Size(140,23);
        this.TextBoxValueB.TabIndex = 4;
        //
        // TextBoxResult
        //
        this.TextBoxResult.BackColor = System.Drawing.SystemColors.Control;
        this.TextBoxResult.ReadOnly =  true;
        this.TextBoxResult.Location = new System.Drawing.Point(112,88);
        this.TextBoxResult.Size = new System.Drawing.Size(140,23);
        this.TextBoxResult.TabIndex = 5;
        //
        // ButtonPlus
        //
        this.ButtonPlus.Text =  "+";
        this.ButtonPlus.Location = new System.Drawing.Point(56,144);
        this.ButtonPlus.Size = new System.Drawing.Size(52,32);
        this.ButtonPlus.TabIndex = 6;
        this.ButtonPlus.Click += new System.EventHandler(ButtonPlus_Click);
        //
        // ButtonMinus
        //
        this.ButtonMinus.Text =  "-";
        this.ButtonMinus.Location = new System.Drawing.Point(136,144);
        this.ButtonMinus.Size = new System.Drawing.Size(52,32);
        this.ButtonMinus.TabIndex = 7;
        this.ButtonMinus.Click += new System.EventHandler(ButtonMinus_Click);
        //
        // ButtonMultiply
        //
        this.ButtonMultiply.Text =  "*";
        this.ButtonMultiply.Location = new System.Drawing.Point(216,144);
        this.ButtonMultiply.Size = new System.Drawing.Size(52,32);
        this.ButtonMultiply.TabIndex = 8;
        this.ButtonMultiply.Click += new System.EventHandler(ButtonMultiply_Click);
        //
        // ButtonDivide
        //
        this.ButtonDivide.Text =  "/";
        this.ButtonDivide.Location = new System.Drawing.Point(292,144);
        this.ButtonDivide.Size = new System.Drawing.Size(52,32);
        this.ButtonDivide.TabIndex = 9;
        this.ButtonDivide.Click += new System.EventHandler(ButtonDivide_Click);
        //
        // ButtonExit
        //
        this.ButtonExit.Text =  "Exit";
        this.ButtonExit.Location = new System.Drawing.Point(308,24);
        this.ButtonExit.Size = new System.Drawing.Size(84,40);
        this.ButtonExit.TabIndex = 10;
        this.ButtonExit.Click += new System.EventHandler(ButtonExit_Click);
        //
        // ButtonReset
        //
        this.ButtonReset.Text =  "Reset";
        this.ButtonReset.Location = new System.Drawing.Point(308,72);
        this.ButtonReset.Size = new System.Drawing.Size(84,40);
        this.ButtonReset.TabIndex = 11;
        this.ButtonReset.Click += new System.EventHandler(ButtonReset_Click);
     //
     // form
     //
        this.Size = new System.Drawing.Size(429,240);
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text =  "Form1";
        this.Controls.Add(this.LabelValueA);
        this.Controls.Add(this.LabelValueB);
        this.Controls.Add(this.LabelResult);
        this.Controls.Add(this.TextBoxValueA);
        this.Controls.Add(this.TextBoxValueB);
        this.Controls.Add(this.TextBoxResult);
        this.Controls.Add(this.ButtonPlus);
        this.Controls.Add(this.ButtonMinus);
        this.Controls.Add(this.ButtonMultiply);
        this.Controls.Add(this.ButtonDivide);
        this.Controls.Add(this.ButtonExit);
        this.Controls.Add(this.ButtonReset);
        this.ResumeLayout(false);
    } 

    #endregion 

    private System.Windows.Forms.Label LabelValueA;
    private System.Windows.Forms.Label LabelValueB;
    private System.Windows.Forms.Label LabelResult;
    private System.Windows.Forms.TextBox TextBoxValueA;
    private System.Windows.Forms.TextBox TextBoxValueB;
    private System.Windows.Forms.TextBox TextBoxResult;
    private System.Windows.Forms.Button ButtonPlus;
    private System.Windows.Forms.Button ButtonMinus;
    private System.Windows.Forms.Button ButtonMultiply;
    private System.Windows.Forms.Button ButtonDivide;
    private System.Windows.Forms.Button ButtonExit;
    private System.Windows.Forms.Button ButtonReset;
}

// private void ButtonPlus_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void ButtonMinus_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void ButtonMultiply_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void ButtonDivide_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void ButtonExit_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void ButtonReset_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

