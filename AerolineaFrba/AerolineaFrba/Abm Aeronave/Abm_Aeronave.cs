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

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class Abm_Aeronave : Form
    {
        public Abm_Aeronave()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0 && textBox3.Text.Length != 0 && textBox4.Text.Length != 0)
                boton_Agregar_Aeronave.Enabled = true;
            else boton_Agregar_Aeronave.Enabled = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Butacas butacas = new Butacas();
            butacas.Show();
        }

        private void boton_Agregar_Aeronave_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCmd = new SqlCommand("select * from THE_CVENGERS.FABRICANTE where FABRICANTE_NOMBRE ='" + comboBox1.SelectedItem.ToString() + "'", Conexion.getConexion());
            SqlDataReader sqlReader;
            sqlReader = sqlCmd.ExecuteReader();
            sqlReader.Read();
            String idFab = sqlReader["FABRICANTE_ID"].ToString();
            sqlReader.Close();

            sqlCmd.CommandText = "select * from THE_CVENGERS.SERVICIO where SERVICIO_NOMBRE ='" + comboBox2.SelectedItem.ToString() + "'";
            sqlReader = sqlCmd.ExecuteReader();
            sqlReader.Read();
            String idServ = sqlReader["SERVICIO_ID"].ToString();
            sqlReader.Close();

            sqlCmd.CommandText = "insert into THE_CVENGERS.AERONAVE(AERONAVE_CANTIDAD_BUTACAS,AERONAVE_FABRICANTE_AVION,AERONAVE_ESPACIO_ENCOMIENDAS,AERONAVE_MATRICULA_AVION,AERONAVE_MODELO_AVION,AERONAVE_SERVICIO) VALUES ('"+textBox3.Text+"',"+idFab+"," +textBox4.Text + ",'"+textBox1.Text+"','"+textBox2.Text+"',"+idServ+")";
            sqlCmd.ExecuteNonQuery();

            listBox1.Items.Add(textBox1.Text);
            listBox1.Refresh();
        }

        private void Abm_Aeronave_Load(object sender, EventArgs e)
        {
            Llenador.LlenadorDeTablas lleni = new Llenador.LlenadorDeTablas();
            lleni.llenarComboBox(ref comboBox1,"FABRICANTE","FABRICANTE_NOMBRE");
            lleni.llenarComboBox(ref comboBox2, "SERVICIO","SERVICIO_NOMBRE");
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            lleni.llenarListBox(ref listBox1, "AERONAVE", "AERONAVE_MATRICULA_AVION");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0 && textBox3.Text.Length != 0 && textBox4.Text.Length != 0)
                boton_Agregar_Aeronave.Enabled = true;
            else boton_Agregar_Aeronave.Enabled = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0 && textBox3.Text.Length != 0 && textBox4.Text.Length != 0)
                boton_Agregar_Aeronave.Enabled = true;
            else boton_Agregar_Aeronave.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0 && textBox3.Text.Length != 0 && textBox4.Text.Length != 0)
                boton_Agregar_Aeronave.Enabled = true;
            else boton_Agregar_Aeronave.Enabled = false;
        }
    }
}
