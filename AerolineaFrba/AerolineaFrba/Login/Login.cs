using AerolineaFrba.Llenador;
using AerolineaFrba.TipoTerminal;
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

        LlenadorDeTablas llenador = new LlenadorDeTablas();

        public Login()
        {
            InitializeComponent();
            mostrarRolesDisponibles();
            textBox_usuario.Enabled = false;
            textBox_contraseña.Enabled = false;
            comboBox_roles.SelectedItem = "Cliente"; 
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!comboBox_roles.SelectedItem.Equals("Cliente"))
            {
                validarLogin();
            }
            else
            {
                AerolineaFrba pantallaInicial = new AerolineaFrba(Terminal.Kiosco);
                pantallaInicial.Show();
                this.Hide();

            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_usuario.Text = "";
            textBox_contraseña.Text = "";

            if (!comboBox_roles.SelectedItem.Equals("Cliente"))

            {
                textBox_usuario.Enabled = true;
                textBox_contraseña.Enabled = true;
            }

            else
            {
                textBox_usuario.Enabled = false;
                textBox_contraseña.Enabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void mostrarRolesDisponibles()
        {
            llenador.llenarComboBox(ref comboBox_roles, "ROL", "ROL_NOMBRE");
            
        }

        public void validarLogin()
        {
            int resultadoLectura;

            if (!string.IsNullOrWhiteSpace(textBox_usuario.Text) && !string.IsNullOrWhiteSpace(textBox_contraseña.Text))
            {
                SqlCommand sqlCmd = new SqlCommand("EXEC THE_CVENGERS.chequeoLogin(" + textBox_usuario + "," + textBox_contraseña + ")", Conexion.getConexion());

                SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                resultadoLectura =  sqlReader.GetInt32(0);

                switch (resultadoLectura)
                {
                    case 1:   AerolineaFrba pantallaInicial = new AerolineaFrba(Terminal.Usuario);
                              pantallaInicial.Show();
                              this.Hide();
                              break;

                    case 2:   MessageBox.Show("Reingrese su contraseña.");
                              break;

                    case 3:   MessageBox.Show("El usuario con el que intenta ingresar no existe.");
                              break;

                    case 4:   MessageBox.Show("El usuario con el que intenta ingresar no tiene permisos de administrador.");
                              break;

                    case 5:   MessageBox.Show("El usuario con el que intenta ingresar se encuenta inhabilitado.");
                              break;
                }

                sqlReader.Close();
            }
        }
    }
}