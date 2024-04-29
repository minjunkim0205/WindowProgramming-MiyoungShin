namespace Te06;

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
        this.ActivationTimer = new System.Windows.Forms.Timer();
        this.ActivationTimeLabel = new System.Windows.Forms.Label();
        this.SuspendLayout();
        //
        // ActivationTimer
        //
        this.ActivationTimer.Interval = 10;
        this.ActivationTimer.Tick += new System.EventHandler(ActivationTimer_Tick);
        //
        // ActivationTimeLabel
        //
        this.ActivationTimeLabel.AutoSize =  true;
        this.ActivationTimeLabel.Text =  "00:00:00.0000000";
        this.ActivationTimeLabel.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.ActivationTimeLabel.Location = new System.Drawing.Point(36,60);
        this.ActivationTimeLabel.Size = new System.Drawing.Size(351,59);
        this.ActivationTimeLabel.TabIndex = 1;
     //
     // form
     //
        this.Size = new System.Drawing.Size(426,240);
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text =  "Load Close Time";
        this.Load += new System.EventHandler(Form1_Load);
        this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(Form1_FormClosed);
        this.Shown += new System.EventHandler(Form1_Shown);
        this.Controls.Add(this.ActivationTimeLabel);
        this.ResumeLayout(false);
    } 

    #endregion 

    private System.Windows.Forms.Timer ActivationTimer;
    private System.Windows.Forms.Label ActivationTimeLabel;
}

// private void ActivationTimer_Tick(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void Form1_Load(System.Object? sender, System.EventArgs e)
// {
//
// }

// private void Form1_FormClosed(System.Object? sender, System.Windows.Forms.FormClosedEventArgs e)
// {
//
// }

// private void Form1_Shown(System.Object? sender, System.EventArgs e)
// {
//
// }

