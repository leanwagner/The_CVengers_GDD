using AerolineaFrba.Llenador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Ruta
{
    public partial class Abm_Ruta : Form
    {

        LlenadorDeTablas llenador = new LlenadorDeTablas();

        public Abm_Ruta()
        {
            InitializeComponent();
            this.mostrarServicios();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void boton_Modificar_Click(object sender, EventArgs e)
        {
            RutaModificar rutaAModificar = new RutaModificar();
            rutaAModificar.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Abm_Ruta_Load(object sender, EventArgs e)
        {

        }

        public void mostrarServicios()
        {

            llenador.llenarCheckedListBox(ref checkedListBox_servicios,"SERVICIO","SERVICIO_NOMBRE");

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
