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

namespace AerolineaFrba.Abm_Ruta
{
    public partial class Rol : Form
    {

        public Rol()
        {
            InitializeComponent();
            LlenadorDeTablas lleni = new LlenadorDeTablas();
           // lleni.llenarListBoxConCondicion(ref listBox1, "ROL", "ROL_NOMBRE","ROL_ESTADO = 1");
           // lleni.llenarListBoxConCondicion(ref listBox2, "ROL", "ROL_NOMBRE", "ROL_ESTADO = 0");
            lleni.llenarCheckedListBox(ref checkedListBox1, "FUNCIONALIDAD", "FUNC_NOMBRE");
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (textBox1.Text.Length != 0 && !button1.Enabled && e.NewValue == CheckState.Checked)
            {
                button1.Enabled = true;

            }
            else if(button1.Enabled && e.NewValue == CheckState.Unchecked && checkedListBox1.CheckedItems.Count<=1)
            {
                button1.Enabled = false;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            String asz = listBox1.SelectedItem.ToString();
            Abm_Rol.ModificarRol mod = new Abm_Rol.ModificarRol(asz);
       
            mod.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCmd = new SqlCommand("select * from THE_CVENGERS.ROL where ROL_NOMBRE ='" + listBox1.SelectedItem.ToString() + "'", Conexion.getConexion());
            SqlDataReader sqlReader;
            sqlReader = sqlCmd.ExecuteReader();
            sqlReader.Read();
            String idRol = sqlReader["ROL_ID"].ToString();
            sqlReader.Close();

            sqlCmd.CommandText = "update THE_CVENGERS.ROL set ROL_ESTADO = 0 where ROL_ID = " + idRol;
            sqlCmd.ExecuteNonQuery();

            int x = listBox1.SelectedIndex;
            listBox2.Items.Add(listBox1.SelectedItem.ToString());
            listBox2.Refresh();
            listBox1.Items.RemoveAt(x);
            listBox1.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCmd = new SqlCommand("select * from THE_CVENGERS.ROL where ROL_NOMBRE ='" + listBox2.SelectedItem.ToString() + "'", Conexion.getConexion());
            SqlDataReader sqlReader;
            sqlReader = sqlCmd.ExecuteReader();
            sqlReader.Read();
            String idRol = sqlReader["ROL_ID"].ToString();
            sqlReader.Close();

            sqlCmd.CommandText = "update THE_CVENGERS.ROL set ROL_ESTADO = 1 where ROL_ID = " + idRol;
            sqlCmd.ExecuteNonQuery();
            int x = listBox2.SelectedIndex;
            listBox1.Items.Add(listBox2.SelectedItem.ToString());
            listBox1.Refresh();
            
            listBox2.Items.RemoveAt(x);
            listBox2.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String asz = listBox2.SelectedItem.ToString();
            Abm_Rol.ModificarRol mod = new Abm_Rol.ModificarRol(asz);

            mod.Show();
        }

        private void Rol_Activated(object sender, EventArgs e)
        {
            LlenadorDeTablas lleni = new LlenadorDeTablas();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            lleni.llenarListBoxConCondicion(ref listBox1, "ROL", "ROL_NOMBRE", "ROL_ESTADO = 1");
            lleni.llenarListBoxConCondicion(ref listBox2, "ROL", "ROL_NOMBRE", "ROL_ESTADO = 0");
            listBox1.Refresh();
            listBox2.Refresh();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button4.Enabled = true;
            button5.Enabled = true;
        }

       

       

     
    }
}
