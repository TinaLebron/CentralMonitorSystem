namespace CentralＭonitoringSystem.src.views.communication
{
    partial class CommunicationStatusUserControl
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
            this.groupBoxLandscapingInterfaceCard = new System.Windows.Forms.GroupBox();
            this.groupBoxFunctionCard = new System.Windows.Forms.GroupBox();
            this.panelOutside.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOutside
            // 
            this.panelOutside.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOutside.BackColor = System.Drawing.Color.White;
            this.panelOutside.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOutside.Controls.Add(this.groupBoxLandscapingInterfaceCard);
            this.panelOutside.Controls.Add(this.groupBoxFunctionCard);
            this.panelOutside.Location = new System.Drawing.Point(0, 0);
            this.panelOutside.Margin = new System.Windows.Forms.Padding(2);
            this.panelOutside.Name = "panelOutside";
            this.panelOutside.Size = new System.Drawing.Size(2853, 1424);
            this.panelOutside.TabIndex = 4;
            // 
            // groupBoxLandscapingInterfaceCard
            // 
            this.groupBoxLandscapingInterfaceCard.Font = new System.Drawing.Font("PMingLiU", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBoxLandscapingInterfaceCard.Location = new System.Drawing.Point(1521, 130);
            this.groupBoxLandscapingInterfaceCard.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBoxLandscapingInterfaceCard.Name = "groupBoxLandscapingInterfaceCard";
            this.groupBoxLandscapingInterfaceCard.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBoxLandscapingInterfaceCard.Size = new System.Drawing.Size(750, 1262);
            this.groupBoxLandscapingInterfaceCard.TabIndex = 1;
            this.groupBoxLandscapingInterfaceCard.TabStop = false;
            this.groupBoxLandscapingInterfaceCard.Text = "造景盤介面卡";
            // 
            // groupBoxFunctionCard
            // 
            this.groupBoxFunctionCard.Font = new System.Drawing.Font("PMingLiU", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBoxFunctionCard.Location = new System.Drawing.Point(46, 130);
            this.groupBoxFunctionCard.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBoxFunctionCard.Name = "groupBoxFunctionCard";
            this.groupBoxFunctionCard.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBoxFunctionCard.Size = new System.Drawing.Size(1421, 1262);
            this.groupBoxFunctionCard.TabIndex = 0;
            this.groupBoxFunctionCard.TabStop = false;
            this.groupBoxFunctionCard.Text = "功能卡";
            // 
            // CommunicationStatusUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelOutside);
            this.Name = "CommunicationStatusUserControl";
            this.Size = new System.Drawing.Size(2876, 1349);
            this.panelOutside.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOutside;
        private System.Windows.Forms.GroupBox groupBoxLandscapingInterfaceCard;
        private System.Windows.Forms.GroupBox groupBoxFunctionCard;
    }
}
