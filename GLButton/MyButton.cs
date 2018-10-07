using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GLButton
{
    public partial class MyButton: PictureBox
    {
        public MyButton()
        {
            InitializeComponent();
        }

        public Image hoverImage;
        public Image normalImage;

        public Image ImageHover
        {
            get { return hoverImage; }
            set { hoverImage = value; }
        }

        public Image ImageNormal
        {
            get { return normalImage; }
            set { normalImage = value; }
        }

        private void MyButton_MouseHover(object sender, EventArgs e)
        {
            this.Image = ImageHover;
        }

        private void MyButton_MouseLeave(object sender, EventArgs e)
        {
            this.Image = ImageNormal;
        }
    }
}
