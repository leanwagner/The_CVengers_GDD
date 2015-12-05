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

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class BajaAeronave : Form
    {
        public string matricula_aeronave;

        public BajaAeronave(string mat)
        {
            InitializeComponent();
            matricula_aeronave = mat;

            dateTimePicker_reinc.Format = DateTimePickerFormat.Custom;
            dateTimePicker_reinc.CustomFormat = "dd/MM/yyyy";
            dateTimePicker_reinc.MinDate = DateTimeHandler.devolverFechaDB();
            
       
        
        }

        private void button1_Click(object sender, EventArgs e) //Mandale cumbia acá
        {
            if (radioButton_bajaTaller.Checked) 
            { 
            
            
            }

            if (radioButton_bajaTotal.Checked)
            { 

            }

            this.Close();
        }

        private int dameIdAeronave(string matricula)
        {
            SqlCommand sqlCmd = new SqlCommand("select AERONAVE_ID from THE_CVENGERS.AERONAVE where AERONAVE_MATRICULA_AVION ='"+ matricula+ "'", Conexion.getConexion());
            SqlDataReader sqlReader;
            sqlReader = sqlCmd.ExecuteReader();
            sqlReader.Read();
            int id = Int32.Parse(sqlReader["AERONAVE_ID"].ToString());
            sqlReader.Close();

            return id;

        }

        private void radioButton_bajaTaller_CheckedChanged(object sender, EventArgs e)
        {
           

            if (radioButton_bajaTotal.Checked)
            {
                dateTimePicker_reinc.Enabled = false;
            }
            if (radioButton_bajaTaller.Checked)
            { dateTimePicker_reinc.Enabled = true; }

        }

        

       
    }
}
