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
    public class Conexion
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
                    inicializarFechaSistema();
                    return conexionDB;
                }

                catch 
                {
                    MessageBox.Show("No se pudo establecer conexion con la base de datos","Error",MessageBoxButtons.Ok);
                    Environment.Exit(1);
                }

            }
            return conexionDB;
        }

        public static void inicializarFechaSistema()
        {
            String fechaSistema = ConfigurationManager.AppSettings["Fecha"];
            
            SqlCommand sqlCmd = new SqlCommand("EXEC THE_CVENGERS.setearFecha @P1= '" + fechaSistema + ".000'",Conexion.getConexion());
            sqlCmd.ExecuteNonQuery();
        }
    }
}
