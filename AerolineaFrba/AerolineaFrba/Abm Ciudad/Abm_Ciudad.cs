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

namespace AerolineaFrba.Abm_Ciudad
{
    public partial class Abm_Ciudad : Form
    {
        public LlenadorDeTablas llenador = new LlenadorDeTablas();

        public Abm_Ciudad()
        {
            InitializeComponent();
        }

        private void Abm_Ciudad_Load(object sender, EventArgs e)
        {
           
            llenador.llenarDataGridView(dataGridView1, "CIUDAD");
        }

        private void boton_Agregar_Ciudad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            boton_Agregar_Ciudad.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            boton_Modificar.Enabled = true;
        }

        private void boton_Modificar_Click(object sender, EventArgs e)
        {
            DataGridViewRow seleccionado = dataGridView1.SelectedRows[0];
            MessageBox.Show("La ciudad seleccionada es: " + seleccionado.Cells[1].Value.ToString());
        }
    }
}
