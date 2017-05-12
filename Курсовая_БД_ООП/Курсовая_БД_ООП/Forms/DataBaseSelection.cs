using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_БД_ООП.Forms
{
    public partial class DataBaseSelection : Form
    {
        public DataBaseSelection()
        {
            InitializeComponent();
            tableSelectionList.Enabled = false;
            GetDatabaseList();
        }

        private void databaseSelectionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (var con = new SqlConnection(String.Format("Data Source=192.168.100.50,1433;Initial Catalog={0};User ID=sa;Password=WaveTest1;", databaseSelectionList.SelectedItem)))
                {
                    con.Open();
                    string sql = "Select DISTINCT(name) FROM sys.Tables";
                    var command = new SqlCommand(sql, con);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataSet ds = new DataSet();

                    adapter.SelectCommand = command;
                    adapter.Fill(ds);
                    adapter.Dispose();
                    command.Dispose();

                    //DataTable dt = con.GetSchema("Tables");
                    //foreach (DataRow row in dt.Rows)
                    //foreach(var table in ds.Tables[0].Rows)
                    //{
                    //    tableSelectionList.Items.Add(table..ToString());
                    //}
                    //for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                    //{
                    //    tableSelectionList.Items.Add(ds.Tables[0].Rows[i].ItemArray[0].ToString());
                    //}
                    DataTable dt = con.GetSchema("Tables");
                    foreach (DataRow row in dt.Rows)
                    {
                        string tablename = (string)row[2];
                        tableSelectionList.Items.Add(tablename);
                    }
                }
                tableSelectionList.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception message: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tableSelectionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (var con = new SqlConnection(String.Format("Data Source=192.168.100.50,1433;Initial Catalog={0};User ID=sa;Password=WaveTest1;", databaseSelectionList.SelectedItem)))
                {
                    con.Open();
                    DataTable dt = con.GetSchema("Tables");
                    DataRow selected;
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row[2].ToString() == tableSelectionList.SelectedItem.ToString())
                        {
                            selected = row;
                            break;
                        }
                    }

                    string sql = "Select TOP 1 * from " + tableSelectionList.SelectedItem.ToString();
                    SqlCommand sqlCmd = new SqlCommand(sql, con);
                    SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                    DataTable schemaTable = sqlReader.GetSchemaTable();

                    int i = -1;
                    foreach (DataRow row in schemaTable.Rows)
                    {
                        i++;
                        // get only name of column -> [0], other indexes are the data
                        string columnName = row[schemaTable.Columns[0]].ToString();
                        string record = columnName + " — " + sqlReader.GetDataTypeName(i);
                        tableColumnsList.Items.Add(record);
                    }


                }
            }catch(Exception ex)
            {
                MessageBox.Show("Exception message: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetDatabaseList()
        {
            try
            {
                //// Open connection to the database
                //string conString = "server=xeon;uid=sa;pwd=manager; database=northwind";

                //using (SqlConnection con = new SqlConnection(conString))
                //{
                //    con.Open();

                //    // Set up a command with the given query and associate
                //    // this with the current connection.
                //    using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases", con))
                //    {
                //        using (IDataReader dr = cmd.ExecuteReader())
                //        {
                //            while (dr.Read())
                //            {
                //                databaseSelectionList.Items.Add(dr[0].ToString());
                //            }
                //        }
                //    }
                //}
                using (var con = new SqlConnection("Data Source=192.168.100.50,1433;User ID=sa;Password=WaveTest1;"))
                {
                    con.Open();
                    DataTable databases = con.GetSchema("Databases");
                    foreach (DataRow database in databases.Rows)
                    {
                        String databaseName = database.Field<String>("database_name");
                        short dbID = database.Field<short>("dbid");
                        DateTime creationDate = database.Field<DateTime>("create_date");
                        databaseSelectionList.Items.Add(databaseName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception message: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
