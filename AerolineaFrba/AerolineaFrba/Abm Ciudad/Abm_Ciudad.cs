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
           
            llenador.llenarDataGridView(dataGridView1, "CIUDAD");
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
             SqlCommand sqlCmd = new SqlCommand("insert into THE_CVENGERS.CIUDAD(CIUDAD_NOMBRE) values ('"+textBox1.Text+"')", Conexion.getConexion());
            
            try
            {
                sqlCmd.ExecuteNonQuery();

                llenador.llenarDataGridView(dataGridView1, "CIUDAD");
                textBox1.Text = "";

            }
            
                catch(Exception ex){
                 MessageBox.Show(ex.ToString());
                
                }
        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow seleccionado = dataGridView1.SelectedRows[0];
            DialogResult dialogResult = MessageBox.Show("¿Está seguro de eliminar la ciudad: " + seleccionado.Cells[1].Value.ToString()+ "?","Confirmar",MessageBoxButtons.YesNo);
            
            if (dialogResult == DialogResult.Yes)
            {
                //deletear si se puede
                SqlCommand sqlCmd = new SqlCommand("", Conexion.getConexion());
                sqlCmd.ExecuteNonQuery();
                llenador.llenarDataGridView(dataGridView1, "CIUDAD");

            }
        }

        private void button_modificarTotal_Click(object sender, EventArgs e)
        {
                        
            DataGridViewRow seleccionado = dataGridView1.SelectedRows[0];
            SqlCommand sqlCmd = new SqlCommand("UPDATE THE_CVENGERS.CIUDAD SET CIUDAD_NOMBRE='" + textBox2.Text + "' WHERE CIUDAD_ID=" + seleccionado.Cells[0].Value.ToString() + ";", Conexion.getConexion());
            sqlCmd.ExecuteNonQuery();
            llenador.llenarDataGridView(dataGridView1, "CIUDAD");
            textBox2.Text = "";
            groupBox3.Enabled = false;
            groupBox2.Enabled = true;
        }
    }
}
