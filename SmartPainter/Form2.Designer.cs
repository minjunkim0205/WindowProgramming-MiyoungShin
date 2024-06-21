namespace SmartPainter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.buttonColorBackground = new System.Windows.Forms.Button();
            this.labelBackground = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(81, 6);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(100, 20);
            this.textBoxWidth.TabIndex = 0;
            this.textBoxWidth.Text = "429";
            this.textBoxWidth.TextChanged += new System.EventHandler(this.textBoxWidth_TextChanged);
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(40, 9);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(35, 13);
            this.labelWidth.TabIndex = 2;
            this.labelWidth.Text = "Width";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(40, 35);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(38, 13);
            this.labelHeight.TabIndex = 4;
            this.labelHeight.Text = "Height";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(81, 32);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxHeight.TabIndex = 3;
            this.textBoxHeight.Text = "240";
            this.textBoxHeight.TextChanged += new System.EventHandler(this.textBoxHeight_TextChanged);
            // 
            // buttonColorBackground
            // 
            this.buttonColorBackground.BackColor = System.Drawing.Color.White;
            this.buttonColorBackground.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonColorBackground.Location = new System.Drawing.Point(138, 58);
            this.buttonColorBackground.Name = "buttonColorBackground";
            this.buttonColorBackground.Size = new System.Drawing.Size(43, 20);
            this.buttonColorBackground.TabIndex = 17;
            this.buttonColorBackground.UseVisualStyleBackColor = false;
            this.buttonColorBackground.Click += new System.EventHandler(this.buttonColorBackground_Click);
            // 
            // labelBackground
            // 
            this.labelBackground.AutoSize = true;
            this.labelBackground.Location = new System.Drawing.Point(40, 61);
            this.labelBackground.Name = "labelBackground";
            this.labelBackground.Size = new System.Drawing.Size(92, 13);
            this.labelBackground.TabIndex = 20;
            this.labelBackground.Text = "Background Color";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(72, 84);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 21;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 111);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelBackground);
            this.Controls.Add(this.buttonColorBackground);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.textBoxWidth);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Paint Setting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Button buttonColorBackground;
        private System.Windows.Forms.Label labelBackground;
        private System.Windows.Forms.Button buttonOk;
    }
}