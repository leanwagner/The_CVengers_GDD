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

namespace AerolineaFrba.Compra
{
    public partial class AgregarPasajeEncomienda : Form
    {
        LlenadorDeTablas llenador = new LlenadorDeTablas();
        int viajeId;

        public AgregarPasajeEncomienda(int id_viaje,TipoCompra tipo)
        {
            viajeId = id_viaje;
            InitializeComponent();
            dateTimePicker_nacimiento.Format = DateTimePickerFormat.Custom;
            dateTimePicker_nacimiento.CustomFormat = "dd/MM/yyyy";
            if (tipo == TipoCompra.Pasaje) { groupBox3.Visible = false;}
            else { groupBox1.Visible = false; this.Text = "Agregar Encomienda"; }
            llenarComboBoxPisoAeronave(ref comboBox_piso);
        }

        public void llenarComboBoxPisoAeronave(ref ComboBox miCombo)
        {
            int cantidadPisos, piso;
            piso = 1;

            SqlCommand sqlCmd = new SqlCommand("SELECT MAX(B.BUTACA_PISO) AS B FROM THE_CVENGERS.BUTACA B, THE_CVENGERS.AERONAVE A, THE_CVENGERS.VIAJE V WHERE V.VIAJE_ID =" + viajeId +
                "AND V.VIAJE_AERONAVE = A.AERONAVE_ID AND B.BUTACA_AERONAVE = A.AERONAVE_ID", Conexion.getConexion());

            SqlDataReader reader = sqlCmd.ExecuteReader();

            reader.Read();

            cantidadPisos = Int32.Parse(reader["B"].ToString());
            
            while (piso <= cantidadPisos)
            {
                miCombo.Items.Add(piso);
                piso++;
            }
            reader.Close();
        }

        public void llenarComboBoxTipoAsiento(ref ComboBox miCombo)
        {
            miCombo.Items.Add("Ventanilla");
            miCombo.Items.Add("Pasillo");
        }

        public void llenarComboBoxAsientosDisponibles(ref ComboBox miCombo)
        {
            String tablas = "AERONAVE A, THE_CVENGERS.VIAJE V, THE_CVENGERS.BUTACA B";
            String condicion = "V.VIAJE_ID = " + viajeId.ToString() + " AND A.AERONAVE_ID = V.VIAJE_AERONAVE AND B.BUTACA_AERONAVE = A.AERONAVE_ID AND B.BUTACA_PISO = " + comboBox_piso.SelectedItem.ToString() + " AND B.BUTACA_TIPO = '" + comboBox1.SelectedItem + "' ORDER BY B.BUTACA_NRO";
            llenador.llenarComboBoxConCondicion(ref miCombo, tablas, "BUTACA_NRO", condicion);
        }

        private void comboBox_piso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_piso.SelectedItem != null)
            {
                comboBox1.Items.Clear();
                comboBox1.Enabled = true;
                llenarComboBoxTipoAsiento(ref comboBox1);
      
            } 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                comboBox_butacasDisponibles.Items.Clear();
                comboBox_butacasDisponibles.Enabled = true;
                llenarComboBoxAsientosDisponibles(ref comboBox_butacasDisponibles);

                if (comboBox_butacasDisponibles.Items.Count == 0)
                    errorProvider_disponibles.SetError(comboBox_butacasDisponibles, "No hay butacas disponibles");
                else
                    errorProvider_disponibles.Clear();
            } 
        }


        
    }
}
