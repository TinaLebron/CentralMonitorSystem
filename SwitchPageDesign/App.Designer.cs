namespace SwitchPageDesign
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
            this.btnCommunication = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnBuildTable = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCommunication
            // 
            this.btnCommunication.Location = new System.Drawing.Point(40, 22);
            this.btnCommunication.Name = "btnCommunication";
            this.btnCommunication.Size = new System.Drawing.Size(79, 60);
            this.btnCommunication.TabIndex = 5;
            this.btnCommunication.Text = "通訊(綠色)";
            this.btnCommunication.UseVisualStyleBackColor = true;
            this.btnCommunication.Click += new System.EventHandler(this.btnCommunication_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(159, 22);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(79, 60);
            this.btnRecord.TabIndex = 2;
            this.btnRecord.Text = "記錄(藍色)";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnBuildTable
            // 
            this.btnBuildTable.Location = new System.Drawing.Point(284, 22);
            this.btnBuildTable.Name = "btnBuildTable";
            this.btnBuildTable.Size = new System.Drawing.Size(79, 60);
            this.btnBuildTable.TabIndex = 3;
            this.btnBuildTable.Text = "建表(紅色)";
            this.btnBuildTable.UseVisualStyleBackColor = true;
            this.btnBuildTable.Click += new System.EventHandler(this.btnBuildTable_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(394, 22);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(79, 60);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "確認(沒反應)";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(40, 124);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(184, 30);
            this.btnMain.TabIndex = 1;
            this.btnMain.Text = "主畫面";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(40, 175);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(184, 30);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "各戶安全";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(40, 230);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(184, 30);
            this.btn2.TabIndex = 7;
            this.btn2.Text = "公共照明";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(40, 290);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(184, 30);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "公共安全";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 627);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnBuildTable);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.btnCommunication);
            this.Name = "App";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCommunication;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnBuildTable;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
    }
}

