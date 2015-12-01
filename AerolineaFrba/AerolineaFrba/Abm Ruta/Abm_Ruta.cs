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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

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
      

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

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
    }
}
