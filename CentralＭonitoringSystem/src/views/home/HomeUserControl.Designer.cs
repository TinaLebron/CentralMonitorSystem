namespace CentralＭonitoringSystem.src.views.home
{
    partial class HomeUserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.gridViewStationCode = new System.Windows.Forms.DataGridView();
            this.StationCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kind = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStationCode)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("PMingLiU", 25.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(205, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(714, 470);
            this.label1.TabIndex = 0;
            this.label1.Text = "主頁";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridViewStationCode
            // 
            this.gridViewStationCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewStationCode.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StationCode,
            this.Kind,
            this.Action});
            this.gridViewStationCode.Location = new System.Drawing.Point(810, 278);
            this.gridViewStationCode.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.gridViewStationCode.Name = "gridViewStationCode";
            this.gridViewStationCode.RowTemplate.Height = 24;
            this.gridViewStationCode.Size = new System.Drawing.Size(780, 984);
            this.gridViewStationCode.TabIndex = 4;
            // 
            // StationCode
            // 
            this.StationCode.HeaderText = "站碼";
            this.StationCode.Name = "StationCode";
            // 
            // Kind
            // 
            this.Kind.HeaderText = "種類";
            this.Kind.Items.AddRange(new object[] {
            "",
            "16DI",
            "8DO"});
            this.Kind.Name = "Kind";
            // 
            // Action
            // 
            this.Action.HeaderText = "動作";
            this.Action.Items.AddRange(new object[] {
            "開啟",
            "關閉"});
            this.Action.Name = "Action";
            // 
            // HomeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.gridViewStationCode);
            this.Controls.Add(this.label1);
            this.Name = "HomeUserControl";
            this.Size = new System.Drawing.Size(2876, 1349);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStationCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridViewStationCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationCode;
        private System.Windows.Forms.DataGridViewComboBoxColumn Kind;
        private System.Windows.Forms.DataGridViewComboBoxColumn Action;
    }
}
