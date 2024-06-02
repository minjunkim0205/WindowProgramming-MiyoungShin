namespace Te05
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("1학기");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("2학기");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("1학년", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("1학기");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("2학기");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("2학년", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("1학기");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("2학기");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("3학년", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("1학기");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("2학기");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("4학년", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            this.treeViewShow = new System.Windows.Forms.TreeView();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.listBoxShow = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeViewShow
            // 
            this.treeViewShow.Location = new System.Drawing.Point(11, 12);
            this.treeViewShow.Name = "treeViewShow";
            treeNode1.Name = "nodeSemester1";
            treeNode1.Text = "1학기";
            treeNode2.Name = "nodeSemester2";
            treeNode2.Text = "2학기";
            treeNode3.Name = "nodeGrade1";
            treeNode3.Text = "1학년";
            treeNode4.Name = "nodeSemester1";
            treeNode4.Text = "1학기";
            treeNode5.Name = "nodeSemester2";
            treeNode5.Text = "2학기";
            treeNode6.Name = "nodeGrade2";
            treeNode6.Text = "2학년";
            treeNode7.Name = "nodeSemester1";
            treeNode7.Text = "1학기";
            treeNode8.Name = "nodeSemester2";
            treeNode8.Text = "2학기";
            treeNode9.Name = "nodeGrade3";
            treeNode9.Text = "3학년";
            treeNode10.Name = "nodeSemester1";
            treeNode10.Text = "1학기";
            treeNode11.Name = "nodeSemester2";
            treeNode11.Text = "2학기";
            treeNode12.Name = "nodeGrade4";
            treeNode12.Text = "4학년";
            this.treeViewShow.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode9,
            treeNode12});
            this.treeViewShow.Size = new System.Drawing.Size(192, 147);
            this.treeViewShow.TabIndex = 0;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(12, 169);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(191, 20);
            this.textBoxInput.TabIndex = 1;
            // 
            // listBoxShow
            // 
            this.listBoxShow.FormattingEnabled = true;
            this.listBoxShow.Location = new System.Drawing.Point(209, 12);
            this.listBoxShow.Name = "listBoxShow";
            this.listBoxShow.Size = new System.Drawing.Size(192, 147);
            this.listBoxShow.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(209, 167);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(64, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(272, 167);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(65, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(337, 167);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(64, 23);
            this.buttonPrint.TabIndex = 5;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 201);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxShow);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.treeViewShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewShow;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.ListBox listBoxShow;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonPrint;
    }
}

