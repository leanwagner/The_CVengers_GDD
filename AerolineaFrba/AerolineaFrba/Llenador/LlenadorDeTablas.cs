using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Llenador
{
    public class LlenadorDeTablas
    {

        public void llenarComboBox(ref ComboBox miCombo, String nombreTabla, String nombreColumna)
        {

            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM THE_CVENGERS." + nombreTabla, Conexion.getConexion());

            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                miCombo.Items.Add(sqlReader[nombreColumna].ToString());
            }

            sqlReader.Close();
        
        }

    }
}
