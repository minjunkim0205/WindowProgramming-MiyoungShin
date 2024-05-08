namespace Te09;

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
        this.ButtonA = new System.Windows.Forms.Button();
        this.Button1 = new System.Windows.Forms.Button();
        this.ButtonB = new System.Windows.Forms.Button();
        this.ButtonC = new System.Windows.Forms.Button();
        this.ButtonBringToFront = new System.Windows.Forms.Button();
        this.ButtonSendToBack = new System.Windows.Forms.Button();
        this.ButtonDisable = new System.Windows.Forms.Button();
        this.ButtonEnable = new System.Windows.Forms.Button();
        this.ButtonShow = new System.Windows.Forms.Button();
        this.ButtonHide = new System.Windows.Forms.Button();
        this.SuspendLayout();
        //
        // ButtonA
        //
        this.ButtonA.Controls.Add(this.Button1);
        this.ButtonA.Text =  "ButtonA";
        this.ButtonA.Location = new System.Drawing.Point(28,12);
        this.ButtonA.Size = new System.Drawing.Size(172,23);
        //
        // Button1
        //
        this.Button1.Text =  "Button1";
        this.Button1.Location = new System.Drawing.Point(44,20);
        this.Button1.TabIndex = 1;
        //
        // ButtonB
        //
        this.ButtonB.Text =  "ButtonB";
        this.ButtonB.Location = new System.Drawing.Point(124,24);
        this.ButtonB.Size = new System.Drawing.Size(172,23);
        this.ButtonB.TabIndex = 2;
        //
        // ButtonC
        //
        this.ButtonC.Text =  "ButtonC";
        this.ButtonC.Location = new System.Drawing.Point(220,36);
        this.ButtonC.Size = new System.Drawing.Size(172,23);
        this.ButtonC.TabIndex = 3;
        //
        // ButtonBringToFront
        //
        this.ButtonBringToFront.Text =  "Bring To Front";
        this.ButtonBringToFront.Location = new System.Drawing.Point(28,92);
        this.ButtonBringToFront.Size = new System.Drawing.Size(172,23);
        this.ButtonBringToFront.TabIndex = 4;
        this.ButtonBringToFront.Click += new System.EventHandler(ButtonBringToFront_Click);
        //
        // ButtonSendToBack
        //
        this.ButtonSendToBack.Text =  "Send To Back";
        this.ButtonSendToBack.Location = new System.Drawing.Point(220,92);
        this.ButtonSendToBack.Size = new System.Drawing.Size(172,23);
        this.ButtonSendToBack.TabIndex = 5;
        this.ButtonSendToBack.Click += new System.EventHandler(ButtonSendToBack_Click);
        //
        // ButtonDisable
        //
        this.ButtonDisable.Text =  "Disable";
        this.ButtonDisable.Location = new System.Drawing.Point(28,128);
        this.ButtonDisable.Size = new System.Drawing.Size(172,23);
        this.ButtonDisable.TabIndex = 6;
        this.ButtonDisable.Click += new System.EventHandler(ButtonDisable_Click);
        //
        // ButtonEnable
        //
        this.ButtonEnable.Text =  "Enable";
        this.ButtonEnable.Location = new System.Drawing.Point(220,128);
        this.ButtonEnable.Size = new System.Drawing.Size(172,23);
        this.ButtonEnable.TabIndex = 7;
        this.ButtonEnable.Click += new System.EventHandler(ButtonEnable_Click);
        //
        // ButtonShow
        //
        this.ButtonShow.Text =  "Show";
        this.ButtonShow.Location = new System.Drawing.Point(28,164);
        this.ButtonShow.Size = new System.Drawing.Size(172,23);
        this.ButtonShow.TabIndex = 8;
        this.ButtonShow.Click += new System.EventHandler(ButtonShow_Click);
        //
        // ButtonHide
        //
        this.ButtonHide.Text =  "Hide";
        this.ButtonHide.Location = new System.Drawing.Point(220,164);
        this.ButtonHide.Size = new System.Drawing.Size(172,23);
        this.ButtonHide.TabIndex = 9;
        this.ButtonHide.Click += new System.EventHandler(ButtonHide_Click);
     //
     // form
     //
        this.Size = new System.Drawing.Size(429,240);
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text =  "Form1";
        this.Controls.Add(this.ButtonA);
        this.Controls.Add(this.ButtonB);
        this.Controls.Add(this.ButtonC);
        this.Controls.Add(this.ButtonBringToFront);
        this.Controls.Add(this.ButtonSendToBack);
        this.Controls.Add(this.ButtonDisable);
        this.Controls.Add(this.ButtonEnable);
        this.Controls.Add(this.ButtonShow);
        this.Controls.Add(this.ButtonHide);
        this.ResumeLayout(false);
    } 

    #endregion 

    private System.Windows.Forms.Button ButtonA;
    private System.Windows.Forms.Button Button1;
    private System.Windows.Forms.Button ButtonB;
    private System.Windows.Forms.Button ButtonC;
    private System.Windows.Forms.Button ButtonBringToFront;
    private System.Windows.Forms.Button ButtonSendToBack;
    private System.Windows.Forms.Button ButtonDisable;
    private System.Windows.Forms.Button ButtonEnable;
    private System.Windows.Forms.Button ButtonShow;
    private System.Windows.Forms.Button ButtonHide;
}

// private void ButtonBringToFront_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void ButtonSendToBack_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void ButtonDisable_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void ButtonEnable_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void ButtonShow_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void ButtonHide_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

