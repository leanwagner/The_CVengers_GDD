using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Canje_Millas
{
    public partial class Canje_Millas : Form
    {
        String idProd;
        String idClie;
        decimal valorPremioElegido;
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
            lleni.llenarComboBoxConCondicion(ref nombreCombo,"CLIENTE","CLIENTE_APELLIDO","CLIENTE_DNI = " + dniBox.Text);
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
                idClie = reader["CLIENTE_ID"].ToString();
                cmd.CommandText = "select THE_CVENGERS.consultarMillas(" + idClie + ") as m";
                reader.Close();
                reader = cmd.ExecuteReader();
                reader.Read();
                label12.Visible = true;
                label12.Text = reader["m"].ToString();
                reader.Close();
            }
            else 
            {
                label8.Visible = false;

                label9.Visible = false;

                label10.Visible = false;
                label12.Visible = false;
            }


        }

        private void Canje_Millas_Load(object sender, EventArgs e)
        {
            label8.Visible = false;

            label9.Visible = false;

            label10.Visible = false;
            label12.Visible = false;
            lleni.llenarComboBoxPremios(ref premioCombo);
            canjBoton.Enabled = false;
        }

        private void nombreCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorDniDup.Clear();
            SqlCommand cmd = new SqlCommand("select * from THE_CVENGERS.CLIENTE where CLIENTE_DNI = " + dniBox.Text+ "and CLIENTE_APELLIDO ='"+nombreCombo.SelectedItem.ToString()+"'", Conexion.getConexion());
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            label8.Visible = true;
            label8.Text = reader["CLIENTE_APELLIDO"].ToString() + ", " + reader["CLIENTE_NOMBRE"].ToString();
            label9.Visible = true;
            label9.Text = reader["CLIENTE_MAIL"].ToString();
            label10.Visible = true;
            label10.Text = DateTime.Parse(reader["CLIENTE_FECHA_NAC"].ToString()).Date.ToString("dd-MMM-yyyy");
            idClie = reader["CLIENTE_ID"].ToString();
            cmd.CommandText = "select THE_CVENGERS.consultarMillas(" + idClie + ") as m";
            reader.Close();
            reader = cmd.ExecuteReader();
            reader.Read();
            label12.Visible = true;
            label12.Text = reader["m"].ToString();
            reader.Close();
        }

        private void premioCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (premioCombo.SelectedIndex != -1 && canUpDown.Value != 0 && label12.Visible)
            {
                if (valorPremioElegido * canUpDown.Value <= Int32.Parse(label12.Text))
                {
                    canjBoton.Enabled = true;
                    errorPuntos.Clear();
                }
                else { errorPuntos.SetError(canjBoton, "No tiene suficientes puntos");
                canjBoton.Enabled = false;
                }
            }
            else
            { canjBoton.Enabled = false;
            errorPuntos.Clear();
            }
            if (premioCombo.SelectedIndex == -1)
                return;
            SqlCommand cmd = new SqlCommand("select * from THE_CVENGERS.PRODUCTO where '" + premioCombo.SelectedItem.ToString() + "' like '%' + PRODUCTO_NOMBRE + '%'", Conexion.getConexion());
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            canUpDown.Value = 0;
            canUpDown.Maximum = decimal.Parse(rd["PRODUCTO_STOCK"].ToString());
            valorPremioElegido = decimal.Parse(rd["PRODUCTO_MILLAS_NECESARIAS"].ToString());
            idProd = rd["PRODUCTO_ID"].ToString();
            if (canUpDown.Maximum == 0)
                errorNoStock.SetError(canUpDown, "No hay stock de ese producto");
            else errorNoStock.Clear();

            rd.Close();
        }

        private void canUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (premioCombo.SelectedIndex != -1 && canUpDown.Value != 0 && label12.Visible)
            {
                if (valorPremioElegido * canUpDown.Value <= Int32.Parse(label12.Text))
                {
                    canjBoton.Enabled = true;
                    errorPuntos.Clear();
                }
                else
                {
                    errorPuntos.SetError(canjBoton, "No tiene suficientes puntos");
                    canjBoton.Enabled = false;
                }
            }
            else
            {
                canjBoton.Enabled = false;
                errorPuntos.Clear();
            }
        }

        private void canjBoton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("exec THE_CVENGERS.realizarCanje @cli =" + idClie + ", @prod= " + idProd + ", @cant = " + canUpDown.Value.ToString(), Conexion.getConexion());
            //cmd.ExecuteNonQuery();
           // MessageBox.Show("Canje realizado exitosamente");
            MessageBox.Show(cmd.CommandText);
            premioCombo.SelectedIndex = -1;
            cmd.CommandText = "select THE_CVENGERS.consultarMillas(" + idClie + ") as m";
            
            reader = cmd.ExecuteReader();
            reader.Read();
           
            label12.Text = reader["m"].ToString();
            reader.Close();

        }

        private void label12_VisibleChanged(object sender, EventArgs e)
        {
            if (premioCombo.SelectedIndex != -1 && canUpDown.Value != 0 && label12.Visible)
            {
                if (valorPremioElegido * canUpDown.Value <= Int32.Parse(label12.Text))
                {
                    canjBoton.Enabled = true;
                    errorPuntos.Clear();
                }
                else
                {
                    errorPuntos.SetError(canjBoton, "No tiene suficientes puntos");
                    canjBoton.Enabled = false;
                }
            }
            else
            {
                canjBoton.Enabled = false;
                errorPuntos.Clear();
            }

            if (!label12.Visible)
            {
                premioCombo.SelectedIndex = -1;
                canUpDown.Value = 0;
                nombreCombo.SelectedIndex = -1;
                nombreCombo.Text = "";
                nombreCombo.Items.Clear();
            }
        }

        private void nombreCombo_VisibleChanged(object sender, EventArgs e)
        {
            
        }
    }
}
