using AerolineaFrba.Objetos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba.MyNumericUpDown;
using System.Data.SqlClient;
using AerolineaFrba.Llenador;
using AerolineaFrba.HoraDB;

namespace AerolineaFrba.Compra
{
    public partial class Carrito : Form
    {
        int idViaje;
        int id_cliente;
        public static int kgs_disponibles;
        public static Collection<Cliente> ListaClientes = new Collection<Cliente>();
        public static Collection<int> ListaButacas = new Collection<int>();
        LlenadorDeTablas lloni = new LlenadorDeTablas();
        bool estaTodoAutocompletado = false;

        public Carrito(int id_viaje, int kgs)
        {
            InitializeComponent();
            idViaje = id_viaje;
            llenarCollectionAux();
            kgs_disponibles = kgs;
            dateTimePicker_nacimiento.Format = DateTimePickerFormat.Custom;
            dateTimePicker_nacimiento.CustomFormat = "dd/MM/yyyy";
            dateTimePicker_vencimiento.Format = DateTimePickerFormat.Custom;
            dateTimePicker_vencimiento.CustomFormat = "MM/yy";
            dateTimePicker_nacimiento.MaxDate = DateTimeHandler.devolverFechaDB();
            groupBox_tarjeta.Enabled = false;
            checkeoUsuario();
            seteoDateTime(ref dateTimePicker_vencimiento);
            llenarComboBoxTarjetas(ref comboBox_tipoTarjeta);


        }

        public void llenarCollectionAux()
        {
            ListBox aux = new ListBox();
            String tablas = "AERONAVE A, THE_CVENGERS.VIAJE V, THE_CVENGERS.BUTACA B";
            String condicion = "V.VIAJE_ID = " + idViaje.ToString() + " AND A.AERONAVE_ID = V.VIAJE_AERONAVE AND B.BUTACA_AERONAVE = A.AERONAVE_ID";
            lloni.llenarListBoxConCondicion(ref aux, tablas, "BUTACA_NRO", condicion);
            foreach (object value in aux.Items)
                ListaButacas.Add(Int32.Parse(value.ToString()));
        }

        public void llenarComboBoxTarjetas(ref ComboBox miCombo)
        {
            lloni.llenarComboBox(ref miCombo,"TIPO_TARJETA","TIPO_TARJETA_DETALLE");
        }

        public void llenarComboBoxCuotas(ref ComboBox miCombo,string nombreTarjeta)
        {
            string tablas  = "CUOTASXTARJETA T, THE_CVENGERS.TIPO_TARJETA O ";
            string condicion = "O.TIPO_TARJETA_DETALLE = '" + nombreTarjeta + "' AND O.TIPO_TARJETA_ID = T.CUOTASXTARJETA_TIPO";
            lloni.llenarComboBoxConCondicion(ref miCombo,tablas,"CUOTASXTARJETA_CUOTAS",condicion);
        }

        public void seteoDateTime(ref DateTimePicker date)
        {
            dateTimePicker_vencimiento.MinDate = DateTimeHandler.devolverFechaDB();
        }


        public void checkeoUsuario()
        {

            radioButton_tarjeta.Checked = true;
            radioButton_efectivo.Enabled = false;

        }
        private void button_aEncomienda_Click(object sender, EventArgs e)
        {
            if (kgs_disponibles == 0)
            {
                MessageBox.Show("El viaje no tiene más KG disponibles", "Error: KG insuficientes", MessageBoxButtons.OK);
                return;
            }
            AgregarPasajeEncomienda ventana = new AgregarPasajeEncomienda(idViaje, TipoCompra.Encomienda);
            ventana.Show();
        }

        private void button_aPasaje_Click(object sender, EventArgs e)
        {
            if (ListaButacas.Count == 0)
            {
                MessageBox.Show("El viaje no tiene más butacas disponibles", "Error: butacas insuficientes", MessageBoxButtons.OK);
                return;
            }
            AgregarPasajeEncomienda ventana = new AgregarPasajeEncomienda(idViaje, TipoCompra.Pasaje);
            ventana.Show();
        }

        public static void agregarCliente(Cliente cliente)
        {
            ListaClientes.Add(cliente);
        }

        public float calcularPrecioTotal()
        {
            float retu = 0f;
            foreach (Cliente cli in ListaClientes)
            {
                retu += cli.getItem().calcularPrecio();
            }
            return retu;
        }

