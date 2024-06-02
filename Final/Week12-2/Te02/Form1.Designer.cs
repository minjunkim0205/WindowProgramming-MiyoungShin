namespace Te02;

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
        this.LabelDeparture = new System.Windows.Forms.Label();
        this.LabelArrival = new System.Windows.Forms.Label();
        this.TextBoxDeparture = new System.Windows.Forms.TextBox();
        this.TextBoxArrival = new System.Windows.Forms.TextBox();
        this.ButtonDeparture = new System.Windows.Forms.Button();
        this.ButtonArrival = new System.Windows.Forms.Button();
        this.ButtonReset = new System.Windows.Forms.Button();
        this.SuspendLayout();
        //
        // LabelDeparture
        //
        this.LabelDeparture.AutoSize =  true;
        this.LabelDeparture.Text =  "Departure Date";
        this.LabelDeparture.Location = new System.Drawing.Point(36,44);
        this.LabelDeparture.Size = new System.Drawing.Size(86,15);
        //
        // LabelArrival
        //
        this.LabelArrival.AutoSize =  true;
        this.LabelArrival.Text =  "Arrival Date";
        this.LabelArrival.Location = new System.Drawing.Point(36,80);
        this.LabelArrival.Size = new System.Drawing.Size(68,15);
        this.LabelArrival.TabIndex = 1;
        //
        // TextBoxDeparture
        //
        this.TextBoxDeparture.Text =  "";
        this.TextBoxDeparture.Location = new System.Drawing.Point(124,40);
        this.TextBoxDeparture.Size = new System.Drawing.Size(216,23);
        this.TextBoxDeparture.TabIndex = 2;
        //
        // TextBoxArrival
        //
        this.TextBoxArrival.Text =  "";
        this.TextBoxArrival.Location = new System.Drawing.Point(124,76);
        this.TextBoxArrival.Size = new System.Drawing.Size(216,23);
        this.TextBoxArrival.TabIndex = 3;
        //
        // ButtonDeparture
        //
        this.ButtonDeparture.Text =  "Departure Date";
        this.ButtonDeparture.Location = new System.Drawing.Point(36,156);
        this.ButtonDeparture.Size = new System.Drawing.Size(136,23);
        this.ButtonDeparture.TabIndex = 4;
        this.ButtonDeparture.Click += new System.EventHandler(ButtonDeparture_Click);
        //
        // ButtonArrival
        //
        this.ButtonArrival.Text =  "Arrival Date";
        this.ButtonArrival.Location = new System.Drawing.Point(176,156);
        this.ButtonArrival.Size = new System.Drawing.Size(136,23);
        this.ButtonArrival.TabIndex = 5;
        this.ButtonArrival.Click += new System.EventHandler(ButtonArrival_Click);
        //
        // ButtonReset
        //
        this.ButtonReset.Text =  "Reset";
        this.ButtonReset.Location = new System.Drawing.Point(316,156);
        this.ButtonReset.TabIndex = 6;
        this.ButtonReset.Click += new System.EventHandler(ButtonReset_Click);
     //
     // form
     //
        this.Size = new System.Drawing.Size(429,240);
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text =  "Form1";
        this.Controls.Add(this.LabelDeparture);
        this.Controls.Add(this.LabelArrival);
        this.Controls.Add(this.TextBoxDeparture);
        this.Controls.Add(this.TextBoxArrival);
        this.Controls.Add(this.ButtonDeparture);
        this.Controls.Add(this.ButtonArrival);
        this.Controls.Add(this.ButtonReset);
        this.ResumeLayout(false);
    } 

    #endregion 

    private System.Windows.Forms.Label LabelDeparture;
    private System.Windows.Forms.Label LabelArrival;
    private System.Windows.Forms.TextBox TextBoxDeparture;
    private System.Windows.Forms.TextBox TextBoxArrival;
    private System.Windows.Forms.Button ButtonDeparture;
    private System.Windows.Forms.Button ButtonArrival;
    private System.Windows.Forms.Button ButtonReset;
}

// private void ButtonDeparture_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void ButtonArrival_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void ButtonReset_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

