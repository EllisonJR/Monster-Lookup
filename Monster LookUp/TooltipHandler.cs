using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;

namespace Monster_LookUp
{

    class TooltipHandler
    {
        public List<Control> controls { get; set; }
        ToolTip toolTip;
        public TooltipHandler()
        {
            controls = new List<Control>();
        }
        public void InitializeTooltips()
        {
            foreach (Control control in controls)
            {
                toolTip = new ToolTip();
                toolTip.SetToolTip(control, control.AccessibleDescription);
                Debug.WriteLine(toolTip.ToString());
            }
        }
    }
}
