using System;

namespace PostgreSQLManager
{
    public class Result
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public string ConnectionString { get; set; }
    }
}
