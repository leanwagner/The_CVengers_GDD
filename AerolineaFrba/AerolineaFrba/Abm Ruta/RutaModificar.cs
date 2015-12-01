using AerolineaFrba.Llenador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        


        public RutaModificar(int cod_ruta, string ciudad_origen, string ciudad_destino,decimal precio_KG, decimal precio_pasaje)
        {
            InitializeComponent();
            this.mostrarCiudad(ref comboBox_ciudadOrigen);
            this.mostrarCiudad(ref comboBox_ciudadDestino);
            this.mostrarServicios(); 
            //comboBox_ciudadDestino.SelectedItem="Chicago"; --- SETEOS PARA LEVANTAR
            numericUpDown_codRuta.Value = cod_ruta;
            numericUpDown_precioKG.Value = precio_KG;
            numericUpDown_precioPasaje.Value = precio_pasaje;
        }

        public void mostrarCiudad(ref ComboBox miCombo)
        {
            llenador.llenarComboBox(ref miCombo, "CIUDAD", "CIUDAD_NOMBRE");

        }

        public void mostrarServicios()
        {

            llenador.llenarCheckedListBox(ref checkedListBox_servicios, "SERVICIO", "SERVICIO_NOMBRE");

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

    }
}
