using AerolineaFrba.HoraDB;
using AerolineaFrba.Llenador;
using AerolineaFrba.Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Compra
{
    public partial class Compra : Form
    {
        LlenadorDeTablas llenador = new LlenadorDeTablas();
        object elementoQuitadoTablaDestino;
        object elementoQuitadoTablaOrigen;
        int id_viaje;
        int kgs_disponibles;

        public Compra()
        {
            InitializeComponent();
            this.mostrarViajes();
            llenarCombosCiudad(ref comboBox_destino);
            llenarCombosCiudad(ref comboBox_origen);
            button_continuarCompra.Enabled = false;
            
            mostrarServicios();
            
        }

        private void llenarCombosCiudad(ref ComboBox mi_combo)
        {
            llenador.llenarComboBox(ref mi_combo, "CIUDAD", "CIUDAD_NOMBRE");
        }

        private void comboBox_origen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (elementoQuitadoTablaDestino != null)
                comboBox_destino.Items.Add(elementoQuitadoTablaDestino);

            int indiceElegido = comboBox_destino.Items.IndexOf(comboBox_origen.SelectedItem);
            elementoQuitadoTablaDestino = comboBox_origen.SelectedItem;

            comboBox_destino.Items.RemoveAt(indiceElegido);

            comboBox_destino.Refresh();

            activarBotonLimpiar();


        }

        private void Compra_Load(object sender, EventArgs e)
        {
            dateTimePicker_fechaViaje.Format = DateTimePickerFormat.Custom;
            dateTimePicker_fechaViaje.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dateTimePicker_fechaViaje.MinDate = DateTimeHandler.devolverFechaDB();
            dateTimePicker_fechaViaje.Value = DateTimeHandler.devolverFechaDB();
        }

        private void comboBox_destino_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (elementoQuitadoTablaOrigen != null)
                comboBox_origen.Items.Add(elementoQuitadoTablaOrigen);

            int indiceElegido = comboBox_origen.Items.IndexOf(comboBox_destino.SelectedItem);
            elementoQuitadoTablaOrigen = comboBox_destino.SelectedItem;

            comboBox_origen.Items.RemoveAt(indiceElegido);

            comboBox_origen.Refresh();

            activarBotonLimpiar();
        }

        public void mostrarServicios()
        {

            llenador.llenarCheckedListBox(ref checkedListBox_servicios, "SERVICIO", "SERVICIO_NOMBRE");

        }


        private void button_limpiar_Click(object sender, EventArgs e)
        {
            limpiarForms();
            llenador.llenarDGV_Compra(dataGridView1);
        }

        public void activarBotonLimpiar()
        {
            if (comboBox_destino.SelectedItem != null || comboBox_origen.SelectedItem != null)
                button_limpiar.Enabled = true;
 
        }

        public void limpiarForms()
        {         
            comboBox_destino.Items.Clear();
            llenarCombosCiudad(ref comboBox_destino);
            comboBox_origen.Items.Clear();
            llenarCombosCiudad(ref comboBox_origen);

            elementoQuitadoTablaDestino = null;
            elementoQuitadoTablaOrigen = null;

            foreach (int checkedIndex in checkedListBox_servicios.CheckedIndices)
                checkedListBox_servicios.SetItemChecked(checkedIndex, false);

            dateTimePicker_fechaViaje.Value = dateTimePicker_fechaViaje.MinDate;

            button_limpiar.Enabled = false;
        }

        private void dateTimePicker_fechaViaje_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Compare(dateTimePicker_fechaViaje.Value, dateTimePicker_fechaViaje.MinDate) > 0)
                button_limpiar.Enabled = true;
            else if(comboBox_destino.SelectedItem == null && comboBox_origen.SelectedItem == null && checkedListBox_servicios.CheckedItems.Count < 1 )
                button_limpiar.Enabled = false;
        }

        public void mostrarViajes()
        {
            llenador.llenarDGV_Compra(dataGridView1);
            dataGridView1.ClearSelection(); // esto rompe al carajo si no tengo lleno el DGV
        }

        private void checkedListBox_servicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            activarBotonLimpiar();
        }

        private void checkedListBox_servicios_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                button_limpiar.Enabled = true;

            }
            else if (e.NewValue == CheckState.Unchecked && checkedListBox_servicios.CheckedItems.Count <= 1 && comboBox_destino.SelectedItem == null && comboBox_origen.SelectedItem == null && DateTime.Compare(dateTimePicker_fechaViaje.Value, dateTimePicker_fechaViaje.MinDate) <= 0)
            {
                button_limpiar.Enabled = false;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateTimePicker_fechaViaje.MinDate = dateTimePicker_fechaViaje.MinDate.AddSeconds(1);
        }


        private void button_buscar_Click(object sender, EventArgs e)
        {
            String sqlQuery = "SELECT * FROM THE_CVENGERS.viajesCompra WHERE 1=1";


            if (comboBox_origen.SelectedItem != null)
                sqlQuery = sqlQuery + " AND Origen LIKE '_" + comboBox_origen.SelectedItem.ToString().Substring(1) + "'";

            if (comboBox_destino.SelectedItem != null)
                sqlQuery = sqlQuery + " AND Destino LIKE '_" + comboBox_destino.SelectedItem.ToString().Substring(1) + "'";

            if (DateTime.Compare(dateTimePicker_fechaViaje.Value, dateTimePicker_fechaViaje.MinDate) > 0)
                sqlQuery = sqlQuery + " AND [Fecha de Salida] >= '" + dateTimePicker_fechaViaje.Value.ToString(CultureInfo.InvariantCulture) + "'";

            if (checkedListBox_servicios.CheckedIndices.Count > 0)
            {
                sqlQuery = sqlQuery + "AND (1=0";

                foreach (int index in checkedListBox_servicios.CheckedIndices)
                    sqlQuery = sqlQuery + " OR [Tipo de Servicio] = '" + checkedListBox_servicios.Items[index].ToString() + "'";
                sqlQuery = sqlQuery + ")";
            }

            llenador.filtrarDataGridView(dataGridView1, sqlQuery);
        }


        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            
        }


        private void button_continuarCompra_Click(object sender, EventArgs e)
        {
           
            Carrito ventana = new Carrito(id_viaje,kgs_disponibles);
            


           ventana.Show();
        }

        private void dataGridView1_CellMouseClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            DataGridViewRow seleccionado = dataGridView1.SelectedRows[0];
            id_viaje = Int32.Parse(seleccionado.Cells[0].Value.ToString());
            kgs_disponibles = Int32.Parse(seleccionado.Cells[6].Value.ToString());
            button_continuarCompra.Enabled = true;
        }

        

    }
}
