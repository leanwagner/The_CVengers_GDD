using AerolineaFrba.HoraDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Generacion_Viaje
{
    public partial class Generacion_Viaje : Form
    {
        DataGridViewRow select;
        
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
            dataGridView1.Rows[0].Selected = false;

            //6 7 y 8 son primera clase, ejecutivo y turista
            comboBox1.Enabled = false;
            errorProvider2.Clear();
            errorProvider1.SetError(comboBox1, "Debe seleccionar una ruta");
            button1.Enabled = false;

            datePicker1.MinDate = DateTimeHandler.devolverFechaDB();
            timePicker1.MinDate = DateTimeHandler.devolverFechaDB();

            datePicker1.Value = DateTimeHandler.devolverFechaDB();
            timePicker1.Value = DateTimeHandler.devolverFechaDB();


        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0)
                return;
           select = dataGridView1.SelectedRows[0];

            comboBox1.SelectedIndex = -1;
                comboBox1.Items.Clear();
                comboBox1.Refresh();
                Llenador.LlenadorDeTablas lleni = new Llenador.LlenadorDeTablas();
                String cond = "(1=0";

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

                cond = cond + ") and AERONAVE_ESTADO = 1 and not exists(select * from THE_CVENGERS.TALLER where TALLER_AERONAVE_ID = AERONAVE_ID and THE_CVENGERS.fechaReal() between TALLER_FECHA_ENTRADA and TALLER_FECHA_SALIDA)";

                lleni.llenarComboBoxConCondicion(ref comboBox1, "AERONAVE", "AERONAVE_MATRICULA_AVION", cond);
                errorProvider1.Clear();
                errorProvider2.SetError(comboBox1, "Este campo solo muestra los aviones que proveen el servicio de la ruta seleccionada");
                comboBox1.Enabled = true;
               
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (comboBox1.SelectedIndex != -1)
            {
                button1.Enabled = true;
               
            }
            else
                button1.Enabled = false;
        }

        private void datePicker1_ValueChanged(object sender, EventArgs e)
        {
            datePicker2.MinDate = datePicker1.Value.AddMinutes(5);
            timePicker2.MinDate = datePicker1.Value.AddMinutes(5);
           // datePicker2.MaxDate = datePicker1.Value.AddDays(1);
           // timePicker2.MaxDate = datePicker1.Value.AddDays(1);

          
            if (comboBox1.SelectedIndex != -1)
            { button1.Enabled = true;
           
            }
            else { button1.Enabled = false;
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCmd = new SqlCommand("select * from THE_CVENGERS.AERONAVE where AERONAVE_MATRICULA_AVION ='" + comboBox1.SelectedItem.ToString() + "'", Conexion.getConexion());
            SqlDataReader sqlReader;
            sqlReader = sqlCmd.ExecuteReader();
            sqlReader.Read();
            String idAero = sqlReader["AERONAVE_ID"].ToString();
            sqlReader.Close();

            sqlCmd.CommandText = "exec THE_CVENGERS.generarViaje @aeronave = " + idAero +
                ", @ruta =" + select.Cells[0].Value.ToString() +
                ", @salida = '" + (datePicker1.Value.Date + timePicker1.Value.TimeOfDay).ToString(CultureInfo.InvariantCulture) +
                "', @llegadaest = '" + (datePicker2.Value.Date + timePicker2.Value.TimeOfDay).ToString(CultureInfo.InvariantCulture) + "'";
            //MessageBox.Show(sqlCmd.CommandText);
            try
            {
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Viaje generado exitosamente");
                comboBox1.SelectedIndex = -1;
                datePicker1.Value = datePicker1.MinDate;
                timePicker1.Value = timePicker1.MinDate;
                datePicker2.Value = datePicker2.MinDate;
                timePicker2.Value = timePicker2.MinDate;
                dataGridView1.ClearSelection();
                comboBox1.Items.Clear();
                errorProvider1.SetError(comboBox1, "Debe seleccionar una ruta");
                errorProvider2.Clear();
                comboBox1.Enabled = false;
            }
            catch (Exception exc) {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK);
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            datePicker1.MinDate = datePicker1.MinDate.AddSeconds(1);
            timePicker1.MinDate = timePicker1.MinDate.AddSeconds(1);
        }

        
    }
}
