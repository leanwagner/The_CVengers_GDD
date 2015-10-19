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
        public AerolineaFrba()
        {
            InitializeComponent();
        }

        private void AerolineaFrba_Load(object sender, EventArgs e)
        {

        }

        private void boton_Rol_Click(object sender, EventArgs e)
        {
            Abm_Rol.Rol unRol = new Abm_Rol.Rol();
            unRol.Show();
        }
    }
}
