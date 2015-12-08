using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public void llenarComboBoxAeronaves(ref ComboBox miCombo, int id_avion,String fecha)
        {

            SqlCommand sqlCmd = new SqlCommand("", Conexion.getConexion());

            if (fecha == "") sqlCmd.CommandText = "select * from THE_CVENGERS.aeronavesQuePuedenSuplantarDePorVida(" + id_avion.ToString() + ")";
            else sqlCmd.CommandText = "select * from THE_CVENGERS.aeronavesQuePuedenSuplantarPorUnLapso(" + id_avion.ToString() + "," + fecha + ")";

            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                miCombo.Items.Add(sqlReader["AERONAVE_MATRICULA_AVION"].ToString());
            }

            sqlReader.Close();

        }

        public void llenarComboBoxSemestre(ref ComboBox miCombo,int a, int lista)
        {

            SqlCommand sqlCmd = new SqlCommand("select distinct (case when MONTH(COMPRA_FECHA)>6 then 2 else 1 end) 's' from THE_CVENGERS.COMPRA where year(COMPRA_FECHA)=" + a, Conexion.getConexion());

            switch (lista) 
            { 
                case 0:
                    sqlCmd.CommandText = "select distinct (case when MONTH(COMPRA_FECHA)>6 then 2 else 1 end) 's' from THE_CVENGERS.COMPRA where year(COMPRA_FECHA)=" + a;
                    break;
                case 1:
                    sqlCmd.CommandText = "select distinct (case when MONTH(COMPRA_FECHA)>6 then 2 else 1 end) 's' from THE_CVENGERS.COMPRA where year(COMPRA_FECHA)=" + a;
                    break;
                case 2:
                case 3:
                case 4:
                    break;
            }

            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                miCombo.Items.Add(sqlReader["s"].ToString());
            }

            sqlReader.Close();

        }

        public void llenarComboBoxAnios(ref ComboBox miCombo)
        {

            SqlCommand sqlCmd = new SqlCommand("select distinct year(COMPRA_FECHA) 'a' from THE_CVENGERS.COMPRA where COMPRA_ID in (select PASAJE_COMPRA from THE_CVENGERS.PASAJE where COMPRA_ID = PASAJE_COMPRA)", Conexion.getConexion());

            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                miCombo.Items.Add(sqlReader["a"].ToString());
            }

            sqlReader.Close();

        }


        public void llenarComboBoxPremios(ref ComboBox miCombo)
        {

            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM THE_CVENGERS.PRODUCTO order by PRODUCTO_MILLAS_NECESARIAS", Conexion.getConexion());

            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                miCombo.Items.Add(sqlReader["PRODUCTO_NOMBRE"].ToString() +" - " +sqlReader["PRODUCTO_MILLAS_NECESARIAS"] +" Puntos");
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

        public void llenarComboBoxConCondicion(ref ComboBox miCombo, String nombreTabla, String nombreColumna, String condicion)
        {

            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM THE_CVENGERS." + nombreTabla + " where " + condicion, Conexion.getConexion());

            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

         //   MessageBox.Show(sqlCmd.CommandText);
            while (sqlReader.Read())
            {
                miCombo.Items.Add(sqlReader[nombreColumna].ToString());
            }

            sqlReader.Close();

        }
        public void llenarComboBoxDeUnaCollection( ref List <int> colec,ref ComboBox miCombo)
        {
            

            foreach (int id in colec)
                miCombo.Items.Add(id); 

        }
        public void llenarListaConCondicion(ref Collection<int> lista, String nombreTabla, String nombreColumna, String condicion)
        {

            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM THE_CVENGERS." + nombreTabla + " where " + condicion, Conexion.getConexion());

            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            //   MessageBox.Show(sqlCmd.CommandText);
            while (sqlReader.Read())
            {
   
                lista.Add(Int32.Parse(sqlReader[nombreColumna].ToString()));
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
                adapter = new SqlDataAdapter("select * from [THE_CVENGERS]." + nombreTabla, Conexion.getConexion());
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
        public void llenarDataGridViewABMCiudad(DataGridView dgv)
        {
            SqlDataAdapter adapter;
            DataTable tabla;

            try
            {
                adapter = new SqlDataAdapter("select CIUDAD_ID as 'Id Ciudad', CIUDAD_NOMBRE as 'Nombre Ciudad' from [THE_CVENGERS].CIUDAD WHERE CIUDAD_ESTADO=1", Conexion.getConexion());
                tabla = new DataTable();

                adapter.Fill(tabla);
                dgv.DataSource = tabla;
                dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                adapter.Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show("rompe mostrando ciudades");

            }
        }

        public void llenarDataGridViewDevolucion(DataGridView dgv,String idCl)
        {
            SqlDataAdapter adapter;
            DataTable tabla;

            try
            {
                adapter = new SqlDataAdapter("select * from [THE_CVENGERS].comprasCliente("+idCl+") order by 'Fecha compra'", Conexion.getConexion());
                tabla = new DataTable();

                adapter.Fill(tabla);
                dgv.DataSource = tabla;
                dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                adapter.Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Rompe mostrando tabla " + ex);

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
        public void llenarDGV_Compra(DataGridView dgv)
        {
            SqlDataAdapter adapter;
            DataTable tabla;

            try
            {
                adapter = new SqlDataAdapter("SELECT * FROM THE_CVENGERS.viajesCompra", Conexion.getConexion());
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


        public void filtrarDataGridView(DataGridView miDataGridView, String sqlQuery)
        {

            SqlDataAdapter adapter;
            DataTable tabla;

            try
            {
                adapter = new SqlDataAdapter(sqlQuery, Conexion.getConexion());
                tabla = new DataTable();

                adapter.Fill(tabla);
                miDataGridView.DataSource = tabla;
                miDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                adapter.Dispose();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK);

            }
        }

    }
}
