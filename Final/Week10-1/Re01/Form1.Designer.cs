namespace Re01;

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
        this.CheckBoxA = new System.Windows.Forms.CheckBox();
        this.CheckBoxB = new System.Windows.Forms.CheckBox();
        this.CheckBoxG = new System.Windows.Forms.CheckBox();
        this.CheckBoxD = new System.Windows.Forms.CheckBox();
        this.ButtonConfirm = new System.Windows.Forms.Button();
        this.SuspendLayout();
        //
        // CheckBoxA
        //
        this.CheckBoxA.AutoSize =  true;
        this.CheckBoxA.Text =  "Alpha(&A)";
        this.CheckBoxA.Location = new System.Drawing.Point(40,36);
        this.CheckBoxA.Size = new System.Drawing.Size(73,19);
        this.CheckBoxA.CheckedChanged += new System.EventHandler(CheckBoxA_CheckedChanged);
        //
        // CheckBoxB
        //
        this.CheckBoxB.AutoSize =  true;
        this.CheckBoxB.Text =  "Beta(&B)";
        this.CheckBoxB.Location = new System.Drawing.Point(40,56);
        this.CheckBoxB.Size = new System.Drawing.Size(64,19);
        this.CheckBoxB.TabIndex = 1;
        this.CheckBoxB.CheckedChanged += new System.EventHandler(CheckBoxB_CheckedChanged);
        //
        // CheckBoxG
        //
        this.CheckBoxG.AutoSize =  true;
        this.CheckBoxG.Text =  "Gamma(&G)";
        this.CheckBoxG.Location = new System.Drawing.Point(40,76);
        this.CheckBoxG.Size = new System.Drawing.Size(84,19);
        this.CheckBoxG.TabIndex = 3;
        this.CheckBoxG.CheckedChanged += new System.EventHandler(CheckBoxG_CheckedChanged);
                //
        // CheckBoxD
        //
        this.CheckBoxD.AutoSize =  true;
        this.CheckBoxD.Text =  "Delta(&D)";
        this.CheckBoxD.Location = new System.Drawing.Point(40,96);
        this.CheckBoxD.Size = new System.Drawing.Size(69,19);
        this.CheckBoxD.TabIndex = 2;
        this.CheckBoxD.CheckedChanged += new System.EventHandler(CheckBoxD_CheckedChanged);
        //
        // ButtonConfirm
        //
        this.ButtonConfirm.Text =  "Confirm";
        this.ButtonConfirm.Location = new System.Drawing.Point(296,148);
        this.ButtonConfirm.TabIndex = 4;
        this.ButtonConfirm.Click += new System.EventHandler(ButtonConfirm_Click);
     //
     // form
     //
        this.Size = new System.Drawing.Size(429,240);
        this.Text =  "Form1";
        this.Controls.Add(this.CheckBoxA);
        this.Controls.Add(this.CheckBoxB);
        this.Controls.Add(this.CheckBoxD);
        this.Controls.Add(this.CheckBoxG);
        this.Controls.Add(this.ButtonConfirm);
        this.ResumeLayout(false);
    } 

    #endregion 

    private System.Windows.Forms.CheckBox CheckBoxA;
    private System.Windows.Forms.CheckBox CheckBoxB;
    private System.Windows.Forms.CheckBox CheckBoxG;
    private System.Windows.Forms.CheckBox CheckBoxD;
    private System.Windows.Forms.Button ButtonConfirm;
}

// private void CheckBoxA_CheckedChanged(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void CheckBoxB_CheckedChanged(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void CheckBoxG_CheckedChanged(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void CheckBoxD_CheckedChanged(System.Object? sender, System.EventArgs e)
// {
// 
// }

// private void ButtonConfirm_Click(System.Object? sender, System.EventArgs e)
// {
// 
// }

