using CentralＭonitoringSystem.enums;
using CentralＭonitoringSystem.src.Database;
using CentralＭonitoringSystem.src.views;
using CentralＭonitoringSystem.src.views.communication;
using CentralＭonitoringSystem.src.views.home;
using CentralＭonitoringSystem.src.views.record;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentralＭonitoringSystem
{
    public partial class App : Form
    {
        private static DBHelper dBHelper;
        public static DBHelper MyDBHelper
        {
            get
            {
                if (dBHelper != null)
                    return dBHelper;
                else
                    return null;
            }
        }

        //主頁
        HomeUserControl homeUserControl;
        //通訊UI
        CommunicationStatusUserControl communicationStatusUserControl;
        //記錄UI
        RecordUserControl recordUserControl;
        //建表UI
        BuildingTableUserControl buildingTableUserControl;

        Page mPage;
        Dictionary<Page, UserControl> pagesDictionary = new Dictionary<Page, UserControl>();
        
        //連接資料庫
        SqlConnectionStringBuilder scsb;

        //tree view
        string nodeName = "";
        List<int> nodeNumList = new List<int>();

        public App()
        {
            InitializeComponent();
            Init();

            //一開始畫面是Home
            mPage = Page.Home;
            SwitchPage(mPage);//換頁的function
        }

        private void Init()
        {
            communicationStatusUserControl = new CommunicationStatusUserControl();
            recordUserControl = new RecordUserControl();
            homeUserControl = new HomeUserControl();
            buildingTableUserControl = new BuildingTableUserControl();

            pagesDictionary.Add(Page.Communication, communicationStatusUserControl);
            pagesDictionary.Add(Page.Record, recordUserControl);
            pagesDictionary.Add(Page.Home, homeUserControl);
            pagesDictionary.Add(Page.BuildTable, buildingTableUserControl);

            contentPanel.Controls.Add(pagesDictionary[Page.Communication]);
            contentPanel.Controls.Add(pagesDictionary[Page.Record]);
            contentPanel.Controls.Add(pagesDictionary[Page.Home]);

            //最大塊的panel，用來加建表UI
            this.buildingTablePanel.Controls.Add(buildingTableUserControl);
            this.buildingTablePanel.Visible = false;

            //tree的event
            menuTreeView.AfterSelect += MenuTreeView_AfterSelect;
        }

        //換頁的function
        public void SwitchPage(Page desPage)
        {
            foreach (Page Page in pagesDictionary.Keys)
            {
                if (Page.Equals(desPage))
                {
                    pagesDictionary[Page].Visible = true;
                }
                else
                {
                    pagesDictionary[Page].Visible = false;
                }
            }
        }

        //treeview事件
        private void MenuTreeView_AfterSelect(object sender,System.Windows.Forms.TreeViewEventArgs e)
        {
            mPage = Page.Home;
            SwitchPage(mPage);
        }

        //建立資料庫本機端
        private void Form1_Load(object sender, EventArgs e)
        {
            dBHelper = new DBHelper();
            TreeView();
        }
        //tree view產生
        private void TreeView()
        {
            dBHelper.Open();

            SqlDataReader rContents = dBHelper.SelectAllFromContents();

            while (rContents.Read() == true)
            {
                nodeName = rContents["DirectoryName"].ToString(); ;
                nodeNumList.Add(Convert.ToInt32(rContents["ContentsID"]));
                TreeNode GroupEditing = new TreeNode();
                GroupEditing.Text = nodeName;
                menuTreeView.Nodes.Add(GroupEditing);
            }
            rContents.Close();

            for (int i = 0; i < nodeNumList.Count; i += 1)
            {

                SqlDataReader rGroupNumber = dBHelper.SelectALLFromGroupＮumber(nodeNumList[i]);

                while (rGroupNumber.Read() == true)
                {
                    nodeName = rGroupNumber["GroupExplanation"].ToString();
                    menuTreeView.Nodes[nodeNumList[i]].Nodes.Add(nodeName);
                }
                rGroupNumber.Close();
            }
            menuTreeView.ExpandAll();

            dBHelper.Close();
        }

        //產生日期與時間
        private void Timer_Tick(object sender, EventArgs e)
        {
            lblTimeNow.Text = string.Format("{0}", DateTime.Now);
        }
        
        //show communicationStatusUserControl
        private void BtnCommunication_Click(object sender, EventArgs e)
        {
            mPage = Page.Communication;
            SwitchPage(mPage);
        }
        
        //show recordUserControl
        private void BtnRecord_Click(object sender, EventArgs e)
        {
            mPage = Page.Record;
            SwitchPage(mPage);
        }
        
        //show buildingTableUserControl
        private void BtnBuildTable_Click(object sender, EventArgs e)
        {
            mPage = Page.BuildTable;
            ShowBuildingTable(true,false);
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (!mPage.Equals(Page.BuildTable)) return;
            ShowBuildingTable(false, true);
            pagesDictionary[Page.Home].Visible = true;
            pagesDictionary[Page.Home].BringToFront();


        }
        
        //可關閉或顯示BuildingTable的事件
        private void ShowBuildingTable(bool open,bool close)
        {
            //將tree,content隱藏
            treeViewPanel.Visible = close;
            contentPanel.Visible = close;

            //3顆按鈕隱藏
            threeBtnsHidePanel.Visible = close;

            //show建表UI
            buildingTablePanel.Visible = open;
            buildingTableUserControl.Visible = open;

        }
    }
}
