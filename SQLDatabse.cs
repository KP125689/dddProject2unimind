﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using MySql;



namespace dddProject2
{
    public class SQLDatabse
    {
        public static MySqlConnection GetConnection()
        {
            string connStr = "server=localhost;user=root;database=UniMind;port=3306;password=L3tM31n"; //paramenters will change once deployed on cloud
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL database...");
                conn.Open();
                Console.WriteLine("connection successful");


            }
            catch (Exception)
            {
                Console.WriteLine("theres been an error");
            }
            conn.Close(); // close the connection 
            return conn;
        }
        public static void LoginPageDatabase()
        {
            GetConnection().Open();
        }
    }
}
