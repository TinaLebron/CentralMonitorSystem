using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentralＭonitoringSystem.src.views.home
{
    public partial class HomeUserControl : UserControl
    {
        public HomeUserControl()
        {
            InitializeComponent();
        }
        public void SetImage(Image img)
        {
            this.pictureBox1.Image = img;
        }
    }
}
