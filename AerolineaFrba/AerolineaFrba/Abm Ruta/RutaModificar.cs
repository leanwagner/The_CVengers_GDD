﻿using AerolineaFrba.Llenador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Ruta
{
    public partial class RutaModificar : Form
       {
        LlenadorDeTablas llenador = new LlenadorDeTablas();
        object elementoQuitadoTablaDestino;
        object elementoQuitadoTablaOrigen;
        


        public RutaModificar(int ruta_id, int cod_ruta, string ciudad_origen, string ciudad_destino,decimal precio_KG, decimal precio_pasaje)
        {
            InitializeComponent();
            this.mostrarCiudad(ref comboBox_ciudadOrigen);
            this.mostrarCiudad(ref comboBox_ciudadDestino);
            this.mostrarServicios(sacoServicios(ruta_id)); 
            comboBox_ciudadDestino.SelectedItem= ciudad_destino; // SETEOS PARA LEVANTAR la vista
            comboBox_ciudadOrigen.SelectedItem = ciudad_origen;
            numericUpDown_codRuta.Value = cod_ruta;
            numericUpDown_precioKG.Value = precio_KG;
            numericUpDown_precioPasaje.Value = precio_pasaje;
            
            
            
        }

        public void mostrarCiudad(ref ComboBox miCombo)
        {
            llenador.llenarComboBox(ref miCombo, "CIUDAD", "CIUDAD_NOMBRE");

        }

        public void mostrarServicios(List<int> lista)
        {

            llenador.llenarCheckedListBoxMRuta(ref checkedListBox_servicios,lista);

        } 

        private void comboBox_ciudadOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (elementoQuitadoTablaDestino != null)
                comboBox_ciudadDestino.Items.Add(elementoQuitadoTablaDestino);

            int indiceElegido = comboBox_ciudadDestino.Items.IndexOf(comboBox_ciudadOrigen.SelectedItem);
            elementoQuitadoTablaDestino = comboBox_ciudadOrigen.SelectedItem;

            comboBox_ciudadDestino.Items.RemoveAt(indiceElegido);

            comboBox_ciudadDestino.Refresh();
        }


        public static List<int> sacoServicios(int ruta_id) {

            List<int> list = new List<int>();
          

            SqlCommand sqlCmd = new SqlCommand("SELECT SERVICIOXRUTA_RUTA FROM [GD2C2015].[THE_CVENGERS].[SERVICIOXRUTA] WHERE SERVICIOXRUTA_RUTA =" + ruta_id, Conexion.getConexion());

            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                list.Add(Int32.Parse(sqlReader["SERVICIOXRUTA_RUTA"].ToString()));
            }

            sqlReader.Close();

            return list;
        }


        private void comboBox_ciudadDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (elementoQuitadoTablaOrigen != null)
                comboBox_ciudadOrigen.Items.Add(elementoQuitadoTablaOrigen);

            int indiceElegido = comboBox_ciudadOrigen.Items.IndexOf(comboBox_ciudadDestino.SelectedItem);
            elementoQuitadoTablaOrigen = comboBox_ciudadDestino.SelectedItem;

            comboBox_ciudadOrigen.Items.RemoveAt(indiceElegido);

            comboBox_ciudadOrigen.Refresh();
        }

        private void boton_Agregar_Ciudad_Click(object sender, EventArgs e)
        {
            String servicio1 = "NULL";
            String servicio2 = "NULL";
            String servicio3 = "NULL";

            if(checkedListBox_servicios.CheckedItems.Contains(checkedListBox_servicios.Items[0]))
                servicio1 = checkedListBox_servicios.Items[0].ToString();

            if(checkedListBox_servicios.CheckedItems.Contains(checkedListBox_servicios.Items[1]))
                servicio2 = checkedListBox_servicios.Items[1].ToString();

            if(checkedListBox_servicios.CheckedItems.Contains(checkedListBox_servicios.Items[2]))
                servicio3 = checkedListBox_servicios.Items[2].ToString();


             try
                {
                       SqlCommand sqlCmd = new SqlCommand("EXEC THE_CVENGERS.modificacionRuta @P1 = " + numericUpDown_codRuta.Value +
                        ", @P2 = '" + comboBox_ciudadOrigen.SelectedItem.ToString() +
                        "', @P3 = '" + comboBox_ciudadDestino.SelectedItem.ToString() +
                        "', @P4 = " +  numericUpDown_precioKG.Value+
                        ", @P5 = " + numericUpDown_precioPasaje.Value +
                        ", @P6 = '" + servicio1 +
                        "', @P7 = " + servicio2 +
                        ", @P8 = " + servicio3, Conexion.getConexion());

                    sqlCmd.ExecuteScalar();

                    MessageBox.Show("La Ruta ha sido modificada con éxito.");

                    this.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
        }

    }
}
