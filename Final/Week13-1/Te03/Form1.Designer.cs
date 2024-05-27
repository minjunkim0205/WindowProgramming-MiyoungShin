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
        this.LabelMain = new System.Windows.Forms.Label();
        this.LabelRedValue = new System.Windows.Forms.Label();
        this.LabelGreenValue = new System.Windows.Forms.Label();
        this.LabelBlueValue = new System.Windows.Forms.Label();
        this.LabelRed = new System.Windows.Forms.Label();
        this.LabelBlue = new System.Windows.Forms.Label();
        this.LabelGreen = new System.Windows.Forms.Label();
        this.TrackBarRed = new System.Windows.Forms.TrackBar();
        this.TrackBarGreen = new System.Windows.Forms.TrackBar();
        this.TrackBarBlue = new System.Windows.Forms.TrackBar();
        ((System.ComponentModel.ISupportInitialize)(this.TrackBarRed)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.TrackBarGreen)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.TrackBarBlue)).BeginInit();
        this.SuspendLayout();
        //
        // LabelMain
        //
        this.LabelMain.Text =  "";
        this.LabelMain.AutoSize = false;
        this.LabelMain.Location = new System.Drawing.Point(8,8);
        this.LabelMain.Size = new System.Drawing.Size(228,184);
        this.LabelMain.BackColor = Color.FromArgb(0, 0, 0);
        this.LabelMain.BorderStyle = BorderStyle.Fixed3D;
        //
        // LabelRedValue
        //
        this.LabelRedValue.AutoSize =  true;
        this.LabelRedValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.LabelRedValue.Text =  "0";
        this.LabelRedValue.Location = new System.Drawing.Point(256,16);
        this.LabelRedValue.Size = new System.Drawing.Size(13,15);
        this.LabelRedValue.TabIndex = 1;
        //
        // LabelGreenValue
        //
        this.LabelGreenValue.AutoSize =  true;
        this.LabelGreenValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.LabelGreenValue.Text =  "0";
        this.LabelGreenValue.Location = new System.Drawing.Point(316,16);
        this.LabelGreenValue.Size = new System.Drawing.Size(13,15);
        this.LabelGreenValue.TabIndex = 2;
        //
        // LabelBlueValue
        //
        this.LabelBlueValue.AutoSize =  true;
        this.LabelBlueValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.LabelBlueValue.Text =  "0";
        this.LabelBlueValue.Location = new System.Drawing.Point(376,16);
        this.LabelBlueValue.Size = new System.Drawing.Size(13,15);
        this.LabelBlueValue.TabIndex = 3;
        //
        // LabelRed
        //
        this.LabelRed.AutoSize =  true;
        this.LabelRed.Text =  "Red";
        this.LabelRed.Location = new System.Drawing.Point(248,172);
        this.LabelRed.Size = new System.Drawing.Size(27,15);
        this.LabelRed.TabIndex = 4;
        //
        // LabelBlue
        //
        this.LabelBlue.AutoSize =  true;
        this.LabelBlue.Text =  "Blue";
        this.LabelBlue.Location = new System.Drawing.Point(364,172);
        this.LabelBlue.Size = new System.Drawing.Size(30,15);
        this.LabelBlue.TabIndex = 5;
        //
        // LabelGreen
        //
        this.LabelGreen.AutoSize =  true;
        this.LabelGreen.Text =  "Green";
        this.LabelGreen.Location = new System.Drawing.Point(300,172);
        this.LabelGreen.Size = new System.Drawing.Size(38,15);
        this.LabelGreen.TabIndex = 6;
        //
        // TrackBarRed
        //
        this.TrackBarRed.Maximum = 255;
        this.TrackBarRed.Orientation = System.Windows.Forms.Orientation.Vertical;
        this.TrackBarRed.Text =  "TrackBarRed";
        this.TrackBarRed.TickFrequency = 20;
        this.TrackBarRed.Value = 0;
        this.TrackBarRed.Location = new System.Drawing.Point(240,36);
        this.TrackBarRed.Size = new System.Drawing.Size(45,132);
        this.TrackBarRed.TabIndex = 7;
        this.TrackBarRed.TickStyle = TickStyle.Both;
        this.TrackBarRed.ValueChanged += new System.EventHandler(TrackBar_ValueChanged);
        //
        // TrackBarGreen
        //
        this.TrackBarGreen.Maximum = 255;
        this.TrackBarGreen.Orientation = System.Windows.Forms.Orientation.Vertical;
        this.TrackBarGreen.Text =  "TrackBarGreen";
        this.TrackBarGreen.TickFrequency = 20;
        this.TrackBarGreen.Value = 0;
        this.TrackBarGreen.Location = new System.Drawing.Point(300,36);
        this.TrackBarGreen.Size = new System.Drawing.Size(45,132);
        this.TrackBarGreen.TabIndex = 8;
        this.TrackBarGreen.TickStyle = TickStyle.Both;
        this.TrackBarGreen.ValueChanged += new System.EventHandler(TrackBar_ValueChanged);
        //
        // TrackBarBlue
        //
        this.TrackBarBlue.Maximum = 255;
        this.TrackBarBlue.Orientation = System.Windows.Forms.Orientation.Vertical;
        this.TrackBarBlue.Text =  "TrackBarBlue";
        this.TrackBarBlue.TickFrequency = 20;
        this.TrackBarBlue.Value = 0;
        this.TrackBarBlue.Location = new System.Drawing.Point(360,36);
        this.TrackBarBlue.Size = new System.Drawing.Size(45,132);
        this.TrackBarBlue.TabIndex = 9;
        this.TrackBarBlue.TickStyle = TickStyle.Both;
        this.TrackBarBlue.ValueChanged += new System.EventHandler(TrackBar_ValueChanged);
     //
     // form
     //
        this.Size = new System.Drawing.Size(429,240);
        this.Text =  "Form1";
        this.Controls.Add(this.LabelMain);
        this.Controls.Add(this.LabelRedValue);
        this.Controls.Add(this.LabelGreenValue);
        this.Controls.Add(this.LabelBlueValue);
        this.Controls.Add(this.LabelRed);
        this.Controls.Add(this.LabelBlue);
        this.Controls.Add(this.LabelGreen);
        this.Controls.Add(this.TrackBarRed);
        this.Controls.Add(this.TrackBarGreen);
        this.Controls.Add(this.TrackBarBlue);
        ((System.ComponentModel.ISupportInitialize)(this.TrackBarRed)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.TrackBarGreen)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.TrackBarBlue)).EndInit();
        this.ResumeLayout(false);
    } 

    #endregion 

    private System.Windows.Forms.Label LabelMain;
    private System.Windows.Forms.Label LabelRedValue;
    private System.Windows.Forms.Label LabelGreenValue;
    private System.Windows.Forms.Label LabelBlueValue;
    private System.Windows.Forms.Label LabelRed;
    private System.Windows.Forms.Label LabelBlue;
    private System.Windows.Forms.Label LabelGreen;
    private System.Windows.Forms.TrackBar TrackBarRed;
    private System.Windows.Forms.TrackBar TrackBarGreen;
    private System.Windows.Forms.TrackBar TrackBarBlue;
}

// private void TrackBar_ValueChanged(System.Object? sender, System.EventArgs e)
// {
// 
// }

