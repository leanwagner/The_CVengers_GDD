using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Registro_Llegada_Destino
{
    public partial class Registro_LlegadaDestino : Form
    {
        public Registro_LlegadaDestino()
        {
            InitializeComponent();
        }

        private void Registro_LlegadaDestino_Load(object sender, EventArgs e)
        {
            dateTimePicker_HoraLlegada.Format = DateTimePickerFormat.Time;
            dateTimePicker_HoraLlegada.ShowUpDown = true;
        }

     

        
    }
}
