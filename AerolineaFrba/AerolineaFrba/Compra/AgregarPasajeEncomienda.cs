using AerolineaFrba.Llenador;
using AerolineaFrba.Objetos;
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
        TipoCompra tipoActual;

        public AgregarPasajeEncomienda(int id_viaje,TipoCompra tipo)
        {
            tipoActual = tipo;
            viajeId = id_viaje;
            InitializeComponent();
            dateTimePicker_nacimiento.Format = DateTimePickerFormat.Custom;
            dateTimePicker_nacimiento.CustomFormat = "dd/MM/yyyy";
            numericUpDown_kilos.Maximum = Carrito.kgs_disponibles;
            if (tipo == TipoCompra.Pasaje) { groupBox3.Visible = false;}
            else { groupBox1.Visible = false; this.Text = "Agregar Encomienda"; button_agregarItem.Text = "Agregar Encomienda"; }
            llenarComboBoxPisoAeronave(ref comboBox_piso);
            groupBox2.Enabled = false;
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
            foreach (object obj in miCombo.Items) // NO SE PUEDE SACAR COSAS DE ALGO QUE ESTAS RECORRIENDO
            {
                if (!Carrito.ListaButacas.Contains(Int32.Parse(obj.ToString()))) // ARREGLAR
                    miCombo.Items.Remove(obj);
            }
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

        private void button_agregarItem_Click(object sender, EventArgs e)
        {
            Cliente cliente;
            switch (tipoActual)
            {
                
                case TipoCompra.Pasaje: 
                    
                    Pasaje pasaje = new Pasaje(Int32.Parse(comboBox_butacasDisponibles.SelectedItem.ToString()),this.viajeId);
                    cliente = new Cliente((Int32)numericUpDown_dni.Value,textBox_nombre.Text,textBox_apellido.Text,textBox_direccion.Text,(Int32)numericUpDown_telefono.Value
                    ,textBox_mail.Text,dateTimePicker_nacimiento.Value.ToString(),pasaje);
                    Carrito.agregarCliente(cliente);
                    Carrito.ListaButacas.Remove(Int32.Parse(comboBox_butacasDisponibles.SelectedItem.ToString()));
                    break;

                case TipoCompra.Encomienda:
                    Encomienda encomienda = new Encomienda((Int32)numericUpDown_kilos.Value,this.viajeId);

                    cliente = new Cliente((Int32)numericUpDown_dni.Value,textBox_nombre.Text,textBox_apellido.Text,textBox_direccion.Text,(Int32)numericUpDown_telefono.Value
                    ,textBox_mail.Text,dateTimePicker_nacimiento.Value.ToString(),encomienda);
                    Carrito.agregarCliente(cliente);
                    Carrito.kgs_disponibles = Carrito.kgs_disponibles - (Int32)numericUpDown_kilos.Value;
                    break;

              
                    
            }

            this.Close();
        }

        private void numericUpDown_dni_KeyUp(object sender, KeyEventArgs e)
        {
            if (numericUpDown_dni.Text.Length > 1)
            {
                SqlCommand cmd = new SqlCommand("select * from THE_CVENGERS.CLIENTE where CLIENTE_DNI = " + numericUpDown_dni.Text, Conexion.getConexion());
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    textBox_apellido.Text = reader["CLIENTE_APELLIDO"].ToString();
                    textBox_nombre.Text = reader["CLIENTE_NOMBRE"].ToString();
                    textBox_mail.Text = reader["CLIENTE_MAIL"].ToString();
                    dateTimePicker_nacimiento.Text = DateTime.Parse(reader["CLIENTE_FECHA_NAC"].ToString()).Date.ToString("dd-MMM-yyyy");
                    textBox_direccion.Text = reader["CLIENTE_DIR"].ToString();
                    numericUpDown_telefono.Text = reader["CLIENTE_TELEFONO"].ToString();
                }
                reader.Close();

            }
        }

        private void comboBox_butacasDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
        }

        private void numericUpDown_kilos_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown_kilos.Value > 0)
                groupBox2.Enabled = true;
            else
                groupBox2.Enabled = false;
        }


        
    }
}
