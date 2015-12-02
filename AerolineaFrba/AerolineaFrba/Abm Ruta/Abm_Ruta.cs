using AerolineaFrba.Llenador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Ruta
{
    public partial class Abm_Ruta : Form
    {

        LlenadorDeTablas llenador = new LlenadorDeTablas();
        object elementoQuitadoTablaDestino;
        object elementoQuitadoTablaOrigen;
        object quitadoFiltroOrigen;
        object quitadoFiltroDestino;

        public Abm_Ruta()
        {
            InitializeComponent();
            this.mostrarServicios();
            this.mostrarCiudad(ref comboBox_ciudadOrigen);
            this.mostrarCiudad(ref comboBox_ciudadDestino);
            this.mostrarCiudad(ref comboBox_filtroOrigen);
            this.mostrarCiudad(ref comboBox_filtroDestino);
            comboBox_ciudadOrigen.Focus();
            this.mostrarRutas();
        }

        public void inicializarTodoAFabrica()
        {


            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            comboBox_ciudadDestino.Items.Clear();
            mostrarCiudad(ref comboBox_ciudadDestino);
            comboBox_ciudadOrigen.Items.Clear();
            mostrarCiudad(ref comboBox_ciudadOrigen);
           
            elementoQuitadoTablaDestino = null;
            elementoQuitadoTablaOrigen = null;

            foreach (int checkedIndex in checkedListBox_servicios.CheckedIndices)
                checkedListBox_servicios.SetItemChecked(checkedIndex, false);
            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void boton_Modificar_Click(object sender, EventArgs e)
        {
           
            
            DataGridViewRow seleccionado = dataGridView_listadoRutas.SelectedRows[0];

            RutaModificar rutaAModificar = new RutaModificar(Int32.Parse(seleccionado.Cells[0].Value.ToString()), Int32.Parse(seleccionado.Cells[1].Value.ToString()), seleccionado.Cells[2].Value.ToString(), seleccionado.Cells[3].Value.ToString(), System.Convert.ToDecimal(seleccionado.Cells[4].Value.ToString()), System.Convert.ToDecimal(seleccionado.Cells[5].Value.ToString()), seleccionado.Cells[6].Value.ToString(), seleccionado.Cells[7].Value.ToString(),seleccionado.Cells[8].Value.ToString());

            rutaAModificar.Show();

        }

        private void Abm_Ruta_Load(object sender, EventArgs e)
        {

        }

        public void mostrarServicios()
        {

            llenador.llenarCheckedListBox(ref checkedListBox_servicios,"SERVICIO","SERVICIO_NOMBRE");

        }

        public void mostrarCiudad(ref ComboBox miCombo)
        {
            llenador.llenarComboBox(ref miCombo, "CIUDAD", "CIUDAD_NOMBRE");

        }

        public void mostrarRutas()
        {
            llenador.llenarDGV_ABMRutas(dataGridView_listadoRutas);
        }
      
        private void comboBox_ciudadOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if(elementoQuitadoTablaDestino != null)
            comboBox_ciudadDestino.Items.Add(elementoQuitadoTablaDestino);

            int indiceElegido = comboBox_ciudadDestino.Items.IndexOf(comboBox_ciudadOrigen.SelectedItem);
            elementoQuitadoTablaDestino = comboBox_ciudadOrigen.SelectedItem;

            comboBox_ciudadDestino.Items.RemoveAt(indiceElegido);

            comboBox_ciudadDestino.Refresh();
        }

        private void comboBox_ciudadDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (elementoQuitadoTablaOrigen!= null)
                comboBox_ciudadOrigen.Items.Add(elementoQuitadoTablaOrigen);

            int indiceElegido = comboBox_ciudadOrigen.Items.IndexOf(comboBox_ciudadDestino.SelectedItem);
            elementoQuitadoTablaOrigen = comboBox_ciudadDestino.SelectedItem;
                
            comboBox_ciudadOrigen.Items.RemoveAt(indiceElegido);

            comboBox_ciudadOrigen.Refresh();
        }

        private void button_agregarRuta_Click(object sender, EventArgs e)
        {
            
            String servicio1 = "NULL";
            String servicio2 = "NULL";
            String servicio3 = "NULL";

            if(checkedListBox_servicios.CheckedItems.Contains(checkedListBox_servicios.Items[0]))
                servicio1 = checkedListBox_servicios.Items[0].ToString();

            if(checkedListBox_servicios.CheckedItems.Contains(checkedListBox_servicios.Items[1]))
                servicio2 = checkedListBox_servicios.Items[1].ToString();

            if(checkedListBox_servicios.CheckedItems.Contains(checkedListBox_servicios.Items[2]))
                servicio3 = checkedListBox_servicios.Items[2].ToString();

            if (comboBox_ciudadOrigen.SelectedItem != null && comboBox_ciudadDestino.SelectedItem != null && numericUpDown1.Value > 0 && numericUpDown2.Value > 0)
            {
                errorProvider_ciudadDestino.Clear();
                errorProvider_ciudadOrigen.Clear();
                errorProvider_precioKg.Clear();
                errorProvider_precioPasaje.Clear();
                errorProvider_Servicios.Clear();

                try
                {
                       SqlCommand sqlCmd = new SqlCommand("EXEC THE_CVENGERS.creacionRuta @P1 = " + numericUpDown3.Value +

                        ", @P2 = '" + comboBox_ciudadOrigen.SelectedItem.ToString().Substring(1) +
                        "', @P3 = '" + comboBox_ciudadDestino.SelectedItem.ToString().Substring(1) +

                        "', @P4 = '" + numericUpDown1.Value.ToString(CultureInfo.InvariantCulture) +
                        "', @P5 = '" + numericUpDown2.Value.ToString(CultureInfo.InvariantCulture) +
                        "', @P6 = '" + servicio1 +
                        "', @P7 = " + servicio2 +
                        ", @P8 = " + servicio3, Conexion.getConexion());

                    sqlCmd.ExecuteScalar();

                    
                    MessageBox.Show("La Ruta ha sido creada con éxito.");

                    inicializarTodoAFabrica();

                    llenador.llenarDGV_ABMRutas(dataGridView_listadoRutas);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
            }

            else
            {
                if (comboBox_ciudadOrigen.SelectedItem == null)
                    errorProvider_ciudadOrigen.SetError(comboBox_ciudadOrigen, "Por favor seleccione una ciudad de Origen");
                else errorProvider_ciudadOrigen.Clear();


                if (comboBox_ciudadDestino.SelectedItem == null)
                    errorProvider_ciudadDestino.SetError(comboBox_ciudadDestino, "Por favor seleccione una ciudad de Destino");
                else errorProvider_ciudadDestino.Clear();

                if (checkedListBox_servicios.CheckedItems.Count == 0)
                    errorProvider_Servicios.SetError(checkedListBox_servicios, "Por favor seleccione al menos un servicio");
                else errorProvider_Servicios.Clear();

                if (numericUpDown1.Value <= 0)
                    errorProvider_precioKg.SetError(numericUpDown1, "Por favor seleccione un número mayor que cero");
                else
                    errorProvider_precioKg.Clear();

                if (numericUpDown2.Value <= 0)
                    errorProvider_precioPasaje.SetError(numericUpDown2, "Por favor seleccione un número mayor que cero");
                else
                    errorProvider_precioPasaje.Clear();
            }
        }

        private void dataGridView_listadoRutas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
            button_modificarRuta.Enabled = true;
            
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            String sqlQuery = "SELECT * FROM THE_CVENGERS.RutasDisponibles WHERE 1=1";
            

            if (comboBox_filtroOrigen.SelectedItem != null)
                sqlQuery = sqlQuery + " AND Origen LIKE '_" + comboBox_filtroOrigen.SelectedItem.ToString().Substring(1) + "'";

            if (comboBox_filtroDestino.SelectedItem != null)
                sqlQuery = sqlQuery + " AND Destino LIKE '_" + comboBox_filtroDestino.SelectedItem.ToString().Substring(1) + "'";

            if (numericUpDown_kgHasta.Value > numericUpDown_kgDesde.Value)
            {
                errorProvider_precioKgHasta.Clear();
                sqlQuery = sqlQuery + " AND [Precio Base Por Kilo] BETWEEN " + numericUpDown_kgDesde.Value.ToString(CultureInfo.InvariantCulture) + " AND " + numericUpDown_kgHasta.Value.ToString(CultureInfo.InvariantCulture);
            }
            else
                errorProvider_precioKgHasta.SetError(numericUpDown_kgHasta, "El valor del Campo Hasta debe ser mayor al del campo Desde");

            if (numericUpDown_pasajeHasta.Value > numericUpDown_pasajeDesde.Value)
            {
                errorProvider_precioPasajeHasta.Clear();
                sqlQuery = sqlQuery + " AND [Precio Base Por Pasaje] BETWEEN " + numericUpDown_pasajeDesde.Value.ToString(CultureInfo.InvariantCulture) + " AND " + numericUpDown_pasajeHasta.Value.ToString(CultureInfo.InvariantCulture);
            }
            else
                errorProvider_precioPasajeHasta.SetError(numericUpDown_pasajeHasta, "El valor del Campo Hasta debe ser mayor al del campo Desde");


            if (myNumericUpDown_codRuta.Text != "")
                sqlQuery = sqlQuery + " AND [Código de Rutas] = " + myNumericUpDown_codRuta.Value.ToString();

            llenador.filtrarDataGridView(dataGridView_listadoRutas, sqlQuery);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown_kgDesde.Value = 0;
            numericUpDown_kgHasta.Value = 0;
            numericUpDown_pasajeDesde.Value = 0;
            numericUpDown_pasajeHasta.Value = 0;
            myNumericUpDown_codRuta.Value = -1;

            comboBox_filtroDestino.Items.Clear();
            mostrarCiudad(ref comboBox_filtroDestino);
            comboBox_filtroOrigen.Items.Clear();
            mostrarCiudad(ref comboBox_filtroOrigen);

            quitadoFiltroDestino = null;
            quitadoFiltroOrigen = null;

            llenador.llenarDGV_ABMRutas(dataGridView_listadoRutas);
            errorProvider_precioKgHasta.Clear();
            errorProvider_precioPasajeHasta.Clear();

        }

        private void comboBox_filtroOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (quitadoFiltroDestino != null)
                comboBox_filtroDestino.Items.Add(quitadoFiltroDestino);

            int indiceElegido = comboBox_filtroDestino.Items.IndexOf(comboBox_filtroOrigen.SelectedItem);
            quitadoFiltroDestino = comboBox_filtroOrigen.SelectedItem;

            comboBox_filtroDestino.Items.RemoveAt(indiceElegido);

            comboBox_filtroDestino.Refresh();
        }

        private void comboBox_filtroDestino_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (quitadoFiltroOrigen != null)
                comboBox_filtroOrigen.Items.Add(quitadoFiltroOrigen);

            int indiceElegido = comboBox_filtroOrigen.Items.IndexOf(comboBox_filtroDestino.SelectedItem);
            quitadoFiltroOrigen = comboBox_filtroDestino.SelectedItem;

            comboBox_filtroOrigen.Items.RemoveAt(indiceElegido);

            comboBox_filtroOrigen.Refresh();
        }

    }

}
