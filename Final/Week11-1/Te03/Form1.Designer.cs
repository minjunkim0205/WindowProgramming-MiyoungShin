namespace Te03;

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
        this.LabelAlign = new System.Windows.Forms.Label();
        this.LabelStyle = new System.Windows.Forms.Label();
        this.CheckBoxLeft = new System.Windows.Forms.CheckBox();
        this.CheckBoxCenter = new System.Windows.Forms.CheckBox();
        this.CheckBoxRight = new System.Windows.Forms.CheckBox();
        this.CheckBoxBold = new System.Windows.Forms.CheckBox();
        this.CheckBoxUnderscore = new System.Windows.Forms.CheckBox();
        this.CheckBoxItalic = new System.Windows.Forms.CheckBox();
        this.ButtonChangeColor = new System.Windows.Forms.Button();
        this.ButtonExit = new System.Windows.Forms.Button();
        this.CheckBoxStrikethrough = new System.Windows.Forms.CheckBox();
        this.LabelTarget = new System.Windows.Forms.Label();
        this.SuspendLayout();
        //
        // LabelAlign
        //
        this.LabelAlign.AutoSize =  true;
        this.LabelAlign.Text =  "Align";
        this.LabelAlign.Location = new System.Drawing.Point(32,24);
        this.LabelAlign.Size = new System.Drawing.Size(35,15);
        //
        // LabelStyle
        //
        this.LabelStyle.AutoSize =  true;
        this.LabelStyle.Text =  "Style";
        this.LabelStyle.Location = new System.Drawing.Point(164,24);
        this.LabelStyle.Size = new System.Drawing.Size(32,15);
        this.LabelStyle.TabIndex = 1;
        //
        // CheckBoxLeft
        //
        this.CheckBoxLeft.AutoSize =  true;
        this.CheckBoxLeft.Text =  "Left";
        this.CheckBoxLeft.Location = new System.Drawing.Point(28,48);
        this.CheckBoxLeft.Size = new System.Drawing.Size(46,19);
        this.CheckBoxLeft.TabIndex = 2;
        this.CheckBoxLeft.Click += new System.EventHandler(CheckBoxAlign_Click);
        //
        // CheckBoxCenter
        //
        this.CheckBoxCenter.AutoSize =  true;
        this.CheckBoxCenter.Text =  "Center";
        this.CheckBoxCenter.Location = new System.Drawing.Point(28,72);
        this.CheckBoxCenter.Size = new System.Drawing.Size(61,19);
        this.CheckBoxCenter.TabIndex = 3;
        this.CheckBoxCenter.Click += new System.EventHandler(CheckBoxAlign_Click);
        //
        // CheckBoxRight
        //
        this.CheckBoxRight.AutoSize =  true;
        this.CheckBoxRight.Text =  "Right";
        this.CheckBoxRight.Location = new System.Drawing.Point(28,96);
        this.CheckBoxRight.Size = new System.Drawing.Size(54,19);
        this.CheckBoxRight.TabIndex = 4;
        this.CheckBoxRight.Click += new System.EventHandler(CheckBoxAlign_Click);
        //
        // CheckBoxBold
        //
        this.CheckBoxBold.AutoSize =  true;
        this.CheckBoxBold.Text =  "Bold";
        this.CheckBoxBold.Location = new System.Drawing.Point(160,48);
        this.CheckBoxBold.Size = new System.Drawing.Size(50,19);
        this.CheckBoxBold.TabIndex = 5;
        this.CheckBoxBold.Click += new System.EventHandler(CheckBoxStyle_Click);
        //
        // CheckBoxUnderscore
        //
        this.CheckBoxUnderscore.AutoSize =  true;
        this.CheckBoxUnderscore.Text =  "Underscore";
        this.CheckBoxUnderscore.Location = new System.Drawing.Point(160,72);
        this.CheckBoxUnderscore.Size = new System.Drawing.Size(86,19);
        this.CheckBoxUnderscore.TabIndex = 6;
        this.CheckBoxUnderscore.Click += new System.EventHandler(CheckBoxStyle_Click);
        //
        // CheckBoxItalic
        //
        this.CheckBoxItalic.AutoSize =  true;
        this.CheckBoxItalic.Text =  "Italic";
        this.CheckBoxItalic.Location = new System.Drawing.Point(160,96);
        this.CheckBoxItalic.Size = new System.Drawing.Size(51,19);
        this.CheckBoxItalic.TabIndex = 7;
        this.CheckBoxItalic.Click += new System.EventHandler(CheckBoxStyle_Click);
        //
        // CheckBoxStrikethrough
        //
        this.CheckBoxStrikethrough.AutoSize =  true;
        this.CheckBoxStrikethrough.Text =  "Strikethrough";
        this.CheckBoxStrikethrough.Location = new System.Drawing.Point(160,120);
        this.CheckBoxStrikethrough.Size = new System.Drawing.Size(98,19);
        this.CheckBoxStrikethrough.TabIndex = 12;
        this.CheckBoxStrikethrough.Click += new System.EventHandler(CheckBoxStyle_Click);
        //
        // ButtonChangeColor
        //
        this.ButtonChangeColor.Text =  "Change\nColor";
        this.ButtonChangeColor.Location = new System.Drawing.Point(300,28);
        this.ButtonChangeColor.Size = new System.Drawing.Size(75,108);
        this.ButtonChangeColor.TabIndex = 9;
        this.ButtonChangeColor.Click += new System.EventHandler(ButtonChangeColor_Click);
        //
        // ButtonExit
        //
        this.ButtonExit.Text =  "Exit";
        this.ButtonExit.Location = new System.Drawing.Point(300,156);
        this.ButtonExit.TabIndex = 10;
        this.ButtonExit.Click += new System.EventHandler(ButtonExit_Click);
        //
        // Label
        //
        this.LabelTarget.AutoSize =  true;
        this.LabelTarget.Text =  "정렬과 스타일 적용하기 ";
        this.LabelTarget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.LabelTarget.Location = new System.Drawing.Point(36,160);
        this.LabelTarget.AutoSize = false;
        this.LabelTarget.Size = new System.Drawing.Size(200,17);
        this.LabelTarget.TabIndex = 13;
     //
     // form
     //
        this.Size = new System.Drawing.Size(429,240);
        this.Text =  "Form1";
        this.Controls.Add(this.LabelAlign);
        this.Controls.Add(this.LabelStyle);
        this.Controls.Add(this.CheckBoxLeft);
        this.Controls.Add(this.CheckBoxCenter);
        this.Controls.Add(this.CheckBoxRight);
        this.Controls.Add(this.CheckBoxBold);
        this.Controls.Add(this.CheckBoxUnderscore);
        this.Controls.Add(this.CheckBoxItalic);
        this.Controls.Add(this.ButtonChangeColor);
        this.Controls.Add(this.ButtonExit);
        this.Controls.Add(this.CheckBoxStrikethrough);
        this.Controls.Add(this.LabelTarget);
        this.ResumeLayout(false);
    } 

    #endregion 

    private System.Windows.Forms.Label LabelAlign;
    private System.Windows.Forms.Label LabelStyle;
    private System.Windows.Forms.CheckBox CheckBoxLeft;
    private System.Windows.Forms.CheckBox CheckBoxCenter;
    private System.Windows.Forms.CheckBox CheckBoxRight;
    private System.Windows.Forms.CheckBox CheckBoxBold;
    private System.Windows.Forms.CheckBox CheckBoxUnderscore;
    private System.Windows.Forms.CheckBox CheckBoxItalic;
    private System.Windows.Forms.CheckBox CheckBoxStrikethrough;
    private System.Windows.Forms.Button ButtonChangeColor;
    private System.Windows.Forms.Button ButtonExit;
    private System.Windows.Forms.Label LabelTarget;
}

// private void CheckBoxAlign_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void CheckBoxStyle_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void ButtonChangeColor_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void ButtonExit_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

