namespace Te04
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "자몽",
            "2",
            "8200",
            "16400"}, -1);
            this.listViewShow = new System.Windows.Forms.ListView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelType = new System.Windows.Forms.Label();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.labelCost = new System.Windows.Forms.Label();
            this.domainUpDown = new System.Windows.Forms.DomainUpDown();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ColumnHeaderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewShow
            // 
            this.listViewShow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeaderType,
            this.columnHeaderAmount,
            this.columnHeaderCost,
            this.columnHeaderTotal});
            this.listViewShow.FullRowSelect = true;
            this.listViewShow.GridLines = true;
            this.listViewShow.HideSelection = false;
            this.listViewShow.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewShow.Location = new System.Drawing.Point(12, 12);
            this.listViewShow.Name = "listViewShow";
            this.listViewShow.Size = new System.Drawing.Size(326, 97);
            this.listViewShow.TabIndex = 0;
            this.listViewShow.UseCompatibleStateImageBehavior = false;
            this.listViewShow.View = System.Windows.Forms.View.Details;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(347, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(57, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(347, 41);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(57, 23);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(347, 70);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(57, 23);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(12, 123);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(31, 13);
            this.labelType.TabIndex = 4;
            this.labelType.Text = "Type";
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(61, 120);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(146, 20);
            this.textBoxType.TabIndex = 5;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(61, 146);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(146, 20);
            this.textBoxAmount.TabIndex = 7;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(12, 149);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(43, 13);
            this.labelAmount.TabIndex = 6;
            this.labelAmount.Text = "Amount";
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(61, 172);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(146, 20);
            this.textBoxCost.TabIndex = 9;
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(12, 175);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(28, 13);
            this.labelCost.TabIndex = 8;
            this.labelCost.Text = "Cost";
            // 
            // domainUpDown
            // 
            this.domainUpDown.Items.Add("사과");
            this.domainUpDown.Items.Add("바나나");
            this.domainUpDown.Items.Add("포도");
            this.domainUpDown.Items.Add("자몽");
            this.domainUpDown.Location = new System.Drawing.Point(218, 121);
            this.domainUpDown.Name = "domainUpDown";
            this.domainUpDown.ReadOnly = true;
            this.domainUpDown.Size = new System.Drawing.Size(120, 20);
            this.domainUpDown.TabIndex = 10;
            this.domainUpDown.Text = "=== 품목 선택 ===";
            this.domainUpDown.TextChanged += new System.EventHandler(this.domainUpDown_TextChanged);
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(218, 147);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.ReadOnly = true;
            this.numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown.TabIndex = 11;
            this.numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // ColumnHeaderType
            // 
            this.ColumnHeaderType.Text = "Type";
            this.ColumnHeaderType.Width = 76;
            // 
            // columnHeaderAmount
            // 
            this.columnHeaderAmount.Text = "Amount";
            this.columnHeaderAmount.Width = 75;
            // 
            // columnHeaderCost
            // 
            this.columnHeaderCost.Text = "Cost";
            this.columnHeaderCost.Width = 80;
            // 
            // columnHeaderTotal
            // 
            this.columnHeaderTotal.Text = "Total";
            this.columnHeaderTotal.Width = 88;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 201);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.domainUpDown);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewShow);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewShow;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.DomainUpDown domainUpDown;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.ColumnHeader ColumnHeaderType;
        private System.Windows.Forms.ColumnHeader columnHeaderAmount;
        private System.Windows.Forms.ColumnHeader columnHeaderCost;
        private System.Windows.Forms.ColumnHeader columnHeaderTotal;
    }
}

