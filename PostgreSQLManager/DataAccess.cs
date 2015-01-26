using System;
using Npgsql;

namespace PostgreSQLManager
{
    public class DataAccess
    {
        private ConnectionData connectionData;

        public DataAccess(ConnectionData connectionData)
        {
            this.connectionData = new ConnectionData();
            this.connectionData = connectionData;
        }

        public Result TestDatabaseConnection()
        {
            Result result = new Result();
            try
            {
                string connectionString = CreateConnectionString();

                if (!string.IsNullOrWhiteSpace(connectionString))
                {
                    NpgsqlConnection connection = new NpgsqlConnection(connectionString);
                    connection.Open();

                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        result.Success = true;
                        result.Message = "Connection Test Passed";
                        result.ConnectionString = connectionString;
                    }
                    else
                    {
                        result.Success = false;
                        result.Message = "Connection Test Failed";
                        result.ConnectionString = connectionString;
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }

            return result;
        }

        public string CreateConnectionString()
        {
            string connectionString = string.Format("Server={0};Port={1};User Id={2};Password={3};Database={4}",
                connectionData.ServerName, connectionData.PortNumber, connectionData.UserName, connectionData.Password, connectionData.DatabaseName);

            return connectionString;
        }
    }
}
