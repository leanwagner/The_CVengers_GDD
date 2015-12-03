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

namespace AerolineaFrba.Compra
{
    public partial class Compra : Form
    {
        LlenadorDeTablas llenador = new LlenadorDeTablas();
        object elementoQuitadoTablaDestino;
        object elementoQuitadoTablaOrigen;

        public Compra()
        {
            InitializeComponent();
            llenarCombosCiudad(ref comboBox_destino);
            llenarCombosCiudad(ref comboBox_origen);
        }

        private void llenarCombosCiudad(ref ComboBox mi_combo)
        {
            llenador.llenarComboBox(ref mi_combo, "CIUDAD", "CIUDAD_NOMBRE");
        }

        private void comboBox_origen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (elementoQuitadoTablaDestino != null)
                comboBox_destino.Items.Add(elementoQuitadoTablaDestino);

            int indiceElegido = comboBox_destino.Items.IndexOf(comboBox_origen.SelectedItem);
            elementoQuitadoTablaDestino = comboBox_origen.SelectedItem;

            comboBox_destino.Items.RemoveAt(indiceElegido);

            comboBox_destino.Refresh();


        }

        private void comboBox_destino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (elementoQuitadoTablaOrigen != null)
                comboBox_origen.Items.Add(elementoQuitadoTablaOrigen);

            int indiceElegido = comboBox_origen.Items.IndexOf(comboBox_destino.SelectedItem);
            elementoQuitadoTablaOrigen = comboBox_destino.SelectedItem;

            comboBox_origen.Items.RemoveAt(indiceElegido);

            comboBox_origen.Refresh();

            
        }
    }
}
