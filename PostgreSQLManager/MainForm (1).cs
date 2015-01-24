using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Npgsql;
using System.IO;

namespace PostgreSQLManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btConnectionTest_Click(object sender, EventArgs e)
        {
            string userMessage = "";
            ConnectionData connectionInfo = GetConnectionInformation();
            DataAccess dataAccess = new DataAccess(connectionInfo);
            Result result = dataAccess.TestDatabaseConnection();

            if (result.Success == true)
            {
                userMessage = string.Format("Can Connect = {0}", result.Success);
            }
            else
            {
                userMessage = string.Format("Message Returned = {0} Can Connect = {1}", result.Message, result.Success);
            }

            MessageBox.Show(userMessage);
        }

        private void btLoadQuery_Click(object sender, EventArgs e)
        {
            QueryTextBox.Text = "";
            string queryText = GetSavedQuery();
            QueryTextBox.Text = queryText;
        }

        private void btSaveQuery_Click(object sender, EventArgs e)
        {
            string queryText = QueryTextBox.Text;
            SaveQuery(queryText);
        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            QueryTextBox.Clear();
            dataGridView1.DataSource = "";
            dataGridView1.Refresh();
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            //DataTable dataTable = new DataTable();
            //dataTable = GetInfo();
            ////CreateInfo();
            //dataGridView1.DataSource = dataTable;
        }

        //private void CreateInfo()
        //{
        //    using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        //    {
        //        connection.Open();

        //        string query = QueryTextBox.Text;

        //        NpgsqlCommand command = new NpgsqlCommand(query, connection);

        //        int test = command.ExecuteNonQuery();

        //        if (test > 0)
        //        {
        //            MessageBox.Show("Added Data");
        //        }
        //        else
        //        {
        //            MessageBox.Show("No Records Added");
        //        }
        //    }
        //}

        //private DataTable GetInfo()
        //{
        //    using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        //    {
        //        connection.Open();

        //        string query = QueryTextBox.Text;
        //        NpgsqlTransaction transaction = connection.BeginTransaction();

        //        NpgsqlCommand command = new NpgsqlCommand(query, connection);
        //        command.CommandType = CommandType.StoredProcedure;

        //        using (NpgsqlDataReader dr = command.ExecuteReader())
        //        {
        //            DataTable dataTable = new DataTable();
        //            dataTable.Load(dr);
        //            transaction.Commit();
        //            connection.Close();
        //            return dataTable;
        //        }
        //    }
        //}

        private ConnectionData GetConnectionInformation()
        {
            ConnectionData data = new ConnectionData();
            data.ServerName = tbServerName.Text;
            data.PortNumber = tbPort.Text;
            data.UserName = tbUserName.Text;
            data.Password = tbPassword.Text;
            data.DatabaseName = tbDatabaseName.Text;

            return data;
        }

        private string GetSavedQuery()
        {
            string queryText = "";
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "Postgres SQL File (*.SQL)|*.SQL";
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                try
                {
                    queryText = File.ReadAllText(file);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return queryText;
        }

        private void SaveQuery(string queryText)
        {
            saveFileDialog1.FileName = "Query";
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.Filter = "Postgres SQL File (*.SQL)|*.SQL";

            DialogResult result = saveFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                string file = saveFileDialog1.FileName;
                File.WriteAllText(file, queryText);
            }
        }
    }
}
