namespace Te03
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelShowColor = new System.Windows.Forms.Label();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.labelRedValue = new System.Windows.Forms.Label();
            this.labelGreenValue = new System.Windows.Forms.Label();
            this.labelBlueValue = new System.Windows.Forms.Label();
            this.labelRed = new System.Windows.Forms.Label();
            this.labelGreen = new System.Windows.Forms.Label();
            this.labelBlue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // labelShowColor
            // 
            this.labelShowColor.BackColor = System.Drawing.Color.Black;
            this.labelShowColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelShowColor.Location = new System.Drawing.Point(12, 9);
            this.labelShowColor.Name = "labelShowColor";
            this.labelShowColor.Size = new System.Drawing.Size(220, 183);
            this.labelShowColor.TabIndex = 0;
            // 
            // trackBarRed
            // 
            this.trackBarRed.Location = new System.Drawing.Point(250, 51);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarRed.Size = new System.Drawing.Size(45, 104);
            this.trackBarRed.TabIndex = 3;
            this.trackBarRed.TickFrequency = 20;
            this.trackBarRed.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarRed.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Location = new System.Drawing.Point(301, 51);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarGreen.Size = new System.Drawing.Size(45, 104);
            this.trackBarGreen.TabIndex = 4;
            this.trackBarGreen.TickFrequency = 20;
            this.trackBarGreen.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarGreen.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Location = new System.Drawing.Point(352, 51);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarBlue.Size = new System.Drawing.Size(45, 104);
            this.trackBarBlue.TabIndex = 5;
            this.trackBarBlue.TickFrequency = 20;
            this.trackBarBlue.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarBlue.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // labelRedValue
            // 
            this.labelRedValue.AutoSize = true;
            this.labelRedValue.Location = new System.Drawing.Point(265, 35);
            this.labelRedValue.Name = "labelRedValue";
            this.labelRedValue.Size = new System.Drawing.Size(13, 13);
            this.labelRedValue.TabIndex = 6;
            this.labelRedValue.Text = "0";
            // 
            // labelGreenValue
            // 
            this.labelGreenValue.AutoSize = true;
            this.labelGreenValue.Location = new System.Drawing.Point(316, 35);
            this.labelGreenValue.Name = "labelGreenValue";
            this.labelGreenValue.Size = new System.Drawing.Size(13, 13);
            this.labelGreenValue.TabIndex = 7;
            this.labelGreenValue.Text = "0";
            // 
            // labelBlueValue
            // 
            this.labelBlueValue.AutoSize = true;
            this.labelBlueValue.Location = new System.Drawing.Point(367, 35);
            this.labelBlueValue.Name = "labelBlueValue";
            this.labelBlueValue.Size = new System.Drawing.Size(13, 13);
            this.labelBlueValue.TabIndex = 8;
            this.labelBlueValue.Text = "0";
            // 
            // labelRed
            // 
            this.labelRed.AutoSize = true;
            this.labelRed.ForeColor = System.Drawing.Color.Red;
            this.labelRed.Location = new System.Drawing.Point(260, 158);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(27, 13);
            this.labelRed.TabIndex = 9;
            this.labelRed.Text = "Red";
            // 
            // labelGreen
            // 
            this.labelGreen.AutoSize = true;
            this.labelGreen.ForeColor = System.Drawing.Color.Lime;
            this.labelGreen.Location = new System.Drawing.Point(305, 158);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(36, 13);
            this.labelGreen.TabIndex = 10;
            this.labelGreen.Text = "Green";
            // 
            // labelBlue
            // 
            this.labelBlue.AutoSize = true;
            this.labelBlue.ForeColor = System.Drawing.Color.Blue;
            this.labelBlue.Location = new System.Drawing.Point(362, 158);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(28, 13);
            this.labelBlue.TabIndex = 11;
            this.labelBlue.Text = "Blue";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 201);
            this.Controls.Add(this.labelBlue);
            this.Controls.Add(this.labelGreen);
            this.Controls.Add(this.labelRed);
            this.Controls.Add(this.labelBlueValue);
            this.Controls.Add(this.labelGreenValue);
            this.Controls.Add(this.labelRedValue);
            this.Controls.Add(this.trackBarBlue);
            this.Controls.Add(this.trackBarGreen);
            this.Controls.Add(this.trackBarRed);
            this.Controls.Add(this.labelShowColor);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelShowColor;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.Label labelRedValue;
        private System.Windows.Forms.Label labelGreenValue;
        private System.Windows.Forms.Label labelBlueValue;
        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.Label labelGreen;
        private System.Windows.Forms.Label labelBlue;
    }
}

