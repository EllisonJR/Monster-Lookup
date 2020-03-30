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
    public class DBConnector
    {
        BindingSource bindingSource1;
        SQLiteDataAdapter dataAdapter;
        DataTable table = new DataTable();
        string connectionString = "Data Source=Monsters.db; Version = 3; New = True; Compress = True;";
        public BindingSource GrabData(string selectCommand)
        {
            bindingSource1 = new BindingSource();
            dataAdapter = new SQLiteDataAdapter();
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
                table = new DataTable
                {
                    Locale = CultureInfo.InvariantCulture
                };
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;
            }
            catch (SQLiteException)
            {
                //EAT DAT EXCEPTION BEEBEE
            }
            return bindingSource1;
        }
        public DataTable ExposeData(string selectCommand)
        {
            bindingSource1 = new BindingSource();
            dataAdapter = new SQLiteDataAdapter();
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
                table = new DataTable
                {
                    Locale = CultureInfo.InvariantCulture
                };
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;
            }
            catch (SQLiteException)
            {
                //EAT DAT EXCEPTION BEEBEE
            }
            return table;
        }
    }
}
