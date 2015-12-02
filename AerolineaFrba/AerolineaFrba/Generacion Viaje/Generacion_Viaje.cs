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
            //dataGridView1.Rows[0].Selected = true;

            //6 7 y 8 son primera clase, ejecutivo y turista
            comboBox1.Enabled = false;
            errorProvider1.SetError(comboBox1, "Debe seleccionar una ruta");
            button1.Enabled = false;

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
                comboBox1.Enabled = true;
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        
    }
}
