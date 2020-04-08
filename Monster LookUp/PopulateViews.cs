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
    /*
     *
     *JUST TO BE UP FRONT
     * This code is BAD
     * All it does is iterate through the controls in the list which are richtext contorls and one picture box
     * it gets to a control, populates data based on that controls sql query (pulled from accessible name/accible description)
     * it puts the queried data into a datatable (or a byte array if its a blob/image)
     * then it iterates through the contorls and displays the data to them by passing in each seperate entity and formatting it to display all pretty like
     * 
     * this is scalable, i can make that happen, but i had to hack this together as my semester was starting soon and im NOT learning C++ and dealing with concantenated string front end/sql
     */
    class PopulateViews
    {
        DBConnector dbConnector;
        public List<Control> controls { get; set; }

        string monsterName;

        int stringLoopCounter = 0;
        public PopulateViews()
        {
            controls = new List<Control>();
            dbConnector = new DBConnector();
        }

        public void IterateDataTables()
        {
            foreach (Control control in controls)
            {
                if (control is RichTextBox)
                {
                    DataTable dataTable = PopulateDataTable(control.AccessibleDescription);

                    RichTextBox rtfBox = (RichTextBox)control;
                    string str = "";
                    for (int r = 0; r < dataTable.Rows.Count; r++)
                    {
                        for (int c = 0; c < dataTable.Columns.Count; c++)
                        {
                                str += FormatCellContent(dataTable, dataTable.Rows[r][c].ToString(), r, c, rtfBox);
                        }
                    }
                    if (rtfBox.Name == "statBlockBox")
                    {
                        DataTable dataTable2 = new DataTable();
                        dataTable2 = PopulateDataTable(control.AccessibleName);
                        for (int r = 0; r < dataTable2.Rows.Count; r++)
                        {
                            for (int c = 0; c < dataTable2.Columns.Count; c++)
                            {
                                str += FormatCellContent(dataTable2, dataTable2.Rows[r][c].ToString(), r, c, rtfBox);
                            }
                        }
                    }
                    RichTextBox temp = new RichTextBox();
                    temp.Rtf = @"{\rtf1\ansi\deff0{\fonttbl {\f0 Helvetica;}{\f1 ProFontWindows;}}\fs28 " + str + "}";
                    rtfBox.SelectAll();
                    rtfBox.SelectedRtf = temp.Rtf;
                    temp.Dispose();
                    stringLoopCounter = 0;
                }
                else if(control is PictureBox)
                {
                    DataTable dataTable = PopulateDataTable("SELECT image FROM monsters WHERE monsterName = ");
                    if (dataTable.Rows[0][0] != null)
                    {
                        PictureBox pictureBox = (PictureBox)control;
                        byte[] ImageByte;
                        ImageByte = (byte[])dataTable.Rows[0][0];
                        pictureBox.Image = ByteToImage(ImageByte);
                    }
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
        public Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;

        }
        private DataTable PopulateDataTable(string initialQuery)
        {
            string monsterActionQuery = initialQuery + "'" + monsterName + "'" + ";";
            return dbConnector.ExposeData(monsterActionQuery);
        }
        private string FormatCellContent(DataTable table, string cellContent, int rowIndex, int columnIndex, RichTextBox box)
        {
            string columnName = table.Columns[columnIndex].ColumnName.ToString();
            if (box.Name == "statBlockBox")
            {
                switch (columnName)
                {
                    case "monsterName":
                        cellContent = @"\fs28\b " + cellContent + @"\b0\par ";
                        break;
                    case "size":
                        cellContent = @"\fs22\i " + cellContent + " ";
                        break;
                    case "monsterType":
                        break;
                    case "monsterSubtype":
                        if(table.Columns[columnIndex] != null)
                        {
                            cellContent = " (" + cellContent + ")";
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "alignment":
                        cellContent = ", " + cellContent + @"\i0\par\fs30-----------------------------------------\par\fs24 ";
                        break;
                    case "armorClass":
                        cellContent = @"\b Armor Class \b0 " + cellContent + @"\par ";
                        break;
                    case "hitpointAverage":
                        cellContent = @"\b Hit Points \b0 " + cellContent + @"\par ";
                        break;
                    case "speed":
                        cellContent = @"\b Speed \b0 " + cellContent + "ft.";
                        break;
                    case "burrow":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            cellContent = ", burrow " + cellContent + "ft.";
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "climb":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            cellContent = ", climb " + cellContent + "ft.";
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "fly":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            cellContent = ", fly " + cellContent + "ft.";
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "swim":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            cellContent = ", swim " + cellContent + "ft.";
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "strength":
                        string str = cellContent;
                        cellContent = @"\par\fs30-----------------------------------------\par\fs24\b " + "   STR   " + "DEX   " + "CON   " + "INT   " + "WIS  " + "CHA   " + @"\b0\par\fs20";
                        cellContent += "    " + str;
                        break;
                    case "strmod":
                        cellContent += "    ";
                        break;
                    case "dexmod":
                        cellContent = cellContent + "    ";
                        break;
                    case "conmod":
                        cellContent = cellContent + "    ";
                        break;
                    case "intmod":
                        cellContent = cellContent + "    ";
                        break;
                    case "wismod":
                        cellContent = cellContent + "    ";
                        break;
                    case "chamod":
                        cellContent = cellContent + @"    \par\fs30-----------------------------------------\fs22 ";
                        break;
                    case "Str":
                    case "Dex":
                    case "Con":
                    case "Int":
                    case "Wis":
                    case "Cha":
                        cellContent = "";
                        break;
                    case "strthrowmod":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if(stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Saving Throws \b0" + "Str +" + cellContent;
                            }
                            else
                            {
                                cellContent = ", Str +" + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "dexthrowmod":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Saving Throws \b0" + "Dex +" + cellContent;
                            }
                            else
                            {
                                cellContent = ", Dex +" + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "conthrowmod":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Saving Throws \b0" + "Con +" + cellContent;
                            }
                            else
                            {
                                cellContent = ", Con +" + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "intthrowmod":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Saving Throws \b0" + "Int +" + cellContent;
                            }
                            else
                            {
                                cellContent = ", Int +" + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "wisthrowmod":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Saving Throws \b0" + "Wis +" + cellContent;
                            }
                            else
                            {
                                cellContent = ", Wis +" + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "chathrowmod":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Saving Throws \b0" + "Cha +" + cellContent;
                            }
                            else
                            {
                                cellContent = ", Cha +" + cellContent;
                            }
                        }
                        else
                        {
                            cellContent = "";
                        }
                        stringLoopCounter = 0;
                        break;
                    case "acidres":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Damage Resistances \b0" + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "bludres":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Damage Resistances \b0" + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "coldres":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Damage Resistances \b0" + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "fireres":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Damage Resistances \b0" + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "forceres":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Damage Resistances \b0" + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "lightres":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Damage Resistances \b0" + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "necres":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Damage Resistances \b0" + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "pierceres":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Damage Resistances \b0" + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "poisres":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Damage Resistances \b0" + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "psyres":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Damage Resistances \b0" + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "radres":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Damage Resistances \b0" + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "slashres":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Damage Resistances \b0" + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "thunres":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Damage Resistances \b0" + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "multires":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Damage Resistances \b0" + cellContent;
                            }
                            else
                            {
                                cellContent = "; " + cellContent;
                            }
                        }
                        else
                        {
                            cellContent = "";
                        }
                        stringLoopCounter = 0;
                        break;
                    case "acidimm":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Damage Immunities \b0" + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "bludimm":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Damage Immunities \b0" + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "coldimm":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Damage Immunities \b0" + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "fireimm":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Damage Immunities \b0" + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "forceimm":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Damage Immunities \b0" + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "lightimm":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Damage Immunities \b0" + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "necimm":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Damage Immunities \b0" + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "pierceimm":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Damage Immunities \b0" + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "poisimm":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Damage Immunities \b0" + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "psyimm":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Damage Immunities \b0" + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "radimm":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Damage Immunities \b0" + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "slashimm":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Damage Immunities \b0" + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "thunimm":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Damage Immunities \b0" + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "multiimm":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Damage Immunities \b0" + cellContent;
                            }
                            else
                            {
                                cellContent = "; " + cellContent;
                            }
                        }
                        else
                        {
                            cellContent = "";
                        }
                        stringLoopCounter = 0;
                        break;
                    case "blind":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Condition Immunities \b0" + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "charm":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Condition Immunities \b0" + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "deaf":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Condition Immunities \b0" + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "fright":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Condition Immunities \b0" + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "grasp":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Condition Immunities \b0" + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "incap":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Condition Immunities \b0" + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "invis":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Condition Immunities \b0" + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "para":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Condition Immunities \b0" + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "petri":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Condition Immunities \b0" + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "pois":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Condition Immunities \b0" + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "prone":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Condition Immunities \b0" + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "restr":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Condition Immunities \b0" + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "stun":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Condition Immunities \b0" + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter = 0;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "uncon":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Condition Immunities \b0" + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "exhaust":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Condition Immunities \b0" + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                        }
                        else
                        {
                            cellContent = "";
                        }
                        stringLoopCounter = 0;
                        break;
                    case "blindsight":
                    case "darkvision":
                    case "truesight":
                    case "tremorsense":
                        cellContent = "";
                        break;
                    case "blindsightdistance":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Senses \b0 Blindsight " + cellContent + " ft. (blind beyond this radius)";
                            }
                            else
                            {
                                cellContent = ", Blindsight " + cellContent + "ft.";
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "darkvisiondistance":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Senses \b0 Darkvision " + cellContent + " ft.";
                            }
                            else
                            {
                                cellContent = "; Darkvision " + cellContent + "ft.";
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "truesightdistance":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Senses \b0 Truesight " + cellContent + " ft.";
                            }
                            else
                            {
                                cellContent = ", Truesight " + cellContent + "ft.";
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "tremorsensedistance":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Senses \b0 Tremorsense " + cellContent + " ft.";
                            }
                            else
                            {
                                cellContent = ", Tremorsense " + cellContent + "ft.";
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "passivePerception":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Senses \b0 passive Perception " + cellContent;
                            }
                            else
                            {
                                cellContent = ", passive Perception " + cellContent;
                            }
                        }
                        else
                        {
                            cellContent = "";
                        }
                        stringLoopCounter = 0;
                        break;
                    case "alllang":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Languages \b0 " + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "aby":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Languages \b0 " + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "aq":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Languages \b0 " + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "aur":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Languages \b0 " + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "celes":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Languages \b0 " + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "com":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Languages \b0 " + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "deep":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Languages \b0 " + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "drac":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Languages \b0 " + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "druid":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Languages \b0 " + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "dwar":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Languages \b0 " + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "elf":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Languages \b0 " + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "giant":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Languages \b0 " + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "gnom":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Languages \b0 " + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "gob":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Languages \b0 " + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "gnoll":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Languages \b0 " + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "half":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Languages \b0 " + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "ignan":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Languages \b0 " + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "infern":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Languages \b0 " + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "orc":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Languages \b0 " + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "prim":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Languages \b0 " + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "sylv":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Languages \b0 " + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "terr":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Languages \b0 " + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "under":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Languages \b0 " + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "aar":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Languages \b0 " + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "none":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Languages \b0 " + cellContent;
                            }
                            else
                            {
                                cellContent = ", " + cellContent;
                            }
                            stringLoopCounter++;
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "telepathyDistance":
                        if (!string.IsNullOrWhiteSpace(cellContent))
                        {
                            if (stringLoopCounter == 0)
                            {
                                cellContent = @"\par\b Languages \b0 Telepathy " + cellContent + " ft.";
                            }
                            else
                            {
                                cellContent = ", Telepathy " + cellContent + " ft.";
                            }
                        }
                        else
                        {
                            cellContent = "";
                        }
                        break;
                    case "challengeRating":
                        cellContent = @"\par\b Challenge \b0 " + cellContent;
                        break;
                    case "expReward":
                        cellContent = " (" + cellContent + " XP)";
                        break;

                }
            }
            else if (box.Name == "actionsBox" || box.Name == "specialTraitsBox" || box.Name == "legendaryActionsBox" || box.Name == "regionalEffectsBox" || box.Name == "lairActionsBox")
            {
                if (table.Columns[columnIndex].ColumnName == "charges" && !string.IsNullOrWhiteSpace(cellContent))
                {
                    cellContent += "/";
                }
                else
                {
                    if (columnIndex == 0)
                    {
                        cellContent = @"\b " + cellContent + @" \b0\par ";
                    }
                    else if(!string.IsNullOrWhiteSpace(cellContent))
                    {
                        cellContent += @"\par ";
                        if (columnIndex == table.Columns.Count - 1)
                        {
                            cellContent += @" \par ";
                        }
                    }
                }
            }
            return cellContent;
        }
    }
}
