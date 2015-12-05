using AerolineaFrba.Llenador;
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
    public partial class DecisionAeronave : Form
    {

        public int id_aeronave;
        public string fecha;
        public DecisionAeronave(int id_aero, string fecha_reinc)
        {
            InitializeComponent();
            this.id_aeronave = id_aero;
            this.fecha=fecha_reinc;
        }

        private void button_reprogramar_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            LlenadorDeTablas lloni = new LlenadorDeTablas();
            lloni.llenarComboBoxAeronaves(ref comboBox_aeronaves, this.id_aeronave,this.fecha);
            if (comboBox_aeronaves.Items.Count == 0)
            {
                groupBox2.Enabled = false;
                groupBox3.Enabled = true;
            }

               

        }

        private void comboBox_aeronaves_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void button_repro_Click(object sender, EventArgs e)
        {
            if (fecha != "")
            {
                try
                {
                    SqlCommand sqlCmds = new SqlCommand("EXEC THE_CVENGERS.suplirAeronaveEsteLapso @avion1 = " + id_aeronave + ", @avion2 = " + dameIdAeronave(comboBox_aeronaves.SelectedItem.ToString()) + ", @fecha = '" + fecha + "'", Conexion.getConexion());

                    sqlCmds.ExecuteScalar();

                    SqlCommand sqlCmdr = new SqlCommand("EXEC THE_CVENGERS.mandarATallerHastaFecha @avion = " + id_aeronave + ", @fecha = '"+ fecha + "'", Conexion.getConexion());

                    sqlCmdr.ExecuteScalar();



                    MessageBox.Show("Se dio de baja la aeronave seleccionada mientras esté en el taller por la de matrícula " + comboBox_aeronaves.SelectedItem.ToString(), "Baja exitosa", MessageBoxButtons.OK);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else {

                try
                {
                    SqlCommand sqlCmds = new SqlCommand("EXEC THE_CVENGERS.aeronavePuedeReemplazarDePorVida @avion1 = " + id_aeronave + ", @avion2 = " + dameIdAeronave(comboBox_aeronaves.SelectedItem.ToString()), Conexion.getConexion());

                    sqlCmds.ExecuteScalar();

                   
                            SqlCommand sqlCmdss = new SqlCommand("EXEC THE_CVENGERS.suplirAeronaveParaSiempre @avion1 = " + id_aeronave + ", @avion2 = " + dameIdAeronave(comboBox_aeronaves.SelectedItem.ToString()), Conexion.getConexion());

                            sqlCmdss.ExecuteScalar();

                            SqlCommand sqlCmdp = new SqlCommand("EXEC THE_CVENGERS.darDeBajaVitaliciaAeronave @avion = " + id_aeronave, Conexion.getConexion());

                            sqlCmdp.ExecuteScalar();

                            MessageBox.Show("Se dio de baja la aeronave seleccionada por la de matrícula " + comboBox_aeronaves.SelectedItem.ToString(), "Baja exitosa", MessageBoxButtons.OK);
                            this.Close();
                   

                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                    
            
            
            }

        }

        private void button_cancelarTodo_Click(object sender, EventArgs e)
        {
            if (fecha != "")
            {
                try
                {
                    SqlCommand sqlCmds = new SqlCommand("EXEC THE_CVENGERS.cancelarViajesParaUnLapso @avion = " + id_aeronave + ", @fecha = '" + fecha + "'", Conexion.getConexion());

                    sqlCmds.ExecuteScalar();

                    SqlCommand sqlCmdt = new SqlCommand("EXEC THE_CVENGERS.mandarATallerHastaFecha @avion = " + id_aeronave + ", @fecha = '" + fecha + "'", Conexion.getConexion());

                    sqlCmdt.ExecuteScalar();


                    MessageBox.Show("Se cancelaron todos los viajes para la aeronave seleccionada mientras esté en el taller y se hicieron las devoluciones correspondientes.", "Baja exitosa", MessageBoxButtons.OK);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    SqlCommand sqlCmds = new SqlCommand("EXEC THE_CVENGERS.cancelarViajesDeAvión @avion = " + id_aeronave, Conexion.getConexion());

                    sqlCmds.ExecuteScalar();

                    SqlCommand sqlCmdp = new SqlCommand("EXEC THE_CVENGERS.darDeBajaVitaliciaAeronave @avion = " + id_aeronave, Conexion.getConexion());

                    sqlCmdp.ExecuteScalar();


                    MessageBox.Show("Se cancelaron todos los pasajes para la aeronave seleccionada. ", "Baja exitosa", MessageBoxButtons.OK);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
 



            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength != 0) button1.Enabled = true;
            else button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("", Conexion.getConexion());
            cmd.CommandText = "EXEC THE_CVENGERS.crearAeronaveSuplente @Id ='" + id_aeronave + "', @matricula = '" + textBox1.Text + "'";
            try
            {
                cmd.ExecuteNonQuery();
                // MessageBox.Show(cmd.CommandText);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }

            //YA SE CREO EL REEMPLAZO

            if (fecha != "")
            {
                try
                {
                    SqlCommand sqlCmds = new SqlCommand("EXEC THE_CVENGERS.suplirAeronaveEsteLapso @avion1 = " + id_aeronave + ", @avion2 = " + dameIdAeronave(textBox1.Text) + ", @fecha = '" + fecha + "'", Conexion.getConexion());

                    sqlCmds.ExecuteScalar();

                    SqlCommand sqlCmdr = new SqlCommand("EXEC THE_CVENGERS.mandarATallerHastaFecha @avion = " + id_aeronave + ", @fecha = '" + fecha + "'", Conexion.getConexion());

                    sqlCmdr.ExecuteScalar();



                    MessageBox.Show("Se dio de baja la aeronave seleccionada mientras esté en el taller. Ha sido reemplazada por la aeronave de matrícula " + textBox1.Text, "Baja exitosa", MessageBoxButtons.OK);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {

                try
                {
                    SqlCommand sqlCmds = new SqlCommand("EXEC THE_CVENGERS.aeronavePuedeReemplazarDePorVida @avion1 = " + id_aeronave + ", @avion2 = " + dameIdAeronave(textBox1.Text), Conexion.getConexion());
                    MessageBox.Show(sqlCmds.CommandText);
                    sqlCmds.ExecuteScalar();


                    SqlCommand sqlCmdss = new SqlCommand("EXEC THE_CVENGERS.suplirAeronaveParaSiempre @avion1 = " + id_aeronave + ", @avion2 = " + dameIdAeronave(textBox1.Text), Conexion.getConexion());

                    sqlCmdss.ExecuteScalar();

                    SqlCommand sqlCmdp = new SqlCommand("EXEC THE_CVENGERS.darDeBajaVitaliciaAeronave @avion = " + id_aeronave, Conexion.getConexion());

                    sqlCmdp.ExecuteScalar();

                    MessageBox.Show("Se dio de baja la aeronave seleccionada. Ha sido reeplazada por la aeronave de matrícula " + textBox1.Text, "Baja exitosa", MessageBoxButtons.OK);
                    this.Close();



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }



            }


        }

    }
    
}
