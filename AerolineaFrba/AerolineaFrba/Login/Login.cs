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

namespace AerolineaFrba.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            mostrarRolesDisponibles();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void mostrarRolesDisponibles()
        {
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM THE_CVENGERS.CIUDAD", Conexion.getConexion());

            //Conexion.getConexion().Open();

            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                comboBox_roles.Items.Add(sqlReader["CIUDAD_NOMBRE"].ToString()); 
            }

            sqlReader.Close();
            
        }
    }
}