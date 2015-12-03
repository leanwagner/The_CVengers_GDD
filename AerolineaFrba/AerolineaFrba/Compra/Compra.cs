﻿using AerolineaFrba.HoraDB;
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

namespace AerolineaFrba.Compra
{
    public partial class Compra : Form
    {
        LlenadorDeTablas llenador = new LlenadorDeTablas();
        object elementoQuitadoTablaDestino;
        object elementoQuitadoTablaOrigen;

        public Compra()
        {
            InitializeComponent();
            this.mostrarViajes();
            numericUpDown_encomiendas.Minimum = 0;
            numericUpDown_pasajes.Minimum = 0;
            llenarCombosCiudad(ref comboBox_destino);
            llenarCombosCiudad(ref comboBox_origen);
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
            dateTimePicker_fechaViaje.CustomFormat = "yyyy-MM-dd HH:mm:ss";
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
            else if(comboBox_destino.SelectedItem == null && comboBox_origen.SelectedItem == null && checkedListBox_servicios.CheckedItems.Count > 1 )
                button_limpiar.Enabled = false;
        }

        public void mostrarViajes()
        {
            llenador.llenarDGV_Compra(dataGridView1);
            dataGridView1.Rows[0].Selected = false;
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


    }
}
