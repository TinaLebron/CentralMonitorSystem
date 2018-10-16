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

            //this.rbPoints1.CheckedChanged += RbPoints_CanFocus;
            //this.rbPoints2.CheckedChanged += RbPoints_CanFocus;
            //this.rbPoints3.CheckedChanged += RbPoints_CanFocus;

            //點數的radio button 點擊的事件
            this.rbPoints1.CheckedChanged += RbPoints_checkedChanged;
            this.rbPoints2.CheckedChanged += RbPoints_checkedChanged;
            this.rbPoints3.CheckedChanged += RbPoints_checkedChanged;
            this.rbPoints4.CheckedChanged += RbPoints_checkedChanged;
            this.rbPoints5.CheckedChanged += RbPoints_checkedChanged;
            this.rbPoints6.CheckedChanged += RbPoints_checkedChanged;
            this.rbPoints7.CheckedChanged += RbPoints_checkedChanged;
            this.rbPoints8.CheckedChanged += RbPoints_checkedChanged;
            this.rbPoints9.CheckedChanged += RbPoints_checkedChanged;
            this.rbPoints10.CheckedChanged += RbPoints_checkedChanged;
            this.rbPoints11.CheckedChanged += RbPoints_checkedChanged;
            this.rbPoints12.CheckedChanged += RbPoints_checkedChanged;
            this.rbPoints13.CheckedChanged += RbPoints_checkedChanged;
            this.rbPoints14.CheckedChanged += RbPoints_checkedChanged;
            this.rbPoints15.CheckedChanged += RbPoints_checkedChanged;
            this.rbPoints16.CheckedChanged += RbPoints_checkedChanged;


        }
        //點數的radio button 點擊的事件
        private void RbPoints_checkedChanged(object sender, EventArgs e)
        {
            //LINQ方式,取得radio button 的值
            var rb = this.groupBoxPoints.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);

            //Console.WriteLine(rb.Text);

            dBHelper.Open();
            SqlDataReader reader = dBHelper.SelectFromSensingPointWithSensorID(Int32.Parse(rb.Text) );
            if (reader.HasRows)
            {
                Console.WriteLine("有資料");
                while (reader.Read())
                {

                    int point = (int)reader["Points"];
                    bool signalType = (bool)reader["SignalType"];
                    bool alarmOutput = (bool)reader["AlarmOutput"];
                    bool singalPreset = (bool)reader["SignalPreset"];
                    string groupNumber = string.Format("{0}", (int)reader["GroupNumber"]);
                    string signalDescription = string.Format("{0}", (string)reader["SignalDescription"]);
                    string signalDisplayTextNormally = string.Format("{0}", (string)reader["SignalDisplayTextNormally"]);
                    string signalAnomalyDisplayText = string.Format("{0}", (string)reader["SignalAnomalyDisplayText"]);
                    string normalSignalFileName = string.Format("{0}", (string)reader["NormalSignalFileName"]);
                    string signalAnomalyFileName = string.Format("{0}", (string)reader["SignalAnomalyFileName"]);
                    string graphicXCoordinate = string.Format("{0}", (string)reader["GraphicXCoordinate"]);
                    string graphicYCoordinate = string.Format("{0}", (string)reader["GraphicYCoordinate"]);
                    string titleContent = string.Format("{0}", (string)reader["TitleContent"]);


                    //Console.WriteLine("點數: " + point + "\n" +
                    //                  "信號型式: " + ((signalType == true) ? "常開" : "常閉") + "\n" + 
                    //                  "警報輸出: " + ((alarmOutput == true) ? "開啟" : "關閉") + "\n" +
                    //                  "信號預設: " + ((singalPreset == true) ? "常開" : "常閉") + "\n" +
                    //                  "群編號: " + groupNumber + "\n" +
                    //                  "信號說明: " + signalDescription + "\n" +
                    //                  "信號正常顯示文字: " + signalDisplayTextNormally + "\n" +
                    //                  "信號異常顯示文字: " + signalAnomalyDisplayText + "\n" +
                    //                  "信號正常對應圖形檔名: " + normalSignalFileName + "\n" +
                    //                  "信號異常對應圖形檔名: " + signalAnomalyFileName + "\n" +
                    //                  "圖形X座標: " + graphicXCoordinate + "\n" +
                    //                  "圖形Y座標: " + graphicYCoordinate + "\n" +
                    //                  "標題內容: " + titleContent + "\n" );
                    // Console.WriteLine("信號型式: " + ((signalType == true) ? "常開" : "常閉"));
                    Console.WriteLine("--------------------------------------");
                    //將資料set進model
                    signals.Add(new Signal(point,
                        signalType,
                        alarmOutput,
                        singalPreset,
                        groupNumber,
                        signalDescription,
                        signalDisplayTextNormally,
                        signalAnomalyDisplayText,
                        normalSignalFileName,
                        signalAnomalyFileName,
                        graphicXCoordinate,
                        graphicYCoordinate,
                        titleContent));

                    tbGroup.Text = signals[0].GroupNumber;
                    tbSignalDescription.Text = signals[0].SignalDescription;
                    tbSignalDisplayTextNormally.Text = signals[0].SignalDisplayTextNormally;
                    tbSignalAnomalyDisplayText.Text = signals[0].SignalAnomalyDisplayText;
                    tbNormalSignalFileName.Text = signals[0].NormalSignalFileName;
                    tbSignalAnomalyFileName.Text = signals[0].SignalAnomalyFileName;
                    tbXCoordinate.Text = signals[0].GraphicXCoordinate;
                    tbYCoordinate.Text = signals[0].GraphicYCoordinate;
                    tbTitleContent.Text = signals[0].TitleContent;
                }
            }
            else
            {
                Console.WriteLine("SensingPoint table裡面沒有任何資料");
            }
            reader.Close();
            dBHelper.Close();

            Console.WriteLine("印出站點1信號table所有資料");

            foreach (Signal signal in signals)
            {
                Console.WriteLine("點數: {0}\t信號型式: {1}\t警報輸出: {2}\t信號預設: {3}\t群編號: {4}\t 信號說明:{5}\t信號正常顯示文字 :{6}\t信號異常顯示文字 :{7}\t信號正常對應圖形檔名: {8}\t信號正常對應圖形檔名: {9}\t圖形X座標: {10}\t圖形Y座標: {11}\t標題內容: {12}",
                    signal.Point,
                    signal.SignalType,
                    signal.AlarmOutput,
                    signal.SignalPreset,
                    signal.GroupNumber,
                    signal.SignalDescription,
                    signal.SignalDisplayTextNormally,
                    signal.SignalAnomalyDisplayText,
                    signal.NormalSignalFileName,
                    signal.SignalAnomalyFileName,
                    signal.GraphicXCoordinate,
                    signal.GraphicYCoordinate,
                    signal.TitleContent);
            }
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
        

           // SetSignalUI();

            //new 6個model,因為站碼1只有6個點數有值
            //for (int i = 0; i < 6; i++)
            //{
            //    signals.Add(new Signal());
            //}
            
            
            
            
        }

        

        

        //從sensingPoint table select資料，然後秀出在信號UI上
        private void SetSignalUI()
        {
           
        }
        //測試
        //private void RbPoints_CanFocus(object sender, EventArgs e)
        //{
        //    RadioButton rb = (RadioButton)sender;
        //    Console.WriteLine("RadioButton : " + rb.Text);
        //}
        //測試
        private void BuildingTableUserControl_BindingContextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("BuildingTableUserControl_BindingContextChanged");
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

        private void groupBoxPoints_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
