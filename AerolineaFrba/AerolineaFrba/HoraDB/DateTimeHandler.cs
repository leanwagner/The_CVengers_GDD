using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.HoraDB
{
    public class DateTimeHandler
    {
        public static DateTime devolverFechaDB()
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SELECT THE_CVENGERS.fechaReal() AS f", Conexion.getConexion());

                SqlDataReader reader = sqlCmd.ExecuteReader();

                reader.Read();
                DateTime retu = SqlDateTime.Parse(reader["f"].ToString()).Value;
                reader.Close();
                return retu;
            }
            catch
            {
                MessageBox.Show("No se puede traer hora de la base de datos","Error",MessageBoxButtons.OK);
                return new DateTime();
            }
        }
    }
}
