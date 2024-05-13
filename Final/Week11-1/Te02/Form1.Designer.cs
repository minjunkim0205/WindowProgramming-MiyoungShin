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
        this.LabelName = new System.Windows.Forms.Label();
        this.LabelResidence = new System.Windows.Forms.Label();
        this.LabelPassword = new System.Windows.Forms.Label();
        this.TextBoxName = new System.Windows.Forms.TextBox();
        this.TextBoxPassword = new System.Windows.Forms.TextBox();
        this.ComboBoxResidence = new System.Windows.Forms.ComboBox();
        this.GroupBoxLanguage = new System.Windows.Forms.GroupBox();
        this.CheckBoxCSharp = new System.Windows.Forms.CheckBox();
        this.CheckBoxPython = new System.Windows.Forms.CheckBox();
        this.CheckBoxC = new System.Windows.Forms.CheckBox();
        this.CheckBoxJava = new System.Windows.Forms.CheckBox();
        this.CheckBoxCpp = new System.Windows.Forms.CheckBox();
        this.CheckBoxRust = new System.Windows.Forms.CheckBox();
        this.ButtonExit = new System.Windows.Forms.Button();
        this.ButtonReset = new System.Windows.Forms.Button();
        this.ListBoxData = new System.Windows.Forms.ListBox();
        this.ButtonAdd = new System.Windows.Forms.Button();
        this.ButtonDelete = new System.Windows.Forms.Button();
        this.ButtonFind = new System.Windows.Forms.Button();
        this.GroupBoxLanguage.SuspendLayout();
        this.SuspendLayout();
        //
        // LabelName
        //
        this.LabelName.AutoSize =  true;
        this.LabelName.Text =  "Name";
        this.LabelName.Location = new System.Drawing.Point(16,8);
        this.LabelName.Size = new System.Drawing.Size(39,15);
        //
        // LabelResidence
        //
        this.LabelResidence.AutoSize =  true;
        this.LabelResidence.Text =  "Residence";
        this.LabelResidence.Location = new System.Drawing.Point(16,32);
        this.LabelResidence.Size = new System.Drawing.Size(60,15);
        this.LabelResidence.TabIndex = 1;
        //
        // LabelPassword
        //
        this.LabelPassword.AutoSize =  true;
        this.LabelPassword.Text =  "Password";
        this.LabelPassword.Location = new System.Drawing.Point(16,56);
        this.LabelPassword.Size = new System.Drawing.Size(57,15);
        this.LabelPassword.TabIndex = 2;
        //
        // TextBoxName
        //
        this.TextBoxName.Text =  "";
        this.TextBoxName.Location = new System.Drawing.Point(88,4);
        this.TextBoxName.Size = new System.Drawing.Size(136,23);
        this.TextBoxName.TabIndex = 3;
        //
        // TextBoxPassword
        //
        this.TextBoxPassword.Text =  "";
        this.TextBoxPassword.Location = new System.Drawing.Point(88,52);
        this.TextBoxPassword.PasswordChar = '*';
        this.TextBoxPassword.Size = new System.Drawing.Size(136,23);
        this.TextBoxPassword.TabIndex = 5;
        //
        // ComboBoxResidence
        //
        this.ComboBoxResidence.DropDownWidth = 136;
        this.ComboBoxResidence.ItemHeight = 15;
        this.ComboBoxResidence.Text =  "";
        this.ComboBoxResidence.Items.AddRange(new string[]{"서울", "춘천", "대전", "부산"});
        this.ComboBoxResidence.Location = new System.Drawing.Point(88,28);
        this.ComboBoxResidence.DropDownStyle = ComboBoxStyle.DropDownList;
        this.ComboBoxResidence.Size = new System.Drawing.Size(136,23);
        this.ComboBoxResidence.TabIndex = 6;
        //
        // GroupBoxLanguage
        //
        this.GroupBoxLanguage.Controls.Add(this.CheckBoxCSharp);
        this.GroupBoxLanguage.Controls.Add(this.CheckBoxPython);
        this.GroupBoxLanguage.Controls.Add(this.CheckBoxC);
        this.GroupBoxLanguage.Controls.Add(this.CheckBoxJava);
        this.GroupBoxLanguage.Controls.Add(this.CheckBoxCpp);
        this.GroupBoxLanguage.Controls.Add(this.CheckBoxRust);
        this.GroupBoxLanguage.Text =  "Preferred Languag";
        this.GroupBoxLanguage.Location = new System.Drawing.Point(16,80);
        this.GroupBoxLanguage.Size = new System.Drawing.Size(208,92);
        this.GroupBoxLanguage.TabIndex = 7;
        //
        // CheckBoxCSharp
        //
        this.CheckBoxCSharp.AutoSize =  true;
        this.CheckBoxCSharp.Text =  "C#";
        this.CheckBoxCSharp.Location = new System.Drawing.Point(8,64);
        this.CheckBoxCSharp.Size = new System.Drawing.Size(41,19);
        this.CheckBoxCSharp.TabIndex = 9;
        //
        // CheckBoxPython
        //
        this.CheckBoxPython.AutoSize =  true;
        this.CheckBoxPython.Text =  "Python";
        this.CheckBoxPython.Location = new System.Drawing.Point(8,16);
        this.CheckBoxPython.Size = new System.Drawing.Size(64,19);
        this.CheckBoxPython.TabIndex = 11;
        //
        // CheckBoxC
        //
        this.CheckBoxC.AutoSize =  true;
        this.CheckBoxC.Text =  "C";
        this.CheckBoxC.Location = new System.Drawing.Point(8,40);
        this.CheckBoxC.Size = new System.Drawing.Size(34,19);
        this.CheckBoxC.TabIndex = 12;
        //
        // CheckBoxJava
        //
        this.CheckBoxJava.AutoSize =  true;
        this.CheckBoxJava.Text =  "Java";
        this.CheckBoxJava.Location = new System.Drawing.Point(112,16);
        this.CheckBoxJava.Size = new System.Drawing.Size(48,19);
        this.CheckBoxJava.TabIndex = 14;
        //
        // CheckBoxCpp
        //
        this.CheckBoxCpp.AutoSize =  true;
        this.CheckBoxCpp.Text =  "C++";
        this.CheckBoxCpp.Location = new System.Drawing.Point(112,40);
        this.CheckBoxCpp.Size = new System.Drawing.Size(50,19);
        this.CheckBoxCpp.TabIndex = 15;
        //
        // CheckBoxRust
        //
        this.CheckBoxRust.AutoSize =  true;
        this.CheckBoxRust.Text =  "Rust";
        this.CheckBoxRust.Location = new System.Drawing.Point(112,64);
        this.CheckBoxRust.Size = new System.Drawing.Size(49,19);
        this.CheckBoxRust.TabIndex = 16;
        //
        // ButtonExit
        //
        this.ButtonExit.Text =  "Exit";
        this.ButtonExit.Location = new System.Drawing.Point(40,176);
        this.ButtonExit.TabIndex = 17;
        this.ButtonExit.Click += new System.EventHandler(ButtonExit_Click);
        //
        // ButtonReset
        //
        this.ButtonReset.Text =  "Reset";
        this.ButtonReset.Location = new System.Drawing.Point(124,176);
        this.ButtonReset.TabIndex = 18;
        this.ButtonReset.Click += new System.EventHandler(ButtonReset_Click);
        //
        // ListBoxData
        //
        this.ListBoxData.HorizontalScrollbar =  true;
        this.ListBoxData.ItemHeight = 15;
        this.ListBoxData.ScrollAlwaysVisible =  true;
        this.ListBoxData.SelectedIndex = -1;
        this.ListBoxData.Location = new System.Drawing.Point(236,40);
        this.ListBoxData.Size = new System.Drawing.Size(168,154);
        this.ListBoxData.Text =  "";
        this.ListBoxData.TabIndex = 19;
        //
        // ButtonAdd
        //
        this.ButtonAdd.Text =  "Add";
        this.ButtonAdd.Location = new System.Drawing.Point(236,12);
        this.ButtonAdd.Size = new System.Drawing.Size(56,23);
        this.ButtonAdd.TabIndex = 20;
        this.ButtonAdd.Click += new System.EventHandler(ButtonAdd_Click);
        //
        // ButtonDelete
        //
        this.ButtonDelete.Text =  "Delete";
        this.ButtonDelete.Location = new System.Drawing.Point(348,12);
        this.ButtonDelete.Size = new System.Drawing.Size(56,23);
        this.ButtonDelete.TabIndex = 21;
        this.ButtonDelete.Click += new System.EventHandler(ButtonDelete_Click);
        //
        // ButtonFind
        //
        this.ButtonFind.Text =  "Find";
        this.ButtonFind.Location = new System.Drawing.Point(292,12);
        this.ButtonFind.Size = new System.Drawing.Size(56,23);
        this.ButtonFind.TabIndex = 22;
        this.ButtonFind.Click += new System.EventHandler(ButtonFind_Click);
     //
     // form
     //
        this.Size = new System.Drawing.Size(429,240);
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text =  "Form1";
        this.Controls.Add(this.LabelName);
        this.Controls.Add(this.LabelResidence);
        this.Controls.Add(this.LabelPassword);
        this.Controls.Add(this.TextBoxName);
        this.Controls.Add(this.TextBoxPassword);
        this.Controls.Add(this.ComboBoxResidence);
        this.Controls.Add(this.GroupBoxLanguage);
        this.Controls.Add(this.ButtonExit);
        this.Controls.Add(this.ButtonReset);
        this.Controls.Add(this.ListBoxData);
        this.Controls.Add(this.ButtonAdd);
        this.Controls.Add(this.ButtonDelete);
        this.Controls.Add(this.ButtonFind);
        this.GroupBoxLanguage.ResumeLayout(false);
        this.ResumeLayout(false);
    } 

    #endregion 

    private System.Windows.Forms.Label LabelName;
    private System.Windows.Forms.Label LabelResidence;
    private System.Windows.Forms.Label LabelPassword;
    private System.Windows.Forms.TextBox TextBoxName;
    private System.Windows.Forms.TextBox TextBoxPassword;
    private System.Windows.Forms.ComboBox ComboBoxResidence;
    private System.Windows.Forms.GroupBox GroupBoxLanguage;
    private System.Windows.Forms.CheckBox CheckBoxCSharp;
    private System.Windows.Forms.CheckBox CheckBoxPython;
    private System.Windows.Forms.CheckBox CheckBoxC;
    private System.Windows.Forms.CheckBox CheckBoxJava;
    private System.Windows.Forms.CheckBox CheckBoxCpp;
    private System.Windows.Forms.CheckBox CheckBoxRust;
    private System.Windows.Forms.Button ButtonExit;
    private System.Windows.Forms.Button ButtonReset;
    private System.Windows.Forms.ListBox ListBoxData;
    private System.Windows.Forms.Button ButtonAdd;
    private System.Windows.Forms.Button ButtonDelete;
    private System.Windows.Forms.Button ButtonFind;
}

// private void ButtonExit_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void ButtonReset_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void ButtonAdd_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void ButtonDelete_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void ButtonFind_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

