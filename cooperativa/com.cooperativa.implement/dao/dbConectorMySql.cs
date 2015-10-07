using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace com.cooperativa.implement
{
    public class dbConectorMySql
    {

        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=cooperativa; Uid=root; pwd=1234;");

            conectar.Open();
            return conectar;
        }

    }
}
