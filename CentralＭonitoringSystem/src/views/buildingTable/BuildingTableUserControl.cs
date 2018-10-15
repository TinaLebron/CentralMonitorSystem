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
using CentralＭonitoringSystem.src.model;

namespace CentralＭonitoringSystem.src.views
{
    public partial class BuildingTableUserControl : UserControl
    {

        //存資料庫的SensingPoint
        List<Signal> signals = new List<Signal>();


        //所有資料庫相關資料
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

            this.rbPoints1.CheckedChanged += RbPoints_CanFocus;
            this.rbPoints2.CheckedChanged += RbPoints_CanFocus;
            this.rbPoints3.CheckedChanged += RbPoints_CanFocus;
        }

        private void RbPoints_CanFocus(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            Console.WriteLine("RadioButton : " + rb.Text);
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
            //從sensingPoint table select資料，然後秀出在信號UI上
        

            SetSignalUI();
        }

        //從sensingPoint table select資料，然後秀出在信號UI上
        private void SetSignalUI()
        {
           
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

        //判別

        //讀取sensor與GroupNumber表,顯示建表所有表格
        private void SelectDatafromSensorAndGroupNumber()
        {
            dBHelper.Open();

            SqlDataReader rSensorAndGroupNumber = dBHelper.SelectDatafromSensingPoint((gridViewStationCode.CurrentRow.Index) + 1,strPoint);

           if(rSensorAndGroupNumber.Read() == true)
            {
                if ((bool)rSensorAndGroupNumber["SignalType"] == true)
                {
                    radioButton8.Checked = true;
                }
                else
                {
                    radioButton7.Checked = true;
                }
                if((bool)rSensorAndGroupNumber["AlarmOutput"] == true)
                {
                    
                    radioButton6.Checked = true;
                }
                else
                {
                    radioButton5.Checked = true;
                }
                if ((bool)rSensorAndGroupNumber["SignalPreset"] == true)
                {
                    
                    radioButton10.Checked = true;
                }
                else 
                {
                    radioButton9.Checked = true;
                }


                tbGroup.Text = string.Format("{0}", (int)rSensorAndGroupNumber["GroupNumber"]);
                tbSignalDescription.Text = string.Format("{0}", (string)rSensorAndGroupNumber["SignalDescription"]);
                tbSignalDisplayTextNormally.Text = string.Format("{0}", (string)rSensorAndGroupNumber["SignalDisplayTextNormally"]);
                tbSignalAnomalyDisplayText.Text = string.Format("{0}", (string)rSensorAndGroupNumber["SignalAnomalyDisplayText"]);
                tbNormalSignalFileName.Text = string.Format("{0}", (string)rSensorAndGroupNumber["NormalSignalFileName"]);
                tbSignalAnomalyFileName.Text = string.Format("{0}", (string)rSensorAndGroupNumber["SignalAnomalyFileName"]);
                tbXCoordinate.Text = string.Format("{0}", (string)rSensorAndGroupNumber["GraphicXCoordinate"]);
                tbYCoordinate.Text = string.Format("{0}", (string)rSensorAndGroupNumber["GraphicYCoordinate"]);
                tbTitleContent.Text = string.Format("{0}", (string)rSensorAndGroupNumber["TitleContent"]);
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
    }
}
