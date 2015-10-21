using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Ciudad
{
    public partial class Abm_Ciudad : Form
    {
        public Abm_Ciudad()
        {
            InitializeComponent();
        }

        private void Abm_Ciudad_Load(object sender, EventArgs e)
        {
            Conexion.llenarTabla(dataGridView1, "CIUDAD");
        }
    }
}
