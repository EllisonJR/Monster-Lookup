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
    class MonsterFilter
    {
        public List<Control> controls { get; set; }
        public MonsterFilter()
        {
            controls = new List<Control>();
        }

        //returns a query to the main form by way of appending conditionals to the original query
        public string ParseQuery()
        {
            string additionalString = "";
            foreach (Control control in controls)
            {
                additionalString += ControlChecker(control);
            }

            return additionalString;
        }

        //clear all filter controls
        public void ClearAll()
        {
            foreach (Control control in controls)
            {
                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }
                if (control is CheckedListBox)
                {
                    CheckedListBox checkedListBox = (CheckedListBox)control;
                    for (int i = 0; i < checkedListBox.Items.Count; i++)
                    {
                        checkedListBox.SetItemChecked(i, false);
                    }
                }
                if(control is RichTextBox)
                {
                    RichTextBox box = (RichTextBox)control;
                    box.Clear();
                }
            }
        }

        //passes controls into itself to check the control's name, accessability description, and accessability name and uses those to determine
        //flow of control as well as sql query appending
        string ControlChecker(Control passedInControl)
        {
            /*
             * This block uses a second index (i2) outside of the looping index
             * its purpose is to loop through the items of a passed in checkboxlist
             * as it runs into checked items, the secondary index (i2) increments
             * 
             * if it runs into a checked item in the list, it will take the name of the qualifier, and the name of the checked item, 
             * then append them into the sql query to be passed back into the main query in the query compiler method
             * 
             * Upon running into the first checked item (i2 == 0) it will append " AND (" to the beginning of the string 
             * indicating the beginning of the grouping of items to be returned and placed in parenthesis after the AND SQL operator
             * if it is not the first time seeing a checkeditem (i2 > 0) it will append the OR operator to allow for as many conditions as needed
             * 
             * when i2 == the count of checked items in the list, it will place the closing parenthesis then break, completing its task
             * 
             * the other to if statements that check the passed in control just check for values and appends a string based on true/false values and richtextboxes numerical values
             */
            string mainString = "";
            string joinQualifier = passedInControl.AccessibleName;
            if (passedInControl is CheckedListBox)
            {
                CheckedListBox listBox = (CheckedListBox)passedInControl;
                int i2 = 1;
                if (listBox.CheckedItems.Count != 0)
                {
                    for (int i = 0; i < listBox.Items.Count; i++)
                    {
                        if (listBox.GetItemChecked(i) == true)
                        {
                            if (i2 == 1)
                            {
                                mainString += " AND (";
                                mainString += joinQualifier + " = '" + (string)listBox.Items[i] + "'";
                            }
                            else
                            {
                                mainString += " OR " + joinQualifier + " = '" + (string)listBox.Items[i] + "'";
                            }
                            if (i2 == listBox.CheckedItems.Count)
                            {
                                mainString += ")";
                                break;
                            }
                            i2++;
                        }
                    }
                }
            }

            if(passedInControl is CheckBox)
            {
                CheckBox checkbox = (CheckBox)passedInControl;
                if (checkbox.Checked == true)
                {
                    switch (checkbox.AccessibleDescription)
                    {
                        case "notNull":
                            mainString = " AND (" + joinQualifier + " IS NOT NULL)";
                            break;
                        case "trueFalse":
                            mainString = " AND (" + joinQualifier + " = true)";
                            break;
                    }
                }
            }
            if(passedInControl is RichTextBox)
            {
                RichTextBox textbox = (RichTextBox)passedInControl;
                int textBoxValue;
                joinQualifier = textbox.AccessibleName;
                if (textbox.AccessibleDescription == "min")
                {
                    if (textbox.Text != "")
                    {
                        textBoxValue = Convert.ToInt32(textbox.Text);
                        if (Convert.ToInt32(textbox.Text) <= 0)
                        {
                            textBoxValue = 0;
                        }
                        else
                        {
                            textBoxValue = Convert.ToInt32(textbox.Text);
                        }
                    }
                    else
                    {
                        textBoxValue = 0;
                    }
                    mainString = " AND (" + joinQualifier + " > " + textBoxValue + ")";
                }

                if (textbox.AccessibleDescription == "max")
                {
                    if (textbox.Text != "")
                    {

                        textBoxValue = Convert.ToInt32(textbox.Text);
                    }
                    else
                    {
                        textBoxValue = Int32.MaxValue;
                    }
                    mainString = " AND (" + joinQualifier + " < " + textBoxValue + ")";
                }
            }
            return mainString;
        }
    }
}
