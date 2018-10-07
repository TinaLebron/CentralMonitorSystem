namespace CentralＭonitoringSystem
{
    partial class APP
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("主畫面");
            this.panelLest = new System.Windows.Forms.Panel();
            this.lblTimeNow = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.TSSBtnSelect = new System.Windows.Forms.ToolStripSplitButton();
            this.TSSBtnControl = new System.Windows.Forms.ToolStripSplitButton();
            this.TSSBtnReport = new System.Windows.Forms.ToolStripSplitButton();
            this.TSSBtnOther = new System.Windows.Forms.ToolStripSplitButton();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.treeViewPanel = new System.Windows.Forms.Panel();
            this.menuTreeView = new System.Windows.Forms.TreeView();
            this.topMenuToolStrip = new System.Windows.Forms.Panel();
            this.menubarPanel = new System.Windows.Forms.Panel();
            this.labelOK = new System.Windows.Forms.Label();
            this.btnOK = new GLButton.MyButton();
            this.labelBuildTable = new System.Windows.Forms.Label();
            this.btnBuildTable = new GLButton.MyButton();
            this.labelCommunication = new System.Windows.Forms.Label();
            this.btnCommunication = new GLButton.MyButton();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelRecord = new System.Windows.Forms.Label();
            this.btnRecord = new GLButton.MyButton();
            this.buildingTablePanel = new System.Windows.Forms.Panel();
            this.threeBtnsHidePanel = new System.Windows.Forms.Panel();
            this.panelLest.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.treeViewPanel.SuspendLayout();
            this.topMenuToolStrip.SuspendLayout();
            this.menubarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuildTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCommunication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecord)).BeginInit();
            this.threeBtnsHidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLest
            // 
            this.panelLest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLest.BackColor = System.Drawing.Color.Black;
            this.panelLest.Controls.Add(this.lblTimeNow);
            this.panelLest.Location = new System.Drawing.Point(0, 1574);
            this.panelLest.Margin = new System.Windows.Forms.Padding(2);
            this.panelLest.Name = "panelLest";
            this.panelLest.Size = new System.Drawing.Size(3467, 150);
            this.panelLest.TabIndex = 9;
            // 
            // lblTimeNow
            // 
            this.lblTimeNow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimeNow.BackColor = System.Drawing.Color.Black;
            this.lblTimeNow.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTimeNow.ForeColor = System.Drawing.Color.White;
            this.lblTimeNow.Location = new System.Drawing.Point(2968, 4);
            this.lblTimeNow.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTimeNow.Name = "lblTimeNow";
            this.lblTimeNow.Size = new System.Drawing.Size(444, 88);
            this.lblTimeNow.TabIndex = 9;
            this.lblTimeNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSBtnSelect,
            this.TSSBtnControl,
            this.TSSBtnReport,
            this.TSSBtnOther});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip.Size = new System.Drawing.Size(7126, 45);
            this.toolStrip.TabIndex = 10;
            this.toolStrip.Text = "toolStrip1";
            // 
            // TSSBtnSelect
            // 
            this.TSSBtnSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSSBtnSelect.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSSBtnSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.TSSBtnSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSSBtnSelect.Name = "TSSBtnSelect";
            this.TSSBtnSelect.Size = new System.Drawing.Size(166, 42);
            this.TSSBtnSelect.Text = "查詢(S)";
            this.TSSBtnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.TSSBtnSelect.ToolTipText = "查詢\r\n";
            // 
            // TSSBtnControl
            // 
            this.TSSBtnControl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSSBtnControl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TSSBtnControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.TSSBtnControl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSSBtnControl.Name = "TSSBtnControl";
            this.TSSBtnControl.Size = new System.Drawing.Size(170, 42);
            this.TSSBtnControl.Text = "控制(C)";
            this.TSSBtnControl.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // TSSBtnReport
            // 
            this.TSSBtnReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSSBtnReport.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TSSBtnReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.TSSBtnReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSSBtnReport.Name = "TSSBtnReport";
            this.TSSBtnReport.Size = new System.Drawing.Size(167, 42);
            this.TSSBtnReport.Text = "報表(P)";
            this.TSSBtnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.TSSBtnReport.ToolTipText = "報表(P)";
            // 
            // TSSBtnOther
            // 
            this.TSSBtnOther.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSSBtnOther.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TSSBtnOther.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.TSSBtnOther.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSSBtnOther.Name = "TSSBtnOther";
            this.TSSBtnOther.Size = new System.Drawing.Size(168, 42);
            this.TSSBtnOther.Text = "其他(o)";
            this.TSSBtnOther.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.TSSBtnOther.ToolTipText = "其他(O)";
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.contentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.contentPanel.Location = new System.Drawing.Point(621, 223);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(2878, 1349);
            this.contentPanel.TabIndex = 16;
            // 
            // treeViewPanel
            // 
            this.treeViewPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.treeViewPanel.Controls.Add(this.menuTreeView);
            this.treeViewPanel.Location = new System.Drawing.Point(3, 226);
            this.treeViewPanel.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.treeViewPanel.Name = "treeViewPanel";
            this.treeViewPanel.Size = new System.Drawing.Size(596, 1364);
            this.treeViewPanel.TabIndex = 15;
            // 
            // menuTreeView
            // 
            this.menuTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.menuTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.menuTreeView.Font = new System.Drawing.Font("PMingLiU", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.menuTreeView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.menuTreeView.LineColor = System.Drawing.Color.White;
            this.menuTreeView.Location = new System.Drawing.Point(0, 32);
            this.menuTreeView.Margin = new System.Windows.Forms.Padding(2);
            this.menuTreeView.Name = "menuTreeView";
            treeNode2.Name = "Node0";
            treeNode2.Text = "主畫面";
            this.menuTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.menuTreeView.Size = new System.Drawing.Size(598, 1332);
            this.menuTreeView.TabIndex = 2;
            // 
            // topMenuToolStrip
            // 
            this.topMenuToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.topMenuToolStrip.Controls.Add(this.toolStrip);
            this.topMenuToolStrip.Location = new System.Drawing.Point(-2, 1);
            this.topMenuToolStrip.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.topMenuToolStrip.Name = "topMenuToolStrip";
            this.topMenuToolStrip.Size = new System.Drawing.Size(7126, 70);
            this.topMenuToolStrip.TabIndex = 14;
            // 
            // menubarPanel
            // 
            this.menubarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menubarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.menubarPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menubarPanel.Controls.Add(this.threeBtnsHidePanel);
            this.menubarPanel.Controls.Add(this.labelOK);
            this.menubarPanel.Controls.Add(this.btnOK);
            this.menubarPanel.Controls.Add(this.labelTitle);
            this.menubarPanel.Location = new System.Drawing.Point(0, 63);
            this.menubarPanel.Margin = new System.Windows.Forms.Padding(2);
            this.menubarPanel.Name = "menubarPanel";
            this.menubarPanel.Size = new System.Drawing.Size(3467, 164);
            this.menubarPanel.TabIndex = 13;
            // 
            // labelOK
            // 
            this.labelOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.labelOK.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.labelOK.Location = new System.Drawing.Point(787, 120);
            this.labelOK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOK.Name = "labelOK";
            this.labelOK.Size = new System.Drawing.Size(100, 36);
            this.labelOK.TabIndex = 19;
            this.labelOK.Text = "確認";
            this.labelOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOK
            // 
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOK.Image = global::CentralＭonitoringSystem.Properties.Resources.確定1;
            this.btnOK.ImageHover = global::CentralＭonitoringSystem.Properties.Resources.確定2;
            this.btnOK.ImageNormal = global::CentralＭonitoringSystem.Properties.Resources.確定1;
            this.btnOK.Location = new System.Drawing.Point(743, 20);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(191, 100);
            this.btnOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnOK.TabIndex = 18;
            this.btnOK.TabStop = false;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // labelBuildTable
            // 
            this.labelBuildTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.labelBuildTable.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelBuildTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.labelBuildTable.Location = new System.Drawing.Point(552, 108);
            this.labelBuildTable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBuildTable.Name = "labelBuildTable";
            this.labelBuildTable.Size = new System.Drawing.Size(100, 36);
            this.labelBuildTable.TabIndex = 17;
            this.labelBuildTable.Text = "建表";
            this.labelBuildTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBuildTable
            // 
            this.btnBuildTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuildTable.Image = global::CentralＭonitoringSystem.Properties.Resources.建表1;
            this.btnBuildTable.ImageHover = global::CentralＭonitoringSystem.Properties.Resources.建表2;
            this.btnBuildTable.ImageNormal = global::CentralＭonitoringSystem.Properties.Resources.建表1;
            this.btnBuildTable.Location = new System.Drawing.Point(508, 8);
            this.btnBuildTable.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnBuildTable.Name = "btnBuildTable";
            this.btnBuildTable.Size = new System.Drawing.Size(191, 100);
            this.btnBuildTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuildTable.TabIndex = 16;
            this.btnBuildTable.TabStop = false;
            this.btnBuildTable.Click += new System.EventHandler(this.BtnBuildTable_Click);
            // 
            // labelCommunication
            // 
            this.labelCommunication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.labelCommunication.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelCommunication.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.labelCommunication.Location = new System.Drawing.Point(112, 112);
            this.labelCommunication.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCommunication.Name = "labelCommunication";
            this.labelCommunication.Size = new System.Drawing.Size(100, 36);
            this.labelCommunication.TabIndex = 15;
            this.labelCommunication.Text = "通訊";
            this.labelCommunication.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCommunication
            // 
            this.btnCommunication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCommunication.Image = global::CentralＭonitoringSystem.Properties.Resources.icons8_flow_chart_80;
            this.btnCommunication.ImageHover = global::CentralＭonitoringSystem.Properties.Resources.icons8_flow_chart_80__1_;
            this.btnCommunication.ImageNormal = global::CentralＭonitoringSystem.Properties.Resources.icons8_flow_chart_80;
            this.btnCommunication.Location = new System.Drawing.Point(66, 10);
            this.btnCommunication.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnCommunication.Name = "btnCommunication";
            this.btnCommunication.Size = new System.Drawing.Size(191, 100);
            this.btnCommunication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCommunication.TabIndex = 14;
            this.btnCommunication.TabStop = false;
            this.btnCommunication.Click += new System.EventHandler(this.BtnCommunication_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.labelTitle.Font = new System.Drawing.Font("PMingLiU", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(977, 20);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(2388, 122);
            this.labelTitle.TabIndex = 13;
            this.labelTitle.Text = "中央監控系統";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRecord
            // 
            this.labelRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.labelRecord.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.labelRecord.Location = new System.Drawing.Point(328, 108);
            this.labelRecord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRecord.Name = "labelRecord";
            this.labelRecord.Size = new System.Drawing.Size(100, 36);
            this.labelRecord.TabIndex = 11;
            this.labelRecord.Text = "紀錄";
            this.labelRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRecord
            // 
            this.btnRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRecord.Image = global::CentralＭonitoringSystem.Properties.Resources.icons8_video_editing_80;
            this.btnRecord.ImageHover = global::CentralＭonitoringSystem.Properties.Resources.icons8_video_editing_80__1_;
            this.btnRecord.ImageNormal = global::CentralＭonitoringSystem.Properties.Resources.icons8_video_editing_80;
            this.btnRecord.Location = new System.Drawing.Point(285, 8);
            this.btnRecord.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(191, 100);
            this.btnRecord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRecord.TabIndex = 10;
            this.btnRecord.TabStop = false;
            this.btnRecord.Click += new System.EventHandler(this.BtnRecord_Click);
            // 
            // buildingTablePanel
            // 
            this.buildingTablePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buildingTablePanel.Location = new System.Drawing.Point(0, 225);
            this.buildingTablePanel.Name = "buildingTablePanel";
            this.buildingTablePanel.Size = new System.Drawing.Size(3086, 1347);
            this.buildingTablePanel.TabIndex = 17;
            // 
            // threeBtnsHidePanel
            // 
            this.threeBtnsHidePanel.Controls.Add(this.btnBuildTable);
            this.threeBtnsHidePanel.Controls.Add(this.btnRecord);
            this.threeBtnsHidePanel.Controls.Add(this.labelCommunication);
            this.threeBtnsHidePanel.Controls.Add(this.labelBuildTable);
            this.threeBtnsHidePanel.Controls.Add(this.btnCommunication);
            this.threeBtnsHidePanel.Controls.Add(this.labelRecord);
            this.threeBtnsHidePanel.Location = new System.Drawing.Point(17, 12);
            this.threeBtnsHidePanel.Name = "threeBtnsHidePanel";
            this.threeBtnsHidePanel.Size = new System.Drawing.Size(711, 146);
            this.threeBtnsHidePanel.TabIndex = 20;
            // 
            // APP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(2884, 1722);
            this.Controls.Add(this.treeViewPanel);
            this.Controls.Add(this.panelLest);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.topMenuToolStrip);
            this.Controls.Add(this.menubarPanel);
            this.Controls.Add(this.buildingTablePanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "APP";
            this.Text = "中央監控系統";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLest.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.treeViewPanel.ResumeLayout(false);
            this.topMenuToolStrip.ResumeLayout(false);
            this.menubarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuildTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCommunication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecord)).EndInit();
            this.threeBtnsHidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelLest;
        private System.Windows.Forms.Label lblTimeNow;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripSplitButton TSSBtnSelect;
        private System.Windows.Forms.ToolStripSplitButton TSSBtnControl;
        private System.Windows.Forms.ToolStripSplitButton TSSBtnReport;
        private System.Windows.Forms.ToolStripSplitButton TSSBtnOther;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel treeViewPanel;
        private System.Windows.Forms.TreeView menuTreeView;
        private System.Windows.Forms.Panel topMenuToolStrip;
        private System.Windows.Forms.Panel menubarPanel;
        private System.Windows.Forms.Label labelOK;
        private GLButton.MyButton btnOK;
        private System.Windows.Forms.Label labelBuildTable;
        private GLButton.MyButton btnBuildTable;
        private System.Windows.Forms.Label labelCommunication;
        private GLButton.MyButton btnCommunication;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelRecord;
        private GLButton.MyButton btnRecord;
        private System.Windows.Forms.Panel buildingTablePanel;
        private System.Windows.Forms.Panel threeBtnsHidePanel;
    }
}

