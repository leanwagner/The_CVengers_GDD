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
    public partial class Abm_Ruta : Form
    {

        LlenadorDeTablas llenador = new LlenadorDeTablas();
        object elementoQuitadoTablaDestino;
        object elementoQuitadoTablaOrigen;

        public Abm_Ruta()
        {
            InitializeComponent();
            this.mostrarServicios();
            this.mostrarCiudad(ref comboBox_ciudadOrigen);
            this.mostrarCiudad(ref comboBox_ciudadDestino);
            comboBox_ciudadOrigen.Focus();
            this.mostrarRutas();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void boton_Modificar_Click(object sender, EventArgs e)
        {
            RutaModificar rutaAModificar = new RutaModificar();
            rutaAModificar.Show();
        }

        private void Abm_Ruta_Load(object sender, EventArgs e)
        {

        }

        public void mostrarServicios()
        {

            llenador.llenarCheckedListBox(ref checkedListBox_servicios,"SERVICIO","SERVICIO_NOMBRE");

        }

        public void mostrarCiudad(ref ComboBox miCombo)
        {
            llenador.llenarComboBox(ref miCombo, "CIUDAD", "CIUDAD_NOMBRE");

        }

        public void mostrarRutas()
        {
            llenador.llenarDataGridView(dataGridView_listadoRutas,"RUTA");
        }
      
        private void comboBox_ciudadOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if(elementoQuitadoTablaDestino != null)
            comboBox_ciudadDestino.Items.Add(elementoQuitadoTablaDestino);

            int indiceElegido = comboBox_ciudadDestino.Items.IndexOf(comboBox_ciudadOrigen.SelectedItem);
            elementoQuitadoTablaDestino = comboBox_ciudadOrigen.SelectedItem;

            comboBox_ciudadDestino.Items.RemoveAt(indiceElegido);

            comboBox_ciudadDestino.Refresh();
        }

        private void comboBox_ciudadDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (elementoQuitadoTablaOrigen!= null)
                comboBox_ciudadOrigen.Items.Add(elementoQuitadoTablaOrigen);

            int indiceElegido = comboBox_ciudadOrigen.Items.IndexOf(comboBox_ciudadDestino.SelectedItem);
            elementoQuitadoTablaOrigen = comboBox_ciudadDestino.SelectedItem;
                
            comboBox_ciudadOrigen.Items.RemoveAt(indiceElegido);

            comboBox_ciudadOrigen.Refresh();
        }

        private void button_agregarRuta_Click(object sender, EventArgs e)
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

            MessageBox.Show(servicio1);
            MessageBox.Show(servicio2);
            MessageBox.Show(servicio3);
            if (comboBox_ciudadOrigen.SelectedItem != null && comboBox_ciudadDestino.SelectedItem != null && numericUpDown1.Value > 0 && numericUpDown2.Value > 0)
            {
                try
                {
                    string comandin = "EXEC THE_CVENGERS.creacionRuta @P1 = " + numericUpDown3.Value +
                           ", @P2 = '" + (comboBox_ciudadOrigen.SelectedItem.ToString()).Substring(1) +
                           "', @P3 = '" + (comboBox_ciudadDestino.SelectedItem.ToString()).Substring(1) +
                           "', @P4 = " + numericUpDown1.Value +
                           ", @P5 = " + numericUpDown2.Value +
                           ", @P6 = '" + servicio1 +
                           "', @P7 = '" + servicio2 +
                           "', @P8 = '" + servicio3 + "'";
                    MessageBox.Show(comandin);




                    SqlCommand sqlCmd = new SqlCommand("EXEC THE_CVENGERS.creacionRuta @P1 = " + numericUpDown3.Value +
                        ", @P2 = " + comboBox_ciudadOrigen.SelectedItem.ToString() +
                        ", @P3 = " + comboBox_ciudadDestino.SelectedItem.ToString() +
                        ", @P4 = " + numericUpDown1.Value +
                        ", @P5 = " + numericUpDown2.Value +
                        ", @P6 = " + servicio1 +
                        ", @P7 = " + servicio2 +
                        ", @P8 = " + servicio3, Conexion.getConexion());

                    sqlCmd.ExecuteScalar();

                    dataGridView_listadoRutas.Refresh();
                    MessageBox.Show("ya inserte todo");

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
            }

            /*else
            {
                if(comboBox_ciudadOrigen.SelectedItem == null)
                    MessageBox.Show("Por favor seleccione una Ciudad de Origen", "Error: No Hay una Ciudad de Origen Seleccionada", MessageBoxButtons.OK);

                if (comboBox_ciudadDestino.SelectedItem == null)
                    MessageBox.Show("Por favor seleccione una Ciudad de Origen", "Error: No Hay una Ciudad de Origen Seleccionada", MessageBoxButtons.OK);
            }*/
        }
    }

}
