﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchPageDesign.src.panels
{
    public class CommunicationPanel : Panel
    {
        public CommunicationPanel()
        {
            this.BackColor = System.Drawing.Color.Green;
            this.Location = new System.Drawing.Point(252, 124);
            this.Name = "mPanel";
            this.Size = new System.Drawing.Size(769, 491);
            this.Visible = true;
        }
    }
}
