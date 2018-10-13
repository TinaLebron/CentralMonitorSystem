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

        //存放點數選擇的值
        string strPoint;
        //存放信號型式的值
        string strType;
        //存放警報輸出的值
        string strAlarm;
        //存放信號預設的值
        string strPreset;


        public BuildingTableUserControl()
        {
            InitializeComponent();
            
            gridViewStationCode.CellClick += GridViewStationCode_CellClick;
            rbActionOpen.CheckedChanged += RbActionOpen_CheckedChanged;
            rbActionClose.CheckedChanged += RbActionOpen_CheckedChanged;
            rb16DI.CheckedChanged += RbSensor_checkedChanged;
            rb8DO.CheckedChanged += RbSensor_checkedChanged;
            rbBare.CheckedChanged += RbSensor_checkedChanged;
            this.BindingContextChanged += BuildingTableUserControl_BindingContextChanged;
        }

        private void BuildingTableUserControl_BindingContextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("BuildingTableUserControl_BindingContextChanged");
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

            //一開始進入畫面,種類設定,動作設定 UI要出現值
            SetSensorUI(0);
        }

        //設定Sensor UI
        private void SetSensorUI(int index)
        {
            DataGridViewRow currentRow = gridViewStationCode.Rows[index];

            string sTyple = currentRow.Cells[1].Value.ToString();
            string sAction = currentRow.Cells[2].Value.ToString();
            if (sTyple.Equals("16DI"))
            {
                rb16DI.Checked = true;
            }
            else if (sTyple.Equals("8DO"))
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

        //種類設定事件
        //當radioButton屬性checked值被給變,此函式會被觸發
        private void RbSensor_checkedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            //Console.WriteLine("" + rb.Text);
            if (currentCell == null) return; 
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
            if (currentCell == null) return;
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
            dBHelper.Open();

            SqlDataReader rSensorAndGroupNumber = dBHelper.SelectDatafromSensorAndGroupNumber(gridViewStationCode.CurrentRow.Index,strPoint);

            while (rSensorAndGroupNumber.Read() == true)
            {
                groupBoxSignalType.Text = string.Format("{0}", (int)rSensorAndGroupNumber["SignalType"]);
                groupBoxAlarmOutput.Text = string.Format("{0}", (int)rSensorAndGroupNumber["AlarmOutput"]);
                groupBoxSignalPreset.Text = string.Format("{0}", (int)rSensorAndGroupNumber["SignalPreset"]);
                tbGroup.Text = string.Format("{0}", (int)rSensorAndGroupNumber["GroupNumber"]);
                tbSignalDescription.Text = string.Format("{0}", (int)rSensorAndGroupNumber["SignalDescription"]);
                tbSignalDisplayTextNormally.Text = string.Format("{0}", (int)rSensorAndGroupNumber["SignalDisplayTextNormally"]);
                tbSignalAnomalyDisplayText.Text = string.Format("{0}", (int)rSensorAndGroupNumber["SignalAnomalyDisplayText"]);
                tbNormalSignalFileName.Text = string.Format("{0}", (int)rSensorAndGroupNumber["NormalSignalFileName"]);
                tbSignalAnomalyFileName.Text = string.Format("{0}", (int)rSensorAndGroupNumber["SignalAnomalyFileName"]);
                tbXCoordinate.Text = string.Format("{0}", (int)rSensorAndGroupNumber["GraphicXCoordinate"]);
                tbYCoordinate.Text = string.Format("{0}", (int)rSensorAndGroupNumber["GraphicYCoordinate"]);
                tbTitleContent.Text = string.Format("{0}", (int)rSensorAndGroupNumber["TitleContent"]);
            }
            rSensorAndGroupNumber.Close();
            dBHelper.Close();

        }

        //Cell click點擊事件
        private void GridViewStationCode_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            currentCell = e;
            int row = currentCell.RowIndex;//列
            int column = currentCell.ColumnIndex;//行

            SetSensorUI(row);


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
        //點數1的事件
        private void RbPoints1_CheckedChanged(object sender, EventArgs e)
        {
            strPoint = "1";
            SelectDatafromSensorAndGroupNumber();
        }
        //點數2的事件
        private void RbPoints2_CheckedChanged(object sender, EventArgs e)
        {
            strPoint = "2";
            SelectDatafromSensorAndGroupNumber();
        }
        //點數3的事件
        private void RbPoints3_CheckedChanged(object sender, EventArgs e)
        {
            strPoint = "3";
            SelectDatafromSensorAndGroupNumber();
        }
        //點數4的事件
        private void RbPoints4_CheckedChanged(object sender, EventArgs e)
        {
            strPoint = "4";
            SelectDatafromSensorAndGroupNumber();
        }
        //點數5的事件
        private void RbPoints5_CheckedChanged(object sender, EventArgs e)
        {
            strPoint = "5";
            SelectDatafromSensorAndGroupNumber();
        }
        //點數6的事件
        private void RbPoints6_CheckedChanged(object sender, EventArgs e)
        {
            strPoint = "6";
            SelectDatafromSensorAndGroupNumber();
        }
        //點數7的事件
        private void RbPoints7_CheckedChanged(object sender, EventArgs e)
        {
            strPoint = "7";
            SelectDatafromSensorAndGroupNumber();
        }
        //點數8的事件
        private void RbPoints8_CheckedChanged(object sender, EventArgs e)
        {
            strPoint = "8";
            SelectDatafromSensorAndGroupNumber();
        }
        //點數9的事件
        private void RbPoints9_CheckedChanged(object sender, EventArgs e)
        {
            strPoint = "9";
            SelectDatafromSensorAndGroupNumber();
        }
        //點數10的事件
        private void RbPoints10_CheckedChanged(object sender, EventArgs e)
        {
            strPoint = "10";
            SelectDatafromSensorAndGroupNumber();
        }
        //點數11的事件
        private void RbPoints11_CheckedChanged(object sender, EventArgs e)
        {
            strPoint = "11";
            SelectDatafromSensorAndGroupNumber();
        }
        //點數12的事件
        private void RbPoints12_CheckedChanged(object sender, EventArgs e)
        {
            strPoint = "12";
            SelectDatafromSensorAndGroupNumber();
        }
        //點數13的事件
        private void RbPoints13_CheckedChanged(object sender, EventArgs e)
        {
            strPoint = "13";
            SelectDatafromSensorAndGroupNumber();
        }
        //點數14的事件
        private void RbPoints14_CheckedChanged(object sender, EventArgs e)
        {
            strPoint = "14";
            SelectDatafromSensorAndGroupNumber();
        }
        //點數15的事件
        private void RbPoints15_CheckedChanged(object sender, EventArgs e)
        {
            strPoint = "15";
            SelectDatafromSensorAndGroupNumber();
        }
        //點數16的事件
        private void RbPoints16_CheckedChanged(object sender, EventArgs e)
        {
            strPoint = "16";
            SelectDatafromSensorAndGroupNumber();
        }
        //信號型式常開的事件
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            strType = "常開";
            SelectDatafromSensorAndGroupNumber();
        }
        //信號型式常閉的事件
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            strType = "常閉";
            SelectDatafromSensorAndGroupNumber();
        }
        //
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            strType = "開啟";
            SelectDatafromSensorAndGroupNumber();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            strType = "關閉";
            SelectDatafromSensorAndGroupNumber();
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            strType = "常開";
            SelectDatafromSensorAndGroupNumber();
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            strType = "常閉";
            SelectDatafromSensorAndGroupNumber();
        }
    }
}
