﻿using AerolineaFrba.Llenador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
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
        int ID_Ruta;
        


        public RutaModificar(int ruta_id, int cod_ruta, string ciudad_origen, string ciudad_destino,decimal precio_KG, decimal precio_pasaje, string tipo_primera, string tipo_eco, string tipo_turista)
        {
            InitializeComponent();
            ID_Ruta = ruta_id;
            this.mostrarCiudad(ref comboBox_ciudadOrigen);
            this.mostrarCiudad(ref comboBox_ciudadDestino);
            this.mostrarServicios(ref checkedListBox_servicios,tipo_primera,tipo_eco,tipo_turista); 
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

        public void mostrarServicios(ref CheckedListBox  miCombo,  string t_primera,string t_eco,string t_turista)
        {
            
            miCombo.Items.Add("Primera Clase");
            miCombo.Items.Add("Ejecutivo");
            miCombo.Items.Add("Turista");

            if (t_primera == "Sí") { miCombo.SetItemCheckState(0, CheckState.Checked); }
            if (t_eco == "Sí") { miCombo.SetItemCheckState(1, CheckState.Checked); }
            if (t_turista == "Sí") { miCombo.SetItemCheckState(2, CheckState.Checked); }        
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

            if (comboBox_ciudadOrigen.SelectedItem != null && comboBox_ciudadDestino.SelectedItem != null && numericUpDown_precioKG.Value > 0 && numericUpDown_precioPasaje.Value > 0)
            {
                errorProvider_ciudadDestino.Clear();
                errorProvider_ciudadOrigen.Clear();
                errorProvider_precioKg.Clear();
                errorProvider_precioPasaje.Clear();
                errorProvider_Servicios.Clear();

               
             try
                {
                       SqlCommand sqlCmd = new SqlCommand("EXEC THE_CVENGERS.modificacionRuta @P0=" + ID_Ruta +" ,@P1 = " + numericUpDown_codRuta.Value +
                        ", @P2 = '" + comboBox_ciudadOrigen.SelectedItem.ToString().Substring(1) +
                        "', @P3 = '" + comboBox_ciudadDestino.SelectedItem.ToString().Substring(1) +
                        "', @P4 = " +  numericUpDown_precioKG.Value.ToString(CultureInfo.InvariantCulture)+
                        ", @P5 = " + numericUpDown_precioPasaje.Value.ToString(CultureInfo.InvariantCulture) +
                        ", @P6 = '" + servicio1 +
                        "', @P7 = '" + servicio2 +
                        "', @P8 = '" + servicio3+"';", Conexion.getConexion());

                    sqlCmd.ExecuteScalar();

                    MessageBox.Show("La Ruta ha sido modificada con éxito.");

                    this.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }


            }

            else
            {
                if (comboBox_ciudadOrigen.SelectedItem == null)
                    errorProvider_ciudadOrigen.SetError(comboBox_ciudadOrigen, "Por favor seleccione una ciudad de Origen");
                else errorProvider_ciudadOrigen.Clear();


                if (comboBox_ciudadDestino.SelectedItem == null)
                    errorProvider_ciudadDestino.SetError(comboBox_ciudadDestino, "Por favor seleccione una ciudad de Destino");
                else errorProvider_ciudadDestino.Clear();

                if (checkedListBox_servicios.CheckedItems.Count == 0)
                    errorProvider_Servicios.SetError(checkedListBox_servicios, "Por favor seleccione al menos un servicio");
                else errorProvider_Servicios.Clear();

                if (numericUpDown_precioKG.Value <= 0)
                    errorProvider_precioKg.SetError(numericUpDown_precioKG, "Seleccione un número mayor que cero");
                else
                    errorProvider_precioKg.Clear();

                if (numericUpDown_precioPasaje.Value <= 0)
                    errorProvider_precioPasaje.SetError(numericUpDown_precioPasaje, "Seleccione un número mayor que cero");
                else
                    errorProvider_precioPasaje.Clear();
            }



        }


    }
}
