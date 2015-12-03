using AerolineaFrba.HoraDB;
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

namespace AerolineaFrba.Listado_Estadistico
{
    public partial class Listado_Estadistico : Form
    {
        Llenador.LlenadorDeTablas llenu = new Llenador.LlenadorDeTablas();
        public Listado_Estadistico()
        {
            InitializeComponent();
        }

        private void Listado_Estadistico_Load(object sender, EventArgs e)
        {
           
            llenu.llenarComboBoxAnios(ref comboAnio);
            comboSem.Items.Add(1);
            comboSem.Items.Add(2);
            comboLista.Items.Add("Destinos con mas pasajes comprados");
            comboLista.Items.Add("Destinos con aeronaves mas vacias");
            comboLista.Items.Add("Clientes con mas puntos acumulados");
            comboLista.Items.Add("Destinos con pasajes mas cancelados");
            comboLista.Items.Add("Aeronaves con mas cantidad de dias fuera de servicio");
            dataGridView1.Enabled = false;
           }

        private void comboLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboLista.SelectedIndex == -1 || comboSem.SelectedIndex == -1 || comboAnio.SelectedIndex == -1)
            {
                dataGridView1.Enabled = false;
                estadisticaElejida();
            }
            else { dataGridView1.Enabled = true;
            }
        }

        public void estadisticaElejida()
        {
            switch (comboLista.SelectedIndex) 
            { 
                case 0:
                    llenu.llenarDataGridView(dataGridView1,"THE_CVENGERS.destinosConMasPasajesComprados("+comboAnio.SelectedItem.ToString() +","+comboSem.SelectedItem.ToString() +")");
                    break;
                case 1:
                case 2:
                case 3: 
                case 4:
                default:
                    break;
            }
        }
    }
}
