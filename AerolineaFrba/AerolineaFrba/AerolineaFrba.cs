﻿using AerolineaFrba.TipoTerminal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba
{
    public partial class AerolineaFrba : Form
    {
        public AerolineaFrba(Terminal tipoTerminal )
        {
            InitializeComponent();

            switch (tipoTerminal)
            {

                case Terminal.Kiosco: groupUsuario.Visible = false;
                    break;

                case Terminal.Usuario: groupKiosko.Visible = true;
                    break;

            }
         }

        private void AerolineaFrba_Load(object sender, EventArgs e)
        {
            //this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

        }

        private void boton_ABM_Rol_Click(object sender, EventArgs e)
        {
            Abm_Ruta.Rol Rol = new Abm_Ruta.Rol();
            Rol.Show();
        }

        private void boton_ABM_Ciudad_Click(object sender, EventArgs e)
        {
            Abm_Ciudad.Abm_Ciudad Ciudad = new Abm_Ciudad.Abm_Ciudad();
            Ciudad.Show();
        }

        private void boton_ABM_Ruta_Click(object sender, EventArgs e)
        {
            Abm_Ruta.Abm_Ruta Ruta = new Abm_Ruta.Abm_Ruta();
            Ruta.Show();
        }

        private void boton_Canje_Millas_Click(object sender, EventArgs e)
        {
            Canje_Millas.Canje_Millas Millas = new Canje_Millas.Canje_Millas();
            Millas.Show();
        }

        private void boton_Compra_Click(object sender, EventArgs e)
        {
            Compra.Compra Compra = new Compra.Compra();
            Compra.Show();
        }

        private void boton_Consulta_Millas_Click(object sender, EventArgs e)
        {
            Consulta_Millas.Consulta_Millas Consulta_Millas = new Consulta_Millas.Consulta_Millas();
            Consulta_Millas.Show();
        }

        private void boton_Devolucion_Click(object sender, EventArgs e)
        {
            Devolucion.Devolucion Devolucion = new Devolucion.Devolucion();
            Devolucion.Show();
        }

        private void boton_Generar_Viaje_Click(object sender, EventArgs e)
        {
            Generacion_Viaje.Generacion_Viaje Generar_Viaje = new Generacion_Viaje.Generacion_Viaje();
            Generar_Viaje.Show();
        }

        private void boton_Listado_Estadistico_Click(object sender, EventArgs e)
        {
            Listado_Estadistico.Listado_Estadistico ListadoE = new Listado_Estadistico.Listado_Estadistico();
            ListadoE.Show();
        }

        private void boton_Registro_Usuario_Click(object sender, EventArgs e)
        {
            Registro_de_Usuario.Registro_Usuario RegistroUsuario = new Registro_de_Usuario.Registro_Usuario();
            RegistroUsuario.Show();

        }

        private void boton_Registro_Llegada_Click(object sender, EventArgs e)
        {
            Registro_Llegada_Destino.Registro_LlegadaDestino RegistroLlegada = new Registro_Llegada_Destino.Registro_LlegadaDestino();
            RegistroLlegada.Show();
        }

        private void boton_ABM_Aeronave_Click(object sender, EventArgs e)
        {
            Abm_Aeronave.Abm_Aeronave Aeronave = new Abm_Aeronave.Abm_Aeronave();
            Aeronave.Show();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //groupUsuario.Visible = true; <-- tiene que estar en algún lado para hacer visible al groupbox
            Login.Login Loguearme = new Login.Login();
            Loguearme.Show();
        }

        private void AerolineaFrba_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

      

      
       
    }

}
 