        private void Carrito_Activated(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Cliente cli in ListaClientes)
            {
                listBox1.Items.Add(cli);
            }

            labelMonto.Text = calcularPrecioTotal().ToString("00.00");
            if (calcularPrecioTotal() != 0) button_confirmarItems.Enabled = true;
            else button_confirmarItems.Enabled = false;
        }

        private void button_eliminarItem_Click(object sender, EventArgs e)
        {
            Cliente aux = (Cliente)listBox1.SelectedItem;
            ListaClientes.Remove(aux);
            aux.getItem().actualizarValoresCancelados();
            listBox1.Items.Remove(aux);
            labelMonto.Text = calcularPrecioTotal().ToString("00.00");
        }


        private void button_confirmarItems_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de continuar?", "Confirmar Ítems", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                groupBox_tarjeta.Enabled = true;
                groupBox1.Enabled = false;
            }
            else { return; }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
                button_eliminarItem.Enabled = true;

            else
                button_eliminarItem.Enabled = false;
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
                            id_cliente = Int32.Parse(readerAux["CLIENTE_ID"].ToString());
                            estaTodoAutocompletado = true;
                            textBox_apellido.Text = readerAux["CLIENTE_APELLIDO"].ToString();
                            textBox_nombre.Text = readerAux["CLIENTE_NOMBRE"].ToString();
                            textBox2.Text = readerAux["CLIENTE_MAIL"].ToString();
                            dateTimePicker_nacimiento.Text = DateTime.Parse(readerAux["CLIENTE_FECHA_NAC"].ToString()).Date.ToString("dd-MMM-yyyy");
                            textBox1.Text = readerAux["CLIENTE_DIR"].ToString();
                            numericUpDown_telefono.Text = readerAux["CLIENTE_TELEFONO"].ToString();

                        }
                        readerAux.Close();
                        return;
                    case 2:
                        reader.Close();

                        errorProvider_dniDup.SetError(numericUpDown_dni, "No se puede identificar univocamente a un cliente con ese DNI. Ingrese un Apellido");

                        if (textBox_apellido.Text.Length > 0)
                        {
                            SqlCommand sqlCmd = new SqlCommand("select * from THE_CVENGERS.CLIENTE where CLIENTE_DNI = " + numericUpDown_dni.Text + " AND CLIENTE_APELLIDO COLLATE Latin1_General_CI_AI like '" + textBox_apellido.Text + "' COLLATE Latin1_General_CI_AI", Conexion.getConexion());
                            SqlDataReader leedor = sqlCmd.ExecuteReader();


                            leedor.Read();
                            if (leedor.HasRows)
                            {
                                id_cliente = Int32.Parse(leedor["CLIENTE_ID"].ToString());
                                estaTodoAutocompletado = true;
                                errorProvider_dniDup.Clear();
                                textBox_nombre.Text = leedor["CLIENTE_NOMBRE"].ToString();
                                textBox2.Text = leedor["CLIENTE_MAIL"].ToString();
                                dateTimePicker_nacimiento.Text = DateTime.Parse(leedor["CLIENTE_FECHA_NAC"].ToString()).Date.ToString("dd-MMM-yyyy");
                                textBox1.Text = leedor["CLIENTE_DIR"].ToString();
                                numericUpDown_telefono.Text = leedor["CLIENTE_TELEFONO"].ToString();


                            }
                            leedor.Close();
                            return;
                        }
                        return;
                }
            }
        }

        private void radioButton_tarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_tarjeta.Checked)
            {
                dateTimePicker_vencimiento.Enabled = true;
                comboBox_tipoTarjeta.Enabled = true;
                numericUpDown_codigoTarjeta.Enabled = true;
                numericUpDown_numeroTarjeta.Enabled = true;
            }
            if (radioButton_efectivo.Checked)
            {
                dateTimePicker_vencimiento.Enabled = false;
                comboBox_tipoTarjeta.Enabled = false;
                numericUpDown_codigoTarjeta.Enabled = false;
                numericUpDown_numeroTarjeta.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox_tarjeta.Enabled = false;
        }

        private void Carrito_FormClosing(object sender, FormClosingEventArgs e)
        {
            ListaClientes.Clear();
            ListaButacas.Clear();


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
            if (textBox1.Text == "")
            {
                errorProvider_direccion.SetError(textBox1, "Por favor ingrese una Dirección");
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

            if (radioButton_tarjeta.Checked)
            {
                if (comboBox_tipoTarjeta.SelectedItem == null)
                {
                    errorProvider_tipoTarjeta.SetError(comboBox_tipoTarjeta, "Por favor seleccione una Tarjeta");
                    flag += 1;
                }
                else
                    errorProvider_tipoTarjeta.Clear();
                if (comboBox1.SelectedItem == null)
                {
                    errorProvider_cuotas.SetError(comboBox1, "Por favor seleccione la cantidad de cuotas deseada");
                    flag += 1;
                }
                else
                    errorProvider_cuotas.Clear();
                if (numericUpDown_numeroTarjeta.Value.ToString().Length < 16)
                {
                    errorProvider_numero.SetError(numericUpDown_numeroTarjeta, "Cantidad de dígitos Incorrecta. Asegurese que el mismo sea de 16 dígitos");
                    flag += 1;
                }
                else
                    errorProvider_numero.Clear();
                if (numericUpDown_codigoTarjeta.Value.ToString().Length < 3)
                {
                    errorProvider_codigoSeg.SetError(numericUpDown_codigoTarjeta, "Cantidad de dígitos Incorrecta. Aseguree que el mismo sea de 3 dígitos");
                    flag += 1;
                }
                else
                    errorProvider_codigoSeg.Clear();
            }

            return flag;

        }

        private void button_limpiarComprador_Click(object sender, EventArgs e)
        {
            estaTodoAutocompletado = false;
            numericUpDown_dni.Value = 0;
            textBox_nombre.Text = "";
            textBox_apellido.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            numericUpDown_telefono.Value = 0;
            dateTimePicker_nacimiento.Value = dateTimePicker_nacimiento.MaxDate;
            errorProvider_dniDup.Clear();
        }

        private void button_terminarCompra_Click(object sender, EventArgs e)
        {
            if (aplicarValidaciones() > 0)
                return;

           new Cliente(id_cliente,(int)numericUpDown_dni.Value, textBox_nombre.Text, textBox_apellido.Text, textBox1.Text, (int)numericUpDown_telefono.Value, textBox2.Text, dateTimePicker_nacimiento.Value.Date.ToString()).persistirme();

           persistirTarjetaCredito();

           if (radioButton_tarjeta.Checked)
               persistirCompraTarjeta();
           else
               persistirCompraEfectivo();

        }

        public void persistirCompraTarjeta()
        {
            string query = "EXEC THE_CVENGERS.crearCompraConTarjeta @user = '" + +
                "',@cli = '" + id_cliente.ToString() +
                "',@tipoTar = '" + comboBox_tipoTarjeta.SelectedItem.ToString() +
                "',@nro = '" + numericUpDown_numeroTarjeta.Value.ToString() +
                "',@cod = '" + numericUpDown_codigoTarjeta.Value.ToString() +
                "',@fechaVen = '" + dateTimePicker_vencimiento.Value.Date.ToString() +
                "',@monto = '" + labelMonto.Text + 
                "',@cuotas = '" + comboBox1.SelectedItem.ToString() + "'";

            SqlCommand sqlCmd = new SqlCommand(query, Conexion.getConexion());
            MessageBox.Show(sqlCmd.CommandText);
            
            sqlCmd.ExecuteNonQuery();

        }

        public void persistirCompraEfectivo()
        {
            string query = "";
            SqlCommand sqlCmd = new SqlCommand(query, Conexion.getConexion());
            MessageBox.Show(sqlCmd.CommandText);

            sqlCmd.ExecuteNonQuery();
        }

        private void comboBox_tipoTarjeta_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            llenarComboBoxCuotas(ref comboBox1, comboBox_tipoTarjeta.SelectedItem.ToString());
            comboBox1.Enabled = true;
        }

        public void persistirTarjetaCredito()
        {
            string query = "EXEC THE_CVENGERS.ingresarTarjeta @cli = '" + id_cliente.ToString() + 
                "' ,@tipoTar = '" + comboBox_tipoTarjeta.SelectedItem.ToString() +
                "' ,@nro = '" + numericUpDown_numeroTarjeta.Value.ToString() +
                "' ,@cod = '" + numericUpDown_codigoTarjeta.Value.ToString() +
                "' ,@fechaVen = '" + dateTimePicker_vencimiento.Value.Date.ToString() + "'";

            SqlCommand sqlCmd = new SqlCommand(query,Conexion.getConexion());

            MessageBox.Show(sqlCmd.CommandText);

            try
            {
                sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);    
            }
        }
        
    }
}
