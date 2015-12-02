using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace AerolineaFrba
{
    class Conexion
    {
        private static SqlConnection conexionDB = null;

        public static SqlConnection getConexion()
        {
            if (conexionDB == null)
            {
                try
                {
                    conexionDB = new SqlConnection(ConfigurationManager.AppSettings["confSQL"].ToString());
                    conexionDB.Open();
                    return conexionDB;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo establecer conexion con la base de datos: " + ex);
                }

            }
            return conexionDB;
        }      
    }
}
