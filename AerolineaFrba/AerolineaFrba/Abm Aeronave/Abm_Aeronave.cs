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

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class Abm_Aeronave : Form
    {

        String matAnt;
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

            if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0 && textBox3.Value != 0 && textBox4.Value != 0) boton_Agregar_Aeronave.Enabled = true;
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

            sqlCmd.CommandText = "insert into THE_CVENGERS.AERONAVE(AERONAVE_CANTIDAD_BUTACAS,AERONAVE_FABRICANTE_AVION,AERONAVE_ESPACIO_ENCOMIENDAS,AERONAVE_MATRICULA_AVION,AERONAVE_MODELO_AVION,AERONAVE_SERVICIO) VALUES ('" + textBox3.Value.ToString() + "'," + idFab + "," + textBox4.Value.ToString(CultureInfo.InvariantCulture) + ",'" + textBox1.Text + "','" + textBox2.Text + "'," + idServ + ")";
            try
            {
                sqlCmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Ya existe un avion con esa matricula","Error",MessageBoxButtons.OK);
            }
            listBox1.Items.Add(textBox1.Text);
            listBox1.Refresh();

            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
            
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
            if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0 && textBox3.Value != 0 && textBox4.Value != 0) boton_Agregar_Aeronave.Enabled = true;
            else boton_Agregar_Aeronave.Enabled = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0 && textBox3.Value != 0 && textBox4.Value != 0) boton_Agregar_Aeronave.Enabled = true;
            else boton_Agregar_Aeronave.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0 && textBox3.Value != 0 && textBox4.Value != 0)
                boton_Agregar_Aeronave.Enabled = true;
            else boton_Agregar_Aeronave.Enabled = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            boton_Modificar_Aeronave.Enabled = true;
            boton_Eliminar_Aeronave.Enabled = true;
        }

        private void boton_Modificar_Aeronave_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            groupBox3.Refresh();
            this.Refresh();
            Llenador.LlenadorDeTablas lleni = new Llenador.LlenadorDeTablas();
            lleni.llenarComboBox(ref comboBox4, "FABRICANTE", "FABRICANTE_NOMBRE");
            lleni.llenarComboBox(ref comboBox3, "SERVICIO", "SERVICIO_NOMBRE");

            SqlCommand sqlCmd = new SqlCommand("select * from THE_CVENGERS.AERONAVE, THE_CVENGERS.SERVICIO, THE_CVENGERS.FABRICANTE where AERONAVE_FABRICANTE_AVION = FABRICANTE_ID and AERONAVE_SERVICIO = SERVICIO_ID and AERONAVE_MATRICULA_AVION ='" + listBox1.SelectedItem.ToString() + "'", Conexion.getConexion());
            SqlDataReader sqlReader;
            sqlReader = sqlCmd.ExecuteReader();
            sqlReader.Read();
            textBox8.Text = sqlReader["AERONAVE_MATRICULA_AVION"].ToString();
            textBox7.Text = sqlReader["AERONAVE_MODELO_AVION"].ToString();
            comboBox4.SelectedIndex = comboBox4.Items.IndexOf(sqlReader["FABRICANTE_NOMBRE"].ToString());
            comboBox3.SelectedIndex = comboBox3.Items.IndexOf(sqlReader["SERVICIO_NOMBRE"].ToString());
            textBox6.Value = decimal.Parse(sqlReader["AERONAVE_CANTIDAD_BUTACAS"].ToString());
            textBox5.Value = decimal.Parse(sqlReader["AERONAVE_ESPACIO_ENCOMIENDAS"].ToString());
            matAnt = sqlReader["AERONAVE_ID"].ToString();
            sqlReader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            SqlCommand sqlCmd = new SqlCommand("select * from THE_CVENGERS.FABRICANTE where FABRICANTE_NOMBRE ='" + comboBox4.SelectedItem.ToString() + "'", Conexion.getConexion());
            SqlDataReader sqlReader;
            sqlReader = sqlCmd.ExecuteReader();
            sqlReader.Read();
            String idFab = sqlReader["FABRICANTE_ID"].ToString();
            sqlReader.Close();

            sqlCmd.CommandText = "select * from THE_CVENGERS.SERVICIO where SERVICIO_NOMBRE ='" + comboBox3.SelectedItem.ToString() + "'";
            sqlReader = sqlCmd.ExecuteReader();
            sqlReader.Read();
            String idServ = sqlReader["SERVICIO_ID"].ToString();
            sqlReader.Close();



            sqlCmd.CommandText = "UPDATE THE_CVENGERS.AERONAVE set AERONAVE_CANTIDAD_BUTACAS = " + textBox6.Value.ToString() + ",AERONAVE_FABRICANTE_AVION = '" + idFab + "',AERONAVE_ESPACIO_ENCOMIENDAS = " + textBox5.Value.ToString(CultureInfo.InvariantCulture) + ",AERONAVE_MATRICULA_AVION = '" + textBox8.Text + "',AERONAVE_MODELO_AVION = '" + textBox7.Text + "',AERONAVE_SERVICIO = '" + idServ + "' where AERONAVE_ID = " + matAnt;

            try
            {
                sqlCmd.ExecuteNonQuery();
            }
            catch 
            {
                MessageBox.Show("Ya existe un avion con esa matricula", "Error", MessageBoxButtons.OK);
            }
            groupBox3.Visible = false;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Value != 0 && textBox6.Value != 0 && textBox7.Text.Length != 0 && textBox8.Text.Length != 0)
            {
            
                button2.Enabled = true;
            }
            else
            {
                
                button2.Enabled = false;
            }
        }

        
    }
}
