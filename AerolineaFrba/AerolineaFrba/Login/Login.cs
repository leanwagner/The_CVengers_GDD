﻿using AerolineaFrba.Llenador;
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
            comboBox_roles.SelectedItem = "Administrador";
            textBox_usuario.Text = "Pepe";
            textBox_contraseña.Text = "w23e";

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
            if (!string.IsNullOrWhiteSpace(textBox_usuario.Text) && !string.IsNullOrWhiteSpace(textBox_contraseña.Text))
            {

                SqlCommand sqlCmd = new SqlCommand("EXEC THE_CVENGERS.chequeoLogin @P1 = " + textBox_usuario.Text + ",@P2 = " + textBox_contraseña.Text, Conexion.getConexion());

                try
                {
                    sqlCmd.ExecuteScalar();
                    AerolineaFrba pantallaInicial = new AerolineaFrba(Terminal.Usuario);
                    pantallaInicial.Show();
                    this.Hide();
                }

                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK);
                }
            }

            else
            {
                if (string.IsNullOrWhiteSpace(textBox_usuario.Text))

                {
                    MessageBox.Show("Ingrese un Nombre de Usuario", "Error: Nombre de Usuario", MessageBoxButtons.OK);
                }

                if (string.IsNullOrWhiteSpace(textBox_contraseña.Text))
                {
                    MessageBox.Show("Ingrese una contraseña ", "Error: Contraseña", MessageBoxButtons.OK);
                }

            }
        }

        private void textBox_usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)

            {
                textBox_contraseña.Focus();
            }
        }

        private void textBox_contraseña_Enter(object sender, EventArgs e)
        {
            ActiveForm.AcceptButton = button1;
        }

    }
}