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
        MonsterFilter monsterFilter;
        TooltipHandler toolTipHandler;
        DBConnector dbConnector;
        PopulateViews populateViews;

        string mainQueryString;
        string textBoxString;
        string additionalString;
        string fullQuery;
        string secondaryQueryString;
        public Form1()
        {
            InitializeComponent();

            dbConnector = new DBConnector();
            monsterFilter = new MonsterFilter();
            toolTipHandler = new TooltipHandler();
            populateViews = new PopulateViews();

            //pass the form's controls into the filters and tooltip classes for later manipulation
            foreach (Control control in Controls)
            {
                if (control is CheckBox)
                {
                    monsterFilter.controls.Add(control);
                }
                if(control is RichTextBox)
                {
                    RichTextBox rtfControl = (RichTextBox)control;
                    if(rtfControl.ReadOnly == false)
                    {
                        monsterFilter.controls.Add(rtfControl);
                    }
                    else
                    {
                        populateViews.controls.Add(rtfControl);
                    }
                }
                if(control is PictureBox)
                {
                    populateViews.controls.Add(control);
                }
            }
            foreach(Control control in checklistBoxFlowPanel.Controls)
            {
                monsterFilter.controls.Add(control);
                toolTipHandler.controls.Add(control);
            }
            toolTipHandler.InitializeTooltips();

            //initial result group, grab everything in the monster table
            TableUpdate(this, null);
        }

        //Update the table being displayed based on a heavily appended query
        private void TableUpdate(object sender, EventArgs e)
        {
            //create the query
            dataGridView1.DataSource = dbConnector.GrabData(QueryCompiler());
        }

        //compile a query out of constituent parts. a main query, the textbox search bar, and an additional string that is appended with conditionals
        private string QueryCompiler()
        {
            //set the main query to what will be displayed
            //then append the textbox string which will allow for searching anything plus what is currently typed in the box
            mainQueryString = "SELECT DISTINCT mons.monsterName, mons.challengeRating, mons.armorClass, mons.hitpointAverage, mons.monsterType, mons.size ";
            secondaryQueryString = "FROM Monsters AS mons " +
                "LEFT JOIN monsters_actions AS mons_actions ON mons_actions.monsterName = mons.monsterName " +
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

            additionalString = monsterFilter.ParseQuery();

            //finalize the string by appending a semicolon
            additionalString += ";";

            return fullQuery = mainQueryString + secondaryQueryString + textBoxString + additionalString;
        }
        private void dataGridView1_CellClick_PopulateMonsterData(object sender, DataGridViewCellEventArgs e)
        {
            populateViews.ImportMonsterName(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
            //clear all text forms for displaying
            populateViews.Clear();
            populateViews.IterateDisplayBoxes();
            // SQLiteCommand command = new SQLiteCommand("SELECT image FROM monsters WHERE monsterName='" + monsterNameQuery + "'", connection);

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
    }
}
