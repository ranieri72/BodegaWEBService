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
            try
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
            catch (Exception e)
            {
                throw new Exception("Os dados de conexão com o banco de dados não foram encontrados! " + e.Message);
            }
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
                throw new Exception("Erro na conexão com o banco de dados! " + npgEx.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao abrir conexão com o banco de dados! " + e.Message);
            }
        }
    }
}
