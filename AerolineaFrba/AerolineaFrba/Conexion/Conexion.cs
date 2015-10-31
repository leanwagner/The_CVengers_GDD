using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AerolineaFrba
{
    class Conexion
    {
        private static SqlConnection conexionDB = null;
        private static SqlDataAdapter adapter;
        private static DataTable tabla;

        public static SqlConnection getConexion()
        {
            if (conexionDB == null)
            {
                try
                {
                    conexionDB = new SqlConnection("Server=localhost\\SQLSERVER2012;Initial Catalog=GD2C2015;Integrated Security=True");
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

        public static void llenarTabla(DataGridView dgv, String nombreTabla) 
        {

            try {
                adapter = new SqlDataAdapter("EXECUTE [THE_CVENGERS].getAll @RECV = '[THE_CVENGERS]." + nombreTabla+"';", conexionDB);
                tabla = new DataTable();
                
                adapter.Fill(tabla);
                dgv.DataSource=tabla;
                dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                adapter.Dispose();
            }
            catch (Exception ex) {

                MessageBox.Show("Rompe mostrando tabla " + nombreTabla + ex);
            
            }
        }       
    }
}
