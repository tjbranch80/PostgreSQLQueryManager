using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace PostgreSQLManager
{
    public class ProfileManagement
    {
        public XmlDocument CreateProfile(ConnectionData connectionData, string fileName)
        {
            FileManagement fileManagement = new FileManagement();
            XmlDocument xmlDoc = new XmlDocument();

            XmlNode rootNode = xmlDoc.CreateElement(fileName);
            xmlDoc.AppendChild(rootNode);

            XmlElement profileNode = xmlDoc.CreateElement("Profile");

            XmlElement serverName = xmlDoc.CreateElement("ServerName");
            serverName.InnerText = connectionData.ServerName;
            profileNode.AppendChild(serverName);

            XmlElement port = xmlDoc.CreateElement("PortNumber");
            port.InnerText = connectionData.PortNumber;
            profileNode.AppendChild(port);

            XmlElement user = xmlDoc.CreateElement("UserName");
            user.InnerText = connectionData.UserName;
            profileNode.AppendChild(user);

            XmlElement password = xmlDoc.CreateElement("Password");
            password.InnerText = connectionData.Password;
            profileNode.AppendChild(password);

            XmlElement database = xmlDoc.CreateElement("DatabaseName");
            database.InnerText = connectionData.DatabaseName;
            profileNode.AppendChild(database);

            rootNode.AppendChild(profileNode);

            return xmlDoc;
        }
    }
}
