﻿namespace SmartPainter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStripTop = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator01 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.printPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPageSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator02 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemView = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem100 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemZoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemZoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxBar01 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItemFastSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxBar02 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItemUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.labelTool = new System.Windows.Forms.Label();
            this.labelShape = new System.Windows.Forms.Label();
            this.buttonToolLine = new System.Windows.Forms.Button();
            this.buttonToolPencil = new System.Windows.Forms.Button();
            this.buttonToolPail = new System.Windows.Forms.Button();
            this.buttonToolEraser = new System.Windows.Forms.Button();
            this.buttonShapeSquare = new System.Windows.Forms.Button();
            this.buttonShapeCircle = new System.Windows.Forms.Button();
            this.buttonSizeS = new System.Windows.Forms.Button();
            this.buttonSizeM = new System.Windows.Forms.Button();
            this.buttonSizeL = new System.Windows.Forms.Button();
            this.buttonColorPicker = new System.Windows.Forms.Button();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.buttonColor00 = new System.Windows.Forms.Button();
            this.buttonColor01 = new System.Windows.Forms.Button();
            this.buttonColor10 = new System.Windows.Forms.Button();
            this.buttonColor11 = new System.Windows.Forms.Button();
            this.buttonColor12 = new System.Windows.Forms.Button();
            this.buttonColor02 = new System.Windows.Forms.Button();
            this.buttonColor03 = new System.Windows.Forms.Button();
            this.buttonColor04 = new System.Windows.Forms.Button();
            this.buttonColor05 = new System.Windows.Forms.Button();
            this.buttonColor06 = new System.Windows.Forms.Button();
            this.buttonColor13 = new System.Windows.Forms.Button();
            this.buttonColor14 = new System.Windows.Forms.Button();
            this.buttonColor15 = new System.Windows.Forms.Button();
            this.buttonColor16 = new System.Windows.Forms.Button();
            this.buttonColorPipette = new System.Windows.Forms.Button();
            this.buttonColorDelete = new System.Windows.Forms.Button();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.statusStripBottom = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMousePos = new System.Windows.Forms.ToolStripStatusLabel();
            this.trackBarZoom = new System.Windows.Forms.TrackBar();
            this.labelZoom100 = new System.Windows.Forms.Label();
            this.labelZoom0 = new System.Windows.Forms.Label();
            this.buttonSetting = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panelPaint = new System.Windows.Forms.Panel();
            this.pictureBoxPaint = new System.Windows.Forms.PictureBox();
            this.buttonSizeUp = new System.Windows.Forms.Button();
            this.buttonSizeDown = new System.Windows.Forms.Button();
            this.menuStripTop.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.statusStripBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoom)).BeginInit();
            this.panelPaint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaint)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripTop
            // 
            this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolStripMenuItemEdit,
            this.toolStripMenuItemView,
            this.toolStripTextBoxBar01,
            this.toolStripMenuItemFastSave,
            this.toolStripTextBoxBar02,
            this.toolStripMenuItemUndo,
            this.toolStripMenuItemRedo});
            this.menuStripTop.Location = new System.Drawing.Point(0, 0);
            this.menuStripTop.Name = "menuStripTop";
            this.menuStripTop.Size = new System.Drawing.Size(1264, 27);
            this.menuStripTop.TabIndex = 0;
            this.menuStripTop.Text = "menuStrip1";
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripMenuItemLoad,
            this.toolStripMenuItemSave,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator01,
            this.toolStripMenuItemPrint,
            this.toolStripSeparator02,
            this.toolStripMenuItemExit});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(37, 23);
            this.toolStripMenuItemFile.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // toolStripMenuItemLoad
            // 
            this.toolStripMenuItemLoad.Name = "toolStripMenuItemLoad";
            this.toolStripMenuItemLoad.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItemLoad.Text = "Load";
            // 
            // toolStripMenuItemSave
            // 
            this.toolStripMenuItemSave.Name = "toolStripMenuItemSave";
            this.toolStripMenuItemSave.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItemSave.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            // 
            // toolStripSeparator01
            // 
            this.toolStripSeparator01.Name = "toolStripSeparator01";
            this.toolStripSeparator01.Size = new System.Drawing.Size(109, 6);
            // 
            // toolStripMenuItemPrint
            // 
            this.toolStripMenuItemPrint.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printPToolStripMenuItem,
            this.toolStripMenuItemPageSettings});
            this.toolStripMenuItemPrint.Name = "toolStripMenuItemPrint";
            this.toolStripMenuItemPrint.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItemPrint.Text = "Print";
            // 
            // printPToolStripMenuItem
            // 
            this.printPToolStripMenuItem.Name = "printPToolStripMenuItem";
            this.printPToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printPToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.printPToolStripMenuItem.Text = "Print(&P)";
            // 
            // toolStripMenuItemPageSettings
            // 
            this.toolStripMenuItemPageSettings.Name = "toolStripMenuItemPageSettings";
            this.toolStripMenuItemPageSettings.Size = new System.Drawing.Size(155, 22);
            this.toolStripMenuItemPageSettings.Text = "Page settings";
            // 
            // toolStripSeparator02
            // 
            this.toolStripSeparator02.Name = "toolStripSeparator02";
            this.toolStripSeparator02.Size = new System.Drawing.Size(109, 6);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItemExit.Text = "Exit";
            // 
            // toolStripMenuItemEdit
            // 
            this.toolStripMenuItemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCut,
            this.toolStripMenuItemCopy,
            this.toolStripMenuItemPaste});
            this.toolStripMenuItemEdit.Name = "toolStripMenuItemEdit";
            this.toolStripMenuItemEdit.Size = new System.Drawing.Size(39, 23);
            this.toolStripMenuItemEdit.Text = "Edit";
            // 
            // toolStripMenuItemCut
            // 
            this.toolStripMenuItemCut.Name = "toolStripMenuItemCut";
            this.toolStripMenuItemCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.toolStripMenuItemCut.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItemCut.Text = "Cut(&X)";
            // 
            // toolStripMenuItemCopy
            // 
            this.toolStripMenuItemCopy.Name = "toolStripMenuItemCopy";
            this.toolStripMenuItemCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.toolStripMenuItemCopy.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItemCopy.Text = "Copy(&C)";
            // 
            // toolStripMenuItemPaste
            // 
            this.toolStripMenuItemPaste.Name = "toolStripMenuItemPaste";
            this.toolStripMenuItemPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.toolStripMenuItemPaste.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItemPaste.Text = "Paste(&V)";
            // 
            // toolStripMenuItemView
            // 
            this.toolStripMenuItemView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemZoom});
            this.toolStripMenuItemView.Name = "toolStripMenuItemView";
            this.toolStripMenuItemView.Size = new System.Drawing.Size(44, 23);
            this.toolStripMenuItemView.Text = "View";
            // 
            // toolStripMenuItemZoom
            // 
            this.toolStripMenuItemZoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem100,
            this.toolStripMenuItemZoomIn,
            this.toolStripMenuItemZoomOut,
            this.toolStripMenuItemFit});
            this.toolStripMenuItemZoom.Name = "toolStripMenuItemZoom";
            this.toolStripMenuItemZoom.Size = new System.Drawing.Size(106, 22);
            this.toolStripMenuItemZoom.Text = "Zoom";
            // 
            // toolStripMenuItem100
            // 
            this.toolStripMenuItem100.Name = "toolStripMenuItem100";
            this.toolStripMenuItem100.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.toolStripMenuItem100.Size = new System.Drawing.Size(200, 22);
            this.toolStripMenuItem100.Text = "100%(&0)";
            // 
            // toolStripMenuItemZoomIn
            // 
            this.toolStripMenuItemZoomIn.Name = "toolStripMenuItemZoomIn";
            this.toolStripMenuItemZoomIn.Size = new System.Drawing.Size(200, 22);
            this.toolStripMenuItemZoomIn.Text = "Zoom in";
            // 
            // toolStripMenuItemZoomOut
            // 
            this.toolStripMenuItemZoomOut.Name = "toolStripMenuItemZoomOut";
            this.toolStripMenuItemZoomOut.Size = new System.Drawing.Size(200, 22);
            this.toolStripMenuItemZoomOut.Text = "Zoom out";
            // 
            // toolStripMenuItemFit
            // 
            this.toolStripMenuItemFit.Name = "toolStripMenuItemFit";
            this.toolStripMenuItemFit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.toolStripMenuItemFit.Size = new System.Drawing.Size(200, 22);
            this.toolStripMenuItemFit.Text = "Fit to window(&1)";
            // 
            // toolStripTextBoxBar01
            // 
            this.toolStripTextBoxBar01.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripTextBoxBar01.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxBar01.Name = "toolStripTextBoxBar01";
            this.toolStripTextBoxBar01.Size = new System.Drawing.Size(10, 23);
            this.toolStripTextBoxBar01.Text = "|";
            // 
            // toolStripMenuItemFastSave
            // 
            this.toolStripMenuItemFastSave.Name = "toolStripMenuItemFastSave";
            this.toolStripMenuItemFastSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.toolStripMenuItemFastSave.Size = new System.Drawing.Size(43, 23);
            this.toolStripMenuItemFastSave.Text = "Save";
            // 
            // toolStripTextBoxBar02
            // 
            this.toolStripTextBoxBar02.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripTextBoxBar02.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxBar02.Name = "toolStripTextBoxBar02";
            this.toolStripTextBoxBar02.Size = new System.Drawing.Size(10, 23);
            this.toolStripTextBoxBar02.Text = "|";
            // 
            // toolStripMenuItemUndo
            // 
            this.toolStripMenuItemUndo.Name = "toolStripMenuItemUndo";
            this.toolStripMenuItemUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.toolStripMenuItemUndo.Size = new System.Drawing.Size(63, 23);
            this.toolStripMenuItemUndo.Text = "Undo(&Z)";
            // 
            // toolStripMenuItemRedo
            // 
            this.toolStripMenuItemRedo.Name = "toolStripMenuItemRedo";
            this.toolStripMenuItemRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.toolStripMenuItemRedo.Size = new System.Drawing.Size(61, 23);
            this.toolStripMenuItemRedo.Text = "Redo(&Y)";
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelMain.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanelMain.ColumnCount = 40;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMain.Controls.Add(this.labelTool, 2, 2);
            this.tableLayoutPanelMain.Controls.Add(this.labelShape, 4, 2);
            this.tableLayoutPanelMain.Controls.Add(this.buttonToolLine, 2, 0);
            this.tableLayoutPanelMain.Controls.Add(this.buttonToolPencil, 3, 0);
            this.tableLayoutPanelMain.Controls.Add(this.buttonToolPail, 2, 1);
            this.tableLayoutPanelMain.Controls.Add(this.buttonToolEraser, 3, 1);
            this.tableLayoutPanelMain.Controls.Add(this.buttonShapeSquare, 5, 0);
            this.tableLayoutPanelMain.Controls.Add(this.buttonShapeCircle, 5, 1);
            this.tableLayoutPanelMain.Controls.Add(this.buttonSizeS, 7, 0);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxSize, 8, 1);
            this.tableLayoutPanelMain.Controls.Add(this.buttonSizeM, 8, 0);
            this.tableLayoutPanelMain.Controls.Add(this.buttonSizeL, 9, 0);
            this.tableLayoutPanelMain.Controls.Add(this.buttonColorPicker, 11, 0);
            this.tableLayoutPanelMain.Controls.Add(this.labelColor, 10, 2);
            this.tableLayoutPanelMain.Controls.Add(this.labelSize, 7, 2);
            this.tableLayoutPanelMain.Controls.Add(this.buttonColor00, 13, 0);
            this.tableLayoutPanelMain.Controls.Add(this.buttonColor01, 14, 0);
            this.tableLayoutPanelMain.Controls.Add(this.buttonColor10, 13, 1);
            this.tableLayoutPanelMain.Controls.Add(this.buttonColor11, 14, 1);
            this.tableLayoutPanelMain.Controls.Add(this.buttonColor12, 15, 1);
            this.tableLayoutPanelMain.Controls.Add(this.buttonColor02, 15, 0);
            this.tableLayoutPanelMain.Controls.Add(this.buttonColor03, 16, 0);
            this.tableLayoutPanelMain.Controls.Add(this.buttonColor04, 17, 0);
            this.tableLayoutPanelMain.Controls.Add(this.buttonColor05, 18, 0);
            this.tableLayoutPanelMain.Controls.Add(this.buttonColor06, 19, 0);
            this.tableLayoutPanelMain.Controls.Add(this.buttonColor13, 16, 1);
            this.tableLayoutPanelMain.Controls.Add(this.buttonColor14, 17, 1);
            this.tableLayoutPanelMain.Controls.Add(this.buttonColor15, 18, 1);
            this.tableLayoutPanelMain.Controls.Add(this.buttonColor16, 19, 1);
            this.tableLayoutPanelMain.Controls.Add(this.buttonColorPipette, 20, 1);
            this.tableLayoutPanelMain.Controls.Add(this.buttonColorDelete, 20, 0);
            this.tableLayoutPanelMain.Controls.Add(this.buttonSizeDown, 9, 1);
            this.tableLayoutPanelMain.Controls.Add(this.buttonSizeUp, 7, 1);
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1264, 96);
            this.tableLayoutPanelMain.TabIndex = 1;
            // 
            // labelTool
            // 
            this.tableLayoutPanelMain.SetColumnSpan(this.labelTool, 2);
            this.labelTool.Location = new System.Drawing.Point(67, 64);
            this.labelTool.Name = "labelTool";
            this.labelTool.Size = new System.Drawing.Size(58, 26);
            this.labelTool.TabIndex = 2;
            this.labelTool.Text = "Tool";
            this.labelTool.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelShape
            // 
            this.tableLayoutPanelMain.SetColumnSpan(this.labelShape, 3);
            this.labelShape.Location = new System.Drawing.Point(131, 64);
            this.labelShape.Name = "labelShape";
            this.labelShape.Size = new System.Drawing.Size(90, 26);
            this.labelShape.TabIndex = 6;
            this.labelShape.Text = "Shape";
            this.labelShape.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonToolLine
            // 
            this.buttonToolLine.Image = ((System.Drawing.Image)(resources.GetObject("buttonToolLine.Image")));
            this.buttonToolLine.Location = new System.Drawing.Point(67, 3);
            this.buttonToolLine.Name = "buttonToolLine";
            this.buttonToolLine.Size = new System.Drawing.Size(26, 26);
            this.buttonToolLine.TabIndex = 31;
            this.buttonToolLine.UseVisualStyleBackColor = true;
            this.buttonToolLine.Click += new System.EventHandler(this.buttonToolLine_Click);
            // 
            // buttonToolPencil
            // 
            this.buttonToolPencil.Image = ((System.Drawing.Image)(resources.GetObject("buttonToolPencil.Image")));
            this.buttonToolPencil.Location = new System.Drawing.Point(99, 3);
            this.buttonToolPencil.Name = "buttonToolPencil";
            this.buttonToolPencil.Size = new System.Drawing.Size(26, 26);
            this.buttonToolPencil.TabIndex = 32;
            this.buttonToolPencil.UseVisualStyleBackColor = true;
            this.buttonToolPencil.Click += new System.EventHandler(this.buttonToolPencil_Click);
            // 
            // buttonToolPail
            // 
            this.buttonToolPail.Image = ((System.Drawing.Image)(resources.GetObject("buttonToolPail.Image")));
            this.buttonToolPail.Location = new System.Drawing.Point(67, 35);
            this.buttonToolPail.Name = "buttonToolPail";
            this.buttonToolPail.Size = new System.Drawing.Size(26, 26);
            this.buttonToolPail.TabIndex = 33;
            this.buttonToolPail.UseVisualStyleBackColor = true;
            this.buttonToolPail.Click += new System.EventHandler(this.buttonToolPail_Click);
            // 
            // buttonToolEraser
            // 
            this.buttonToolEraser.Image = ((System.Drawing.Image)(resources.GetObject("buttonToolEraser.Image")));
            this.buttonToolEraser.Location = new System.Drawing.Point(99, 35);
            this.buttonToolEraser.Name = "buttonToolEraser";
            this.buttonToolEraser.Size = new System.Drawing.Size(26, 26);
            this.buttonToolEraser.TabIndex = 34;
            this.buttonToolEraser.UseVisualStyleBackColor = true;
            this.buttonToolEraser.Click += new System.EventHandler(this.buttonToolEraser_Click);
            // 
            // buttonShapeSquare
            // 
            this.buttonShapeSquare.Image = ((System.Drawing.Image)(resources.GetObject("buttonShapeSquare.Image")));
            this.buttonShapeSquare.Location = new System.Drawing.Point(163, 3);
            this.buttonShapeSquare.Name = "buttonShapeSquare";
            this.buttonShapeSquare.Size = new System.Drawing.Size(26, 26);
            this.buttonShapeSquare.TabIndex = 35;
            this.buttonShapeSquare.UseVisualStyleBackColor = true;
            this.buttonShapeSquare.Click += new System.EventHandler(this.buttonShapeSquare_Click);
            // 
            // buttonShapeCircle
            // 
            this.buttonShapeCircle.Image = ((System.Drawing.Image)(resources.GetObject("buttonShapeCircle.Image")));
            this.buttonShapeCircle.Location = new System.Drawing.Point(163, 35);
            this.buttonShapeCircle.Name = "buttonShapeCircle";
            this.buttonShapeCircle.Size = new System.Drawing.Size(26, 26);
            this.buttonShapeCircle.TabIndex = 35;
            this.buttonShapeCircle.UseVisualStyleBackColor = true;
            this.buttonShapeCircle.Click += new System.EventHandler(this.buttonShapeCircle_Click);
            // 
            // buttonSizeS
            // 
            this.buttonSizeS.Image = ((System.Drawing.Image)(resources.GetObject("buttonSizeS.Image")));
            this.buttonSizeS.Location = new System.Drawing.Point(227, 3);
            this.buttonSizeS.Name = "buttonSizeS";
            this.buttonSizeS.Size = new System.Drawing.Size(26, 26);
            this.buttonSizeS.TabIndex = 37;
            this.buttonSizeS.UseVisualStyleBackColor = true;
            this.buttonSizeS.Click += new System.EventHandler(this.buttonSize_Click);
            // 
            // buttonSizeM
            // 
            this.buttonSizeM.Image = ((System.Drawing.Image)(resources.GetObject("buttonSizeM.Image")));
            this.buttonSizeM.Location = new System.Drawing.Point(259, 3);
            this.buttonSizeM.Name = "buttonSizeM";
            this.buttonSizeM.Size = new System.Drawing.Size(26, 26);
            this.buttonSizeM.TabIndex = 38;
            this.buttonSizeM.UseVisualStyleBackColor = true;
            this.buttonSizeM.Click += new System.EventHandler(this.buttonSize_Click);
            // 
            // buttonSizeL
            // 
            this.buttonSizeL.Image = ((System.Drawing.Image)(resources.GetObject("buttonSizeL.Image")));
            this.buttonSizeL.Location = new System.Drawing.Point(291, 3);
            this.buttonSizeL.Name = "buttonSizeL";
            this.buttonSizeL.Size = new System.Drawing.Size(26, 26);
            this.buttonSizeL.TabIndex = 39;
            this.buttonSizeL.UseVisualStyleBackColor = true;
            this.buttonSizeL.Click += new System.EventHandler(this.buttonSize_Click);
            // 
            // buttonColorPicker
            // 
            this.tableLayoutPanelMain.SetColumnSpan(this.buttonColorPicker, 2);
            this.buttonColorPicker.Image = ((System.Drawing.Image)(resources.GetObject("buttonColorPicker.Image")));
            this.buttonColorPicker.Location = new System.Drawing.Point(355, 3);
            this.buttonColorPicker.Name = "buttonColorPicker";
            this.tableLayoutPanelMain.SetRowSpan(this.buttonColorPicker, 2);
            this.buttonColorPicker.Size = new System.Drawing.Size(58, 58);
            this.buttonColorPicker.TabIndex = 38;
            this.buttonColorPicker.UseVisualStyleBackColor = true;
            // 
            // labelColor
            // 
            this.tableLayoutPanelMain.SetColumnSpan(this.labelColor, 12);
            this.labelColor.Location = new System.Drawing.Point(323, 64);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(378, 26);
            this.labelColor.TabIndex = 7;
            this.labelColor.Text = "Color";
            this.labelColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSize
            // 
            this.tableLayoutPanelMain.SetColumnSpan(this.labelSize, 3);
            this.labelSize.Location = new System.Drawing.Point(227, 64);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(90, 26);
            this.labelSize.TabIndex = 3;
            this.labelSize.Text = "Size";
            this.labelSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonColor00
            // 
            this.buttonColor00.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonColor00.Location = new System.Drawing.Point(419, 3);
            this.buttonColor00.Name = "buttonColor00";
            this.buttonColor00.Size = new System.Drawing.Size(26, 26);
            this.buttonColor00.TabIndex = 14;
            this.buttonColor00.UseVisualStyleBackColor = true;
            // 
            // buttonColor01
            // 
            this.buttonColor01.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonColor01.Location = new System.Drawing.Point(451, 3);
            this.buttonColor01.Name = "buttonColor01";
            this.buttonColor01.Size = new System.Drawing.Size(26, 26);
            this.buttonColor01.TabIndex = 16;
            this.buttonColor01.UseVisualStyleBackColor = true;
            // 
            // buttonColor10
            // 
            this.buttonColor10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonColor10.Location = new System.Drawing.Point(419, 35);
            this.buttonColor10.Name = "buttonColor10";
            this.buttonColor10.Size = new System.Drawing.Size(26, 26);
            this.buttonColor10.TabIndex = 15;
            this.buttonColor10.UseVisualStyleBackColor = true;
            // 
            // buttonColor11
            // 
            this.buttonColor11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonColor11.Location = new System.Drawing.Point(451, 35);
            this.buttonColor11.Name = "buttonColor11";
            this.buttonColor11.Size = new System.Drawing.Size(26, 26);
            this.buttonColor11.TabIndex = 17;
            this.buttonColor11.UseVisualStyleBackColor = true;
            // 
            // buttonColor12
            // 
            this.buttonColor12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonColor12.Location = new System.Drawing.Point(483, 35);
            this.buttonColor12.Name = "buttonColor12";
            this.buttonColor12.Size = new System.Drawing.Size(26, 26);
            this.buttonColor12.TabIndex = 19;
            this.buttonColor12.UseVisualStyleBackColor = true;
            // 
            // buttonColor02
            // 
            this.buttonColor02.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonColor02.Location = new System.Drawing.Point(483, 3);
            this.buttonColor02.Name = "buttonColor02";
            this.buttonColor02.Size = new System.Drawing.Size(26, 26);
            this.buttonColor02.TabIndex = 18;
            this.buttonColor02.UseVisualStyleBackColor = true;
            // 
            // buttonColor03
            // 
            this.buttonColor03.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonColor03.Location = new System.Drawing.Point(515, 3);
            this.buttonColor03.Name = "buttonColor03";
            this.buttonColor03.Size = new System.Drawing.Size(26, 26);
            this.buttonColor03.TabIndex = 20;
            this.buttonColor03.UseVisualStyleBackColor = true;
            // 
            // buttonColor04
            // 
            this.buttonColor04.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonColor04.Location = new System.Drawing.Point(547, 3);
            this.buttonColor04.Name = "buttonColor04";
            this.buttonColor04.Size = new System.Drawing.Size(26, 26);
            this.buttonColor04.TabIndex = 21;
            this.buttonColor04.UseVisualStyleBackColor = true;
            // 
            // buttonColor05
            // 
            this.buttonColor05.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonColor05.Location = new System.Drawing.Point(579, 3);
            this.buttonColor05.Name = "buttonColor05";
            this.buttonColor05.Size = new System.Drawing.Size(26, 26);
            this.buttonColor05.TabIndex = 22;
            this.buttonColor05.UseVisualStyleBackColor = true;
            // 
            // buttonColor06
            // 
            this.buttonColor06.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonColor06.Location = new System.Drawing.Point(611, 3);
            this.buttonColor06.Name = "buttonColor06";
            this.buttonColor06.Size = new System.Drawing.Size(26, 26);
            this.buttonColor06.TabIndex = 29;
            this.buttonColor06.UseVisualStyleBackColor = true;
            // 
            // buttonColor13
            // 
            this.buttonColor13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonColor13.Location = new System.Drawing.Point(515, 35);
            this.buttonColor13.Name = "buttonColor13";
            this.buttonColor13.Size = new System.Drawing.Size(26, 26);
            this.buttonColor13.TabIndex = 23;
            this.buttonColor13.UseVisualStyleBackColor = true;
            // 
            // buttonColor14
            // 
            this.buttonColor14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonColor14.Location = new System.Drawing.Point(547, 35);
            this.buttonColor14.Name = "buttonColor14";
            this.buttonColor14.Size = new System.Drawing.Size(26, 26);
            this.buttonColor14.TabIndex = 24;
            this.buttonColor14.UseVisualStyleBackColor = true;
            // 
            // buttonColor15
            // 
            this.buttonColor15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonColor15.Location = new System.Drawing.Point(579, 35);
            this.buttonColor15.Name = "buttonColor15";
            this.buttonColor15.Size = new System.Drawing.Size(26, 26);
            this.buttonColor15.TabIndex = 25;
            this.buttonColor15.UseVisualStyleBackColor = true;
            // 
            // buttonColor16
            // 
            this.buttonColor16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonColor16.Location = new System.Drawing.Point(611, 35);
            this.buttonColor16.Name = "buttonColor16";
            this.buttonColor16.Size = new System.Drawing.Size(26, 26);
            this.buttonColor16.TabIndex = 30;
            this.buttonColor16.UseVisualStyleBackColor = true;
            // 
            // buttonColorPipette
            // 
            this.buttonColorPipette.Image = ((System.Drawing.Image)(resources.GetObject("buttonColorPipette.Image")));
            this.buttonColorPipette.Location = new System.Drawing.Point(643, 35);
            this.buttonColorPipette.Name = "buttonColorPipette";
            this.buttonColorPipette.Size = new System.Drawing.Size(26, 26);
            this.buttonColorPipette.TabIndex = 41;
            this.buttonColorPipette.UseVisualStyleBackColor = true;
            // 
            // buttonColorDelete
            // 
            this.buttonColorDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonColorDelete.Image")));
            this.buttonColorDelete.Location = new System.Drawing.Point(643, 3);
            this.buttonColorDelete.Name = "buttonColorDelete";
            this.buttonColorDelete.Size = new System.Drawing.Size(26, 26);
            this.buttonColorDelete.TabIndex = 40;
            this.buttonColorDelete.UseVisualStyleBackColor = true;
            // 
            // textBoxSize
            // 
            this.textBoxSize.Location = new System.Drawing.Point(259, 35);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(26, 20);
            this.textBoxSize.TabIndex = 42;
            this.textBoxSize.Text = "2";
            this.textBoxSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSize.TextChanged += new System.EventHandler(this.textBoxSize_TextChanged);
            // 
            // statusStripBottom
            // 
            this.statusStripBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMousePos});
            this.statusStripBottom.Location = new System.Drawing.Point(0, 659);
            this.statusStripBottom.Name = "statusStripBottom";
            this.statusStripBottom.Size = new System.Drawing.Size(1264, 22);
            this.statusStripBottom.TabIndex = 4;
            this.statusStripBottom.Text = "statusStrip1";
            // 
            // toolStripStatusLabelMousePos
            // 
            this.toolStripStatusLabelMousePos.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabelMousePos.Name = "toolStripStatusLabelMousePos";
            this.toolStripStatusLabelMousePos.Size = new System.Drawing.Size(25, 17);
            this.toolStripStatusLabelMousePos.Text = "0, 0";
            // 
            // trackBarZoom
            // 
            this.trackBarZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarZoom.AutoSize = false;
            this.trackBarZoom.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarZoom.Location = new System.Drawing.Point(1102, 660);
            this.trackBarZoom.Maximum = 100;
            this.trackBarZoom.Name = "trackBarZoom";
            this.trackBarZoom.Size = new System.Drawing.Size(104, 20);
            this.trackBarZoom.TabIndex = 5;
            this.trackBarZoom.TickFrequency = 10;
            this.trackBarZoom.Value = 100;
            // 
            // labelZoom100
            // 
            this.labelZoom100.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelZoom100.AutoSize = true;
            this.labelZoom100.BackColor = System.Drawing.SystemColors.Control;
            this.labelZoom100.Location = new System.Drawing.Point(1203, 664);
            this.labelZoom100.Name = "labelZoom100";
            this.labelZoom100.Size = new System.Drawing.Size(33, 13);
            this.labelZoom100.TabIndex = 6;
            this.labelZoom100.Text = "100%";
            // 
            // labelZoom0
            // 
            this.labelZoom0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelZoom0.AutoSize = true;
            this.labelZoom0.BackColor = System.Drawing.SystemColors.Control;
            this.labelZoom0.Location = new System.Drawing.Point(1082, 664);
            this.labelZoom0.Name = "labelZoom0";
            this.labelZoom0.Size = new System.Drawing.Size(21, 13);
            this.labelZoom0.TabIndex = 7;
            this.labelZoom0.Text = "0%";
            // 
            // buttonSetting
            // 
            this.buttonSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetting.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSetting.Image = ((System.Drawing.Image)(resources.GetObject("buttonSetting.Image")));
            this.buttonSetting.Location = new System.Drawing.Point(1237, 4);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Size = new System.Drawing.Size(22, 22);
            this.buttonSetting.TabIndex = 9;
            this.buttonSetting.UseVisualStyleBackColor = false;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.Location = new System.Drawing.Point(1211, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(22, 22);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // panelPaint
            // 
            this.panelPaint.Controls.Add(this.pictureBoxPaint);
            this.panelPaint.Location = new System.Drawing.Point(12, 132);
            this.panelPaint.Name = "panelPaint";
            this.panelPaint.Size = new System.Drawing.Size(429, 240);
            this.panelPaint.TabIndex = 11;
            // 
            // pictureBoxPaint
            // 
            this.pictureBoxPaint.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxPaint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPaint.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPaint.Name = "pictureBoxPaint";
            this.pictureBoxPaint.Size = new System.Drawing.Size(429, 240);
            this.pictureBoxPaint.TabIndex = 0;
            this.pictureBoxPaint.TabStop = false;
            this.pictureBoxPaint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPaint_MouseDown);
            this.pictureBoxPaint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPaint_MouseMove);
            this.pictureBoxPaint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPaint_MouseUp);
            // 
            // buttonSizeUp
            // 
            this.buttonSizeUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSizeUp.Location = new System.Drawing.Point(233, 35);
            this.buttonSizeUp.Name = "buttonSizeUp";
            this.buttonSizeUp.Size = new System.Drawing.Size(20, 20);
            this.buttonSizeUp.TabIndex = 43;
            this.buttonSizeUp.Text = "-";
            this.buttonSizeUp.UseVisualStyleBackColor = true;
            this.buttonSizeUp.Click += new System.EventHandler(this.buttonSizeDown_Click);
            // 
            // buttonSizeDown
            // 
            this.buttonSizeDown.Location = new System.Drawing.Point(291, 35);
            this.buttonSizeDown.Name = "buttonSizeDown";
            this.buttonSizeDown.Size = new System.Drawing.Size(20, 20);
            this.buttonSizeDown.TabIndex = 44;
            this.buttonSizeDown.Text = "+";
            this.buttonSizeDown.UseVisualStyleBackColor = true;
            this.buttonSizeDown.Click += new System.EventHandler(this.buttonSizeUp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelPaint);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonSetting);
            this.Controls.Add(this.labelZoom0);
            this.Controls.Add(this.labelZoom100);
            this.Controls.Add(this.trackBarZoom);
            this.Controls.Add(this.statusStripBottom);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Controls.Add(this.menuStripTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripTop;
            this.MinimumSize = new System.Drawing.Size(429, 240);
            this.Name = "Form1";
            this.Text = "Smart Painter";
            this.menuStripTop.ResumeLayout(false);
            this.menuStripTop.PerformLayout();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.statusStripBottom.ResumeLayout(false);
            this.statusStripBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoom)).EndInit();
            this.panelPaint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripTop;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSave;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLoad;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCut;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopy;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPaste;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemView;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemZoom;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem100;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemZoomIn;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemZoomOut;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator01;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPrint;
        private System.Windows.Forms.ToolStripMenuItem printPToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator02;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxBar02;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUndo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFastSave;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxBar01;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRedo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPageSettings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Label labelTool;
        private System.Windows.Forms.Label labelShape;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Button buttonColor00;
        private System.Windows.Forms.Button buttonColor10;
        private System.Windows.Forms.Button buttonColor01;
        private System.Windows.Forms.Button buttonColor11;
        private System.Windows.Forms.Button buttonColor02;
        private System.Windows.Forms.Button buttonColor12;
        private System.Windows.Forms.Button buttonColor03;
        private System.Windows.Forms.Button buttonColor04;
        private System.Windows.Forms.Button buttonColor05;
        private System.Windows.Forms.Button buttonColor13;
        private System.Windows.Forms.Button buttonColor14;
        private System.Windows.Forms.Button buttonColor15;
        private System.Windows.Forms.Button buttonColor06;
        private System.Windows.Forms.Button buttonColor16;
        private System.Windows.Forms.StatusStrip statusStripBottom;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMousePos;
        private System.Windows.Forms.TrackBar trackBarZoom;
        private System.Windows.Forms.Label labelZoom100;
        private System.Windows.Forms.Label labelZoom0;
        private System.Windows.Forms.Button buttonColorPicker;
        private System.Windows.Forms.Button buttonToolLine;
        private System.Windows.Forms.Button buttonToolPencil;
        private System.Windows.Forms.Button buttonToolPail;
        private System.Windows.Forms.Button buttonToolEraser;
        private System.Windows.Forms.Button buttonShapeSquare;
        private System.Windows.Forms.Button buttonShapeCircle;
        private System.Windows.Forms.Button buttonSizeS;
        private System.Windows.Forms.Button buttonSizeM;
        private System.Windows.Forms.Button buttonSizeL;
        private System.Windows.Forms.Button buttonColorDelete;
        private System.Windows.Forms.Button buttonColorPipette;
        private System.Windows.Forms.Button buttonSetting;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Panel panelPaint;
        private System.Windows.Forms.PictureBox pictureBoxPaint;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.Button buttonSizeUp;
        private System.Windows.Forms.Button buttonSizeDown;
    }
}

