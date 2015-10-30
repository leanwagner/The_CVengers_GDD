using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Generacion_Viaje
{
    public partial class Generacion_Viaje : Form
    {
        public Generacion_Viaje()
        {
            InitializeComponent();
        }

        private void Generacion_Viaje_Load(object sender, EventArgs e)
        {
            dateTimePicker_Salida.Format = DateTimePickerFormat.Time;
            dateTimePicker_Salida.ShowUpDown = true;
          
        }

        
    }
}
