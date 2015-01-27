using System.Data;
using Npgsql;
using System;
using System.Windows.Forms;
namespace PostgreSQLManager
{
    public class QueryProcessing
    {
        public DataTable ExecuteQuery(ConnectionData connectionData, string queryText)
        {
            DataTable dataTable = new DataTable();
            DataAccess access = new DataAccess(connectionData);
            string connectionString = access.CreateConnectionString();

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    NpgsqlTransaction transaction = connection.BeginTransaction();

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(queryText, connectionString))
                    {
                        adapter.Fill(dataTable);
                        transaction.Commit();
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dataTable;
        }

        public DataTable ExecuteStoredProcedure(ConnectionData connectionData, string queryText)
        {
            DataTable dataTable = new DataTable();
            DataAccess access = new DataAccess(connectionData);
            string connectionString = access.CreateConnectionString();

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    NpgsqlTransaction transaction = connection.BeginTransaction();

                    NpgsqlCommand command = new NpgsqlCommand(queryText, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                        transaction.Commit();
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dataTable;
        }
    }
}
