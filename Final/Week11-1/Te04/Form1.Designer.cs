namespace Te04;

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
        this.TextBoxItem = new System.Windows.Forms.TextBox();
        this.ListBoxItem = new System.Windows.Forms.ListBox();
        this.CheckedListBoxItem = new System.Windows.Forms.CheckedListBox();
        this.ButtonLeft = new System.Windows.Forms.Button();
        this.ButtonRight = new System.Windows.Forms.Button();
        this.ButtonAddComboBox = new System.Windows.Forms.Button();
        this.ComboBoxItem = new System.Windows.Forms.ComboBox();
        this.ButtonAddList = new System.Windows.Forms.Button();
        this.SuspendLayout();
        //
        // TextBoxItem
        //
        this.TextBoxItem.Text = "";
        this.TextBoxItem.SelectedText = "";
        this.TextBoxItem.SelectionLength = 8;
        this.TextBoxItem.Location = new System.Drawing.Point(12,8);
        this.TextBoxItem.Size = new System.Drawing.Size(120,23);
        //
        // ListBoxItem
        //
        this.ListBoxItem.ItemHeight = 15;
        this.ListBoxItem.Text =  "";
        this.ListBoxItem.Items.AddRange(new string[]{
            "Button", 
            "CheckBox", 
            "RadioButton", 
            "Label"
        });
        this.ListBoxItem.Location = new System.Drawing.Point(12,36);
        this.ListBoxItem.Size = new System.Drawing.Size(120,94);
        this.ListBoxItem.TabIndex = 1;
        //
        // CheckedListBoxItem
        //
        this.CheckedListBoxItem.HorizontalScrollbar =  true;
        this.CheckedListBoxItem.MultiColumn =  true;
        this.CheckedListBoxItem.Text =  "";
        this.CheckedListBoxItem.Items.AddRange(new string[]{
            "영화감상", 
            "음악감상", 
            "스키", 
            "스노우보드", 
            "수영", 
            "농구", 
            "장기", 
            "골프", 
            "바둑", 
            "축구"
        });
        this.CheckedListBoxItem.Location = new System.Drawing.Point(12,136);
        this.CheckedListBoxItem.Size = new System.Drawing.Size(240,58);
        this.CheckedListBoxItem.TabIndex = 3;
        //
        // ButtonLeft
        //
        this.ButtonLeft.Text =  "<<";
        this.ButtonLeft.Location = new System.Drawing.Point(172,56);
        this.ButtonLeft.TabIndex = 4;
        this.ButtonLeft.Click += new System.EventHandler(ButtonLeft_Click);
        //
        // ButtonRight
        //
        this.ButtonRight.Text =  ">>";
        this.ButtonRight.Location = new System.Drawing.Point(172,84);
        this.ButtonRight.TabIndex = 5;
        this.ButtonRight.Click += new System.EventHandler(ButtonRight_Click);
        //
        // ButtonAddComboBox
        //
        this.ButtonAddComboBox.Text =  "Add Combo Box";
        this.ButtonAddComboBox.Location = new System.Drawing.Point(160,8);
        this.ButtonAddComboBox.Size = new System.Drawing.Size(148,23);
        this.ButtonAddComboBox.TabIndex = 6;
        this.ButtonAddComboBox.Click += new System.EventHandler(ButtonAddComboBox_Click);
        //
        // ComboBoxItem
        //
        this.ComboBoxItem.DropDownWidth = 120;
        this.ComboBoxItem.ItemHeight = 15;
        this.ComboBoxItem.SelectedText =  "";
        this.ComboBoxItem.Items.AddRange(new string[]{
            "Button", 
            "CheckBox", 
            "RadioButton", 
            "Label"
        });
        this.ComboBoxItem.SelectionLength = 9;
        this.ComboBoxItem.Text =  "";
        this.ComboBoxItem.Location = new System.Drawing.Point(280,36);
        this.ComboBoxItem.Size = new System.Drawing.Size(120,23);
        this.ComboBoxItem.TabIndex = 7;
        //
        // ButtonAddList
        //
        this.ButtonAddList.Text =  "Add List";
        this.ButtonAddList.Location = new System.Drawing.Point(276,136);
        this.ButtonAddList.Size = new System.Drawing.Size(120,23);
        this.ButtonAddList.TabIndex = 8;
        this.ButtonAddList.Click += new System.EventHandler(ButtonAddList_Click);
     //
     // form
     //
        this.Size = new System.Drawing.Size(429,240);
        this.Text =  "Form1";
        this.Controls.Add(this.TextBoxItem);
        this.Controls.Add(this.ListBoxItem);
        this.Controls.Add(this.CheckedListBoxItem);
        this.Controls.Add(this.ButtonLeft);
        this.Controls.Add(this.ButtonRight);
        this.Controls.Add(this.ButtonAddComboBox);
        this.Controls.Add(this.ComboBoxItem);
        this.Controls.Add(this.ButtonAddList);
        this.ResumeLayout(false);
    } 

    #endregion 

    private System.Windows.Forms.TextBox TextBoxItem;
    private System.Windows.Forms.ListBox ListBoxItem;
    private System.Windows.Forms.CheckedListBox CheckedListBoxItem;
    private System.Windows.Forms.Button ButtonLeft;
    private System.Windows.Forms.Button ButtonRight;
    private System.Windows.Forms.Button ButtonAddComboBox;
    private System.Windows.Forms.ComboBox ComboBoxItem;
    private System.Windows.Forms.Button ButtonAddList;
}

// private void ButtonLeft_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void ButtonRight_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void ButtonAddComboBox_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void ButtonAddList_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

