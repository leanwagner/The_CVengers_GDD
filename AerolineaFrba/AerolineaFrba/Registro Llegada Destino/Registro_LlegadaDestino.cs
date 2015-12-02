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

namespace AerolineaFrba.Registro_Llegada_Destino
{
    public partial class Registro_LlegadaDestino : Form
    {
        LlenadorDeTablas llenador = new LlenadorDeTablas();
        object elementoQuitadoTablaDestino;
        object elementoQuitadoTablaOrigen;

        public Registro_LlegadaDestino()
        {
            InitializeComponent();
            llenarCombosCiudad(ref comboBox_AeropuertoLlegada);
            llenarCombosCiudad(ref comboBox_AeropuertoSalida);
            llenarComboMatricula(ref comboBox_matricula);
            errorProvider_buscarAeronave.SetError(button_BuscarAeronave, "Para desbloquear el boton deben haberse llenado todos los campos");


        }

        private void Registro_LlegadaDestino_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy HH:mm:ss";
        }

        public void llenarCombosCiudad(ref ComboBox miCombo)
        {
            llenador.llenarComboBox(ref miCombo, "CIUDAD", "CIUDAD_NOMBRE");
        }

        public void llenarComboMatricula(ref ComboBox miCombo)
        {
            llenador.llenarComboBox(ref miCombo, "AERONAVE", "AERONAVE_MATRICULA_AVION");
        }

        private void comboBox_AeropuertoSalida_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (elementoQuitadoTablaDestino != null)
                comboBox_AeropuertoLlegada.Items.Add(elementoQuitadoTablaDestino);

            int indiceElegido = comboBox_AeropuertoLlegada.Items.IndexOf(comboBox_AeropuertoSalida.SelectedItem);
            elementoQuitadoTablaDestino = comboBox_AeropuertoSalida.SelectedItem;

            comboBox_AeropuertoLlegada.Items.RemoveAt(indiceElegido);

            comboBox_AeropuertoLlegada.Refresh();

            activarBotonBuscarAeronave();
        }

        private void comboBox_AeropuertoLlegada_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (elementoQuitadoTablaOrigen!= null)
                comboBox_AeropuertoSalida.Items.Add(elementoQuitadoTablaOrigen);

            int indiceElegido = comboBox_AeropuertoSalida.Items.IndexOf(comboBox_AeropuertoLlegada.SelectedItem);
            elementoQuitadoTablaOrigen = comboBox_AeropuertoLlegada.SelectedItem;
                
            comboBox_AeropuertoSalida.Items.RemoveAt(indiceElegido);

            comboBox_AeropuertoSalida.Refresh();

            activarBotonBuscarAeronave();
        }

        public void activarBotonBuscarAeronave()
        {
            if (comboBox_AeropuertoLlegada.SelectedItem != null && comboBox_AeropuertoSalida.SelectedItem != null && comboBox_matricula.SelectedItem != null)
            {
                errorProvider_buscarAeronave.Clear();
                button_BuscarAeronave.Enabled = true;
            }
                
        }

        private void comboBox_matricula_SelectedIndexChanged(object sender, EventArgs e)
        {
            activarBotonBuscarAeronave();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var fechaFormateada = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");
            fechaFormateada = fechaFormateada + ".000";
            


        }

    }
}
