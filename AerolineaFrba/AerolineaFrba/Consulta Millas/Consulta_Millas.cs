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

namespace AerolineaFrba.Consulta_Millas
{
    public partial class Consulta_Millas : Form
    {
        public Consulta_Millas()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            if (dniBox.Text.Length == 0)
            {
                notFound.Clear();
                errorDni.SetError(dniBox, "Debe ingresar el numero de DNI");
            }
            else errorDni.Clear();
            if (nameBox.Text.Length == 0)
            {
                errorName.SetError(nameBox, "Debe ingresar su apellido");
                notFound.Clear();
            }
            else errorName.Clear();

           
            if (dniBox.Text.Length == 0 || nameBox.Text.Length == 0)
                return;

            SqlCommand cmd = new SqlCommand("select * from THE_CVENGERS.CLIENTE where CLIENTE_DNI = " + dniBox.Text + "and CLIENTE_APELLIDO COLLATE Latin1_General_CI_AI like '" + nameBox.Text + "' COLLATE Latin1_General_CI_AI", Conexion.getConexion());
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (nameBox.Text.Length != 0 && dniBox.Text.Length != 0 && !reader.HasRows)
            {
                notFound.SetError(millasLabel, "No se encuentran datos de millas para esos datos");
                this.Size = new Size(300, 106);
                this.Refresh();

                groupBox1.Enabled = false;
                dataGridView1.Enabled = false;
            }
            else
            {
                notFound.Clear();
                this.Size = new Size(300, 321);
                this.Refresh();

                groupBox1.Enabled = true;
                dataGridView1.Enabled = true;
            }
            if (!reader.HasRows)
            {
                reader.Close();
                return;
            }
            String idClie = reader["CLIENTE_ID"].ToString();
            reader.Close();
            SqlDataAdapter adapter;
            DataTable tabla;

            try
            {
                adapter = new SqlDataAdapter("select MILLA_FECHA_ACREDITACION 'Fecha',(MILLA_GANADA - MILLA_GASTADA) 'Millas disponibles' from THE_CVENGERS.MILLA where MILLA_CLIENTE = " + idClie, Conexion.getConexion());
                tabla = new DataTable();

                adapter.Fill(tabla);
                dataGridView1.DataSource = tabla;
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                adapter.Dispose();
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK);


            }
        
        }

        private void Consulta_Millas_Load(object sender, EventArgs e)
        {
              errorDni.SetError(dniBox, "Debe ingresar el numero de DNI");
       
                errorName.SetError(nameBox, "Debe ingresar su apellido");
                groupBox1.Enabled = false;
                dataGridView1.Enabled = false;
                this.Size = new Size(300, 106);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}
