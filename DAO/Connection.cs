using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Connection
    {
        public static void getConnection()
        {
            try
            {
                string con = "server=127.0.0.1;uid=root;pwd=tunglanet123;database=bus007";
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = con;
                conn.Open();
                Console.WriteLine("Ket noi thanh cong");
            }
            catch (MySqlException ex){ 
                Console.WriteLine(ex.Message);
            }
        }

        public static void Main(string[] args)
        {
            getConnection();
        }
    }
}
