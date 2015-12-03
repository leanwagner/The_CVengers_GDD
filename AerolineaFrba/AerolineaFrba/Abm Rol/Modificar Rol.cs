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

namespace AerolineaFrba.Abm_Rol
{
    public partial class ModificarRol : Form
    {

        public String rol;
        public ModificarRol(String rol)
        {
            this.rol = rol;
           
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ModificarRol_Load(object sender, EventArgs e)
        {
            this.Text = rol;
            Llenador.LlenadorDeTablas llenu = new Llenador.LlenadorDeTablas();
            llenu.llenarListBoxConCondicion(ref listBox1, "FUNCIONALIDAD f, THE_CVENGERS.FUNCIONXROL fxr, THE_CVENGERS.ROL r", "FUNC_NOMBRE", "fxr.FXR_FUNC_ID = f.FUNC_ID and fxr.FXR_ROL_ID = r.ROL_ID and r.ROL_NOMBRE = '" + rol + "'");
            llenu.llenarListBoxSacandoLosDelOtro(ref listBox2,ref listBox1, "FUNCIONALIDAD", "FUNC_NOMBRE");
            textBox1.Text = rol;
           
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCmd = new SqlCommand("select * from THE_CVENGERS.ROL where ROL_NOMBRE ='" + rol + "'", Conexion.getConexion());
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();
            sqlReader.Read();
            String idRol = sqlReader["ROL_ID"].ToString();
            sqlReader.Close();
            sqlCmd.CommandText = "select * from THE_CVENGERS.FUNCIONALIDAD where FUNC_NOMBRE ='" + listBox2.SelectedItem.ToString() + "'";
            sqlReader = sqlCmd.ExecuteReader();
            sqlReader.Read();
            String idFuncion = sqlReader["FUNC_ID"].ToString();
            sqlReader.Close();
            //hacer el insert
            sqlCmd.CommandText = "insert into THE_CVENGERS.FUNCIONXROL(FXR_ROL_ID,FXR_FUNC_ID) values (" + idRol + "," + idFuncion + ")";
            try
            {
                sqlCmd.ExecuteNonQuery();
                listBox1.Items.Add(listBox2.SelectedItem.ToString());
                int x = listBox2.SelectedIndex;
                listBox2.Items.RemoveAt(x);
                
                button2.Enabled = false;
                listBox2.Refresh();
                listBox1.Refresh();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK); }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCmd = new SqlCommand("select * from THE_CVENGERS.ROL where ROL_NOMBRE ='" + rol + "'", Conexion.getConexion());
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();
            sqlReader.Read();
            String idRol = sqlReader["ROL_ID"].ToString();
            sqlReader.Close();
            sqlCmd.CommandText = "select * from THE_CVENGERS.FUNCIONALIDAD where FUNC_NOMBRE ='" + listBox1.SelectedItem.ToString() + "'";
            sqlReader = sqlCmd.ExecuteReader();
            sqlReader.Read();
            String idFuncion = sqlReader["FUNC_ID"].ToString();
            sqlReader.Close();
            //hacer el delete
            sqlCmd.CommandText = "delete from THE_CVENGERS.FUNCIONXROL where FXR_ROL_ID = " + idRol + "and FXR_FUNC_ID = " + idFuncion;
            try
            {
                sqlCmd.ExecuteNonQuery();
                listBox2.Items.Add(listBox1.SelectedItem.ToString());
                int x = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(x);
              
                button1.Enabled = false;
                listBox1.Refresh();
                listBox2.Refresh();
        
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK); }

           }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SqlCommand sqlCmd = new SqlCommand("update THE_CVENGERS.ROL set ROL_NOMBRE = '"+textBox1.Text+"' where ROL_NOMBRE = '"+rol+"'", Conexion.getConexion());
            try
            {
                sqlCmd.ExecuteNonQuery();
                this.Text = textBox1.Text;
                this.rol = textBox1.Text;
                this.Refresh();
        
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK); }
               }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) button1.Enabled = false;
            else button1.Enabled = true;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex == -1) button2.Enabled = false;
            else button2.Enabled = true;
        }
    }
}
