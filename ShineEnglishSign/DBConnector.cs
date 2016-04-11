using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Xml;

namespace ShineEnglishSign
{
    static class DBConnector
    {
        private static string server = "localhost";
        private static string username = "root";
        private static string password = "phil";
        private static string database = "sign";
        private static string port = "3306";
        private static MySqlConnection con;
        public static MySqlConnection getcon() 
        {
            XmlDocument doc = new XmlDocument();      
            doc.Load("config.xml");    //加载Xml文件  
            XmlElement rootElem = doc.DocumentElement;   //获取根节点  
            XmlNodeList ipNodes = rootElem.GetElementsByTagName("ip"); //获取person子节点集合
            XmlNodeList nameNodes = rootElem.GetElementsByTagName("name"); //获取person子节点集合
            XmlNodeList pswNodes = rootElem.GetElementsByTagName("psw"); //获取person子节点集合
            server = ipNodes[0].InnerText;
            username = nameNodes[0].InnerText;
            password = pswNodes[0].InnerText;
            string conString = "server=" + server + ";User Id=" + username + ";password=" + password + ";Database=" + database + ";port=" + port;
            con = new MySqlConnection(conString);
            return con;
        }

        public static void close() {
            con.Close();
        }
    }
}
