using AerolineaFrba.HoraDB;
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

        private void button1_Click(object sender, EventArgs e) 
        {
            if (radioButton_bajaTaller.Checked) 
            { 

                try
             {
                 SqlCommand sqlCmd = new SqlCommand("SELECT THE_CVENGERS.aeronaveConViajesPendientesEnEseLapso (" + dameIdAeronave(this.matricula_aeronave) + ",'"+dateTimePicker_reinc.Value.ToString(CultureInfo.InvariantCulture)+"')", Conexion.getConexion());



                 if ((int)sqlCmd.ExecuteScalar() == 0)
                 {
                     try
                     {
                         SqlCommand sqlCmdf = new SqlCommand("EXEC THE_CVENGERS.puedeIrATaller @avion=" + dameIdAeronave(this.matricula_aeronave) + "", Conexion.getConexion());

                         sqlCmdf.ExecuteScalar();


                         try
                         {
                             SqlCommand sqlCmds = new SqlCommand("EXEC THE_CVENGERS.mandarATallerHastaFecha @avion=" + dameIdAeronave(this.matricula_aeronave) + ", @fecha='"+dateTimePicker_reinc.Value.ToString(CultureInfo.InvariantCulture) +"'", Conexion.getConexion());
                             
                             sqlCmds.ExecuteScalar();
                             
                             MessageBox.Show("Se mandó la aeronave "+this.matricula_aeronave+ " hasta el "+dateTimePicker_reinc.Value.ToString(CultureInfo.InvariantCulture), "Baja exitosa");
                         }
                         catch
                         {
                             MessageBox.Show("Rompio mandarATallerHastaFecha");
                         }

                     }
                     catch(Exception ex)
                     {
                         MessageBox.Show(ex.Message);
                     }

                 }
                 else
                 {
                     DecisionAeronave ventana = new DecisionAeronave(dameIdAeronave(this.matricula_aeronave), dateTimePicker_reinc.Value.ToString(CultureInfo.InvariantCulture));
                     ventana.Show();
                 }

            }
            catch
            {
                MessageBox.Show("Rompio aeronaveConViajesPendientes");
            }

            }

            if (radioButton_bajaTotal.Checked)
            {

                try
                {
                    SqlCommand sqlCmd = new SqlCommand("SELECT THE_CVENGERS.aeronaveConViajesPendientes (" + dameIdAeronave(this.matricula_aeronave) + ")", Conexion.getConexion());



                    if ((int)sqlCmd.ExecuteScalar() == 0)
                    {


                        try
                        {
                            SqlCommand sqlCmds = new SqlCommand("EXEC THE_CVENGERS.darDeBajaVitaliciaAeronave @avion=" + dameIdAeronave(this.matricula_aeronave) + "", Conexion.getConexion());

                            sqlCmds.ExecuteScalar();

                            MessageBox.Show("Se dio de baja la aeronave " + this.matricula_aeronave + " de manera vitalicia.", "Baja exitosa");
                        }
                        catch
                        {
                            MessageBox.Show("Rompio darDeBajaVitaliciaAeronave");
                        }

                    }
                    else
                    {

                        DecisionAeronave ventana = new DecisionAeronave(dameIdAeronave(this.matricula_aeronave),"");
                        ventana.Show();
                 
                    }


                }
                catch
                {
                    MessageBox.Show("Rompio aeronave con viajes pendientes");
                }
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
