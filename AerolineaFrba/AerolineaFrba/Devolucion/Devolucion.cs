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
        String idComp;
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
                dataGridView1.ClearSelection();
                dataGridView1.DataSource = null;//  this.Size = new Size(226, 113);
                razonText.ResetText();
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
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            if (dataGridView1.SelectedRows.Count == 0)
            {
                errorRazon.Clear();
                errorList.Clear();
                return;
                
                
            }
            DataGridViewRow select = dataGridView1.SelectedRows[0];
            idComp= select.Cells[1].Value.ToString();
            SqlCommand cmd = new SqlCommand("select * from THE_CVENGERS.itemsDeCompra( "+idComp+")",Conexion.getConexion());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                checkedListBox1.Items.Add(new ItemsDevolucion(reader["Número de item"].ToString(), reader["Tipo"].ToString(), reader["Precio"].ToString()));
            }
            reader.Close();

            if (dataGridView1.SelectedRows.Count != 0)
            {
                errorRazon.SetError(razonText, "Debe ingresar un motivo");

                errorList.SetError(checkedListBox1, "Debe seleccionar al menos un item");
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if(razonText.TextLength == 0)
                errorRazon.SetError(razonText,"Debe ingresar un motivo");
            else errorRazon.Clear();

                if(checkedListBox1.CheckedIndices.Count <= 1 && e.NewValue == CheckState.Unchecked)
                    errorList.SetError(checkedListBox1,"Debe seleccionar al menos un item");
                else if(e.NewValue == CheckState.Checked)
                    errorList.Clear();



            if (e.NewValue == CheckState.Checked && razonText.TextLength != 0)
                buttonDev.Enabled = true;
            else if ((e.NewValue == CheckState.Unchecked && checkedListBox1.CheckedIndices.Count <= 1) || razonText.TextLength == 0)
                buttonDev.Enabled = false;
        }

        private void razonText_TextChanged(object sender, EventArgs e)
        {

             if(razonText.TextLength == 0)
                errorRazon.SetError(razonText,"Debe ingresar un motivo");
            else errorRazon.Clear();

                if(checkedListBox1.CheckedIndices.Count == 0)
                    errorList.SetError(checkedListBox1,"Debe seleccionar al menos un item");
                else errorList.Clear();
            if (razonText.TextLength != 0 && checkedListBox1.CheckedIndices.Count != 0)
                buttonDev.Enabled = true;
            else if (checkedListBox1.CheckedIndices.Count == 0 || razonText.TextLength == 0)
                buttonDev.Enabled = false;
        }

        private void buttonDev_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("Todavia no esta el procedure");

            SqlTransaction transaction = Conexion.getConexion().BeginTransaction();
            try
            {
                SqlCommand cmd = new SqlCommand("exec THE_CVENGERS.crearDevolucion @compra = " + idComp + ", @descripcion= '" + razonText.Text + "'", Conexion.getConexion());
                cmd.Transaction = transaction;
                cmd.ExecuteNonQuery();
                //   MessageBox.Show(cmd.CommandText);
                foreach (object dev in checkedListBox1.CheckedItems)
                {
                    cmd.CommandText = "exec THE_CVENGERS.devolverItem @item = " + ((ItemsDevolucion)dev).getNumero() + ", @tipoItem = '" + ((ItemsDevolucion)dev).getTipo() + "'";
                    cmd.ExecuteNonQuery();
                    //  MessageBox.Show(cmd.CommandText);
                }
                transaction.Commit();
                mandarMensajeDeExito();
                razonText.ResetText();
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                    checkedListBox1.SetItemCheckState(i, (CheckState.Unchecked));
                checkedListBox1.Refresh();
                foreach (int it in checkedListBox1.CheckedIndices) { checkedListBox1.Items.RemoveAt(it); }
                lleni.llenarDataGridViewDevolucion(dataGridView1, idClie);
                dataGridView1.ClearSelection();



            }
            catch (Exception exc)
            {
                if(exc is SqlException)
                transaction.Rollback();
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK);

            }
            


            
        }


        public void mandarMensajeDeExito()
        {
            SqlCommand cmd = new SqlCommand("select * from THE_CVENGERS.COMPRA where COMPRA_ID = "+ idComp, Conexion.getConexion());
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
           bool sw = bool.Parse(rd["COMPRA_FORMA_DE_PAGO"].ToString());
            rd.Close();
            float monto = 0f;
             foreach (int it in checkedListBox1.CheckedIndices) { monto += float.Parse(((ItemsDevolucion)checkedListBox1.Items[it]).getPrecio()); }
            
            String mens = "La devolucion se ha realizado con exito. El monto de $"+ monto.ToString();
            if (!sw)
                mens += " sera retribuido en efectivo.";
            else
            {
                
                mens += " sera retribuido a la tarjeta";
            }
            MessageBox.Show(mens);
        }

    }

}
