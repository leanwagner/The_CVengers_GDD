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
        SqlConnection conexionDB;
        SqlCommand comando;
        SqlDataReader reader;
        SqlDataAdapter adapter;
        DataTable tabla;

        public Conexion() {


            try {
                conexionDB = new SqlConnection("Data Source=LEANDRO\\SQLSERVER2012;Initial Catalog=GD2C2015;Integrated Security=True");                
                conexionDB.Open();
               }
            catch (Exception ex){

                MessageBox.Show("rompe pepe" + ex);
            
            
            }
        }
        public void llenarTabla(DataGridView dgv) 
        {

            try {
                adapter = new SqlDataAdapter("SELECT * FROM CIUDAD;",conexionDB);
                tabla = new DataTable();
                adapter.Fill(tabla);
                dgv.DataSource=tabla;
            }
            catch (Exception ex) {

                MessageBox.Show("rompe pepe mostrando tabla" + ex);
            
            }
        
        
        
        }

    }
}
