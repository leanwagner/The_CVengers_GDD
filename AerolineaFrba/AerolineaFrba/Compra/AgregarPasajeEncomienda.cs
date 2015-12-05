using AerolineaFrba.HoraDB;
using AerolineaFrba.Llenador;
using AerolineaFrba.Objetos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        bool estaTodoAutocompletado = false;
        int cli_id;

        public AgregarPasajeEncomienda(int id_viaje, TipoCompra tipo)
        {
            tipoActual = tipo;
            viajeId = id_viaje;
            InitializeComponent();
            dateTimePicker_nacimiento.Format = DateTimePickerFormat.Custom;
            dateTimePicker_nacimiento.CustomFormat = "dd/MM/yyyy";
            dateTimePicker_nacimiento.MaxDate = DateTimeHandler.devolverFechaDB();
            numericUpDown_kilos.Maximum = Carrito.kgs_disponibles;
            if (tipo == TipoCompra.Pasaje) { groupBox3.Visible = false; }
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
            Collection<int> listina = new Collection<int>();
            llenador.llenarListaConCondicion(ref listina, tablas, "BUTACA_NRO", condicion);

            List<int> both = Carrito.ListaButacas.Intersect(listina).ToList<int>();
            both.Sort();
            llenador.llenarComboBoxDeUnaCollection(ref both, ref miCombo);
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

            if (aplicarValidaciones() > 0)
                return;

            switch (tipoActual)
            {

                case TipoCompra.Pasaje:

                    Pasaje pasaje = new Pasaje(Int32.Parse(comboBox_butacasDisponibles.SelectedItem.ToString()), this.viajeId);
                    cliente = new Cliente(cli_id,(Int32)numericUpDown_dni.Value, textBox_nombre.Text, textBox_apellido.Text, textBox_direccion.Text, (Int32)numericUpDown_telefono.Value
                    , textBox_mail.Text, dateTimePicker_nacimiento.Value.Date.ToString(), pasaje);
                    Carrito.agregarCliente(cliente);
                    Carrito.ListaButacas.Remove(Int32.Parse(comboBox_butacasDisponibles.SelectedItem.ToString()));
                    cliente.persistirme();
                    break;

                case TipoCompra.Encomienda:
                    Encomienda encomienda = new Encomienda((Int32)numericUpDown_kilos.Value, this.viajeId);

                    cliente = new Cliente(cli_id, (Int32)numericUpDown_dni.Value, textBox_nombre.Text, textBox_apellido.Text, textBox_direccion.Text, (Int32)numericUpDown_telefono.Value
                    , textBox_mail.Text, dateTimePicker_nacimiento.Value.Date.ToString(), encomienda);
                    Carrito.agregarCliente(cliente);
                    Carrito.kgs_disponibles = Carrito.kgs_disponibles - (Int32)numericUpDown_kilos.Value;
                    cliente.persistirme();
                    break;

            }

            this.Close();
        }

        private void numericUpDown_dni_KeyUp(object sender, KeyEventArgs e)
        {
            List<String> apellidos = new List<string>();
            if (numericUpDown_dni.Text.Length > 5 && !estaTodoAutocompletado)
            {
                SqlCommand cmd = new SqlCommand("select * from THE_CVENGERS.CLIENTE where CLIENTE_DNI = " + numericUpDown_dni.Text, Conexion.getConexion());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.HasRows)
                        apellidos.Add(reader["CLIENTE_APELLIDO"].ToString());
                }

                switch (apellidos.Count)
                {
                    case 0:
                        reader.Close();
                        return;

                    case 1:
                        reader.Close();
                        SqlDataReader readerAux = cmd.ExecuteReader();
                        readerAux.Read();
                        if (readerAux.HasRows)
                        {
                            cli_id = Int32.Parse(readerAux["CLIENTE_ID"].ToString());
                            estaTodoAutocompletado = true;
                            textBox_apellido.Text = readerAux["CLIENTE_APELLIDO"].ToString();
                            textBox_nombre.Text = readerAux["CLIENTE_NOMBRE"].ToString();
                            textBox_mail.Text = readerAux["CLIENTE_MAIL"].ToString();
                            dateTimePicker_nacimiento.Text = DateTime.Parse(readerAux["CLIENTE_FECHA_NAC"].ToString()).Date.ToString("dd-MMM-yyyy");
                            textBox_direccion.Text = readerAux["CLIENTE_DIR"].ToString();
                            numericUpDown_telefono.Text = readerAux["CLIENTE_TELEFONO"].ToString();

                        }
                        readerAux.Close();
                        return;
                    case 2:
                    default:
                        reader.Close();

                        errorProvider_dniDup.SetError(numericUpDown_dni,"No se puede identificar univocamente a un cliente con ese DNI. Ingrese un Apellido");

                        if (textBox_apellido.Text.Length > 0)
                        {
                            SqlCommand sqlCmd = new SqlCommand("select * from THE_CVENGERS.CLIENTE where CLIENTE_DNI = " + numericUpDown_dni.Text + " AND CLIENTE_APELLIDO COLLATE Latin1_General_CI_AI like '" + textBox_apellido.Text + "' COLLATE Latin1_General_CI_AI", Conexion.getConexion());
                            SqlDataReader leedor = sqlCmd.ExecuteReader();
                            

                            leedor.Read();
                            if (leedor.HasRows)
                            {
                                cli_id = Int32.Parse(leedor["CLIENTE_ID"].ToString());
                                estaTodoAutocompletado = true;
                                errorProvider_dniDup.Clear();
                                textBox_nombre.Text = leedor["CLIENTE_NOMBRE"].ToString();
                                textBox_mail.Text = leedor["CLIENTE_MAIL"].ToString();
                                dateTimePicker_nacimiento.Text = DateTime.Parse(leedor["CLIENTE_FECHA_NAC"].ToString()).Date.ToString("dd-MMM-yyyy");
                                textBox_direccion.Text = leedor["CLIENTE_DIR"].ToString();
                                numericUpDown_telefono.Text = leedor["CLIENTE_TELEFONO"].ToString();
                                

                            }
                            leedor.Close();
                            return;
                        }
                        return;
                }
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

        public int aplicarValidaciones()
        {
            int flag = 0;

            if (textBox_nombre.Text == "")
            {
                errorProvider_nombre.SetError(textBox_nombre, "Por favor ingrese un Nombre");
                flag += 1;
            }
            else
                errorProvider_nombre.Clear();
            if (textBox_apellido.Text == "")
            {
                errorProvider_apellido.SetError(textBox_apellido, "Por favor ingrese un Apellido");
                flag += 1;
            }
            else
                errorProvider_apellido.Clear();
            if (textBox_direccion.Text == "")
            {
                errorProvider_direccion.SetError(textBox_direccion, "Por favor ingrese una Dirección");
                flag += 1;
            }
            else
                errorProvider_direccion.Clear();
            if (numericUpDown_dni.Value.ToString().Count() < 5)
            {
                errorProvider_dni.SetError(numericUpDown_dni, "Por favor ingrese un DNI válido ");
                flag += 1;
            }
            else
                errorProvider_dni.Clear();

            return flag;
        }

        private void button_limpiar_Click(object sender, EventArgs e)
        {
            cli_id = 0;
            estaTodoAutocompletado = false;
            numericUpDown_dni.Value = 0;
            textBox_nombre.Text = "";
            textBox_apellido.Text = "";
            textBox_direccion.Text = "";
            textBox_mail.Text = "";
            numericUpDown_telefono.Value = 0;
            dateTimePicker_nacimiento.Value = dateTimePicker_nacimiento.MaxDate;
            errorProvider_dniDup.Clear();
        }



    }
}
