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
    class PopulateViews
    {
        DBConnector dbConnector;
        public List<Control> controls { get; set; }

        string monsterName;
        public PopulateViews()
        {
            controls = new List<Control>();
            dbConnector = new DBConnector();
        }
        public void IterateDisplayBoxes()
        {
            foreach(Control control in controls)
            {
                if (control is RichTextBox)
                {
                    switch(control.Name)
                    {
                        case "actionsBox":
                            IterateDataTables(control);
                            break;
                        case "specialTraitsBox":
                            IterateDataTables(control);
                            break;
                        case "descriptionBox":
                            IterateDataTables(control);
                            break;
                        case "statBlockBox":
                            IterateDataTables(control);
                            break;
                        case "extrasBox":
                            IterateDataTables(control);
                            break;
                        case "legendaryActionsBox":
                            IterateDataTables(control);
                            break;
                        case "regionalEffectsBox":
                            IterateDataTables(control);
                            break;
                        case "lairActionsBox":
                            IterateDataTables(control);
                            break;
                    }
                }
            }
        }
        private void IterateDataTables(Control control)
        {
            {
                RichTextBox rtfBox = (RichTextBox)control;
                DataTable dataTable = ParseMonsterActions(control.AccessibleDescription);
                for (int r = 0; r < dataTable.Rows.Count; r++)
                {
                    for (int c = 0; c < dataTable.Columns.Count; c++)
                    {
                        if (dataTable.Rows[r][c].ToString() == "")
                        {
                            Debug.WriteLine("test");
                            dataTable.Columns.Remove(dataTable.Columns[c].ToString());
                        }
                    }
                }
                for (int r = 0; r < dataTable.Rows.Count; r++)
                {
                    for (int c = 0; c < dataTable.Columns.Count; c++)
                    {
                        rtfBox.Text += dataTable.Rows[r][c].ToString() + "\n";
                    }
                    rtfBox.Text += "\n";
                }
            }
        }
        public void Clear()
        {
            foreach (Control control in controls)
            {
                if(control is RichTextBox)
                {
                    RichTextBox rtfControl = (RichTextBox)control;
                    rtfControl.ScrollToCaret();
                    rtfControl.Clear();
                }
                if (control is PictureBox)
                {
                    PictureBox pictureControl = (PictureBox)control;
                    if (pictureControl.Image != null)
                    {
                        pictureControl.Image.Dispose();
                    }
                }
            }
        }
        public void ImportMonsterName(string monsterClickQuery)
        {
            monsterName = monsterClickQuery;
        }
        private DataTable ParseMonsterActions(string initialQuery)
        {
            string monsterActionQuery = initialQuery + "'" + monsterName  + "'" + ";";
            return dbConnector.ExposeData(monsterActionQuery);
        }
    }
}
