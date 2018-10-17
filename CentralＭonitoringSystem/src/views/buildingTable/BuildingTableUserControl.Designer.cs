namespace CentralＭonitoringSystem.src.views
{
    partial class BuildingTableUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelOutside = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.groupBoxTypeSetting = new System.Windows.Forms.GroupBox();
            this.rbBare = new System.Windows.Forms.RadioButton();
            this.rb8DO = new System.Windows.Forms.RadioButton();
            this.rb16DI = new System.Windows.Forms.RadioButton();
            this.gridViewStationCode = new System.Windows.Forms.DataGridView();
            this.groupBoxActionSetting = new System.Windows.Forms.GroupBox();
            this.rbActionClose = new System.Windows.Forms.RadioButton();
            this.rbActionOpen = new System.Windows.Forms.RadioButton();
            this.panelRight = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBoxPoints = new System.Windows.Forms.GroupBox();
            this.rbPoints16 = new System.Windows.Forms.RadioButton();
            this.rbPoints15 = new System.Windows.Forms.RadioButton();
            this.rbPoints14 = new System.Windows.Forms.RadioButton();
            this.rbPoints13 = new System.Windows.Forms.RadioButton();
            this.rbPoints12 = new System.Windows.Forms.RadioButton();
            this.rbPoints11 = new System.Windows.Forms.RadioButton();
            this.rbPoints10 = new System.Windows.Forms.RadioButton();
            this.rbPoints9 = new System.Windows.Forms.RadioButton();
            this.rbPoints8 = new System.Windows.Forms.RadioButton();
            this.rbPoints7 = new System.Windows.Forms.RadioButton();
            this.rbPoints6 = new System.Windows.Forms.RadioButton();
            this.rbPoints5 = new System.Windows.Forms.RadioButton();
            this.rbPoints4 = new System.Windows.Forms.RadioButton();
            this.rbPoints3 = new System.Windows.Forms.RadioButton();
            this.rbPoints2 = new System.Windows.Forms.RadioButton();
            this.rbPoints1 = new System.Windows.Forms.RadioButton();
            this.groupBoxSignalPreset = new System.Windows.Forms.GroupBox();
            this.rbSignalPresetClose = new System.Windows.Forms.RadioButton();
            this.rbSignalPresetOpen = new System.Windows.Forms.RadioButton();
            this.groupBoxSignalType = new System.Windows.Forms.GroupBox();
            this.rbSignalTypeClose = new System.Windows.Forms.RadioButton();
            this.rbSignalTypeOpen = new System.Windows.Forms.RadioButton();
            this.groupBoxAlarmOutput = new System.Windows.Forms.GroupBox();
            this.rbAlarmOutputClose = new System.Windows.Forms.RadioButton();
            this.rbAlarmOutputOpen = new System.Windows.Forms.RadioButton();
            this.dataGridViewSelectInformation = new System.Windows.Forms.DataGridView();
            this.tbYCoordinate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbXCoordinate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGraphicPositioning = new System.Windows.Forms.Button();
            this.tbTitleContent = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSignalAnomalyFileName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNormalSignalFileName = new System.Windows.Forms.TextBox();
            this.labelNormalSignalFileName = new System.Windows.Forms.Label();
            this.tbSignalAnomalyDisplayText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSignalDisplayTextNormally = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSignalDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbGroup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelOutside.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.groupBoxTypeSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStationCode)).BeginInit();
            this.groupBoxActionSetting.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxPoints.SuspendLayout();
            this.groupBoxSignalPreset.SuspendLayout();
            this.groupBoxSignalType.SuspendLayout();
            this.groupBoxAlarmOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOutside
            // 
            this.panelOutside.Controls.Add(this.panelLeft);
            this.panelOutside.Controls.Add(this.panelRight);
            this.panelOutside.Location = new System.Drawing.Point(0, 26);
            this.panelOutside.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panelOutside.Name = "panelOutside";
            this.panelOutside.Size = new System.Drawing.Size(3257, 1400);
            this.panelOutside.TabIndex = 1;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.groupBoxTypeSetting);
            this.panelLeft.Controls.Add(this.gridViewStationCode);
            this.panelLeft.Controls.Add(this.groupBoxActionSetting);
            this.panelLeft.Font = new System.Drawing.Font("PMingLiU", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panelLeft.Location = new System.Drawing.Point(7, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(930, 1422);
            this.panelLeft.TabIndex = 30;
            // 
            // groupBoxTypeSetting
            // 
            this.groupBoxTypeSetting.BackColor = System.Drawing.Color.Gray;
            this.groupBoxTypeSetting.Controls.Add(this.rbBare);
            this.groupBoxTypeSetting.Controls.Add(this.rb8DO);
            this.groupBoxTypeSetting.Controls.Add(this.rb16DI);
            this.groupBoxTypeSetting.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBoxTypeSetting.ForeColor = System.Drawing.Color.White;
            this.groupBoxTypeSetting.Location = new System.Drawing.Point(87, 1036);
            this.groupBoxTypeSetting.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBoxTypeSetting.Name = "groupBoxTypeSetting";
            this.groupBoxTypeSetting.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBoxTypeSetting.Size = new System.Drawing.Size(310, 356);
            this.groupBoxTypeSetting.TabIndex = 0;
            this.groupBoxTypeSetting.TabStop = false;
            this.groupBoxTypeSetting.Text = "種類設定";
            // 
            // rbBare
            // 
            this.rbBare.AutoSize = true;
            this.rbBare.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbBare.Location = new System.Drawing.Point(61, 206);
            this.rbBare.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.rbBare.Name = "rbBare";
            this.rbBare.Size = new System.Drawing.Size(27, 26);
            this.rbBare.TabIndex = 2;
            this.rbBare.TabStop = true;
            this.rbBare.UseVisualStyleBackColor = true;
            // 
            // rb8DO
            // 
            this.rb8DO.AutoSize = true;
            this.rb8DO.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rb8DO.Location = new System.Drawing.Point(61, 144);
            this.rb8DO.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.rb8DO.Name = "rb8DO";
            this.rb8DO.Size = new System.Drawing.Size(125, 46);
            this.rb8DO.TabIndex = 1;
            this.rb8DO.TabStop = true;
            this.rb8DO.Text = "8DO";
            this.rb8DO.UseVisualStyleBackColor = true;
            // 
            // rb16DI
            // 
            this.rb16DI.AutoSize = true;
            this.rb16DI.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rb16DI.Location = new System.Drawing.Point(61, 76);
            this.rb16DI.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.rb16DI.Name = "rb16DI";
            this.rb16DI.Size = new System.Drawing.Size(130, 46);
            this.rb16DI.TabIndex = 0;
            this.rb16DI.TabStop = true;
            this.rb16DI.Text = "16DI";
            this.rb16DI.UseVisualStyleBackColor = true;
            // 
            // gridViewStationCode
            // 
            this.gridViewStationCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewStationCode.Location = new System.Drawing.Point(61, 16);
            this.gridViewStationCode.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.gridViewStationCode.Name = "gridViewStationCode";
            this.gridViewStationCode.RowTemplate.Height = 24;
            this.gridViewStationCode.Size = new System.Drawing.Size(780, 984);
            this.gridViewStationCode.TabIndex = 3;
            // 
            // groupBoxActionSetting
            // 
            this.groupBoxActionSetting.BackColor = System.Drawing.Color.Gray;
            this.groupBoxActionSetting.Controls.Add(this.rbActionClose);
            this.groupBoxActionSetting.Controls.Add(this.rbActionOpen);
            this.groupBoxActionSetting.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBoxActionSetting.ForeColor = System.Drawing.Color.White;
            this.groupBoxActionSetting.Location = new System.Drawing.Point(498, 1036);
            this.groupBoxActionSetting.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBoxActionSetting.Name = "groupBoxActionSetting";
            this.groupBoxActionSetting.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBoxActionSetting.Size = new System.Drawing.Size(338, 284);
            this.groupBoxActionSetting.TabIndex = 1;
            this.groupBoxActionSetting.TabStop = false;
            this.groupBoxActionSetting.Text = "動作設定";
            // 
            // rbActionClose
            // 
            this.rbActionClose.AutoSize = true;
            this.rbActionClose.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbActionClose.Location = new System.Drawing.Point(61, 166);
            this.rbActionClose.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.rbActionClose.Name = "rbActionClose";
            this.rbActionClose.Size = new System.Drawing.Size(133, 46);
            this.rbActionClose.TabIndex = 1;
            this.rbActionClose.TabStop = true;
            this.rbActionClose.Text = "關閉";
            this.rbActionClose.UseVisualStyleBackColor = true;
            // 
            // rbActionOpen
            // 
            this.rbActionOpen.AutoSize = true;
            this.rbActionOpen.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbActionOpen.Location = new System.Drawing.Point(61, 76);
            this.rbActionOpen.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.rbActionOpen.Name = "rbActionOpen";
            this.rbActionOpen.Size = new System.Drawing.Size(133, 46);
            this.rbActionOpen.TabIndex = 0;
            this.rbActionOpen.TabStop = true;
            this.rbActionOpen.Text = "開啟";
            this.rbActionOpen.UseVisualStyleBackColor = true;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.btnSave);
            this.panelRight.Controls.Add(this.panel1);
            this.panelRight.Controls.Add(this.groupBoxPoints);
            this.panelRight.Controls.Add(this.groupBoxSignalPreset);
            this.panelRight.Controls.Add(this.groupBoxSignalType);
            this.panelRight.Controls.Add(this.groupBoxAlarmOutput);
            this.panelRight.Controls.Add(this.dataGridViewSelectInformation);
            this.panelRight.Controls.Add(this.tbYCoordinate);
            this.panelRight.Controls.Add(this.label9);
            this.panelRight.Controls.Add(this.tbXCoordinate);
            this.panelRight.Controls.Add(this.label8);
            this.panelRight.Controls.Add(this.btnGraphicPositioning);
            this.panelRight.Controls.Add(this.tbTitleContent);
            this.panelRight.Controls.Add(this.label7);
            this.panelRight.Controls.Add(this.tbSignalAnomalyFileName);
            this.panelRight.Controls.Add(this.label6);
            this.panelRight.Controls.Add(this.tbNormalSignalFileName);
            this.panelRight.Controls.Add(this.labelNormalSignalFileName);
            this.panelRight.Controls.Add(this.tbSignalAnomalyDisplayText);
            this.panelRight.Controls.Add(this.label4);
            this.panelRight.Controls.Add(this.tbSignalDisplayTextNormally);
            this.panelRight.Controls.Add(this.label3);
            this.panelRight.Controls.Add(this.tbSignalDescription);
            this.panelRight.Controls.Add(this.label2);
            this.panelRight.Controls.Add(this.tbGroup);
            this.panelRight.Controls.Add(this.label1);
            this.panelRight.Font = new System.Drawing.Font("PMingLiU", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panelRight.Location = new System.Drawing.Point(934, 0);
            this.panelRight.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(2323, 1422);
            this.panelRight.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(440, 1114);
            this.btnSave.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(264, 154);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(82, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 202);
            this.panel1.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(59, 24);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 156);
            this.button1.TabIndex = 8;
            this.button1.Text = "群號編輯";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(329, 24);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(234, 156);
            this.button2.TabIndex = 9;
            this.button2.Text = "目錄編輯";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // groupBoxPoints
            // 
            this.groupBoxPoints.BackColor = System.Drawing.Color.Gray;
            this.groupBoxPoints.Controls.Add(this.rbPoints16);
            this.groupBoxPoints.Controls.Add(this.rbPoints15);
            this.groupBoxPoints.Controls.Add(this.rbPoints14);
            this.groupBoxPoints.Controls.Add(this.rbPoints13);
            this.groupBoxPoints.Controls.Add(this.rbPoints12);
            this.groupBoxPoints.Controls.Add(this.rbPoints11);
            this.groupBoxPoints.Controls.Add(this.rbPoints10);
            this.groupBoxPoints.Controls.Add(this.rbPoints9);
            this.groupBoxPoints.Controls.Add(this.rbPoints8);
            this.groupBoxPoints.Controls.Add(this.rbPoints7);
            this.groupBoxPoints.Controls.Add(this.rbPoints6);
            this.groupBoxPoints.Controls.Add(this.rbPoints5);
            this.groupBoxPoints.Controls.Add(this.rbPoints4);
            this.groupBoxPoints.Controls.Add(this.rbPoints3);
            this.groupBoxPoints.Controls.Add(this.rbPoints2);
            this.groupBoxPoints.Controls.Add(this.rbPoints1);
            this.groupBoxPoints.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBoxPoints.ForeColor = System.Drawing.Color.White;
            this.groupBoxPoints.Location = new System.Drawing.Point(169, 260);
            this.groupBoxPoints.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBoxPoints.Name = "groupBoxPoints";
            this.groupBoxPoints.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBoxPoints.Size = new System.Drawing.Size(169, 1016);
            this.groupBoxPoints.TabIndex = 33;
            this.groupBoxPoints.TabStop = false;
            this.groupBoxPoints.Text = "點數";
            this.groupBoxPoints.Enter += new System.EventHandler(this.groupBoxPoints_Enter);
            // 
            // rbPoints16
            // 
            this.rbPoints16.AutoSize = true;
            this.rbPoints16.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbPoints16.Location = new System.Drawing.Point(61, 956);
            this.rbPoints16.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.rbPoints16.Name = "rbPoints16";
            this.rbPoints16.Size = new System.Drawing.Size(89, 46);
            this.rbPoints16.TabIndex = 15;
            this.rbPoints16.TabStop = true;
            this.rbPoints16.Text = "16";
            this.rbPoints16.UseVisualStyleBackColor = true;
            // 
            // rbPoints15
            // 
            this.rbPoints15.AutoSize = true;
            this.rbPoints15.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbPoints15.Location = new System.Drawing.Point(61, 898);
            this.rbPoints15.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.rbPoints15.Name = "rbPoints15";
            this.rbPoints15.Size = new System.Drawing.Size(89, 46);
            this.rbPoints15.TabIndex = 14;
            this.rbPoints15.TabStop = true;
            this.rbPoints15.Text = "15";
            this.rbPoints15.UseVisualStyleBackColor = true;
            // 
            // rbPoints14
            // 
            this.rbPoints14.AutoSize = true;
            this.rbPoints14.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbPoints14.Location = new System.Drawing.Point(61, 840);
            this.rbPoints14.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.rbPoints14.Name = "rbPoints14";
            this.rbPoints14.Size = new System.Drawing.Size(89, 46);
            this.rbPoints14.TabIndex = 13;
            this.rbPoints14.TabStop = true;
            this.rbPoints14.Text = "14";
            this.rbPoints14.UseVisualStyleBackColor = true;
            // 
            // rbPoints13
            // 
            this.rbPoints13.AutoSize = true;
            this.rbPoints13.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbPoints13.Location = new System.Drawing.Point(61, 782);
            this.rbPoints13.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.rbPoints13.Name = "rbPoints13";
            this.rbPoints13.Size = new System.Drawing.Size(89, 46);
            this.rbPoints13.TabIndex = 12;
            this.rbPoints13.TabStop = true;
            this.rbPoints13.Text = "13";
            this.rbPoints13.UseVisualStyleBackColor = true;
            // 
            // rbPoints12
            // 
            this.rbPoints12.AutoSize = true;
            this.rbPoints12.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbPoints12.Location = new System.Drawing.Point(61, 724);
            this.rbPoints12.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.rbPoints12.Name = "rbPoints12";
            this.rbPoints12.Size = new System.Drawing.Size(89, 46);
            this.rbPoints12.TabIndex = 11;
            this.rbPoints12.TabStop = true;
            this.rbPoints12.Text = "12";
            this.rbPoints12.UseVisualStyleBackColor = true;
            // 
            // rbPoints11
            // 
            this.rbPoints11.AutoSize = true;
            this.rbPoints11.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbPoints11.Location = new System.Drawing.Point(61, 666);
            this.rbPoints11.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.rbPoints11.Name = "rbPoints11";
            this.rbPoints11.Size = new System.Drawing.Size(89, 46);
            this.rbPoints11.TabIndex = 10;
            this.rbPoints11.TabStop = true;
            this.rbPoints11.Text = "11";
            this.rbPoints11.UseVisualStyleBackColor = true;
            // 
            // rbPoints10
            // 
            this.rbPoints10.AutoSize = true;
            this.rbPoints10.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbPoints10.Location = new System.Drawing.Point(61, 608);
            this.rbPoints10.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.rbPoints10.Name = "rbPoints10";
            this.rbPoints10.Size = new System.Drawing.Size(89, 46);
            this.rbPoints10.TabIndex = 9;
            this.rbPoints10.TabStop = true;
            this.rbPoints10.Text = "10";
            this.rbPoints10.UseVisualStyleBackColor = true;
            // 
            // rbPoints9
            // 
            this.rbPoints9.AutoSize = true;
            this.rbPoints9.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbPoints9.Location = new System.Drawing.Point(61, 550);
            this.rbPoints9.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.rbPoints9.Name = "rbPoints9";
            this.rbPoints9.Size = new System.Drawing.Size(69, 46);
            this.rbPoints9.TabIndex = 8;
            this.rbPoints9.TabStop = true;
            this.rbPoints9.Text = "9";
            this.rbPoints9.UseVisualStyleBackColor = true;
            // 
            // rbPoints8
            // 
            this.rbPoints8.AutoSize = true;
            this.rbPoints8.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbPoints8.Location = new System.Drawing.Point(61, 492);
            this.rbPoints8.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.rbPoints8.Name = "rbPoints8";
            this.rbPoints8.Size = new System.Drawing.Size(69, 46);
            this.rbPoints8.TabIndex = 7;
            this.rbPoints8.TabStop = true;
            this.rbPoints8.Text = "8";
            this.rbPoints8.UseVisualStyleBackColor = true;
            // 
            // rbPoints7
            // 
            this.rbPoints7.AutoSize = true;
            this.rbPoints7.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbPoints7.Location = new System.Drawing.Point(61, 434);
            this.rbPoints7.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.rbPoints7.Name = "rbPoints7";
            this.rbPoints7.Size = new System.Drawing.Size(69, 46);
            this.rbPoints7.TabIndex = 6;
            this.rbPoints7.TabStop = true;
            this.rbPoints7.Text = "7";
            this.rbPoints7.UseVisualStyleBackColor = true;
            // 
            // rbPoints6
            // 
            this.rbPoints6.AutoSize = true;
            this.rbPoints6.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbPoints6.Location = new System.Drawing.Point(61, 376);
            this.rbPoints6.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.rbPoints6.Name = "rbPoints6";
            this.rbPoints6.Size = new System.Drawing.Size(69, 46);
            this.rbPoints6.TabIndex = 5;
            this.rbPoints6.TabStop = true;
            this.rbPoints6.Text = "6";
            this.rbPoints6.UseVisualStyleBackColor = true;
            // 
            // rbPoints5
            // 
            this.rbPoints5.AutoSize = true;
            this.rbPoints5.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbPoints5.Location = new System.Drawing.Point(61, 318);
            this.rbPoints5.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.rbPoints5.Name = "rbPoints5";
            this.rbPoints5.Size = new System.Drawing.Size(69, 46);
            this.rbPoints5.TabIndex = 4;
            this.rbPoints5.TabStop = true;
            this.rbPoints5.Text = "5";
            this.rbPoints5.UseVisualStyleBackColor = true;
            // 
            // rbPoints4
            // 
            this.rbPoints4.AutoSize = true;
            this.rbPoints4.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbPoints4.Location = new System.Drawing.Point(61, 260);
            this.rbPoints4.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.rbPoints4.Name = "rbPoints4";
            this.rbPoints4.Size = new System.Drawing.Size(69, 46);
            this.rbPoints4.TabIndex = 3;
            this.rbPoints4.TabStop = true;
            this.rbPoints4.Text = "4";
            this.rbPoints4.UseVisualStyleBackColor = true;
            // 
            // rbPoints3
            // 
            this.rbPoints3.AutoSize = true;
            this.rbPoints3.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbPoints3.Location = new System.Drawing.Point(61, 202);
            this.rbPoints3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.rbPoints3.Name = "rbPoints3";
            this.rbPoints3.Size = new System.Drawing.Size(69, 46);
            this.rbPoints3.TabIndex = 2;
            this.rbPoints3.TabStop = true;
            this.rbPoints3.Text = "3";
            this.rbPoints3.UseVisualStyleBackColor = true;
            // 
            // rbPoints2
            // 
            this.rbPoints2.AutoSize = true;
            this.rbPoints2.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbPoints2.Location = new System.Drawing.Point(61, 144);
            this.rbPoints2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.rbPoints2.Name = "rbPoints2";
            this.rbPoints2.Size = new System.Drawing.Size(69, 46);
            this.rbPoints2.TabIndex = 1;
            this.rbPoints2.TabStop = true;
            this.rbPoints2.Text = "2";
            this.rbPoints2.UseVisualStyleBackColor = true;
            // 
            // rbPoints1
            // 
            this.rbPoints1.AutoSize = true;
            this.rbPoints1.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbPoints1.Location = new System.Drawing.Point(61, 96);
            this.rbPoints1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.rbPoints1.Name = "rbPoints1";
            this.rbPoints1.Size = new System.Drawing.Size(69, 46);
            this.rbPoints1.TabIndex = 0;
            this.rbPoints1.TabStop = true;
            this.rbPoints1.Text = "1";
            this.rbPoints1.UseVisualStyleBackColor = true;
            // 
            // groupBoxSignalPreset
            // 
            this.groupBoxSignalPreset.BackColor = System.Drawing.Color.Gray;
            this.groupBoxSignalPreset.Controls.Add(this.rbSignalPresetClose);
            this.groupBoxSignalPreset.Controls.Add(this.rbSignalPresetOpen);
            this.groupBoxSignalPreset.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBoxSignalPreset.ForeColor = System.Drawing.Color.White;
            this.groupBoxSignalPreset.Location = new System.Drawing.Point(412, 794);
            this.groupBoxSignalPreset.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBoxSignalPreset.Name = "groupBoxSignalPreset";
            this.groupBoxSignalPreset.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBoxSignalPreset.Size = new System.Drawing.Size(269, 240);
            this.groupBoxSignalPreset.TabIndex = 32;
            this.groupBoxSignalPreset.TabStop = false;
            this.groupBoxSignalPreset.Text = "信號預設";
            // 
            // rbSignalPresetClose
            // 
            this.rbSignalPresetClose.AutoSize = true;
            this.rbSignalPresetClose.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbSignalPresetClose.Location = new System.Drawing.Point(61, 166);
            this.rbSignalPresetClose.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.rbSignalPresetClose.Name = "rbSignalPresetClose";
            this.rbSignalPresetClose.Size = new System.Drawing.Size(133, 46);
            this.rbSignalPresetClose.TabIndex = 1;
            this.rbSignalPresetClose.TabStop = true;
            this.rbSignalPresetClose.Text = "常閉";
            this.rbSignalPresetClose.UseVisualStyleBackColor = true;
            // 
            // rbSignalPresetOpen
            // 
            this.rbSignalPresetOpen.AutoSize = true;
            this.rbSignalPresetOpen.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbSignalPresetOpen.Location = new System.Drawing.Point(61, 76);
            this.rbSignalPresetOpen.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.rbSignalPresetOpen.Name = "rbSignalPresetOpen";
            this.rbSignalPresetOpen.Size = new System.Drawing.Size(133, 46);
            this.rbSignalPresetOpen.TabIndex = 0;
            this.rbSignalPresetOpen.TabStop = true;
            this.rbSignalPresetOpen.Text = "常開";
            this.rbSignalPresetOpen.UseVisualStyleBackColor = true;
            // 
            // groupBoxSignalType
            // 
            this.groupBoxSignalType.BackColor = System.Drawing.Color.Gray;
            this.groupBoxSignalType.Controls.Add(this.rbSignalTypeClose);
            this.groupBoxSignalType.Controls.Add(this.rbSignalTypeOpen);
            this.groupBoxSignalType.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBoxSignalType.ForeColor = System.Drawing.Color.White;
            this.groupBoxSignalType.Location = new System.Drawing.Point(412, 260);
            this.groupBoxSignalType.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBoxSignalType.Name = "groupBoxSignalType";
            this.groupBoxSignalType.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBoxSignalType.Size = new System.Drawing.Size(269, 244);
            this.groupBoxSignalType.TabIndex = 31;
            this.groupBoxSignalType.TabStop = false;
            this.groupBoxSignalType.Text = "信號型式";
            // 
            // rbSignalTypeClose
            // 
            this.rbSignalTypeClose.AutoSize = true;
            this.rbSignalTypeClose.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbSignalTypeClose.Location = new System.Drawing.Point(61, 166);
            this.rbSignalTypeClose.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.rbSignalTypeClose.Name = "rbSignalTypeClose";
            this.rbSignalTypeClose.Size = new System.Drawing.Size(133, 46);
            this.rbSignalTypeClose.TabIndex = 1;
            this.rbSignalTypeClose.TabStop = true;
            this.rbSignalTypeClose.Text = "常閉";
            this.rbSignalTypeClose.UseVisualStyleBackColor = true;
            // 
            // rbSignalTypeOpen
            // 
            this.rbSignalTypeOpen.AutoSize = true;
            this.rbSignalTypeOpen.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbSignalTypeOpen.Location = new System.Drawing.Point(61, 76);
            this.rbSignalTypeOpen.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.rbSignalTypeOpen.Name = "rbSignalTypeOpen";
            this.rbSignalTypeOpen.Size = new System.Drawing.Size(133, 46);
            this.rbSignalTypeOpen.TabIndex = 0;
            this.rbSignalTypeOpen.TabStop = true;
            this.rbSignalTypeOpen.Text = "常開";
            this.rbSignalTypeOpen.UseVisualStyleBackColor = true;
            // 
            // groupBoxAlarmOutput
            // 
            this.groupBoxAlarmOutput.BackColor = System.Drawing.Color.Gray;
            this.groupBoxAlarmOutput.Controls.Add(this.rbAlarmOutputClose);
            this.groupBoxAlarmOutput.Controls.Add(this.rbAlarmOutputOpen);
            this.groupBoxAlarmOutput.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBoxAlarmOutput.ForeColor = System.Drawing.Color.White;
            this.groupBoxAlarmOutput.Location = new System.Drawing.Point(412, 530);
            this.groupBoxAlarmOutput.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBoxAlarmOutput.Name = "groupBoxAlarmOutput";
            this.groupBoxAlarmOutput.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBoxAlarmOutput.Size = new System.Drawing.Size(269, 236);
            this.groupBoxAlarmOutput.TabIndex = 30;
            this.groupBoxAlarmOutput.TabStop = false;
            this.groupBoxAlarmOutput.Text = "警報輸出";
            // 
            // rbAlarmOutputClose
            // 
            this.rbAlarmOutputClose.AutoSize = true;
            this.rbAlarmOutputClose.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbAlarmOutputClose.Location = new System.Drawing.Point(61, 166);
            this.rbAlarmOutputClose.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.rbAlarmOutputClose.Name = "rbAlarmOutputClose";
            this.rbAlarmOutputClose.Size = new System.Drawing.Size(133, 46);
            this.rbAlarmOutputClose.TabIndex = 1;
            this.rbAlarmOutputClose.TabStop = true;
            this.rbAlarmOutputClose.Text = "關閉";
            this.rbAlarmOutputClose.UseVisualStyleBackColor = true;
            // 
            // rbAlarmOutputOpen
            // 
            this.rbAlarmOutputOpen.AutoSize = true;
            this.rbAlarmOutputOpen.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbAlarmOutputOpen.Location = new System.Drawing.Point(61, 76);
            this.rbAlarmOutputOpen.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.rbAlarmOutputOpen.Name = "rbAlarmOutputOpen";
            this.rbAlarmOutputOpen.Size = new System.Drawing.Size(133, 46);
            this.rbAlarmOutputOpen.TabIndex = 0;
            this.rbAlarmOutputOpen.TabStop = true;
            this.rbAlarmOutputOpen.Text = "開啟";
            this.rbAlarmOutputOpen.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSelectInformation
            // 
            this.dataGridViewSelectInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelectInformation.Location = new System.Drawing.Point(1352, 6);
            this.dataGridViewSelectInformation.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.dataGridViewSelectInformation.Name = "dataGridViewSelectInformation";
            this.dataGridViewSelectInformation.RowTemplate.Height = 24;
            this.dataGridViewSelectInformation.Size = new System.Drawing.Size(572, 1288);
            this.dataGridViewSelectInformation.TabIndex = 28;
            this.dataGridViewSelectInformation.Visible = false;
            // 
            // tbYCoordinate
            // 
            this.tbYCoordinate.Location = new System.Drawing.Point(852, 1134);
            this.tbYCoordinate.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tbYCoordinate.Name = "tbYCoordinate";
            this.tbYCoordinate.ReadOnly = true;
            this.tbYCoordinate.Size = new System.Drawing.Size(125, 59);
            this.tbYCoordinate.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(841, 1092);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(221, 48);
            this.label9.TabIndex = 26;
            this.label9.Text = "圖形Y座標";
            // 
            // tbXCoordinate
            // 
            this.tbXCoordinate.Location = new System.Drawing.Point(847, 1020);
            this.tbXCoordinate.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tbXCoordinate.Name = "tbXCoordinate";
            this.tbXCoordinate.ReadOnly = true;
            this.tbXCoordinate.Size = new System.Drawing.Size(130, 59);
            this.tbXCoordinate.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(841, 972);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(223, 44);
            this.label8.TabIndex = 24;
            this.label8.Text = "圖形X座標";
            // 
            // btnGraphicPositioning
            // 
            this.btnGraphicPositioning.BackColor = System.Drawing.Color.LightGray;
            this.btnGraphicPositioning.Location = new System.Drawing.Point(1081, 986);
            this.btnGraphicPositioning.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnGraphicPositioning.Name = "btnGraphicPositioning";
            this.btnGraphicPositioning.Size = new System.Drawing.Size(215, 208);
            this.btnGraphicPositioning.TabIndex = 23;
            this.btnGraphicPositioning.Text = "圖形定位";
            this.btnGraphicPositioning.UseVisualStyleBackColor = false;
            // 
            // tbTitleContent
            // 
            this.tbTitleContent.Location = new System.Drawing.Point(845, 1270);
            this.tbTitleContent.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tbTitleContent.Name = "tbTitleContent";
            this.tbTitleContent.Size = new System.Drawing.Size(446, 59);
            this.tbTitleContent.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(836, 1222);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(251, 42);
            this.label7.TabIndex = 20;
            this.label7.Text = "標題內容";
            // 
            // tbSignalAnomalyFileName
            // 
            this.tbSignalAnomalyFileName.Location = new System.Drawing.Point(849, 884);
            this.tbSignalAnomalyFileName.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tbSignalAnomalyFileName.Name = "tbSignalAnomalyFileName";
            this.tbSignalAnomalyFileName.Size = new System.Drawing.Size(446, 59);
            this.tbSignalAnomalyFileName.TabIndex = 19;
            this.tbSignalAnomalyFileName.Click += new System.EventHandler(this.TBSignalAnomalyFileName_Click);
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(836, 826);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(542, 64);
            this.label6.TabIndex = 18;
            this.label6.Text = "信號異常對應圖形檔名";
            // 
            // tbNormalSignalFileName
            // 
            this.tbNormalSignalFileName.Location = new System.Drawing.Point(849, 724);
            this.tbNormalSignalFileName.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tbNormalSignalFileName.Name = "tbNormalSignalFileName";
            this.tbNormalSignalFileName.Size = new System.Drawing.Size(446, 59);
            this.tbNormalSignalFileName.TabIndex = 17;
            this.tbNormalSignalFileName.Click += new System.EventHandler(this.TBNormalSignalFileName_Click);
            // 
            // labelNormalSignalFileName
            // 
            this.labelNormalSignalFileName.ForeColor = System.Drawing.Color.White;
            this.labelNormalSignalFileName.Location = new System.Drawing.Point(834, 664);
            this.labelNormalSignalFileName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNormalSignalFileName.Name = "labelNormalSignalFileName";
            this.labelNormalSignalFileName.Size = new System.Drawing.Size(527, 64);
            this.labelNormalSignalFileName.TabIndex = 16;
            this.labelNormalSignalFileName.Text = "信號正常對應圖形檔名";
            // 
            // tbSignalAnomalyDisplayText
            // 
            this.tbSignalAnomalyDisplayText.Location = new System.Drawing.Point(849, 548);
            this.tbSignalAnomalyDisplayText.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tbSignalAnomalyDisplayText.Name = "tbSignalAnomalyDisplayText";
            this.tbSignalAnomalyDisplayText.Size = new System.Drawing.Size(440, 59);
            this.tbSignalAnomalyDisplayText.TabIndex = 15;
            this.tbSignalAnomalyDisplayText.Click += new System.EventHandler(this.TBSignalAnomalyDisplayText_Click);
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(841, 490);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(446, 64);
            this.label4.TabIndex = 14;
            this.label4.Text = "信號異常顯示文字";
            // 
            // tbSignalDisplayTextNormally
            // 
            this.tbSignalDisplayTextNormally.Location = new System.Drawing.Point(849, 392);
            this.tbSignalDisplayTextNormally.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tbSignalDisplayTextNormally.Name = "tbSignalDisplayTextNormally";
            this.tbSignalDisplayTextNormally.Size = new System.Drawing.Size(440, 59);
            this.tbSignalDisplayTextNormally.TabIndex = 13;
            this.tbSignalDisplayTextNormally.Click += new System.EventHandler(this.TBSignalDisplayTextNormally_Click);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(841, 334);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(390, 64);
            this.label3.TabIndex = 12;
            this.label3.Text = "信號正常顯示文字";
            // 
            // tbSignalDescription
            // 
            this.tbSignalDescription.Location = new System.Drawing.Point(849, 224);
            this.tbSignalDescription.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tbSignalDescription.Name = "tbSignalDescription";
            this.tbSignalDescription.Size = new System.Drawing.Size(440, 59);
            this.tbSignalDescription.TabIndex = 11;
            this.tbSignalDescription.Click += new System.EventHandler(this.TBSignalDescription_Click);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(841, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 64);
            this.label2.TabIndex = 10;
            this.label2.Text = "信號說明";
            // 
            // tbGroup
            // 
            this.tbGroup.Location = new System.Drawing.Point(849, 76);
            this.tbGroup.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tbGroup.Name = "tbGroup";
            this.tbGroup.Size = new System.Drawing.Size(128, 59);
            this.tbGroup.TabIndex = 9;
            this.tbGroup.Click += new System.EventHandler(this.TBGroup_Click);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(841, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 64);
            this.label1.TabIndex = 8;
            this.label1.Text = "群編號";
            // 
            // BuildingTableUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.panelOutside);
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "BuildingTableUserControl";
            this.Size = new System.Drawing.Size(2875, 1348);
            this.Load += new System.EventHandler(this.BuildingTableUserControl_Load);
            this.panelOutside.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.groupBoxTypeSetting.ResumeLayout(false);
            this.groupBoxTypeSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStationCode)).EndInit();
            this.groupBoxActionSetting.ResumeLayout(false);
            this.groupBoxActionSetting.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBoxPoints.ResumeLayout(false);
            this.groupBoxPoints.PerformLayout();
            this.groupBoxSignalPreset.ResumeLayout(false);
            this.groupBoxSignalPreset.PerformLayout();
            this.groupBoxSignalType.ResumeLayout(false);
            this.groupBoxSignalType.PerformLayout();
            this.groupBoxAlarmOutput.ResumeLayout(false);
            this.groupBoxAlarmOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectInformation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOutside;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.GroupBox groupBoxTypeSetting;
        private System.Windows.Forms.RadioButton rb8DO;
        private System.Windows.Forms.RadioButton rb16DI;
        private System.Windows.Forms.DataGridView gridViewStationCode;
        private System.Windows.Forms.GroupBox groupBoxActionSetting;
        private System.Windows.Forms.RadioButton rbActionClose;
        private System.Windows.Forms.RadioButton rbActionOpen;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.DataGridView dataGridViewSelectInformation;
        private System.Windows.Forms.TextBox tbYCoordinate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbXCoordinate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGraphicPositioning;
        private System.Windows.Forms.TextBox tbTitleContent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSignalAnomalyFileName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNormalSignalFileName;
        private System.Windows.Forms.Label labelNormalSignalFileName;
        private System.Windows.Forms.TextBox tbSignalAnomalyDisplayText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSignalDisplayTextNormally;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSignalDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBoxPoints;
        private System.Windows.Forms.RadioButton rbPoints16;
        private System.Windows.Forms.RadioButton rbPoints15;
        private System.Windows.Forms.RadioButton rbPoints14;
        private System.Windows.Forms.RadioButton rbPoints13;
        private System.Windows.Forms.RadioButton rbPoints12;
        private System.Windows.Forms.RadioButton rbPoints11;
        private System.Windows.Forms.RadioButton rbPoints10;
        private System.Windows.Forms.RadioButton rbPoints9;
        private System.Windows.Forms.RadioButton rbPoints8;
        private System.Windows.Forms.RadioButton rbPoints7;
        private System.Windows.Forms.RadioButton rbPoints6;
        private System.Windows.Forms.RadioButton rbPoints5;
        private System.Windows.Forms.RadioButton rbPoints4;
        private System.Windows.Forms.RadioButton rbPoints3;
        private System.Windows.Forms.RadioButton rbPoints2;
        private System.Windows.Forms.RadioButton rbPoints1;
        private System.Windows.Forms.GroupBox groupBoxSignalPreset;
        private System.Windows.Forms.RadioButton rbSignalPresetClose;
        private System.Windows.Forms.RadioButton rbSignalPresetOpen;
        private System.Windows.Forms.GroupBox groupBoxSignalType;
        private System.Windows.Forms.RadioButton rbSignalTypeClose;
        private System.Windows.Forms.RadioButton rbSignalTypeOpen;
        private System.Windows.Forms.GroupBox groupBoxAlarmOutput;
        private System.Windows.Forms.RadioButton rbAlarmOutputClose;
        private System.Windows.Forms.RadioButton rbAlarmOutputOpen;
        private System.Windows.Forms.RadioButton rbBare;
        private System.Windows.Forms.Button btnSave;
    }
}
