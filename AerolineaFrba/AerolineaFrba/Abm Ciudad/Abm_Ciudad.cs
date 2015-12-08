using AerolineaFrba.Llenador;
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

namespace AerolineaFrba.Abm_Ciudad
{
    public partial class Abm_Ciudad : Form
    {
        public LlenadorDeTablas llenador = new LlenadorDeTablas();

        public Abm_Ciudad()
        {
            InitializeComponent();
        }

        private void Abm_Ciudad_Load(object sender, EventArgs e)
        {
           
            llenador.llenarDataGridViewABMCiudad(dataGridView1);
        }

        private void boton_Agregar_Ciudad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            boton_Agregar_Ciudad.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            boton_Modificar.Enabled = true;
            button_eliminar.Enabled = true;
        }

        private void boton_Modificar_Click(object sender, EventArgs e)
        {
            
            DataGridViewRow seleccionado = dataGridView1.SelectedRows[0];
            groupBox3.Enabled = true;
            groupBox2.Enabled = false;
            textBox2.Text = seleccionado.Cells[1].Value.ToString();
        }

        private void boton_Agregar_Ciudad_Click_1(object sender, EventArgs e)
        {
            //sino ver de hacer un PROC que inserte si no existe esa ciudad
              
            try
            {
                SqlCommand sqlCmd = new SqlCommand("EXEC THE_CVENGERS.ingresarCiudad @ciudad='" + textBox1.Text + "'", Conexion.getConexion());
           
                sqlCmd.ExecuteNonQuery();

                llenador.llenarDataGridViewABMCiudad(dataGridView1);
                textBox1.Text = "";

            }
            
                catch(Exception ex){
                 MessageBox.Show(ex.Message,"Error en el alta");
                
                }
        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow seleccionado = dataGridView1.SelectedRows[0];
            DialogResult dialogResult = MessageBox.Show("¿Está seguro de eliminar la ciudad: " + seleccionado.Cells[1].Value.ToString()+ "?","Confirmar",MessageBoxButtons.YesNo);
            
            if (dialogResult == DialogResult.Yes)
            {
                
                  try
                {
                    SqlCommand sqlCmd = new SqlCommand("EXEC THE_CVENGERS.bajarCiudad @ciudad=" + seleccionado.Cells[0].Value.ToString() + "", Conexion.getConexion());

                    sqlCmd.ExecuteNonQuery();
                    llenador.llenarDataGridViewABMCiudad(dataGridView1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Error en la baja");
                }
            }
        }

        private void button_modificarTotal_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow seleccionado = dataGridView1.SelectedRows[0];
                SqlCommand sqlCmd = new SqlCommand("EXEC THE_CVENGERS.modificarCiudad @idCiudad='" + seleccionado.Cells[0].Value.ToString() + "', @nombreNuevo='" + textBox2.Text + "';", Conexion.getConexion());
                sqlCmd.ExecuteNonQuery();
                llenador.llenarDataGridViewABMCiudad(dataGridView1);
                textBox2.Text = "";
                groupBox3.Enabled = false;
                groupBox2.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error en la modificación");
                llenador.llenarDataGridViewABMCiudad(dataGridView1);
                textBox2.Text = "";
                groupBox3.Enabled = false;
                groupBox2.Enabled = true;
            }
      }
    }
}
