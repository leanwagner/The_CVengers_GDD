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
        int indiceSele;
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

            sqlCmd.CommandText = "EXEC THE_CVENGERS.ingresoAeronave @matri ='"+textBox1.Text+
                "', @model = '"+textBox2.Text+
                "', @fabricante = "+idFab+
                ", @serv = "+idServ+ 
                ", @butacas = " +textBox3.Value.ToString()+
                ", @espacio = " +textBox4.Value.ToString(CultureInfo.InvariantCulture)+
                ", @pisos = "+numericUpDown2.Value.ToString();
            try
            {
                sqlCmd.ExecuteNonQuery();
               // MessageBox.Show(sqlCmd.CommandText);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK);
            }
            MessageBox.Show("Aeronave creada exitosamente");
            listBox1.Items.Add(new Avion(textBox1.Text,comboBox2.Text,comboBox1.Text));
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
           
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM THE_CVENGERS.AERONAVE, THE_CVENGERS.FABRICANTE, THE_CVENGERS.SERVICIO where AERONAVE_FABRICANTE_AVION = FABRICANTE_ID and AERONAVE_SERVICIO = SERVICIO_ID and AERONAVE_ESTADO = 1", Conexion.getConexion());

            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                listBox1.Items.Add(new Avion(sqlReader["AERONAVE_MATRICULA_AVION"].ToString(), sqlReader["SERVICIO_NOMBRE"].ToString(), sqlReader["FABRICANTE_NOMBRE"].ToString()));
            }

            sqlReader.Close();
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

            if (listBox1.SelectedIndex == -1)
                return;
            boton_Eliminar_Aeronave.Enabled = true;

            SqlCommand cmd = new SqlCommand("select case when exists(select * from THE_CVENGERS.VIAJE, THE_CVENGERS.AERONAVE where VIAJE_AERONAVE = AERONAVE_ID and AERONAVE_MATRICULA_AVION ='"+((Avion)listBox1.SelectedItem).matricula +"') then 1 else 0 end", Conexion.getConexion());
            if ((int)cmd.ExecuteScalar() == 0)
            {
                boton_Modificar_Aeronave.Enabled = true;
                errorTieneViajes.Clear();
            }
            else
            {
                boton_Modificar_Aeronave.Enabled = false;
                errorTieneViajes.SetError(boton_Modificar_Aeronave, "No se pueden modificar aeronaves que ya han viajado");
            }
        }

        private void boton_Modificar_Aeronave_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            groupBox3.Refresh();
            groupBox2.Enabled = false;
            this.Refresh();
            Llenador.LlenadorDeTablas lleni = new Llenador.LlenadorDeTablas();
            lleni.llenarComboBox(ref comboBox4, "FABRICANTE", "FABRICANTE_NOMBRE");
            lleni.llenarComboBox(ref comboBox3, "SERVICIO", "SERVICIO_NOMBRE");

            SqlCommand sqlCmd = new SqlCommand("select * from THE_CVENGERS.AERONAVE, THE_CVENGERS.SERVICIO, THE_CVENGERS.FABRICANTE where AERONAVE_FABRICANTE_AVION = FABRICANTE_ID and AERONAVE_SERVICIO = SERVICIO_ID and AERONAVE_MATRICULA_AVION ='" + ((Avion)listBox1.SelectedItem).getMatricula() + "'", Conexion.getConexion());
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
            sqlCmd.CommandText = "select MAX(BUTACA_PISO) 'p' from THE_CVENGERS.BUTACA where BUTACA_AERONAVE =" + matAnt;
            MessageBox.Show(sqlCmd.CommandText);
            sqlReader = sqlCmd.ExecuteReader();
            sqlReader.Read();
            numericUpDown1.Value = decimal.Parse(sqlReader["p"].ToString());
            sqlReader.Close();
            indiceSele = listBox1.SelectedIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            comboBox3.Items.Clear();
                comboBox4.Items.Clear();
                groupBox2.Enabled = true;
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



            sqlCmd.CommandText = "exec THE_CVENGERS.modificarAeronave @matri = '" + textBox8.Text +
                "',@model = '" + textBox7.Text +
                "',@fabricante = " + idFab +
                ",@serv = " + idServ +
                ",@butacas = " + textBox6.Value.ToString() +
                ",@espacio = " + textBox5.Value.ToString(CultureInfo.InvariantCulture) +
                ", @pisos =" + numericUpDown1.Value.ToString() +
                ", @Id = " + matAnt;
            MessageBox.Show(sqlCmd.CommandText);  

            try
            {
               sqlCmd.ExecuteNonQuery();
               // MessageBox.Show("No hace nada hasta que mike haga el procedure modificarAeronave. Descomentar las 3 lineas cerca de este message box cuando el procedure este hecho");  
               listBox1.SelectedIndex = -1;
            listBox1.Items.RemoveAt(indiceSele);
            listBox1.Items.Add(new Avion(textBox8.Text, comboBox3.Text, comboBox4.Text));
            listBox1.Refresh();
            comboBox4.Items.Clear();
            comboBox3.Items.Clear();
            groupBox3.Visible = false;
            groupBox2.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
   
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

        private void label13_Click(object sender, EventArgs e)
        {

        }

        

        private void boton_Eliminar_Aeronave_Click(object sender, EventArgs e)
        {
            

             try
             {
                 SqlCommand sqlCmd = new SqlCommand("SELECT THE_CVENGERS.aeronaveEnElAire (" + dameIdAeronave(((Avion)listBox1.SelectedItem).getMatricula()) + ")", Conexion.getConexion());



                 if ((int)sqlCmd.ExecuteScalar() == 1)
                {                    
                     MessageBox.Show("No se puede dar de baja, la aeronave se encuentra en viaje", "Error");
                }
                else {

                    BajaAeronave ventana = new BajaAeronave(((Avion)listBox1.SelectedItem).getMatricula());
                    ventana.Show();
                }
                

            }
            catch
            {
                MessageBox.Show("Rompio algo", "Error", MessageBoxButtons.OK);
            }

        }

        private int dameIdAeronave(string matricula)
        {
            SqlCommand sqlCmd = new SqlCommand("select AERONAVE_ID from THE_CVENGERS.AERONAVE where AERONAVE_MATRICULA_AVION ='" + matricula + "'", Conexion.getConexion());
            SqlDataReader sqlReader;
            sqlReader = sqlCmd.ExecuteReader();
            sqlReader.Read();
            int id = Int32.Parse(sqlReader["AERONAVE_ID"].ToString());
            sqlReader.Close();

            return id;

        }


        
    }
}
