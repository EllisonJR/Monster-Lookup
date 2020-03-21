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

        string createTempTableString;
        string insertIntoTempTableString;
        string mainQueryString;
        string textBoxString;
        string dropTableString;

        string additionalString;

        string fullQuery;

        string monsterNameQuery;

        SQLiteDataReader monsterInfo;
        DataTable table;

        int entityCount;

        string relevantQueryActionFirstHalf = "CREATE TEMPORARY TABLE backActions(actionName, charges, chargeRefreshRate, actionDescription);" + "INSERT INTO backActions SELECT actionName, charges, chargeRefreshRate, actionDescription FROM monsters_actions WHERE monsterName='";
        string relevantQueryActionSecondHalf = "SELECT * FROM backActions;";

        string rowIdSelectorFirstHalf = "SELECT * FROM backActions WHERE rowid = ";

        Font bold = new Font("Arial",24,FontStyle.Bold);

        List<CheckBox> sizeBoxes = new List<CheckBox>();

        public Form1()
        {
            InitializeComponent();

            sizeListBox.SetItemChecked(0, true);
            sizeListBox.SetItemChecked(1, true);
            sizeListBox.SetItemChecked(2, true);
            sizeListBox.SetItemChecked(3, true);
            sizeListBox.SetItemChecked(4, true);
            sizeListBox.SetItemChecked(5, true);
            sizeListBox.SetItemChecked(6, true);

            fullQuery = createTempTableString + insertIntoTempTableString + mainQueryString + textBoxString + dropTableString;

            TableUpdate(this, null);
        }
        private void TableUpdate(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;

            
            GetData(QueryCompiler());


            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 100;
        }

        private string QueryCompiler()
        {
            additionalString = "";
            createTempTableString = "CREATE TEMPORARY TABLE backMonsters(monsterName, challengeRating, armorClass, hitpointAverage, monsterType, size);";
            insertIntoTempTableString = "INSERT INTO backMonsters SELECT monsterName, challengeRating, armorClass, hitpointAverage, monsterType, size FROM Monsters;";
            mainQueryString = "SELECT monsterName, challengeRating, armorClass, hitpointAverage, monsterType, size FROM backMonsters WHERE monsterName LIKE ";
            textBoxString = "'" + textBox1.Text + "%'";

            additionalString += createSizeStringConditional(additionalString);

            additionalString += ";";
            dropTableString = "DROP TABLE backMonsters;";

            Debug.WriteLine(createTempTableString + insertIntoTempTableString + mainQueryString + textBoxString + additionalString + dropTableString);

            return fullQuery = createTempTableString + insertIntoTempTableString + mainQueryString + textBoxString + additionalString + dropTableString;
            
        }
        private string createSizeStringConditional(string sizeString)
        {
            if (sizeListBox.CheckedItems.Count != 0)
            {
                int secondaryIndex = 0;
                for (int primaryIndex = 0; primaryIndex < sizeListBox.Items.Count; primaryIndex++)
                {
                    if (sizeListBox.GetItemChecked(primaryIndex) == true)
                    {
                        if (secondaryIndex == 0)
                        {
                            sizeString += " AND (";
                            sizeString += "size = '" + sizeListBox.Items.IndexOf(primaryIndex) as string + "'";
                            secondaryIndex++;
                        }
                        if (secondaryIndex > 0)
                        {
                            sizeString += " OR size = '" + sizeListBox.Items.IndexOf(primaryIndex) as string + "'";
                            if (primaryIndex == sizeListBox.CheckedItems.Count)
                            {
                                sizeString += ")";
                            }
                        }
                    }
                }
            }
            
            return sizeString;
        }
        private void GetData(string selectCommand)
        {
            try
            {
                // Specify a connection string.  
                // Replace <SQL Server> with the SQL Server for your Northwind sample database.
                // Replace "Integrated Security=True" with user login information if necessary.
                String connectionString = "Data Source=Monsters.db; Version = 3; New = True; Compress = True;";

                // Create a new data adapter based on the specified query.
                dataAdapter = new SQLiteDataAdapter(selectCommand, connectionString);

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand. 
                SQLiteCommandBuilder commandBuilder = new SQLiteCommandBuilder(dataAdapter);

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

            }
        }
        
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
        private void dataGridView1_CellClick_PopulateMonsterData(object sender, DataGridViewCellEventArgs e)
        {
            foreach(Control rtf in this.Controls)
            {
                if (rtf is RichTextBox)
                {
                    RichTextBox rich = (RichTextBox)rtf;
                    rich.ScrollToCaret();
                }
            }

            String connectionString = "Data Source=Monsters.db; Version = 3; New = True; Compress = True;";

            SQLiteConnection connection = new SQLiteConnection(connectionString);

            table = new DataTable();

            monsterNameQuery = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            SQLiteCommand command = new SQLiteCommand("SELECT image FROM monsters WHERE monsterName='" + monsterNameQuery + "'");
            command.Connection = connection;
            connection.Open();
            monsterInfo = command.ExecuteReader();
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

            command = new SQLiteCommand("SELECT description FROM monsters WHERE monsterName='" + monsterNameQuery + "'");

            command.Connection = connection;
            monsterInfo = command.ExecuteReader();
            monsterInfo.Read();
            descriptionBox.Rtf = (string)GrabMonsterData_OnClick("description");

            command = new SQLiteCommand("SELECT extras FROM monsters WHERE monsterName='" + monsterNameQuery + "'");
            command.Connection = connection;
            monsterInfo = command.ExecuteReader();
            monsterInfo.Read();
            extrasBox.Rtf = (string)GrabMonsterData_OnClick("extras");

            //entityCount = 0;
            //entityCount = EntityCounter(relevantQueryActionFirstHalf + monsterNameQuery + "';", "backActions;");
            actionsBox.Clear();

            /*command = new SQLiteCommand(relevantQueryActionFirstHalf + monsterNameQuery + "';" + relevantQueryActionSecondHalf + "DROP TABLE backActions");
            command.Connection = connection;
            monsterInfo = command.ExecuteReader();
            for (int i = 0; i < 1000; i++)
            {
                monsterInfo.Read();
                actionsBox.Text += (string)GrabMonsterData_OnClick("action");
            }*/
            connection.Close();
        }
        private int EntityCounter(string relevantQuery, string relevantTable)
        {
            int entityCount = 0;

            String connectionString = "Data Source=Monsters.db; Version = 3; New = True; Compress = True;";

            SQLiteConnection connection = new SQLiteConnection(connectionString);

            connection.Open();

            SQLiteCommand countCheck = new SQLiteCommand(relevantQuery + "SELECT COUNT (*) FROM " + relevantTable, connection);
            entityCount = Convert.ToInt32(countCheck.ExecuteScalar());

            connection.Close();

            return entityCount;
        }
    }
}
