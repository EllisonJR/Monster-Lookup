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

        public Form1()
        {
            InitializeComponent();

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

            if (monsterSizes.Text == "Tiny")
            {
                additionalString += " AND size = 'Tiny'";
            }
            if (monsterSizes.Text == "Small")
            {
                additionalString += " AND size = 'Small'";
            }
            if (monsterSizes.Text == "Medium")
            {
                additionalString += " AND size = 'Medium'";
            }
            if (monsterSizes.Text == "Large")
            {
                additionalString += " AND size = 'Large'";
            }
            if (monsterSizes.Text == "Huge")
            {
                additionalString += " AND size = 'Huge'";
            }
            if (monsterSizes.Text == "Gargantuan")
            {
                additionalString += " AND size = 'Gargantuan'";
            }
            if (monsterSizes.Text == "Colossal")
            {
                additionalString += " AND size = 'Colosssal'";
            }
            additionalString += ";";
            dropTableString = "DROP TABLE backMonsters;";

             return fullQuery = createTempTableString + insertIntoTempTableString + mainQueryString + textBoxString + additionalString + dropTableString;
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
        private Byte[] GrabMonsterImage(string selectCommand)
        {
            Byte[] image = null;
            SQLiteDataReader monsterInfo;
            String connectionString = "Data Source=Monsters.db; Version = 3; New = True; Compress = True;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(selectCommand, connection))
                {
                    using (monsterInfo = command.ExecuteReader())
                    {
                        while (monsterInfo.Read())
                        {
                            if (monsterInfo["image"] != null && !Convert.IsDBNull(monsterInfo["image"]))
                            {
                                image = (Byte[])monsterInfo["image"];
                            }
                        }
                    }
                }
                connection.Close();
            }
            return image;
        }
        private string GrabMonsterDescription(string selectCommand)
        {
            string description = "";
            SQLiteDataReader monsterInfo;
            String connectionString = "Data Source=Monsters.db; Version = 3; New = True; Compress = True;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(selectCommand, connection))
                {
                    using (monsterInfo = command.ExecuteReader())
                    {
                        while (monsterInfo.Read())
                        {
                            if (monsterInfo["description"] != null && !Convert.IsDBNull(monsterInfo["description"]))
                            {
                                description = (string)monsterInfo["description"];
                            }
                        }
                    }
                }
                connection.Close();
            }
            return description;
        }
        private void dataGridView1_CellClick_PopulateMonsterData(object sender, DataGridViewCellEventArgs e)
        {
            monsterNameQuery = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();

            Byte[] data = GrabMonsterImage("SELECT image FROM monsters WHERE monsterName='" + monsterNameQuery + "'");
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

            descriptionBox.Text = GrabMonsterDescription("SELECT description FROM monsters WHERE monsterName='" + monsterNameQuery + "'");
        }
    }
}
