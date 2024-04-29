namespace Te08;

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
        this.DaysAgo = new System.Windows.Forms.Button();
        this.DaysLater = new System.Windows.Forms.Button();
        this.day = new System.Windows.Forms.Label();
        this.Today = new System.Windows.Forms.Label();
        this.SuspendLayout();
        //
        // DaysAgo
        //
        this.DaysAgo.Text =  "10 days ago";
        this.DaysAgo.Location = new System.Drawing.Point(20,72);
        this.DaysAgo.Size = new System.Drawing.Size(116,48);
        this.DaysAgo.Click += new System.EventHandler(DaysAgo_Click);
        //
        // DaysLater
        //
        this.DaysLater.Text =  "10 days later";
        this.DaysLater.Location = new System.Drawing.Point(276,72);
        this.DaysLater.Size = new System.Drawing.Size(116,48);
        this.DaysLater.TabIndex = 1;
        this.DaysLater.Click += new System.EventHandler(DaysLater_Click);
        //
        // day
        //
        this.day.AutoSize =  true;
        this.day.Text =  "day, MMMM,  00, 0000";
        this.day.Location = new System.Drawing.Point(144,84);
        this.day.Size = new System.Drawing.Size(127,15);
        this.day.TabIndex = 2;
        //
        // Today
        //
        this.Today.AutoSize =  true;
        this.Today.Text =  "Today";
        this.Today.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.Today.Location = new System.Drawing.Point(176,20);
        this.Today.Size = new System.Drawing.Size(67,30);
        this.Today.TabIndex = 3;
     //
     // form
     //
        this.Size = new System.Drawing.Size(426,240);
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text =  "DateTime";
        this.Load += new System.EventHandler(Form1_Load);
        this.Controls.Add(this.DaysAgo);
        this.Controls.Add(this.DaysLater);
        this.Controls.Add(this.day);
        this.Controls.Add(this.Today);
        this.ResumeLayout(false);
    } 

    #endregion 

    private System.Windows.Forms.Button DaysAgo;
    private System.Windows.Forms.Button DaysLater;
    private System.Windows.Forms.Label day;
    private System.Windows.Forms.Label Today;
}

// private void DaysAgo_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void DaysLater_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void Form1_Load(System.Object? sender, System.EventArgs e)
// {
//
// }

