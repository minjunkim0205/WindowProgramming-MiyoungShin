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
        this.ButtonChangeColor = new System.Windows.Forms.Button();
        this.PanelColor = new System.Windows.Forms.Panel();
        this.PanelColor.SuspendLayout();
        this.SuspendLayout();
        //
        // ButtonChangeColor
        //
        this.ButtonChangeColor.Text =  "Change color";
        this.ButtonChangeColor.Location = new System.Drawing.Point(8,164);
        this.ButtonChangeColor.Size = new System.Drawing.Size(396,32);
        this.ButtonChangeColor.Click += new System.EventHandler(ButtonChangeColor_Click);
        //
        // PanelColor
        //
        this.PanelColor.Text =  "PanelColor";
        this.PanelColor.Location = new System.Drawing.Point(4,4);
        this.PanelColor.Size = new System.Drawing.Size(404,152);
        this.PanelColor.TabIndex = 1;
     //
     // form
     //
        this.Size = new System.Drawing.Size(429,240);
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text =  "Form1";
        this.Controls.Add(this.ButtonChangeColor);
        this.Controls.Add(this.PanelColor);
        this.PanelColor.ResumeLayout(false);
        this.ResumeLayout(false);
    } 

    #endregion 

    private System.Windows.Forms.Button ButtonChangeColor;
    private System.Windows.Forms.Panel PanelColor;
}

// private void ButtonChangeColor_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

