using System;
using System.Collections.Generic;
using System.Data;
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

        public void llenarListBox(ref ListBox miCombo, String nombreTabla, String nombreColumna)
        {

            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM THE_CVENGERS." + nombreTabla, Conexion.getConexion());

            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                miCombo.Items.Add(sqlReader[nombreColumna].ToString());
            }

            sqlReader.Close();

        }

        public void llenarCheckedListBox(ref CheckedListBox miCombo, String nombreTabla, String nombreColumna)
        {

            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM THE_CVENGERS." + nombreTabla, Conexion.getConexion());

            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                miCombo.Items.Add(sqlReader[nombreColumna].ToString());
            }

            sqlReader.Close();

        }

        public void llenarDataGridView(DataGridView dgv, String nombreTabla) 
        {
            SqlDataAdapter adapter;
            DataTable tabla;

            try {
                adapter = new SqlDataAdapter("EXECUTE [THE_CVENGERS].getAll @RECV = '[THE_CVENGERS]." + nombreTabla+"';", Conexion.getConexion());
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
