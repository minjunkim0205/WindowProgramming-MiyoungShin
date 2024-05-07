namespace Re04;

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
        this.ListBox = new System.Windows.Forms.ListBox();
        this.ButtonAdd = new System.Windows.Forms.Button();
        this.ButtonRemove = new System.Windows.Forms.Button();
        this.TextBox = new System.Windows.Forms.TextBox();
        this.SuspendLayout();
        //
        // ListBox
        //
        this.ListBox.ItemHeight = 15;
        this.ListBox.Text =  "";
        this.ListBox.Location = new System.Drawing.Point(32,64);
        this.ListBox.Size = new System.Drawing.Size(248,94);
        //
        // ButtonAdd
        //
        this.ButtonAdd.Text =  "Add";
        this.ButtonAdd.Location = new System.Drawing.Point(308,28);
        this.ButtonAdd.TabIndex = 2;
        this.ButtonAdd.Click += new System.EventHandler(ButtonAdd_Click);
        //
        // ButtonRemove
        //
        this.ButtonRemove.Text =  "Remove";
        this.ButtonRemove.Location = new System.Drawing.Point(308,64);
        this.ButtonRemove.TabIndex = 3;
        this.ButtonRemove.Click += new System.EventHandler(ButtonRemove_Click);
        //
        // TextBox
        //
        this.TextBox.Location = new System.Drawing.Point(32,28);
        this.TextBox.Size = new System.Drawing.Size(248,23);
        this.TextBox.TabIndex = 4;
     //
     // form
     //
        this.Size = new System.Drawing.Size(429,240);
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text =  "Form1";
        this.Controls.Add(this.ListBox);
        this.Controls.Add(this.ButtonAdd);
        this.Controls.Add(this.ButtonRemove);
        this.Controls.Add(this.TextBox);
        this.ResumeLayout(false);
    } 

    #endregion 

    private System.Windows.Forms.ListBox ListBox;
    private System.Windows.Forms.Button ButtonAdd;
    private System.Windows.Forms.Button ButtonRemove;
    private System.Windows.Forms.TextBox TextBox;
}

// private void ButtonAdd_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void ButtonRemove_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

