namespace Te07;

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
        this.FixedSingle = new System.Windows.Forms.Button();
        this.None = new System.Windows.Forms.Button();
        this.FixedDialog = new System.Windows.Forms.Button();
        this.FixedToolWindow = new System.Windows.Forms.Button();
        this.SuspendLayout();
        //
        // FixedSingle
        //
        this.FixedSingle.Text =  "FixedSingle";
        this.FixedSingle.Location = new System.Drawing.Point(24,24);
        this.FixedSingle.Size = new System.Drawing.Size(176,72);
        this.FixedSingle.Click += new System.EventHandler(FixedSingle_Click);
        //
        // None
        //
        this.None.Text =  "None";
        this.None.Location = new System.Drawing.Point(212,24);
        this.None.Size = new System.Drawing.Size(176,72);
        this.None.TabIndex = 1;
        this.None.Click += new System.EventHandler(None_Click);
        //
        // FixedDialog
        //
        this.FixedDialog.Text =  "FixedDialog";
        this.FixedDialog.Location = new System.Drawing.Point(24,108);
        this.FixedDialog.Size = new System.Drawing.Size(176,72);
        this.FixedDialog.TabIndex = 2;
        this.FixedDialog.Click += new System.EventHandler(FixedDialog_Click);
        //
        // FixedToolWindow
        //
        this.FixedToolWindow.Text =  "FixedToolWindow";
        this.FixedToolWindow.Location = new System.Drawing.Point(212,108);
        this.FixedToolWindow.Size = new System.Drawing.Size(176,72);
        this.FixedToolWindow.TabIndex = 3;
        this.FixedToolWindow.Click += new System.EventHandler(FixedToolWindow_Click);
     //
     // form
     //
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        this.Size = new System.Drawing.Size(410,201);
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text =  "None";
        this.Controls.Add(this.FixedSingle);
        this.Controls.Add(this.None);
        this.Controls.Add(this.FixedDialog);
        this.Controls.Add(this.FixedToolWindow);
        this.ResumeLayout(false);
    } 

    #endregion 

    private System.Windows.Forms.Button FixedSingle;
    private System.Windows.Forms.Button None;
    private System.Windows.Forms.Button FixedDialog;
    private System.Windows.Forms.Button FixedToolWindow;
}

// private void FixedSingle_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void None_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void FixedDialog_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void FixedToolWindow_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

