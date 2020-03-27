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
    public partial class Form1 : Form
    {
        BindingSource bindingSource1 = new BindingSource();
        SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter();
        String connectionString = "Data Source=Monsters.db; Version = 3; New = True; Compress = True;";

        MonsterFilter monsterFilter;
        List<Control> controls = new List<Control>();

        string mainQueryString;
        string textBoxString;
        string additionalString;
        string fullQuery;
        string monsterNameQuery;
        string secondaryQueryString;

        SQLiteDataReader monsterInfo;
        public Form1()
        {
            InitializeComponent();
            monsterFilter = new MonsterFilter();
            foreach (Control control in Controls)
            {
                if (control is CheckBox || control is RichTextBox)
                {
                    monsterFilter.controls.Add(control);
                }
            }
            foreach(Control control in flowLayoutPanel1.Controls)
            {
                monsterFilter.controls.Add(control);
            }
            InitializeToolTips();

            //initial result group, grab everything in the monster table
            fullQuery = mainQueryString + textBoxString;

            TableUpdate(this, null);
        }

        //Update the table being displayed based on a heavily appended query
        private void TableUpdate(object sender, EventArgs e)
        {
            //create the query
            GetData(QueryCompiler());

            //so i can see the final query in the output
            Debug.WriteLine(fullQuery);

            //bind the new group of results to the datagridview data source
            dataGridView1.DataSource = bindingSource1;

            //these will keep the width of the displayed columns consistently the same upon every table update rather than resizing to fit the data
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 100;
        }

        //compile a query out of constituent parts. a main query, the textbox search bar, and an additional string that is appended with conditionals
        private string QueryCompiler()
        {
            //first we clear the additional string for appending a new query later
            //set the main query to what will be displayed
            //then append the textbox string which will allow for searching anything plus what is currently typed in the box
            additionalString = "";
            mainQueryString = "SELECT DISTINCT mons.monsterName, mons.challengeRating, mons.armorClass, mons.hitpointAverage, mons.monsterType, mons.size ";
            secondaryQueryString = "FROM Monsters AS mons LEFT JOIN monsters_actions AS mons_actions ON mons_actions.monsterName = mons.monsterName " +
                "LEFT JOIN monsters_immunities AS mons_immunities ON mons_immunities.monsterName = mons.monstername " +
                "LEFT JOIN monsters_resistances AS mons_resistances ON mons_resistances.monsterName = mons.monstername " +
                "LEFT JOIN monsters_weaknesses AS mons_weak ON mons_weak.monsterName = mons.monstername " +
                "LEFT JOIN monsters_languages AS mons_langs ON mons_langs.monsterName = mons.monsterName " +
                "LEFT JOIN monsters_legendaryActions AS mons_leg_acts ON mons_leg_acts.monsterName = mons.monsterName " +
                "LEFT JOIN monsters_movementTypes AS mons_movetypes ON mons_movetypes.monsterName = mons.monsterName " +
                "LEFT JOIN monsters_senses AS mons_senses ON mons_senses.monsterName = mons.monsterName " +
                "LEFT JOIN monsters_skills AS mons_skills ON mons_skills.monsterName = mons.monsterName " +
                "LEFT JOIN monsters_traits AS mons_traits ON mons_traits.monsterName = mons.monsterName " +
                "LEFT JOIN monsters_lairs AS mons_lairs ON mons_lairs.monsterName = mons.monsterName " +
                "LEFT JOIN monsters_savingThrows AS mons_saving ON mons_saving.monsterName = mons.monsterName " +
                "LEFT JOIN alignments AS aligns ON aligns.alignment = mons.alignment " +
                "LEFT JOIN challengeRatings AS mons_CRs ON mons_CRs.challengeRating = mons.challengeRating ";

            textBoxString = "WHERE mons.monsterName LIKE '" + textBox1.Text + "%'";

            //process the addition string by passing it in for each different checkbox list

            /*
             * CHANGE THIS TO A ITERATING LIST LATER
             * USE THE NAMES WHILE ITERATING TO PASS INTO THE CONDITIONAL METHOD
             */

            additionalString = monsterFilter.ParseQuery();

            //finalize the string by appending a semicolon
            additionalString += ";";

            return fullQuery = mainQueryString + secondaryQueryString + textBoxString + additionalString;
        }
        //processes the query string itself
        //NOTE TO SELF
        //MAKE THIS WORK WITH EVERY INSTANCE OF NEEDING TO QUERY THE DB
        private void GetData(string selectCommand)
        {
            try
            {
                // Specify a connection string.  
                // Replace <SQL Server> with the SQL Server for your Northwind sample database.
                // Replace "Integrated Security=True" with user login information if necessary.

                // Create a new data adapter based on the specified query.
                dataAdapter = new SQLiteDataAdapter(selectCommand, connectionString);

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand. 

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable
                {
                    Locale = CultureInfo.InvariantCulture
                };
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;
                // Resize the DataGridView columns to fit the newly loaded content.
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch(SQLiteException)
            {
                //EAT DAT EXCEPTION BEEBEE
            }
        }

        //pull monster data to the appropriate window based on the column name and the info grabbed from dataGridView1_CellClick_PopulateMonsterDat
        private object GrabMonsterData_OnClick(string column)
        {
            object returnObject = null;
                if (column == "image")
                {
                    returnObject = (Byte[])monsterInfo["image"];
                }
                else if (column == "action")
                {
                    string str = "";
                    str += (string)monsterInfo["actionName"];
                    if (monsterInfo["charges"] != DBNull.Value)
                    {
                        str += (string)monsterInfo["charges"];
                    }
                    if (monsterInfo["chargeRefreshRate"] != DBNull.Value)
                    {
                        str += (string)monsterInfo["chargeRefreshRate"];
                    }
                    str += (string)monsterInfo["actionDescription"];
                    returnObject = str;
                }
                else
                {
                    returnObject = (string)monsterInfo[column];
                }
            return returnObject;
        }

        //create various SELECT commands to grab data to pass into the display boxes upon clicking the monster
        private void dataGridView1_CellClick_PopulateMonsterData(object sender, DataGridViewCellEventArgs e)
        {
            //clear all text forms for displaying
            foreach(Control rtf in this.Controls)
            {
                if (rtf is RichTextBox)
                {
                    RichTextBox rich = (RichTextBox)rtf;
                    rich.ScrollToCaret();
                    rich.Clear();
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                    }
                }
            }

            //create a new connection, query for something specific like 'IMAGE' and put the data into the appropriate area for view via GrabMonsterData_OnClick
            //gotta work on this a LOT
            /*
             * TO DO
             * ADD ALL APPROPRIATE BOXES FOR DISPLAY
             * ABSTRACT THEM TO METHODS TO CLEAN THIS AREA
             * TRY TO MAKE ONE CONNECTION OPEN AND CLOSE INSTEAD OF MULTIPLE
             * USE A PARSER FOR THE DIFFERENT DATA TYPES, I HAVE ONE FOR IMAGE, NOW NEED ONE FOR TEXT
             * PARSER WILL USE GrabMonsterData_OnClick
             */
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            DataTable table = new DataTable();
            monsterNameQuery = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();

            SQLiteCommand command = new SQLiteCommand("SELECT image FROM monsters WHERE monsterName='" + monsterNameQuery + "'", connection);
            connection.Open();
            monsterInfo = command.ExecuteReader();
            ParseMonsterImage(connection);

            /*command.Connection = connection;
            monsterInfo = command.ExecuteReader();
            monsterInfo.Read();
            descriptionBox.Rtf = (string)GrabMonsterData_OnClick("description");

            command = new SQLiteCommand("SELECT extras FROM monsters WHERE monsterName='" + monsterNameQuery + "'");
            monsterInfo = command.ExecuteReader();
            monsterInfo.Read();
            extrasBox.Rtf = (string)GrabMonsterData_OnClick("extras");
            connection.Close();*/
        }

        //making sure this doesnt mess up if there is no image present
        private void ParseMonsterImage(SQLiteConnection connection)
        {
            monsterInfo.Read();
            Byte[] data = (Byte[])GrabMonsterData_OnClick("image");
            MemoryStream mem = new MemoryStream();
            if (data != null)
            {
                mem = new MemoryStream(data);
                pictureBox1.Image = Image.FromStream(mem);
            }
            else
            {
                pictureBox1.Image = null;
            }
            connection.Close();
        }

        //this method will loop through all lists previously placed into the monsterFilter class and clear them of their checkmarks/fields
        private void ClearButton_Click(object sender, EventArgs e)
        {
            monsterFilter.ClearAll();
            TableUpdate(new object(), e);
        }

        //prevents anything except numbers to be input into the textboxes on the form
        private void TextboxInputChecker(object sender, KeyEventArgs e)
        {
            if ((e.KeyValue >= 48 && e.KeyValue <= 57 || e.KeyValue >= 96 && e.KeyValue <= 105 || e.KeyCode == Keys.Back || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right) && e.Shift != true)
            {
                e.SuppressKeyPress = false;
            }
            else
            {
                e.SuppressKeyPress = true;
            }
        }
        public void InitializeToolTips()
        {
            ToolTip sizeCheckListToolTip = new ToolTip();
            ToolTip monsterSubtypeCheckListToolTip = new ToolTip();
            ToolTip monsterTypeCheckListToolTip = new ToolTip();
            ToolTip environmentCheckListToolTip = new ToolTip();
            ToolTip alignmnetCheckListToolTip = new ToolTip();
            ToolTip broadAlignmentCheckListToolTip = new ToolTip();
            ToolTip actionCheckListToolTip = new ToolTip();
            ToolTip traitCheckListToolTip = new ToolTip();
            ToolTip skillCheckListToolTip = new ToolTip();
            ToolTip senseCheckListToolTip = new ToolTip();
            ToolTip legendaryCheckListToolTip = new ToolTip();
            ToolTip moveTypeCheckListToolTip = new ToolTip();
            ToolTip savingThrowCheckListToolTip = new ToolTip();
            ToolTip langCheckListToolTip = new ToolTip();
            ToolTip immunityCheckListToolTip = new ToolTip();
            ToolTip resistanceCheckListToolTip = new ToolTip();
            ToolTip weaknessCheckListToolTip = new ToolTip();

            sizeCheckListToolTip.SetToolTip(sizeListBox, "Size Category");
            monsterSubtypeCheckListToolTip.SetToolTip(monsterSubtypeCheckListBox, "Monster Subtype");
            monsterTypeCheckListToolTip.SetToolTip(monsterTypeCheckBoxList, "Monster Type");
            environmentCheckListToolTip.SetToolTip(environmentCheckListBox, "Environment");
            alignmnetCheckListToolTip.SetToolTip(alignmentCheckListBox, "Alignment");
            broadAlignmentCheckListToolTip.SetToolTip(broadAlignmentCheckListBox, "Broad Alignment");
            actionCheckListToolTip.SetToolTip(actionCheckListBox, "Actions");
            traitCheckListToolTip.SetToolTip(traitsCheckListBox, "Traits");
            skillCheckListToolTip.SetToolTip(skillsCheckListBox, "Skills");
            senseCheckListToolTip.SetToolTip(sensesCheckListBox, "Senses");
            legendaryCheckListToolTip.SetToolTip(legendaryActCheckListBox, "Legendary Actions");
            moveTypeCheckListToolTip.SetToolTip(moveTypeCheckListBox, "Movement Types");
            savingThrowCheckListToolTip.SetToolTip(savingThrowCheckListBox, "Saving Throws");
            langCheckListToolTip.SetToolTip(langCheckListBox, "Languages");
            immunityCheckListToolTip.SetToolTip(immunityCheckListBox, "Immunities");
            resistanceCheckListToolTip.SetToolTip(resistanceCheckListBox, "Resistances");
            weaknessCheckListToolTip.SetToolTip(weaknessCheckListBox, "Weaknesses");
        }
    }
}
