using AerolineaFrba.Llenador;
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

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class DecisionAeronave : Form
    {

        public int id_aeronave;
        public string fecha;
        public DecisionAeronave(int id_aero, string fecha_reinc)
        {
            InitializeComponent();
            this.id_aeronave = id_aero;
            this.fecha=fecha_reinc;
        }

        private void button_reprogramar_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            LlenadorDeTablas lloni = new LlenadorDeTablas();
            lloni.llenarComboBoxAeronaves(ref comboBox_aeronaves, this.id_aeronave);

               

        }

        private void comboBox_aeronaves_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private int dameIdAeronave(string matricula)
        {
            SqlCommand sqlCmd = new SqlCommand("select AERONAVE_ID from THE_CVENGERS.AERONAVE where AERONAVE_MATRICULA_AVION ='" + matricula + "'", Conexion.getConexion());
            SqlDataReader sqlReader;
            sqlReader = sqlCmd.ExecuteReader();
            sqlReader.Read();
            int id = Int32.Parse(sqlReader["AERONAVE_ID"].ToString());
            sqlReader.Close();

            return id;

        }

        private void button_repro_Click(object sender, EventArgs e)
        {
            try
                        {
                            MessageBox.Show("EXEC THE_CVENGERS.suplirAeronaveEsteLapso @avion1 = " + id_aeronave + ", @avion2 = " + dameIdAeronave(comboBox_aeronaves.SelectedItem.ToString()) + ", @fecha = '" + fecha + "'");
                            SqlCommand sqlCmds = new SqlCommand("EXEC THE_CVENGERS.suplirAeronaveEsteLapso @avion1 = " + id_aeronave + ", @avion2 = " + dameIdAeronave(comboBox_aeronaves.SelectedItem.ToString()) + ", @fecha = '" + fecha+"'", Conexion.getConexion());

                            sqlCmds.ExecuteScalar();

                            MessageBox.Show("Se dio de baja la aeronave seleccionada por la de matrícula " + comboBox_aeronaves.SelectedItem.ToString(), "Baja exitosa",MessageBoxButtons.OK);
                            this.Close();
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
        }

    }
    
}
