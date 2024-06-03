namespace Te02
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxPw = new System.Windows.Forms.TextBox();
            this.labelPw = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 15);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "이름 :";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(67, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(145, 20);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxAll_MouseClick);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(67, 38);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(145, 20);
            this.textBoxNumber.TabIndex = 3;
            this.textBoxNumber.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxAll_MouseClick);
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(12, 41);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(57, 13);
            this.labelNumber.TabIndex = 2;
            this.labelNumber.Text = "전화번호 :";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(67, 64);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(145, 20);
            this.textBoxId.TabIndex = 5;
            this.textBoxId.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxAll_MouseClick);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(12, 67);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(46, 13);
            this.labelId.TabIndex = 4;
            this.labelId.Text = "아이디 :";
            // 
            // textBoxPw
            // 
            this.textBoxPw.Location = new System.Drawing.Point(67, 90);
            this.textBoxPw.Name = "textBoxPw";
            this.textBoxPw.PasswordChar = '*';
            this.textBoxPw.Size = new System.Drawing.Size(145, 20);
            this.textBoxPw.TabIndex = 7;
            this.textBoxPw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxAll_MouseClick);
            // 
            // labelPw
            // 
            this.labelPw.AutoSize = true;
            this.labelPw.Location = new System.Drawing.Point(12, 93);
            this.labelPw.Name = "labelPw";
            this.labelPw.Size = new System.Drawing.Size(57, 13);
            this.labelPw.TabIndex = 6;
            this.labelPw.Text = "비밀번호 :";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(54, 166);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(129, 23);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "종료";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(54, 137);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(129, 23);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "리스트박스에 저장";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 201);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.textBoxPw);
            this.Controls.Add(this.labelPw);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxPw;
        private System.Windows.Forms.Label labelPw;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonAdd;
    }
}