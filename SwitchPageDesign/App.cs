using SwitchPageDesign.src.enums;
using SwitchPageDesign.src.panels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchPageDesign
{
    public partial class App : Form
    {
        Page mPage;
        Dictionary<Page, Panel> mPanelDictionary = new Dictionary<Page, Panel>();

        MainPanel mainPanel;
        BuildTabelPanel buildTabelPanel;
        CommunicationPanel communicationPanel;
        RecordPanel recordPanel;


        public App()
        {
            InitializeComponent();     
            Init();
            //一開始呈現主畫面
            mPage = Page.Main;
            //SwitchPage(mPage);
            SwitchPage(mPage);
        }

        public void Init()
        {
            mainPanel = new MainPanel();
            buildTabelPanel = new BuildTabelPanel();
            communicationPanel = new CommunicationPanel();
            recordPanel = new RecordPanel();

            //panel加入dictionary  (key -> value)
            mPanelDictionary.Add(Page.Main, mainPanel);
            mPanelDictionary.Add(Page.Communication, communicationPanel);
            mPanelDictionary.Add(Page.Record, recordPanel);
            mPanelDictionary.Add(Page.BuildTable, buildTabelPanel);

            this.Controls.Add(mPanelDictionary[Page.Main]);
            this.Controls.Add(mPanelDictionary[Page.Communication]);
            this.Controls.Add(mPanelDictionary[Page.Record]);
            this.Controls.Add(mPanelDictionary[Page.BuildTable]);
        }

        public void SwitchPage(Page desPage)
        {
            foreach (Page page in mPanelDictionary.Keys)
            {
                if (page.Equals(desPage))
                {
                    mPanelDictionary[page].Visible = true;
                }
                else
                {
                    mPanelDictionary[page].Visible = false;
                }
            }
        }


        private void btnCommunication_Click(object sender, EventArgs e)
        {
            mPage = Page.Communication;
           
            SwitchPage(mPage);
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            mPage = Page.Record;
            
            SwitchPage(mPage);
        }

        private void btnBuildTable_Click(object sender, EventArgs e)
        {
            mPage = Page.BuildTable;
            
            SwitchPage(mPage);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (mPage.Equals(Page.BuildTable))
            {
                mPage = Page.Main;
                SwitchPage(mPage);
            }
            else
            {
                return;
            }
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            mPage = Page.Main;
            
            SwitchPage(mPage);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            mPage = Page.Main;
            
            SwitchPage(mPage);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            mPage = Page.Main;
            
            SwitchPage(mPage);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            mPage = Page.Main;
            
            SwitchPage(mPage);
        }
    }
}
