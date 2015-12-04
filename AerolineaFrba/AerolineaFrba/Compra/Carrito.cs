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

namespace AerolineaFrba.Compra
{
    public partial class Carrito : Form
    {
        int id;
        public static int kgs_disponibles;
        public static Collection<Cliente> ListaClientes = new Collection<Cliente>();
        public static Collection<int> ListaButacas = new Collection<int>();
        LlenadorDeTablas lloni = new LlenadorDeTablas();

        public Carrito(int id_viaje, int kgs)
        {
            InitializeComponent();
            id = id_viaje;
            llenarCollectionAux();
            kgs_disponibles = kgs;
            dateTimePicker_nacimiento.Format = DateTimePickerFormat.Custom;
            dateTimePicker_nacimiento.CustomFormat = "dd/MM/yyyy";
            dateTimePicker_vencimiento.Format = DateTimePickerFormat.Custom;
            dateTimePicker_vencimiento.CustomFormat = "MMyy";
            groupBox_tarjeta.Enabled = false;
            checkeoUsuario();           
            

        }

        public void llenarCollectionAux() 
        {
            ListBox aux = new ListBox();
            String tablas = "AERONAVE A, THE_CVENGERS.VIAJE V, THE_CVENGERS.BUTACA B";
            String condicion = "V.VIAJE_ID = " + id.ToString() + " AND A.AERONAVE_ID = V.VIAJE_AERONAVE AND B.BUTACA_AERONAVE = A.AERONAVE_ID";
            lloni.llenarListBoxConCondicion(ref aux, tablas, "BUTACA_NRO", condicion);
            foreach (object value in aux.Items)
                ListaButacas.Add(Int32.Parse(value.ToString()));
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
            AgregarPasajeEncomienda ventana = new AgregarPasajeEncomienda(id,TipoCompra.Encomienda);
            ventana.Show();
        }

        private void button_aPasaje_Click(object sender, EventArgs e)
        {
            if (ListaButacas.Count == 0)
            {
                MessageBox.Show("El viaje no tiene más butacas disponibles", "Error: butacas insuficientes", MessageBoxButtons.OK);
                return;
            } 
            AgregarPasajeEncomienda ventana = new AgregarPasajeEncomienda(id, TipoCompra.Pasaje);
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

            labelMonto.Text = calcularPrecioTotal().ToString();
            if (calcularPrecioTotal() != 0) button_confirmarItems.Enabled = true;
            else button_confirmarItems.Enabled=false;
        }

        private void button_eliminarItem_Click(object sender, EventArgs e)
        {
            Cliente aux = (Cliente)listBox1.SelectedItem;
            ListaClientes.Remove(aux);
            aux.getItem().actualizarValoresCancelados();
            listBox1.Items.Remove(aux);
            labelMonto.Text = calcularPrecioTotal().ToString("0.00");
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
            if(listBox1.SelectedItem != null )
            button_eliminarItem.Enabled = true;
            
            else
                button_eliminarItem.Enabled = false;
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
                    textBox2.Text = reader["CLIENTE_MAIL"].ToString();
                    dateTimePicker_nacimiento.Text = DateTime.Parse(reader["CLIENTE_FECHA_NAC"].ToString()).Date.ToString("dd-MMM-yyyy");
                    textBox1.Text = reader["CLIENTE_DIR"].ToString();
                    numericUpDown_telefono.Text = reader["CLIENTE_TELEFONO"].ToString();
                }
                reader.Close();

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

        
    }
}
