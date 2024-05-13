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
        this.LabelDataA = new System.Windows.Forms.Label();
        this.LabelDataB = new System.Windows.Forms.Label();
        this.LabelResult = new System.Windows.Forms.Label();
        this.ButtonExit = new System.Windows.Forms.Button();
        this.ButtonReset = new System.Windows.Forms.Button();
        this.ButtonPlus = new System.Windows.Forms.Button();
        this.ButtonMinus = new System.Windows.Forms.Button();
        this.ButtonMultiply = new System.Windows.Forms.Button();
        this.ButtonDivide = new System.Windows.Forms.Button();
        this.TextBoxDataA = new System.Windows.Forms.TextBox();
        this.TextBoxDataB = new System.Windows.Forms.TextBox();
        this.TextBoxResult = new System.Windows.Forms.TextBox();
        this.SuspendLayout();
        //
        // LabelDataA
        //
        this.LabelDataA.AutoSize =  true;
        this.LabelDataA.Text =  "DataA";
        this.LabelDataA.Location = new System.Drawing.Point(40,36);
        this.LabelDataA.Size = new System.Drawing.Size(39,15);
        //
        // LabelDataB
        //
        this.LabelDataB.AutoSize =  true;
        this.LabelDataB.Text =  "DataB";
        this.LabelDataB.Location = new System.Drawing.Point(40,68);
        this.LabelDataB.Size = new System.Drawing.Size(38,15);
        this.LabelDataB.TabIndex = 1;
        //
        // LabelResult
        //
        this.LabelResult.AutoSize =  true;
        this.LabelResult.Text =  "Result";
        this.LabelResult.Location = new System.Drawing.Point(40,100);
        this.LabelResult.Size = new System.Drawing.Size(39,15);
        this.LabelResult.TabIndex = 2;
        //
        // ButtonExit
        //
        this.ButtonExit.Text =  "Exit";
        this.ButtonExit.Location = new System.Drawing.Point(304,32);
        this.ButtonExit.Size = new System.Drawing.Size(75,36);
        this.ButtonExit.TabIndex = 3;
        this.ButtonExit.Click += new System.EventHandler(ButtonExit_Click);
        //
        // ButtonReset
        //
        this.ButtonReset.Text =  "Reset";
        this.ButtonReset.Location = new System.Drawing.Point(304,84);
        this.ButtonReset.Size = new System.Drawing.Size(75,36);
        this.ButtonReset.TabIndex = 4;
        this.ButtonReset.Click += new System.EventHandler(ButtonReset_Click);
        //
        // ButtonPlus
        //
        this.ButtonPlus.Text =  "+";
        this.ButtonPlus.Location = new System.Drawing.Point(44,140);
        this.ButtonPlus.Size = new System.Drawing.Size(56,39);
        this.ButtonPlus.TabIndex = 5;
        this.ButtonPlus.Click += new System.EventHandler(ButtonOperation_Click);
        //
        // ButtonMinus
        //
        this.ButtonMinus.Text =  "-";
        this.ButtonMinus.Location = new System.Drawing.Point(108,140);
        this.ButtonMinus.Size = new System.Drawing.Size(56,39);
        this.ButtonMinus.TabIndex = 6;
        this.ButtonMinus.Click += new System.EventHandler(ButtonOperation_Click);
        //
        // ButtonMultiply
        //
        this.ButtonMultiply.Text =  "*";
        this.ButtonMultiply.Location = new System.Drawing.Point(172,140);
        this.ButtonMultiply.Size = new System.Drawing.Size(56,39);
        this.ButtonMultiply.TabIndex = 7;
        this.ButtonMultiply.Click += new System.EventHandler(ButtonOperation_Click);
        //
        // ButtonDivide
        //
        this.ButtonDivide.Text =  "/";
        this.ButtonDivide.Location = new System.Drawing.Point(236,140);
        this.ButtonDivide.Size = new System.Drawing.Size(56,39);
        this.ButtonDivide.TabIndex = 8;
        this.ButtonDivide.Click += new System.EventHandler(ButtonOperation_Click);
        //
        // TextBoxDataA
        //
        this.TextBoxDataA.Location = new System.Drawing.Point(104,32);
        this.TextBoxDataA.Size = new System.Drawing.Size(172,23);
        this.TextBoxDataA.TabIndex = 9;
        //
        // TextBoxDataB
        //
        this.TextBoxDataB.Location = new System.Drawing.Point(104,64);
        this.TextBoxDataB.Size = new System.Drawing.Size(172,23);
        this.TextBoxDataB.TabIndex = 10;
        //
        // TextBoxResult
        //
        this.TextBoxResult.BackColor = System.Drawing.SystemColors.Control;
        this.TextBoxResult.ReadOnly =  true;
        this.TextBoxResult.Location = new System.Drawing.Point(104,96);
        this.TextBoxResult.Size = new System.Drawing.Size(172,23);
        this.TextBoxResult.TabIndex = 11;
     //
     // form
     //
        this.Size = new System.Drawing.Size(429,240);
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text =  "Form1";
        this.Controls.Add(this.LabelDataA);
        this.Controls.Add(this.LabelDataB);
        this.Controls.Add(this.LabelResult);
        this.Controls.Add(this.ButtonExit);
        this.Controls.Add(this.ButtonReset);
        this.Controls.Add(this.ButtonPlus);
        this.Controls.Add(this.ButtonMinus);
        this.Controls.Add(this.ButtonMultiply);
        this.Controls.Add(this.ButtonDivide);
        this.Controls.Add(this.TextBoxDataA);
        this.Controls.Add(this.TextBoxDataB);
        this.Controls.Add(this.TextBoxResult);
        this.ResumeLayout(false);
    } 

    #endregion 

    private System.Windows.Forms.Label LabelDataA;
    private System.Windows.Forms.Label LabelDataB;
    private System.Windows.Forms.Label LabelResult;
    private System.Windows.Forms.Button ButtonExit;
    private System.Windows.Forms.Button ButtonReset;
    private System.Windows.Forms.Button ButtonPlus;
    private System.Windows.Forms.Button ButtonMinus;
    private System.Windows.Forms.Button ButtonMultiply;
    private System.Windows.Forms.Button ButtonDivide;
    private System.Windows.Forms.TextBox TextBoxDataA;
    private System.Windows.Forms.TextBox TextBoxDataB;
    private System.Windows.Forms.TextBox TextBoxResult;
}

// private void ButtonExit_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void ButtonReset_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

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

