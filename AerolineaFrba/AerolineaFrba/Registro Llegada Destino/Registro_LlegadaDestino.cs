using AerolineaFrba.HoraDB;
using AerolineaFrba.Llenador;
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
            groupBox3.Enabled = false;


        }

        private void Registro_LlegadaDestino_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy HH:mm:ss";
            dateTimePicker1.Value = DateTimeHandler.devolverFechaDB();
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
            if (elementoQuitadoTablaOrigen != null)
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

        private void button_BuscarAeronave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SELECT THE_CVENGERS.viajeARegistrar ('" + comboBox_matricula.SelectedItem.ToString() +
                    "', '" + comboBox_AeropuertoSalida.SelectedItem.ToString().Substring(1) +
                "', '" + comboBox_AeropuertoLlegada.SelectedItem.ToString().Substring(1) + "') AS resultado ", Conexion.getConexion());

                MessageBox.Show("SELECT THE_CVENGERS.viajeARegistrar ('" + comboBox_matricula.SelectedItem.ToString() +
                    "', '" + comboBox_AeropuertoSalida.SelectedItem.ToString().Substring(1) +
                "', '" + comboBox_AeropuertoLlegada.SelectedItem.ToString().Substring(1) + "') AS resultado ");

                SqlDataReader reader = sqlCmd.ExecuteReader();

                reader.Read();

                String viajeId = reader["resultado"].ToString();

                reader.Close();

                MessageBox.Show(viajeId);

                sqlCmd = new SqlCommand("SELECT A.AERONAVE_MATRICULA_AVION, A.AERONAVE_MODELO_AVION, S.SERVICIO_NOMBRE, V.VIAJE_FECHA_SALIDA, V.VIAJE_FECHA_LLEGADA_ESTIMADA FROM AERONAVE A, VIAJE V, SERVICIO S WHERE A.AERONAVE_MATRICULA_AVION = '" +  
                comboBox_matricula.SelectedItem.ToString() + "' AND V.VIAJE_ID = " + viajeId + " AND A.AERONAVE_SERVICIO = S.SERVICIO_ID" ,Conexion.getConexion());

                MessageBox.Show("SELECT A.AERONAVE_MATRICULA_AVION, A.AERONAVE_MODELO_AVION, S.SERVICIO_NOMBRE, V.VIAJE_FECHA_SALIDA, V.VIAJE_FECHA_LLEGADA_ESTIMADA FROM AERONAVE A, VIAJE V, SERVICIO S WHERE A.AERONAVE_MATRICULA_AVION = '" +
                comboBox_matricula.SelectedItem.ToString() + "' AND V.VIAJE_ID = " + viajeId + " AND A.AERONAVE_SERVICIO = S.SERVICIO_ID");

                groupBox3.Enabled = true;

               

            }
            catch 
            {
                MessageBox.Show("No hay ningún viaje en proceso de esa Aeronave sobre esa ruta.", "Error", MessageBoxButtons.OK);
            }

        }

        public void limpiarCampos()
        {
            comboBox_AeropuertoLlegada.Items.Clear();
            llenarCombosCiudad(ref comboBox_AeropuertoLlegada);
            comboBox_AeropuertoSalida.Items.Clear();
            llenarCombosCiudad(ref comboBox_AeropuertoSalida);
            comboBox_matricula.Items.Clear();
            llenarComboMatricula(ref comboBox_matricula);
        }

    }
}
