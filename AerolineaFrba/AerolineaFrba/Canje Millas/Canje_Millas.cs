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

namespace AerolineaFrba.Canje_Millas
{
    public partial class Canje_Millas : Form
    {
        
           Llenador.LlenadorDeTablas lleni = new Llenador.LlenadorDeTablas();
           SqlDataReader reader;
        public Canje_Millas()
        {
            InitializeComponent();
        }
        //23718649
        private void dniBox_TextChanged(object sender, EventArgs e)
        {
            if (dniBox.Text.Length == 0)
                return;
            nombreCombo.Items.Clear();
            lleni.llenarComboBoxConCondicion(ref nombreCombo,"CLIENTE","CLIENTE_NOMBRE","CLIENTE_DNI = " + dniBox.Text);
            if (nombreCombo.Items.Count > 1)
            {
                label4.Visible = true;
                nombreCombo.Visible = true;
                errorDniDup.SetError(nombreCombo,"Ese DNI esta duplicado, debe seleccionar un cliente para continuar");
            }
            else
            {
                label4.Visible = false;
                nombreCombo.Visible = false;
            }

            if (nombreCombo.Items.Count == 1)
            {
                SqlCommand cmd = new SqlCommand("select * from THE_CVENGERS.CLIENTE where CLIENTE_DNI = " + dniBox.Text, Conexion.getConexion());
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                label8.Visible = true;
                label8.Text = reader["CLIENTE_APELLIDO"].ToString() + ", " + reader["CLIENTE_NOMBRE"].ToString();
                label9.Visible = true;
                label9.Text = reader["CLIENTE_MAIL"].ToString();
                label10.Visible = true;
                label10.Text = DateTime.Parse(reader["CLIENTE_FECHA_NAC"].ToString()).Date.ToString("dd-MMM-yyyy");
                reader.Close();
            }
            else 
            {
                label8.Visible = false;

                label9.Visible = false;

                label10.Visible = false;
            }


        }

        private void Canje_Millas_Load(object sender, EventArgs e)
        {
            label8.Visible = false;

            label9.Visible = false;

            label10.Visible = false;
            lleni.llenarComboBoxPremios(ref premioCombo);
            canjBoton.Enabled = false;
        }

        private void nombreCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorDniDup.Clear();
            SqlCommand cmd = new SqlCommand("select * from THE_CVENGERS.CLIENTE where CLIENTE_DNI = " + dniBox.Text+ "and CLIENTE_NOMBRE ='"+nombreCombo.SelectedItem.ToString()+"'", Conexion.getConexion());
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            label8.Visible = true;
            label8.Text = reader["CLIENTE_APELLIDO"].ToString() + ", " + reader["CLIENTE_NOMBRE"].ToString();
            label9.Visible = true;
            label9.Text = reader["CLIENTE_MAIL"].ToString();
            label10.Visible = true;
            label10.Text = DateTime.Parse(reader["CLIENTE_FECHA_NAC"].ToString()).Date.ToString("dd-MMM-yyyy");
            reader.Close();
        }

        private void premioCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (premioCombo.SelectedIndex != -1 && canUpDown.Value != 0)
                canjBoton.Enabled = true;
            else
                canjBoton.Enabled = false;
            SqlCommand cmd = new SqlCommand("select * from THE_CVENGERS.PRODUCTO where '" + premioCombo.SelectedItem.ToString() + "' like '%' + PRODUCTO_NOMBRE + '%'", Conexion.getConexion());
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            canUpDown.Value = 0;
            canUpDown.Maximum = decimal.Parse(rd["PRODUCTO_STOCK"].ToString());
            if (canUpDown.Maximum == 0)
                errorNoStock.SetError(canUpDown, "No hay stock de ese producto");
            else errorNoStock.Clear();
            rd.Close();
        }

        private void canUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (premioCombo.SelectedIndex != -1 && canUpDown.Value != 0)
                canjBoton.Enabled = true;
            else
                canjBoton.Enabled = false;
        }
    }
}
