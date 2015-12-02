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
        public void llenarListBoxSacandoLosDelOtro(ref ListBox miCombo,ref ListBox list, String nombreTabla, String nombreColumna)
        {

            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM THE_CVENGERS." + nombreTabla, Conexion.getConexion());

            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                if(!list.Items.Contains(sqlReader[nombreColumna].ToString()))
                miCombo.Items.Add(sqlReader[nombreColumna].ToString());
            }

            sqlReader.Close();

        }

        public void llenarComboBoxSacandoLosDelOtro(ref ComboBox miCombo, ref ComboBox list, String nombreTabla, String nombreColumna)
        {

            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM THE_CVENGERS." + nombreTabla, Conexion.getConexion());

            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                if (!list.Items.Contains(sqlReader[nombreColumna].ToString()))
                    miCombo.Items.Add(sqlReader[nombreColumna].ToString());
            }

            sqlReader.Close();

        }

        public void llenarListBoxConCondicion(ref ListBox miCombo, String nombreTabla, String nombreColumna, String condicion)
        {

            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM THE_CVENGERS." + nombreTabla + " where " + condicion, Conexion.getConexion());

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
        public void llenarCheckedListBoxMRuta(ref CheckedListBox miCombo,List<int> lista)
        {

            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM THE_CVENGERS.SERVICIO", Conexion.getConexion());

            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {

                miCombo.Items.Add(sqlReader["SERVICIO_NOMBRE"].ToString());
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
        public void llenarDGV_ABMRutas(DataGridView dgv)
        {
            SqlDataAdapter adapter;
            DataTable tabla;

            try
            {
                adapter = new SqlDataAdapter("SELECT * FROM THE_CVENGERS.RutasDisponibles", Conexion.getConexion());
                tabla = new DataTable();

                adapter.Fill(tabla);
                dgv.DataSource = tabla;
                dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                adapter.Dispose();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK);
             

            }
        } 

    }
}
