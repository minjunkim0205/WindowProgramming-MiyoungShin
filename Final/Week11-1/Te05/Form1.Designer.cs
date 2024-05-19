namespace Te05;

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
        this.LabelAdmission = new System.Windows.Forms.Label();
        this.TextBoxName = new System.Windows.Forms.TextBox();
        this.ComboBoxAdmission = new System.Windows.Forms.ComboBox();
        this.ListBoxResult = new System.Windows.Forms.ListBox();
        this.ButtonAdd = new System.Windows.Forms.Button();
        this.ButtonDelete = new System.Windows.Forms.Button();
        this.ButtonExit = new System.Windows.Forms.Button();
        this.GroupBoxGrade = new System.Windows.Forms.GroupBox();
        this.GroupBoxSubject = new System.Windows.Forms.GroupBox();
        this.RadioButtonA = new System.Windows.Forms.RadioButton();
        this.RadioButtonB = new System.Windows.Forms.RadioButton();
        this.RadioButtonC = new System.Windows.Forms.RadioButton();
        this.RadioButtonD = new System.Windows.Forms.RadioButton();
        this.RadioButtonF = new System.Windows.Forms.RadioButton();
        this.CheckBoxC = new System.Windows.Forms.CheckBox();
        this.CheckBoxCpp = new System.Windows.Forms.CheckBox();
        this.CheckBoxJava = new System.Windows.Forms.CheckBox();
        this.CheckBoxRust = new System.Windows.Forms.CheckBox();
        this.CheckBoxPython = new System.Windows.Forms.CheckBox();
        this.GroupBoxGrade.SuspendLayout();
        this.GroupBoxSubject.SuspendLayout();
        this.SuspendLayout();
        //
        // LabelName
        //
        this.LabelName.AutoSize =  true;
        this.LabelName.Text =  "Name";
        this.LabelName.Location = new System.Drawing.Point(8,8);
        this.LabelName.Size = new System.Drawing.Size(39,15);
        //
        // LabelAdmission
        //
        this.LabelAdmission.AutoSize =  true;
        this.LabelAdmission.Text =  "Admission";
        this.LabelAdmission.Location = new System.Drawing.Point(8,32);
        this.LabelAdmission.Size = new System.Drawing.Size(63,15);
        this.LabelAdmission.TabIndex = 1;
        //
        // TextBoxName
        //
        this.TextBoxName.Text =  "";
        this.TextBoxName.Location = new System.Drawing.Point(72,4);
        this.TextBoxName.Size = new System.Drawing.Size(120,23);
        this.TextBoxName.TabIndex = 2;
        //
        // ComboBoxAdmission
        //
        this.ComboBoxAdmission.ItemHeight = 15;
        this.ComboBoxAdmission.Location = new System.Drawing.Point(72,28);
        this.ComboBoxAdmission.TabIndex = 3;
        //
        // ListBoxResult
        //
        this.ListBoxResult.HorizontalScrollbar =  true;
        this.ListBoxResult.ItemHeight = 15;
        this.ListBoxResult.ScrollAlwaysVisible =  true;
        //this.ListBoxResult.SelectedIndex = 0;
        this.ListBoxResult.Text =  "ListBox";
        this.ListBoxResult.Location = new System.Drawing.Point(204,4);
        this.ListBoxResult.Size = new System.Drawing.Size(200,169);
        this.ListBoxResult.TabIndex = 4;
        //
        // ButtonAdd
        //
        this.ButtonAdd.Text =  "Add";
        this.ButtonAdd.Location = new System.Drawing.Point(204,176);
        this.ButtonAdd.Size = new System.Drawing.Size(64,24);
        this.ButtonAdd.TabIndex = 5;
        this.ButtonAdd.Click += new System.EventHandler(ButtonAdd_Click);
        //
        // ButtonDelete
        //
        this.ButtonDelete.Text =  "Delete";
        this.ButtonDelete.Location = new System.Drawing.Point(272,176);
        this.ButtonDelete.Size = new System.Drawing.Size(64,24);
        this.ButtonDelete.TabIndex = 6;
        this.ButtonDelete.Click += new System.EventHandler(ButtonDelete_Click);
        //
        // ButtonExit
        //
        this.ButtonExit.Text =  "Exit";
        this.ButtonExit.Location = new System.Drawing.Point(340,176);
        this.ButtonExit.Size = new System.Drawing.Size(64,24);
        this.ButtonExit.TabIndex = 7;
        this.ButtonExit.Click += new System.EventHandler(ButtonExit_Click);
        //
        // GroupBoxGrade
        //
        this.GroupBoxGrade.Controls.Add(this.RadioButtonA);
        this.GroupBoxGrade.Controls.Add(this.RadioButtonB);
        this.GroupBoxGrade.Controls.Add(this.RadioButtonC);
        this.GroupBoxGrade.Controls.Add(this.RadioButtonD);
        this.GroupBoxGrade.Controls.Add(this.RadioButtonF);
        this.GroupBoxGrade.Text =  "Grade";
        this.GroupBoxGrade.Location = new System.Drawing.Point(12,56);
        this.GroupBoxGrade.Size = new System.Drawing.Size(52,132);
        this.GroupBoxGrade.TabIndex = 8;
        //
        // GroupBoxSubject
        //
        this.GroupBoxSubject.Controls.Add(this.CheckBoxC);
        this.GroupBoxSubject.Controls.Add(this.CheckBoxCpp);
        this.GroupBoxSubject.Controls.Add(this.CheckBoxJava);
        this.GroupBoxSubject.Controls.Add(this.CheckBoxRust);
        this.GroupBoxSubject.Controls.Add(this.CheckBoxPython);
        this.GroupBoxSubject.Text =  "Subject";
        this.GroupBoxSubject.Location = new System.Drawing.Point(72,56);
        this.GroupBoxSubject.Size = new System.Drawing.Size(120,132);
        this.GroupBoxSubject.TabIndex = 9;
        //
        // RadioButtonA
        //
        this.RadioButtonA.Checked =  true;
        this.RadioButtonA.TabStop =  true;
        this.RadioButtonA.AutoSize =  true;
        this.RadioButtonA.Text =  "A";
        this.RadioButtonA.Location = new System.Drawing.Point(8,12);
        this.RadioButtonA.Size = new System.Drawing.Size(33,19);
        this.RadioButtonA.TabIndex = 16;
        //
        // RadioButtonB
        //
        this.RadioButtonB.AutoSize =  true;
        this.RadioButtonB.Text =  "B";
        this.RadioButtonB.Location = new System.Drawing.Point(8,36);
        this.RadioButtonB.Size = new System.Drawing.Size(32,19);
        this.RadioButtonB.TabIndex = 17;
        //
        // RadioButtonC
        //
        this.RadioButtonC.AutoSize =  true;
        this.RadioButtonC.Text =  "C";
        this.RadioButtonC.Location = new System.Drawing.Point(8,60);
        this.RadioButtonC.Size = new System.Drawing.Size(33,19);
        this.RadioButtonC.TabIndex = 18;
        //
        // RadioButtonD
        //
        this.RadioButtonD.AutoSize =  true;
        this.RadioButtonD.Text =  "D";
        this.RadioButtonD.Location = new System.Drawing.Point(8,84);
        this.RadioButtonD.Size = new System.Drawing.Size(33,19);
        this.RadioButtonD.TabIndex = 19;
        //
        // RadioButtonF
        //
        this.RadioButtonF.AutoSize =  true;
        this.RadioButtonF.Text =  "F";
        this.RadioButtonF.Location = new System.Drawing.Point(8,108);
        this.RadioButtonF.Size = new System.Drawing.Size(31,19);
        this.RadioButtonF.TabIndex = 20;
        //
        // CheckBoxC
        //
        this.CheckBoxC.AutoSize =  true;
        this.CheckBoxC.Text =  "C";
        this.CheckBoxC.Location = new System.Drawing.Point(8,12);
        this.CheckBoxC.Size = new System.Drawing.Size(34,19);
        this.CheckBoxC.TabIndex = 21;
        //
        // CheckBoxCpp
        //
        this.CheckBoxCpp.AutoSize =  true;
        this.CheckBoxCpp.Text =  "Cpp";
        this.CheckBoxCpp.Location = new System.Drawing.Point(8,36);
        this.CheckBoxCpp.Size = new System.Drawing.Size(48,19);
        this.CheckBoxCpp.TabIndex = 22;
        //
        // CheckBoxJava
        //
        this.CheckBoxJava.AutoSize =  true;
        this.CheckBoxJava.Text =  "Java";
        this.CheckBoxJava.Location = new System.Drawing.Point(8,84);
        this.CheckBoxJava.Size = new System.Drawing.Size(48,19);
        this.CheckBoxJava.TabIndex = 23;
        //
        // CheckBoxRust
        //
        this.CheckBoxRust.AutoSize =  true;
        this.CheckBoxRust.Text =  "Rust";
        this.CheckBoxRust.Location = new System.Drawing.Point(8,108);
        this.CheckBoxRust.Size = new System.Drawing.Size(49,19);
        this.CheckBoxRust.TabIndex = 24;
        //
        // CheckBoxPython
        //
        this.CheckBoxPython.AutoSize =  true;
        this.CheckBoxPython.Text =  "Python";
        this.CheckBoxPython.Location = new System.Drawing.Point(8,60);
        this.CheckBoxPython.Size = new System.Drawing.Size(64,19);
        this.CheckBoxPython.TabIndex = 25;
     //
     // form
     //
        this.Size = new System.Drawing.Size(429,240);
        this.Text =  "Form1";
        this.Load += new System.EventHandler(Form1_Load);
        this.Controls.Add(this.LabelName);
        this.Controls.Add(this.LabelAdmission);
        this.Controls.Add(this.TextBoxName);
        this.Controls.Add(this.ComboBoxAdmission);
        this.Controls.Add(this.ListBoxResult);
        this.Controls.Add(this.ButtonAdd);
        this.Controls.Add(this.ButtonDelete);
        this.Controls.Add(this.ButtonExit);
        this.Controls.Add(this.GroupBoxGrade);
        this.Controls.Add(this.GroupBoxSubject);
        this.GroupBoxGrade.ResumeLayout(false);
        this.GroupBoxSubject.ResumeLayout(false);
        this.ResumeLayout(false);
    } 

    #endregion 

    private System.Windows.Forms.Label LabelName;
    private System.Windows.Forms.Label LabelAdmission;
    private System.Windows.Forms.TextBox TextBoxName;
    private System.Windows.Forms.ComboBox ComboBoxAdmission;
    private System.Windows.Forms.ListBox ListBoxResult;
    private System.Windows.Forms.Button ButtonAdd;
    private System.Windows.Forms.Button ButtonDelete;
    private System.Windows.Forms.Button ButtonExit;
    private System.Windows.Forms.GroupBox GroupBoxGrade;
    private System.Windows.Forms.GroupBox GroupBoxSubject;
    private System.Windows.Forms.RadioButton RadioButtonA;
    private System.Windows.Forms.RadioButton RadioButtonB;
    private System.Windows.Forms.RadioButton RadioButtonC;
    private System.Windows.Forms.RadioButton RadioButtonD;
    private System.Windows.Forms.RadioButton RadioButtonF;
    private System.Windows.Forms.CheckBox CheckBoxC;
    private System.Windows.Forms.CheckBox CheckBoxCpp;
    private System.Windows.Forms.CheckBox CheckBoxJava;
    private System.Windows.Forms.CheckBox CheckBoxRust;
    private System.Windows.Forms.CheckBox CheckBoxPython;
}

// private void ButtonAdd_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void ButtonDelete_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void ButtonExit_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void Form1_Load(System.Object? sender, System.EventArgs e)
// {
//
// }

