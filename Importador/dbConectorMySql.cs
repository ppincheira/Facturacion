using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Importador
{

        public class dbConectorMySql
        {

            public static MySqlConnection ObtenerConexion()
            {
                try
                {
                    MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=cooperativa2; Uid=root; pwd=1234;");

                    conectar.Open();
                    return conectar;
                }
                catch
                {
                    return null;
                }
            }

        }
    
}
