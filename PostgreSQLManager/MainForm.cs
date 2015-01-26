using System;
using System.Data;
using System.Windows.Forms;
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
            DataTable dataTable = new DataTable();
            QueryProcessing queryProcessing = new QueryProcessing();
            ConnectionData connData = GetConnectionInformation();
            dataTable = queryProcessing.ExecuteQuery(connData, QueryTextBox.Text);
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

                result = fileManager.SaveNewProfile(connectionData, fileName, filePath);
            }

            MessageBox.Show(result.Message);
        }
    }
}
