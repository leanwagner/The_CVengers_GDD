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
        String viajeId;

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
            dateTimePicker1.CustomFormat = " ";
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


                SqlDataReader reader = sqlCmd.ExecuteReader();

                reader.Read();

                viajeId = reader["resultado"].ToString();

                reader.Close();

                sqlCmd = new SqlCommand("SELECT A.AERONAVE_MATRICULA_AVION, A.AERONAVE_MODELO_AVION, S.SERVICIO_NOMBRE, V.VIAJE_FECHA_SALIDA, V.VIAJE_FECHA_LLEGADA_ESTIMADA FROM THE_CVENGERS.AERONAVE A, THE_CVENGERS.VIAJE V, THE_CVENGERS.SERVICIO S WHERE A.AERONAVE_MATRICULA_AVION = '" +  
                comboBox_matricula.SelectedItem.ToString() + "' AND V.VIAJE_ID = " + viajeId + " AND A.AERONAVE_SERVICIO = S.SERVICIO_ID" ,Conexion.getConexion());

                reader = sqlCmd.ExecuteReader();

                reader.Read();

                label_MatriculaAeronave.Text = reader["AERONAVE_MATRICULA_AVION"].ToString();

                label_ModeloAeronave.Text = reader["AERONAVE_MODELO_AVION"].ToString();

                label_TipoServicio.Text = reader["SERVICIO_NOMBRE"].ToString();

                label_SalidaAeronave.Text = reader["VIAJE_FECHA_SALIDA"].ToString();

                label_LlegadaEstimadaAeronave.Text = reader["VIAJE_FECHA_LLEGADA_ESTIMADA"].ToString();

                dateTimePicker1.MinDate = Convert.ToDateTime(reader["VIAJE_FECHA_SALIDA"].ToString());

                dateTimePicker1.MaxDate = dateTimePicker1.MinDate.AddDays(1);

                reader.Close();

                groupBox3.Enabled = true;
                dateTimePicker1.CustomFormat = "dd-MM-yyyy HH:mm:ss";

               

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
            groupBox3.Enabled = false;
            label_LlegadaEstimadaAeronave.Text = "**hh:mm dd/mm/yyyy**";
            label_MatriculaAeronave.Text = "**NRO**";
            label_ModeloAeronave.Text = "**Modelo**";
            label_SalidaAeronave.Text = "**hh:mm dd/mm/yyyy**";
            label_TipoServicio.Text = "**Servicio**";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("EXEC THE_CVENGERS.registrarLlegada @viaje ='" + viajeId +
                    "', @fecha ='" + dateTimePicker1.Value.ToString() + "'" , Conexion.getConexion());


                sqlCmd.ExecuteNonQuery();

                MessageBox.Show("El viaje fue registrado correctamente");

                limpiarCampos();

            }
            catch
            {
                MessageBox.Show("No se pudo registrar el viaje seleccionado.", "Error", MessageBoxButtons.OK);
            }
        }

    }
}
