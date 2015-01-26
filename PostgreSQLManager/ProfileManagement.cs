using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace PostgreSQLManager
{
    public class ProfileManagement
    {
        public Result SaveProfile(ConnectionData connectionData)
        {
            Result result = new Result();
            FileManagement fileManagement = new FileManagement();
        }

        public void CreateProfileNode(ConnectionData connectionData, XmlTextWriter writer)
        {
            writer.WriteStartElement("Profile");

            writer.WriteStartElement("ServerName");
            writer.WriteString(connectionData.ServerName);
            writer.WriteEndElement();

            writer.WriteStartElement("Port");
            writer.WriteStartElement(connectionData.PortNumber);
            writer.WriteEndElement();

            writer.WriteStartElement("UserName");
            writer.WriteStartElement(connectionData.UserName);
            writer.WriteEndElement();
        }
    }
}
