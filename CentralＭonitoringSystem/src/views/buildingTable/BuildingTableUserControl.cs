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

namespace CentralＭonitoringSystem.src.views
{
    public partial class BuildingTableUserControl : UserControl
    {
        //連接資料庫
        SqlConnectionStringBuilder scsb;

        //圖片
        string csharppath = System.Windows.Forms.Application.StartupPath;
        string localFilePath = "";
        string saveFilePath = "";


        public BuildingTableUserControl()
        {
            InitializeComponent();
            SqlConnection(); //建立資料庫本機端
            gridViewStationCode.CellClick += GridViewStationCode_CellClick;
            rbActionOpen.CheckedChanged += RbActionOpen_CheckedChanged;
            rbActionClose.CheckedChanged += RbActionOpen_CheckedChanged;
            rb16DI.CheckedChanged += Rb16DI_checkedChanged;
            rb8DO.CheckedChanged += Rb16DI_checkedChanged;
        }
        
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
        
       
        //用來儲存第幾列第幾行
        DataGridViewCellEventArgs currentCell;
        private void GridViewStationCode_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentCell = e;
            int row = currentCell.RowIndex;//列
            int column = currentCell.ColumnIndex;//行

            DataGridViewRow currentRow = gridViewStationCode.Rows[row];
            DataGridViewCell currentColumn = currentRow.Cells[column];
            object cellValue = currentColumn.Value;
            Console.WriteLine("cellValue: " + cellValue);

            //改變Radio button
            if (cellValue.Equals("關閉"))
            {
                rbActionClose.Checked = true;
            }
            else if (cellValue.Equals("開啟"))
            {
                rbActionOpen.Checked = true;
            }
            else if (cellValue.Equals("16DI"))
            {
                rb16DI.Checked = true;
            }
            else if (cellValue.Equals("8DO"))
            {
                rb8DO.Checked = true;
            }
            else 
            {
                cellValue = "";

                rbBare.Checked = true;
            }
            

        }
        //建立資料庫本機端
        private void SqlConnection()
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "CentralＭonitoringSystem";
            scsb.IntegratedSecurity = true;
            
            
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
        //讀取資料庫，顯示站碼、種類、動作
        private void BuildingTableUserControl_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("Select StationCode as 站碼,Kind as 種類,Action as 動作 From Sensor ", con);
            adapt.Fill(dt);
            gridViewStationCode.DataSource = dt;
            con.Close();
        }

        private void TBGroup_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("Select Number as 編號,GroupExplanation as 群號說明,GraphicsFileName as 圖形檔名 From GroupＮumber", con);
            adapt.Fill(dt);
            dataGridViewSelectInformation.DataSource = dt;
            dataGridViewSelectInformation.Visible = true;
            con.Close();
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
