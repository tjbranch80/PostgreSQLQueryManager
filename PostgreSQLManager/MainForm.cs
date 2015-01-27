﻿using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using System.IO;
using System.Collections.Generic;

namespace PostgreSQLManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();
            DisplayQueryTypes();
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

            if (!string.IsNullOrWhiteSpace(queryText))
            {
                SaveQuery(queryText);
            }
            else
            {
                MessageBox.Show("No query to save");
            }
        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            QueryTextBox.Clear();
            dataGridView1.DataSource = "";
            dataGridView1.Refresh();
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            int typeID = GetQueryType();
            DataTable dataTable = new DataTable();
            QueryProcessing queryProcessing = new QueryProcessing();
            ConnectionData connData = GetConnectionInformation();

            if (typeID == 1)
            {
                dataTable = queryProcessing.ExecuteQuery(connData, QueryTextBox.Text);
            }
            else
            {
                dataTable = queryProcessing.ExecuteStoredProcedure(connData, QueryTextBox.Text);
            }

            dataGridView1.DataSource = dataTable;
        }

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
            FileManagement fileManager = new FileManagement();
            Result dialogResult = new Result();

            string queryText = "";
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "Postgres SQL File (*.PSQL)|*.PSQL";
            DialogResult openDialogResult = openFileDialog1.ShowDialog();

            if (openDialogResult == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;

                queryText = fileManager.OpenQueryFile(file);
            }

            return queryText;
        }

        private void SaveQuery(string queryText)
        {
            FileManagement fileManager = new FileManagement();
            Result result = new Result();

            saveFileDialog1.FileName = "Query";
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.Filter = "Postgres SQL File (*.PSQL)|*.PSQL";

            DialogResult saveDialogResult = saveFileDialog1.ShowDialog();

            if (saveDialogResult == DialogResult.OK)
            {
                string file = saveFileDialog1.FileName;

                if (!string.IsNullOrWhiteSpace(queryText))
                {
                    result = fileManager.SaveQueryFile(file, queryText);
                }
                
            }

            MessageBox.Show(result.Message);
        }

        private void saveProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Result result = new Result();

            result = SaveProfile();

            MessageBox.Show(result.Message);
        }

        private Result SaveProfile()
        {
            Result result = new Result();

            saveFileDialog1.FileName = "Profile";
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.Filter = "Postgres Profile File (*.XML)|*.XML";

            DialogResult saveDialogResult = saveFileDialog1.ShowDialog();

            if (saveDialogResult == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;

                string fileName = Path.GetFileNameWithoutExtension(filePath);

                FileManagement fileManager = new FileManagement();
                ConnectionData connectionData = new ConnectionData();
                connectionData = GetConnectionInformation();

                result = fileManager.SaveNewProfile(connectionData, filePath);
            }

            return result;
        }

        private void loadProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectionData connectionData = new ConnectionData();

            connectionData = LoadProfile();

            tbServerName.Text = connectionData.ServerName;
            tbPort.Text = connectionData.PortNumber;
            tbUserName.Text = connectionData.UserName;
            tbPassword.Text = connectionData.Password;
            tbDatabaseName.Text = connectionData.DatabaseName;
        }

        private ConnectionData LoadProfile()
        {
            ProfileManagement profileManager = new ProfileManagement();
            ConnectionData connectionData = new ConnectionData();

            Result dialogResult = new Result();

            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "Postgres Profile File (*.XML)|*.XML";
            DialogResult openDialogResult = openFileDialog1.ShowDialog();

            if (openDialogResult == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;

                connectionData = profileManager.GetSavedProfile(filePath);
            }

            return connectionData;
        }

        private void DisplayQueryTypes()
        {
            Dictionary<string, int> queryTypes = new Dictionary<string, int>();
            queryTypes.Add("Query", 1);
            queryTypes.Add("Stored Procedure", 2);

            cbQueryType.DataSource = new BindingSource(queryTypes, null);
            cbQueryType.DisplayMember = "Key";
            cbQueryType.ValueMember = "Value";
        }

        private int GetQueryType()
        {
            int typeID = (int)cbQueryType.SelectedValue;
            return typeID;
        }
    }
}
