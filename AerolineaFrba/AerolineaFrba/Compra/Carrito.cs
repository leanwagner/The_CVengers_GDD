using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Compra
{
    public partial class Carrito : Form
    {
        int id;


        public Carrito(int id_viaje)
        {
            InitializeComponent();
            id = id_viaje;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button_aEncomienda_Click(object sender, EventArgs e)
        {
            AgregarEncomienda ventana = new AgregarEncomienda(id);
            ventana.Show();
        }

        private void button_aPasaje_Click(object sender, EventArgs e)
        {
            AgregarPasaje ventana = new AgregarPasaje(id);
            ventana.Show();
        }

        
       
    }
}
