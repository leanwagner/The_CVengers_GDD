using AerolineaFrba.TipoTerminal;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba
{
    public partial class AerolineaFrba : Form
    {
        int[] posisionesBoton = new int[] { 12, 51, 90, 129, 168,207,246,285,324,361,398 };
        Collection<String> funcionalidades = new Collection<String>();
        SqlDataReader reader;
        public AerolineaFrba()
        {
            InitializeComponent();
         }

        private void AerolineaFrba_Load(object sender, EventArgs e)
        {
            //this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            //this.AutoSize = true;
            acomodarBotones();
        }

        private void acomodarBotones()
        {
            SqlCommand cmd = new SqlCommand("select * from THE_CVENGERS.ROLXUSUARIO rxu, THE_CVENGERS.ROL r, THE_CVENGERS.USUARIO u, THE_CVENGERS.FUNCIONXROL fxr, THE_CVENGERS.FUNCIONALIDAD f where rxu.ROLXUSUARIO_ROL = r.ROL_ID and rxu.ROLXUSUARIO_USUARIO = u.USR_ID and FXR_ROL_ID = r.ROL_ID and f.FUNC_ID = fxr.FXR_FUNC_ID and u.USR_USERNAME = '" + Program.usuarioLogeado + "'", Conexion.getConexion());
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                funcionalidades.Add(reader["FUNC_NOMBRE"].ToString());
               
            }
            reader.Close();
            int proximoBoton = 0;



            if (funcionalidades.Contains("Comprar pasaje - encomienda"))
            {
                boton_Compra.Visible = true;
                boton_Compra.Location = new Point(12, posisionesBoton[proximoBoton]);
                proximoBoton++;
            }

            if (funcionalidades.Contains("Cancelación pasaje o encomienda"))
            {
                boton_Devolucion.Visible = true;
                boton_Devolucion.Location = new Point(12, posisionesBoton[proximoBoton]);
                proximoBoton++;
            }

            if (funcionalidades.Contains("Consultar Millas"))
            {
                boton_Consulta_Millas.Visible = true;
                boton_Consulta_Millas.Location = new Point(12, posisionesBoton[proximoBoton]);
                proximoBoton++;
            }

            if (funcionalidades.Contains("Canje Millas"))
            {
                boton_Canje_Millas.Visible = true;
                boton_Canje_Millas.Location = new Point(12, posisionesBoton[proximoBoton]);
                proximoBoton++;
            }

            if (funcionalidades.Contains("Generar viaje"))
            {
                boton_Generar_Viaje.Visible = true;
                boton_Generar_Viaje.Location = new Point(12, posisionesBoton[proximoBoton]);
                proximoBoton++;
            }

            if (funcionalidades.Contains("Registrar llegada a destino"))
            {
                boton_Registro_Llegada.Visible = true;
                boton_Registro_Llegada.Location = new Point(12, posisionesBoton[proximoBoton]);
                proximoBoton++;
            }

            if (funcionalidades.Contains("Listado Estadístico"))
            {
                boton_Listado_Estadistico.Visible = true;
                boton_Listado_Estadistico.Location = new Point(12, posisionesBoton[proximoBoton]);
                proximoBoton++;
            }

            if (funcionalidades.Contains("ABM Ruta"))
            {
                boton_ABM_Ruta.Visible = true;
                boton_ABM_Ruta.Location = new Point(12, posisionesBoton[proximoBoton]);
                proximoBoton++;
            }

            if (funcionalidades.Contains("ABM Aeronave"))
            {
                boton_ABM_Aeronave.Visible = true;
                boton_ABM_Aeronave.Location = new Point(12, posisionesBoton[proximoBoton]);
                proximoBoton++;
            }

            if (funcionalidades.Contains("ABM Rol"))
            {
                boton_Rol.Visible = true;
                boton_Rol.Location = new Point(12, posisionesBoton[proximoBoton]);
                proximoBoton++;
            }

            if (funcionalidades.Contains("ABM Ciudad"))
            {
                boton_ABM_Ciudad.Visible = true;
                boton_ABM_Ciudad.Location = new Point(12, posisionesBoton[proximoBoton]);
                proximoBoton++;
            }

            this.Size = new Size(this.Size.Width, posisionesBoton[proximoBoton - 1]);
            funcionalidades.Clear();
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
            Devolucion.Devolución Devolucion = new Devolucion.Devolución();
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
           // if (MessageBox.Show("¿Está seguro de salir?", "Cerrar programa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
                Environment.Exit(1);
            //}
            //else { e.Cancel = true; }  <--- comentado para hacer mas rapido el testing, descomentar despues
        }

        private void AerolineaFrba_Activated(object sender, EventArgs e)
        {
            boton_ABM_Aeronave.Visible = false;
            boton_ABM_Ciudad.Visible = false;
            boton_ABM_Ruta.Visible = false;
            boton_Canje_Millas.Visible = false;
            boton_Compra.Visible = false;
            boton_Consulta_Millas.Visible = false;
            boton_Devolucion.Visible = false;
            boton_Generar_Viaje.Visible = false;
            boton_Listado_Estadistico.Visible = false;
            boton_Registro_Llegada.Visible = false;
            boton_Rol.Visible = false;
            acomodarBotones();
            this.Refresh();
        }

      

      
       
    }

}
 