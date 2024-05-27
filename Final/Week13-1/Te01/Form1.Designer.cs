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
        this.ListViewMain = new System.Windows.Forms.ListView();
        this.TextBoxResidence = new System.Windows.Forms.TextBox();
        this.TextBoxAge = new System.Windows.Forms.TextBox();
        this.TextBoxName = new System.Windows.Forms.TextBox();
        this.LabelName = new System.Windows.Forms.Label();
        this.LabelAge = new System.Windows.Forms.Label();
        this.LabelResidence = new System.Windows.Forms.Label();
        this.ButtonAdd = new System.Windows.Forms.Button();
        this.ButtonEdit = new System.Windows.Forms.Button();
        this.ButtonDelete = new System.Windows.Forms.Button();
        this.ButtonInsert = new System.Windows.Forms.Button();
        this.ButtonReset = new System.Windows.Forms.Button();
        this.SuspendLayout();
        //
        // ListViewMain
        //
        this.ListViewMain.Text = "";
        this.ListViewMain.Location = new System.Drawing.Point(8,8);
        this.ListViewMain.Size = new System.Drawing.Size(282,92);
        this.ListViewMain.GridLines = true;
        //
        // TextBoxResidence
        //
        this.TextBoxResidence.Text =  "";
        this.TextBoxResidence.Location = new System.Drawing.Point(72,176);
        this.TextBoxResidence.Size = new System.Drawing.Size(252,23);
        this.TextBoxResidence.TabIndex = 1;
        //
        // TextBoxAge
        //
        this.TextBoxAge.Text =  "";
        this.TextBoxAge.Location = new System.Drawing.Point(72,148);
        this.TextBoxAge.Size = new System.Drawing.Size(252,23);
        this.TextBoxAge.TabIndex = 2;
        //
        // TextBoxName
        //
        this.TextBoxName.Text =  "";
        this.TextBoxName.SelectedText =  "";
        this.TextBoxName.SelectionLength = 8;
        this.TextBoxName.Location = new System.Drawing.Point(72,120);
        this.TextBoxName.Size = new System.Drawing.Size(252,23);
        this.TextBoxName.TabIndex = 3;
        //
        // LabelName
        //
        this.LabelName.AutoSize =  true;
        this.LabelName.Text =  "Name";
        this.LabelName.Location = new System.Drawing.Point(12,124);
        this.LabelName.Size = new System.Drawing.Size(39,15);
        this.LabelName.TabIndex = 4;
        //
        // LabelAge
        //
        this.LabelAge.AutoSize =  true;
        this.LabelAge.Text =  "Age";
        this.LabelAge.Location = new System.Drawing.Point(12,152);
        this.LabelAge.Size = new System.Drawing.Size(28,15);
        this.LabelAge.TabIndex = 5;
        //
        // LabelResidence
        //
        this.LabelResidence.AutoSize =  true;
        this.LabelResidence.Text =  "Residence";
        this.LabelResidence.Location = new System.Drawing.Point(12,180);
        this.LabelResidence.Size = new System.Drawing.Size(60,15);
        this.LabelResidence.TabIndex = 6;
        //
        // ButtonAdd
        //
        this.ButtonAdd.Text =  "Add";
        this.ButtonAdd.Location = new System.Drawing.Point(328,8);
        this.ButtonAdd.TabIndex = 7;
        this.ButtonAdd.Click += new System.EventHandler(ButtonAdd_Click);
        //
        // ButtonEdit
        //
        this.ButtonEdit.Text =  "Edit";
        this.ButtonEdit.Location = new System.Drawing.Point(328,36);
        this.ButtonEdit.TabIndex = 8;
        this.ButtonEdit.Click += new System.EventHandler(ButtonEdit_Click);
        //
        // ButtonDelete
        //
        this.ButtonDelete.Text =  "Delete";
        this.ButtonDelete.Location = new System.Drawing.Point(328,64);
        this.ButtonDelete.TabIndex = 9;
        this.ButtonDelete.Click += new System.EventHandler(ButtonDelete_Click);
        //
        // ButtonInsert
        //
        this.ButtonInsert.Text =  "Insert";
        this.ButtonInsert.Location = new System.Drawing.Point(328,92);
        this.ButtonInsert.TabIndex = 10;
        this.ButtonInsert.Click += new System.EventHandler(ButtonInsert_Click);
        //
        // ButtonReset
        //
        this.ButtonReset.Text =  "Reset";
        this.ButtonReset.Location = new System.Drawing.Point(328,176);
        this.ButtonReset.TabIndex = 11;
        this.ButtonReset.Click += new System.EventHandler(ButtonReset_Click);
     //
     // form
     //
        this.Size = new System.Drawing.Size(429,240);
        this.Text =  "Form1";
        this.Controls.Add(this.ListViewMain);
        this.Controls.Add(this.TextBoxResidence);
        this.Controls.Add(this.TextBoxAge);
        this.Controls.Add(this.TextBoxName);
        this.Controls.Add(this.LabelName);
        this.Controls.Add(this.LabelAge);
        this.Controls.Add(this.LabelResidence);
        this.Controls.Add(this.ButtonAdd);
        this.Controls.Add(this.ButtonEdit);
        this.Controls.Add(this.ButtonDelete);
        this.Controls.Add(this.ButtonInsert);
        this.Controls.Add(this.ButtonReset);
        this.ResumeLayout(false);
    } 

    #endregion 

    private System.Windows.Forms.ListView ListViewMain;
    private System.Windows.Forms.TextBox TextBoxResidence;
    private System.Windows.Forms.TextBox TextBoxAge;
    private System.Windows.Forms.TextBox TextBoxName;
    private System.Windows.Forms.Label LabelName;
    private System.Windows.Forms.Label LabelAge;
    private System.Windows.Forms.Label LabelResidence;
    private System.Windows.Forms.Button ButtonAdd;
    private System.Windows.Forms.Button ButtonEdit;
    private System.Windows.Forms.Button ButtonDelete;
    private System.Windows.Forms.Button ButtonInsert;
    private System.Windows.Forms.Button ButtonReset;
}

// private void ButtonAdd_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void ButtonEdit_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void ButtonDelete_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void ButtonInsert_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void ButtonReset_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

