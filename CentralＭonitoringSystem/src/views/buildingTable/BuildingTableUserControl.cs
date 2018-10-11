using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Collections;
using CentralＭonitoringSystem.src.Database;

namespace CentralＭonitoringSystem.src.views
{
    public partial class BuildingTableUserControl : UserControl
    {
        DBHelper dBHelper;

        //用來儲存第幾列第幾行
        DataGridViewCellEventArgs currentCell;

        //圖片
        string csharppath = System.Windows.Forms.Application.StartupPath;
        string localFilePath = "";
        string saveFilePath = "";


        public BuildingTableUserControl()
        {
            InitializeComponent();
            
            gridViewStationCode.CellClick += GridViewStationCode_CellClick;
            rbActionOpen.CheckedChanged += RbActionOpen_CheckedChanged;
            rbActionClose.CheckedChanged += RbActionOpen_CheckedChanged;
            rb16DI.CheckedChanged += Rb16DI_checkedChanged;
            rb8DO.CheckedChanged += Rb16DI_checkedChanged;
            rbBare.CheckedChanged += Rb16DI_checkedChanged;
        }

        //Load ,讀取資料庫，顯示站碼、種類、動作
        private void BuildingTableUserControl_Load(object sender, EventArgs e)
        {
            dBHelper = App.MyDBHelper;

            //打開連線
            dBHelper.Open();
            //讀取資料庫，顯示站碼、種類、動作
            gridViewStationCode.DataSource = dBHelper.SelectDatafromSensor();
            dBHelper.Close();
        }

        //種類設定事件
        private void Rb16DI_checkedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            //Console.WriteLine("" + rb.Text);

            int row = currentCell.RowIndex;//列
            int column = currentCell.ColumnIndex;//行
            DataGridViewRow currentRow = gridViewStationCode.Rows[row];
            DataGridViewCell currentColumn = currentRow.Cells[column];
            object cellValue = currentColumn.Value;

            if (column == 1)
            {
                currentColumn.Value = rb.Text;
            }
           
        }
        //動作設定事件
        private void RbActionOpen_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton rb = (RadioButton)sender;
            //Console.WriteLine("" + rb.Text);

            int row = currentCell.RowIndex;//列
            int column = currentCell.ColumnIndex;//行
            DataGridViewRow currentRow = gridViewStationCode.Rows[row];
            DataGridViewCell currentColumn = currentRow.Cells[column];
            object cellValue = currentColumn.Value;

            if (column == 2)
            {
                currentColumn.Value = rb.Text;
            }
            
        }

        private void SelectDatafromSensorAndGroupNumber()
        {
            SqlDataReader rSensorAndGroupNumber = dBHelper.SelectDatafromSensorAndGroupNumber();

            if (rSensorAndGroupNumber.Read() == true)
            {
                groupBoxPoints.Text = string.Format("{0}", (int)rSensorAndGroupNumber["SensingPointID"]);
                groupBoxSignalType.Text = string.Format("{0}", (string)rSensorAndGroupNumber["SignalType"]);
                groupBoxAlarmOutput.Text = string.Format("{0}", (string)rSensorAndGroupNumber["AlarmOutput"]);
                groupBoxSignalPreset.Text = string.Format("{0}", (string)rSensorAndGroupNumber["SignalPreset"]);
                tbGroup.Text = string.Format("{0}", (string)rSensorAndGroupNumber["GroupNumber"]);
                tbSignalDescription.Text = string.Format("{0}", (string)rSensorAndGroupNumber["SignalDisplayTextNormally"]);
                tbSignalDisplayTextNormally.Text = string.Format("{0}", (string)rSensorAndGroupNumber[""]);
                tbSignalAnomalyDisplayText.Text = string.Format("{0}", (string)rSensorAndGroupNumber[""]);
                tbNormalSignalFileName.Text = string.Format("{0}", (string)rSensorAndGroupNumber[""]);
                tbSignalAnomalyFileName.Text = string.Format("{0}", (string)rSensorAndGroupNumber[""]);
                tbXCoordinate.Text = string.Format("{0}", (string)rSensorAndGroupNumber["GraphicXCoordinate"]);
                tbYCoordinate.Text = string.Format("{0}", (string)rSensorAndGroupNumber["GraphicYCoordinate"]);
                tbTitleContent.Text = string.Format("{0}", (string)rSensorAndGroupNumber["TitleContent"]);

            }

            
        }


        private void GridViewStationCode_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            currentCell = e;
            int row = currentCell.RowIndex;//列
            int column = currentCell.ColumnIndex;//行
            
            
            DataGridViewRow currentRow = gridViewStationCode.Rows[row];

            string sTyple = currentRow.Cells[1].Value.ToString();
            string sAction = currentRow.Cells[2].Value.ToString();
            //Console.WriteLine(sTyple + sAction);
            if (sTyple.Equals("16DI"))
            {
                rb16DI.Checked = true;
            }
            else if(sTyple.Equals("8DO"))
            {
                rb8DO.Checked = true;
            }
            else 
            {
                rbBare.Checked = true;
            }

            if (sAction.Equals("開啟"))
            {
                rbActionOpen.Checked = true;
            }
            else if (sAction.Equals("關閉"))
            {
                rbActionClose.Checked = true;
            }


        }
        
        //圖形檔名點即秀出檔案夾，選擇圖片，資料夾位置在Bin->Debug->pictures
        private void ShowPictureDialog(TextBox textBox)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(openFileDialog.FileName);
                localFilePath = openFileDialog.FileName.ToString();
                saveFilePath = csharppath + @"\pictures\" + Path.GetFileName(openFileDialog.FileName);
                File.Copy(localFilePath, saveFilePath, true);
                textBox.Text = Path.GetFileName(openFileDialog.FileName);
            }
        }
        //信號正常對應圖形檔名秀出PictureDialog
        private void TBNormalSignalFileName_Click(object sender, EventArgs e)
        {
            ShowPictureDialog(tbNormalSignalFileName);
        }
        //信號異常對應圖形檔名秀出PictureDialog
        private void TBSignalAnomalyFileName_Click(object sender, EventArgs e)
        {
            ShowPictureDialog(tbSignalAnomalyFileName);
        }

        //TextBox群編號點擊event
        private void TBGroup_Click(object sender, EventArgs e)
        {

            dBHelper.Open();
            //讀取GroupNumber表, 顯示標號、群號說明、圖形檔名
            dataGridViewSelectInformation.DataSource = dBHelper.SelectDatafromGroupNumber();
            dataGridViewSelectInformation.Visible = true;
            dBHelper.Close();
        }

        private void TBSignalDescription_Click(object sender, EventArgs e)
        {

        }

        private void TBSignalDisplayTextNormally_Click(object sender, EventArgs e)
        {

        }

        private void TBSignalAnomalyDisplayText_Click(object sender, EventArgs e)
        {

        }
    }
}
