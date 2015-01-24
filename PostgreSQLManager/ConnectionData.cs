using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PostgreSQLManager
{
    public class ConnectionData
    {
        public string ServerName { get; set; }
        public string PortNumber { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string DatabaseName { get; set; }
    }
}
