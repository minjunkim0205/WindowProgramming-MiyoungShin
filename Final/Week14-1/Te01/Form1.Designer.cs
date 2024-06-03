namespace Te01
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
            this.components = new System.ComponentModel.Container();
            this.progressBarShow = new System.Windows.Forms.ProgressBar();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // progressBarShow
            // 
            this.progressBarShow.Location = new System.Drawing.Point(12, 141);
            this.progressBarShow.Name = "progressBarShow";
            this.progressBarShow.Size = new System.Drawing.Size(389, 23);
            this.progressBarShow.TabIndex = 0;
            // 
            // buttonStop
            // 
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStop.Location = new System.Drawing.Point(314, 44);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(87, 41);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStart.Location = new System.Drawing.Point(213, 44);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(87, 41);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelColor
            // 
            this.labelColor.BackColor = System.Drawing.Color.Silver;
            this.labelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColor.Location = new System.Drawing.Point(12, 44);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(87, 41);
            this.labelColor.TabIndex = 5;
            this.labelColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCount
            // 
            this.labelCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCount.Location = new System.Drawing.Point(113, 44);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(87, 41);
            this.labelCount.TabIndex = 6;
            this.labelCount.Text = "0";
            this.labelCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerMain
            // 
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 201);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.progressBarShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarShow;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Timer timerMain;
    }
}