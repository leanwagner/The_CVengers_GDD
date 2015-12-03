using AerolineaFrba.Compra;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Objetos
{
    public class Pasaje : TipoItem
    {
        private Int32 Pasaje_butaca;
        private int viaje_id;

        public Pasaje(Int32 butaca,int viajeId)
        {
            Pasaje_butaca = butaca;
            this.viaje_id = viajeId;
        }

        public Int32 getPasaje_butaca()
        {
            return this.Pasaje_butaca;
        }

        public void persistirItem(int cliente_id)
        {
            string query = "EXEC THE_CVENGERS.crearPasaje @cli= '" + cliente_id.ToString() +
                "', @viaje = '" + viaje_id.ToString() +
                "', @butaca = '" + Pasaje_butaca.ToString() + "'";

            SqlCommand sqlCmd = new SqlCommand(query, Conexion.getConexion());
            sqlCmd.Transaction = Carrito.tran;
            sqlCmd.ExecuteNonQuery();
        }

        public float calcularPrecio() 
        {
            SqlCommand cmd = new SqlCommand("select THE_CVENGERS.calcularPrecioPasaje(" + viaje_id + ") as p", Conexion.getConexion());
            cmd.Transaction = Carrito.tran;
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            float retu = float.Parse(reader["p"].ToString());
            reader.Close();
            return retu;
        }

        override public String ToString()
        {
            return "Pasaje - Numero de viaje: " + viaje_id + "- Butaca: " + Pasaje_butaca.ToString() +"- Precio: $" + calcularPrecio().ToString("0.00"); 
        }

        public void actualizarValoresCancelados()
        {
            Carrito.ListaButacas.Add(Pasaje_butaca);
        }

    }
}
