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

namespace AerolineaFrba.Devolucion
{
    public partial class Devolucion : Form
    {

        Llenador.LlenadorDeTablas lleni = new Llenador.LlenadorDeTablas();
        String idClie;
        public Devolucion()
        {
            InitializeComponent();
            
        }

        private void dniBox_ValueChanged(object sender, EventArgs e)
        {
            if (dniBox.Value == 0)
                return;
            nombreCombo.Items.Clear();
            lleni.llenarComboBoxConCondicion(ref nombreCombo, "CLIENTE", "CLIENTE_APELLIDO", "CLIENTE_DNI = " + dniBox.Value.ToString());
            if (nombreCombo.Items.Count > 1)
            {
                label2.Visible = true;
                nombreCombo.Visible = true;
                errorDniDup.SetError(nombreCombo, "Ese DNI esta duplicado, debe seleccionar un cliente para continuar");
            }
            else
            {
                label2.Visible = false;
                nombreCombo.Visible = false;
            }

            if (nombreCombo.Items.Count == 1)
            {
                SqlCommand cmd = new SqlCommand("select * from THE_CVENGERS.CLIENTE where CLIENTE_DNI = " + dniBox.Value.ToString(), Conexion.getConexion());
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                idClie = reader["CLIENTE_ID"].ToString();
                reader.Close();
                lleni.llenarDataGridViewDevolucion(dataGridView1, idClie);
                dataGridView1.ClearSelection();
               // this.Size = new Size(226, 332);
            }
            else
            {
              //  this.Size = new Size(226, 113);
            }

        }

        private void nombreCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorDniDup.Clear();
            SqlCommand cmd = new SqlCommand("select * from THE_CVENGERS.CLIENTE where CLIENTE_DNI = " + dniBox.Value.ToString() + "and CLIENTE_APELLIDO ='" + nombreCombo.SelectedItem.ToString() + "'", Conexion.getConexion());
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            idClie = reader["CLIENTE_ID"].ToString();
            reader.Close();
            lleni.llenarDataGridViewDevolucion(dataGridView1, idClie);
            dataGridView1.ClearSelection();
          //  this.Size = new Size(226, 332);
            
          
        
        }

        private void Devolucion_Load(object sender, EventArgs e)
        {
           // this.Size = new Size(226, 113);
        }
    }
}
