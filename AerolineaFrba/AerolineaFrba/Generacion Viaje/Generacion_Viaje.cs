using AerolineaFrba.HoraDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
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
            SqlDateTime fechaActual;
            timePicker1.Format = DateTimePickerFormat.Time;
            timePicker2.Format = DateTimePickerFormat.Time;
            timePicker1.ShowUpDown = true;
            timePicker2.ShowUpDown = true;

            datePicker1.Format = DateTimePickerFormat.Custom;
            datePicker2.Format = DateTimePickerFormat.Custom;
            datePicker1.CustomFormat = "dd/MMM/yyyy";
            datePicker2.CustomFormat = "dd/MMM/yyyy";

            Llenador.LlenadorDeTablas lleni = new Llenador.LlenadorDeTablas();
            lleni.llenarDGV_ABMRutas(dataGridView1);
            dataGridView1.Rows[0].Selected = false;

            //6 7 y 8 son primera clase, ejecutivo y turista
            comboBox1.Enabled = false;
            errorProvider2.Clear();
            errorProvider1.SetError(comboBox1, "Debe seleccionar una ruta");
            button1.Enabled = false;

            MessageBox.Show(DateTimeHandler.devolverFechaDB().ToString());
           

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0)
                return;
            DataGridViewRow select = dataGridView1.SelectedRows[0];

            comboBox1.SelectedIndex = -1;
                comboBox1.Items.Clear();
                comboBox1.Refresh();
                Llenador.LlenadorDeTablas lleni = new Llenador.LlenadorDeTablas();
                String cond = "1=0";

                if (select.Cells[6].Value.ToString().CompareTo("Si")>0)
                {
                    
                    cond = cond + "or AERONAVE_SERVICIO = 1";
                }
                if (select.Cells[7].Value.ToString().CompareTo("Si") > 0)
                {

                    cond = cond + "or AERONAVE_SERVICIO = 2";
                }
                if (select.Cells[8].Value.ToString().CompareTo("Si") > 0)
                {

                    
                    cond = cond + "or AERONAVE_SERVICIO = 3";
                }

                lleni.llenarComboBoxConCondicion(ref comboBox1, "AERONAVE", "AERONAVE_MATRICULA_AVION", cond);
                errorProvider1.Clear();
                errorProvider2.SetError(comboBox1, "Este campo solo muestra los aviones que proveen el servicio de la ruta seleccionada");
                comboBox1.Enabled = true;
                errorProvider3.SetError(timePicker2, "La fecha de llegada debe ser despues de la de salida");
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DateTime.Compare(datePicker1.Value.Date + timePicker1.Value.TimeOfDay, datePicker2.Value.Date + timePicker2.Value.TimeOfDay) < 0)
                errorProvider3.Clear();
            else errorProvider3.SetError(timePicker2, "La fecha de llegada debe ser despues de la de salida");

            if (comboBox1.SelectedIndex != -1 && (DateTime.Compare(datePicker1.Value.Date + timePicker1.Value.TimeOfDay, datePicker2.Value.Date + timePicker2.Value.TimeOfDay) < 0))
            {
                button1.Enabled = true;
               
            }
            else
                button1.Enabled = false;
        }

        private void datePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Compare(datePicker1.Value.Date + timePicker1.Value.TimeOfDay, datePicker2.Value.Date + timePicker2.Value.TimeOfDay) < 0)
                errorProvider3.Clear();
            else errorProvider3.SetError(timePicker2, "La fecha de llegada debe ser despues de la de salida");

            if (DateTime.Compare(datePicker1.Value.Date + timePicker1.Value.TimeOfDay, datePicker2.Value.Date + timePicker2.Value.TimeOfDay) < 0 && comboBox1.SelectedIndex != -1)
            { button1.Enabled = true;
           
            }
            else { button1.Enabled = false;
            
            }
        }

        
    }
}
