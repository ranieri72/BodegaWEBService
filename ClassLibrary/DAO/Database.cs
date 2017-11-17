using System;
using Npgsql;
using System.Xml;

namespace ClassLibrary.DAO
{
    public class Database
    {
        private static readonly Database _Instance = new Database();
        private static string local;
        private static string name;
        private static string user;
        private static string password;
        private static string port;

        public Database()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("c:\\database.xml");
            XmlNode node;

            node = doc.DocumentElement.SelectSingleNode("/database/local");
            local = node.InnerText;

            node = doc.DocumentElement.SelectSingleNode("/database/name");
            name = node.InnerText;

            node = doc.DocumentElement.SelectSingleNode("/database/user");
            user = node.InnerText;

            node = doc.DocumentElement.SelectSingleNode("/database/password");
            password = node.InnerText;

            node = doc.DocumentElement.SelectSingleNode("/database/port");
            port = node.InnerText;
        }
        
        public static Database getInstance()
        {
            return _Instance;
        }

        public static NpgsqlConnection openConnection()
        {
            string url = "Server=" + local + ";"
            + "Port=" + port + ";"
            + "Database=" + name + ";"
            + "User Id=" + user + ";"
            + "Password=" + password + ";";
            try
            {
                NpgsqlConnection connection = new NpgsqlConnection(url);
                connection.Open();
                return connection;
            }
            catch (NpgsqlException npgEx)
            {
                Console.WriteLine(npgEx.Message + " openConnection");
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " openConnection");
                return null;
            }
        }
    }
}
