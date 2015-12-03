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
        int origWidth;
       
        public Listado_Estadistico()
        {
            InitializeComponent();
            origWidth = dataGridView1.Width;
            
        }

        private void Listado_Estadistico_Load(object sender, EventArgs e)
        {
           
            llenu.llenarComboBoxAnios(ref comboAnio);
            label3.Visible = false;
            comboSem.Visible = false;
            comboLista.Items.Add("Destinos con mas pasajes comprados");
            comboLista.Items.Add("Destinos con aeronaves mas vacias");
            comboLista.Items.Add("Clientes con mas puntos acumulados");
            comboLista.Items.Add("Destinos con pasajes mas cancelados");
            comboLista.Items.Add("Aeronaves con mas cantidad de dias fuera de servicio");
            dataGridView1.Visible = false;
            this.Size = new Size(498,137);
            button1.Enabled = false;
            errorProvider1.SetError(button1, "Debe seleccionar todos los campos");
           }

        private void comboLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender == comboAnio && comboLista.SelectedIndex != -1) || (sender == comboLista && comboAnio.SelectedIndex != -1))
            {

                comboSem.SelectedIndex = -1;
                comboSem.Items.Clear();
                label3.Visible = true;
                comboSem.Visible = true;
                llenu.llenarComboBoxSemestre(ref comboSem, Int32.Parse(comboAnio.SelectedItem.ToString()),comboLista.SelectedIndex);
                if (comboSem.Items.Count == 1) errorProvider2.SetError(comboSem, "Solo se encuentran datos de un semestre");
                else errorProvider2.Clear();
            }

            if (comboLista.SelectedIndex == -1 || comboSem.SelectedIndex == -1 || comboAnio.SelectedIndex == -1)
            {
                dataGridView1.Visible = false;
                button1.Enabled = false;
                errorProvider1.SetError(button1, "Debe seleccionar todos los campos");
                this.Size = new Size(498, 137);
                
            }
            else { dataGridView1.Visible = true;
            button1.Enabled = true;
            errorProvider1.Clear();
            }
        }

        public void estadisticaElejida()
        {
            switch (comboLista.SelectedIndex) 
            { 
                case 0:
                    llenu.llenarDataGridView(dataGridView1,"destinosConMasPasajesComprados("+comboAnio.SelectedItem.ToString() +","+comboSem.SelectedItem.ToString() +")");
                    achicarYCentrarDGV();
                    break;
                case 1:
                    llenu.llenarDataGridView(dataGridView1, "destinosConAeronavesMasVacias(" + comboAnio.SelectedItem.ToString() + "," + comboSem.SelectedItem.ToString() + ")");
                    achicarYCentrarDGV();
                    break;
                case 2:
                    llenu.llenarDataGridView(dataGridView1, "clientesConMasPuntosAcumulados(" + comboAnio.SelectedItem.ToString() + "," + comboSem.SelectedItem.ToString() + ")");
                    achicarYCentrarDGV();
                    break;
                case 3: 
                     llenu.llenarDataGridView(dataGridView1, "destinosConMasPasajesCancelados(" + comboAnio.SelectedItem.ToString() + "," + comboSem.SelectedItem.ToString() + ")");
                    achicarYCentrarDGV();
                    break;
                case 4:
                default:
                    break;
            }
        }

        public void achicarYCentrarDGV() 
        {
            int nuevoLargo = dataGridView1.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width) + (dataGridView1.RowHeadersVisible ? dataGridView1.RowHeadersWidth : 0) + 3;
            if (nuevoLargo < origWidth)
                dataGridView1.Width = nuevoLargo;
            dataGridView1.Location = new Point(this.Size.Width / 2 - dataGridView1.Width / 2, dataGridView1.Location.Y);
                   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            estadisticaElejida();
            this.Size = new Size(498, 316);
           
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}
