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
        public Abm_Ruta()
        {
            InitializeComponent();
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
    }
}
