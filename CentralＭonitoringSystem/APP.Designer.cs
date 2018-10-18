namespace CentralＭonitoringSystem
{
    partial class App
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("主畫面");
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.threeBtnsHidePanel = new System.Windows.Forms.Panel();
            this.btnBuildTable = new GLButton.MyButton();
            this.btnRecord = new GLButton.MyButton();
            this.labelCommunication = new System.Windows.Forms.Label();
            this.labelBuildTable = new System.Windows.Forms.Label();
            this.btnCommunication = new GLButton.MyButton();
            this.labelRecord = new System.Windows.Forms.Label();
            this.labelOK = new System.Windows.Forms.Label();
            this.btnOK = new GLButton.MyButton();
            this.buildingTablePanel = new System.Windows.Forms.Panel();
            this.panelLest.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.treeViewPanel.SuspendLayout();
            this.topMenuToolStrip.SuspendLayout();
            this.menubarPanel.SuspendLayout();
            this.threeBtnsHidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuildTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCommunication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLest
            // 
            this.panelLest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLest.BackColor = System.Drawing.Color.Black;
            this.panelLest.Controls.Add(this.lblTimeNow);
            this.panelLest.Location = new System.Drawing.Point(0, 787);
            this.panelLest.Margin = new System.Windows.Forms.Padding(1);
            this.panelLest.Name = "panelLest";
            this.panelLest.Size = new System.Drawing.Size(1600, 75);
            this.panelLest.TabIndex = 9;
            // 
            // lblTimeNow
            // 
            this.lblTimeNow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimeNow.BackColor = System.Drawing.Color.Black;
            this.lblTimeNow.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTimeNow.ForeColor = System.Drawing.Color.White;
            this.lblTimeNow.Location = new System.Drawing.Point(1239, 2);
            this.lblTimeNow.Name = "lblTimeNow";
            this.lblTimeNow.Size = new System.Drawing.Size(352, 44);
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
            this.toolStrip.Size = new System.Drawing.Size(3289, 22);
            this.toolStrip.TabIndex = 10;
            this.toolStrip.Text = "toolStrip1";
            this.toolStrip.Visible = false;
            // 
            // TSSBtnSelect
            // 
            this.TSSBtnSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSSBtnSelect.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSSBtnSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.TSSBtnSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSSBtnSelect.Name = "TSSBtnSelect";
            this.TSSBtnSelect.Size = new System.Drawing.Size(87, 19);
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
            this.TSSBtnControl.Size = new System.Drawing.Size(89, 19);
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
            this.TSSBtnReport.Size = new System.Drawing.Size(87, 19);
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
            this.TSSBtnOther.Size = new System.Drawing.Size(88, 19);
            this.TSSBtnOther.Text = "其他(o)";
            this.TSSBtnOther.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.TSSBtnOther.ToolTipText = "其他(O)";
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.contentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.contentPanel.Location = new System.Drawing.Point(271, 113);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1329, 674);
            this.contentPanel.TabIndex = 16;
            // 
            // treeViewPanel
            // 
            this.treeViewPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.treeViewPanel.Controls.Add(this.menuTreeView);
            this.treeViewPanel.Location = new System.Drawing.Point(-1, 112);
            this.treeViewPanel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.treeViewPanel.Name = "treeViewPanel";
            this.treeViewPanel.Size = new System.Drawing.Size(275, 682);
            this.treeViewPanel.TabIndex = 15;
            // 
            // menuTreeView
            // 
            this.menuTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.menuTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.menuTreeView.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.menuTreeView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.menuTreeView.LineColor = System.Drawing.Color.White;
            this.menuTreeView.Location = new System.Drawing.Point(0, 28);
            this.menuTreeView.Margin = new System.Windows.Forms.Padding(1);
            this.menuTreeView.Name = "menuTreeView";
            treeNode1.Name = "Node0";
            treeNode1.Text = "主畫面";
            this.menuTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.menuTreeView.Size = new System.Drawing.Size(276, 654);
            this.menuTreeView.TabIndex = 2;
            // 
            // topMenuToolStrip
            // 
            this.topMenuToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.topMenuToolStrip.Controls.Add(this.toolStrip);
            this.topMenuToolStrip.Location = new System.Drawing.Point(-1, 0);
            this.topMenuToolStrip.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.topMenuToolStrip.Name = "topMenuToolStrip";
            this.topMenuToolStrip.Size = new System.Drawing.Size(3289, 35);
            this.topMenuToolStrip.TabIndex = 14;
            // 
            // menubarPanel
            // 
            this.menubarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menubarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.menubarPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menubarPanel.Controls.Add(this.labelTitle);
            this.menubarPanel.Controls.Add(this.threeBtnsHidePanel);
            this.menubarPanel.Controls.Add(this.labelOK);
            this.menubarPanel.Controls.Add(this.btnOK);
            this.menubarPanel.Location = new System.Drawing.Point(0, 32);
            this.menubarPanel.Margin = new System.Windows.Forms.Padding(1);
            this.menubarPanel.Name = "menubarPanel";
            this.menubarPanel.Size = new System.Drawing.Size(1600, 82);
            this.menubarPanel.TabIndex = 13;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.labelTitle.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(486, 11);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(871, 61);
            this.labelTitle.TabIndex = 21;
            this.labelTitle.Text = "中央監控系統";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // threeBtnsHidePanel
            // 
            this.threeBtnsHidePanel.Controls.Add(this.btnBuildTable);
            this.threeBtnsHidePanel.Controls.Add(this.btnRecord);
            this.threeBtnsHidePanel.Controls.Add(this.labelCommunication);
            this.threeBtnsHidePanel.Controls.Add(this.labelBuildTable);
            this.threeBtnsHidePanel.Controls.Add(this.btnCommunication);
            this.threeBtnsHidePanel.Controls.Add(this.labelRecord);
            this.threeBtnsHidePanel.Location = new System.Drawing.Point(8, 6);
            this.threeBtnsHidePanel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.threeBtnsHidePanel.Name = "threeBtnsHidePanel";
            this.threeBtnsHidePanel.Size = new System.Drawing.Size(328, 73);
            this.threeBtnsHidePanel.TabIndex = 20;
            // 
            // btnBuildTable
            // 
            this.btnBuildTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuildTable.Image = global::CentralＭonitoringSystem.Properties.Resources.建表1;
            this.btnBuildTable.ImageHover = global::CentralＭonitoringSystem.Properties.Resources.建表2;
            this.btnBuildTable.ImageNormal = global::CentralＭonitoringSystem.Properties.Resources.建表1;
            this.btnBuildTable.Location = new System.Drawing.Point(234, 4);
            this.btnBuildTable.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnBuildTable.Name = "btnBuildTable";
            this.btnBuildTable.Size = new System.Drawing.Size(88, 50);
            this.btnBuildTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuildTable.TabIndex = 16;
            this.btnBuildTable.TabStop = false;
            this.btnBuildTable.Click += new System.EventHandler(this.BtnBuildTable_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRecord.Image = global::CentralＭonitoringSystem.Properties.Resources.icons8_video_editing_80;
            this.btnRecord.ImageHover = global::CentralＭonitoringSystem.Properties.Resources.icons8_video_editing_80__1_;
            this.btnRecord.ImageNormal = global::CentralＭonitoringSystem.Properties.Resources.icons8_video_editing_80;
            this.btnRecord.Location = new System.Drawing.Point(132, 4);
            this.btnRecord.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(88, 50);
            this.btnRecord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRecord.TabIndex = 10;
            this.btnRecord.TabStop = false;
            this.btnRecord.Click += new System.EventHandler(this.BtnRecord_Click);
            // 
            // labelCommunication
            // 
            this.labelCommunication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.labelCommunication.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelCommunication.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.labelCommunication.Location = new System.Drawing.Point(52, 56);
            this.labelCommunication.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelCommunication.Name = "labelCommunication";
            this.labelCommunication.Size = new System.Drawing.Size(46, 18);
            this.labelCommunication.TabIndex = 15;
            this.labelCommunication.Text = "通訊";
            this.labelCommunication.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBuildTable
            // 
            this.labelBuildTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.labelBuildTable.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelBuildTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.labelBuildTable.Location = new System.Drawing.Point(255, 54);
            this.labelBuildTable.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelBuildTable.Name = "labelBuildTable";
            this.labelBuildTable.Size = new System.Drawing.Size(46, 18);
            this.labelBuildTable.TabIndex = 17;
            this.labelBuildTable.Text = "建表";
            this.labelBuildTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCommunication
            // 
            this.btnCommunication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCommunication.Image = global::CentralＭonitoringSystem.Properties.Resources.icons8_flow_chart_80;
            this.btnCommunication.ImageHover = global::CentralＭonitoringSystem.Properties.Resources.icons8_flow_chart_80__1_;
            this.btnCommunication.ImageNormal = global::CentralＭonitoringSystem.Properties.Resources.icons8_flow_chart_80;
            this.btnCommunication.Location = new System.Drawing.Point(30, 5);
            this.btnCommunication.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnCommunication.Name = "btnCommunication";
            this.btnCommunication.Size = new System.Drawing.Size(88, 50);
            this.btnCommunication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCommunication.TabIndex = 14;
            this.btnCommunication.TabStop = false;
            this.btnCommunication.Click += new System.EventHandler(this.BtnCommunication_Click);
            // 
            // labelRecord
            // 
            this.labelRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.labelRecord.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.labelRecord.Location = new System.Drawing.Point(151, 54);
            this.labelRecord.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelRecord.Name = "labelRecord";
            this.labelRecord.Size = new System.Drawing.Size(46, 18);
            this.labelRecord.TabIndex = 11;
            this.labelRecord.Text = "紀錄";
            this.labelRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOK
            // 
            this.labelOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.labelOK.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.labelOK.Location = new System.Drawing.Point(363, 60);
            this.labelOK.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelOK.Name = "labelOK";
            this.labelOK.Size = new System.Drawing.Size(46, 18);
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
            this.btnOK.Location = new System.Drawing.Point(343, 10);
            this.btnOK.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(88, 50);
            this.btnOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnOK.TabIndex = 18;
            this.btnOK.TabStop = false;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // buildingTablePanel
            // 
            this.buildingTablePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buildingTablePanel.Location = new System.Drawing.Point(0, 112);
            this.buildingTablePanel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buildingTablePanel.Name = "buildingTablePanel";
            this.buildingTablePanel.Size = new System.Drawing.Size(1600, 674);
            this.buildingTablePanel.TabIndex = 17;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1594, 861);
            this.Controls.Add(this.menubarPanel);
            this.Controls.Add(this.panelLest);
            this.Controls.Add(this.treeViewPanel);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.topMenuToolStrip);
            this.Controls.Add(this.buildingTablePanel);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "App";
            this.Text = "中央監控系統";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLest.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.treeViewPanel.ResumeLayout(false);
            this.topMenuToolStrip.ResumeLayout(false);
            this.menubarPanel.ResumeLayout(false);
            this.threeBtnsHidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBuildTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCommunication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).EndInit();
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
        private System.Windows.Forms.Label labelRecord;
        private GLButton.MyButton btnRecord;
        private System.Windows.Forms.Panel buildingTablePanel;
        private System.Windows.Forms.Panel threeBtnsHidePanel;
        private System.Windows.Forms.Label labelTitle;
    }
}

