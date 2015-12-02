using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.HoraDB
{
    public class DateTimeHandler
    {
        public DateTime devolverFechaDB()
        {
            SqlCommand sqlCmd = new SqlCommand("SELECT THE_CVENGERS.fechaReal() AS f", Conexion.getConexion());

            SqlDataReader reader = sqlCmd.ExecuteReader();

            reader.Read();

            return SqlDateTime.Parse(reader["f"].ToString()).Value;
        }
    }
}
