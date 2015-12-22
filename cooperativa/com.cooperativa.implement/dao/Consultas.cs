using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace com.cooperativa.implement.dao
{
    public class Consultas
    {

        public DataTable GetScript(string Consulta)
        {

            try
            {
                DataTable dt = new DataTable();
                string query;
                query = Consulta;
                MySqlCommand cmd = new MySqlCommand(query, dbConectorMySql.ObtenerConexion());
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                adap.Fill(dt);
                return dt;


            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
