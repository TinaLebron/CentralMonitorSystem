using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralＭonitoringSystem.src.Database
{
    public class DBHelper
    {
        //可以驅動資料庫連線的物件
        private SqlConnectionStringBuilder scsb;
        //連線
        private SqlConnection con;

        public DBHelper()
        {
            Init();
        }

        //資料庫連線設定
        private void Init()
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "CentralＭonitoringSystem";
            scsb.IntegratedSecurity = true;

            con = new SqlConnection(scsb.ToString());
        }

        //打開資料庫連線
        public void Open()
        {
            con.Open();
        }

        //儲存建表資料
        public void SaveBuildingTable()
        {
            //SqlConnection con = new SqlConnection(scsb.ToString());
            //con.Open();
            //string strSQL = "update SensingPoint set SignalType=@Signaltype,AlarmOutput=@Alarmoutput,SignalPreset=@SignalPreset,GroupNumber=@GroupNumber,SignalDescription=@Signaldescription,SignalDisplayTextNormally=@SignalDisplayTextNormally,SignalAnomalyDisplayText=@SignalAnomalyDisplayText,NormalSignalFileName=@NormalSignalFileName,SignalAnomalyFileName=@SignalAnomalyFileName,GraphicXCoordinate=@GraphicXCoordinate,GraphicYCoordinate=@GraphicYCoordinate,TitleContent=@TitleContent where SensingPoint=@SensingPoint and SensorID=@SensorID";
            //SqlCommand cmd = new SqlCommand(strSQL, con);
            //cmd.Parameters.AddWithValue("@Signaltype", );
            //cmd.Parameters.AddWithValue("@Alarmoutput", );
            //cmd.Parameters.AddWithValue("@SignalPreset", );
            //cmd.Parameters.AddWithValue("@GroupNumber", tbGroup.text);
            //cmd.Parameters.AddWithValue("@Signaldescription", tbSignalDescription.text);
            //cmd.Parameters.AddWithValue("@SignalDisplayTextNormally", tbSignalDisplayTextNormally.text);
            //cmd.Parameters.AddWithValue("@SignalAnomalyDisplayText", tbSignalAnomalyDisplayText.Text);
            //cmd.Parameters.AddWithValue("@NormalSignalFileName", tbNormalSignalFileName.Text);
            //cmd.Parameters.AddWithValue("@SignalAnomalyFileName", tbSignalAnomalyFileName.Text);
            //cmd.Parameters.AddWithValue("@GraphicXCoordinate", tbXCoordinate.Text);
            //cmd.Parameters.AddWithValue("@GraphicYCoordinate", tbYCoordinate.Text);
            //cmd.Parameters.AddWithValue("@TitleContent", tbTitleContent.Text);

            //int rows = cmd.ExecuteNonQuery();
            //con.Close();
            //MessageBox.Show("修改完成");


        }

        //讀取sensor表，顯示站碼、種類、動作
        public DataTable SelectDatafromSensor()
        {

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("Select StationCode as 站碼,Type as 種類,Action as 動作 From Sensor ", con);
            
            adapt.Fill(dt);
            return dt;
        }

        //讀取GroupNumber表, 顯示標號、群號說明、圖形檔名
        public DataTable SelectDatafromGroupNumber()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("Select Number as 編號,GroupExplanation as 群號說明,GraphicsFileName as 圖形檔名 From GroupNumber", con);
            adapt.Fill(dt);
            return dt;
        }

        //讀取sensor表,根據id回傳指定的欄位值
        public DataTable SelectDatafromSensor(int id, string col1, string col2)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("Select  as 編號,GroupExplanation as 群號說明,GraphicsFileName as 圖形檔名 From Sensor", con);
            adapt.Fill(dt);
            return dt;
        }

        //讀取sensor與GroupNumber表,顯示建表所有表格
        public SqlDataReader SelectDatafromSensingPoint(int rowIndex,string SensorsNum)
        {
            
            string strSQL = "select * from SensingPoint where Points=@SensingNum and SensorID=@SensorsNum";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SensingNum", rowIndex);
            cmd.Parameters.AddWithValue("@SensorsNum", SensorsNum);
            SqlDataReader reader = cmd.ExecuteReader();
            
            return reader;
        }
        //讀取sensor表,顯示建表所有表格
        public SqlDataReader SelectFromSensingPointWithSensorID(int sensorID)
        {

            string strSQL = "select * from SensingPoint where SensorID=@sensorID";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@sensorID", sensorID);
            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        //回傳treeview的目錄
        public SqlDataReader SelectAllFromContents()
        {
            string strSQL = "select * from Contents where [DirectoryName] NOT Like 'NULL'";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;

            
        }

        //回傳treeview的目錄
        public SqlDataReader SelectALLFromGroupＮumber(int index)
        {
            string strSQL = "select * from GroupＮumber where [ContentsID] = " + "'" + index + "'";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }


        public void Close()
        {
            con.Close();
        }


    }

}
