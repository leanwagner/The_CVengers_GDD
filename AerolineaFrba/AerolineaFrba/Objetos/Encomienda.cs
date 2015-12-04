﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Objetos
{
    public class Encomienda:TipoItem
    {

            private Int32 Encomienda_kg;
            private int viajeId;

            public Encomienda(Int32 encomienda_kg,int viajeId)
            {
                this.Encomienda_kg = encomienda_kg;
                this.viajeId = viajeId;
                
            }
            public Int32 getEncomienda_kg()
            {
                return this.Encomienda_kg;
            }

        public void persistirItem()
        {
        }

        public float calcularPrecio()
        {
            SqlCommand cmd = new SqlCommand("select THE_CVENGERS.calcularPrecioEncomienda(" + viajeId + ","+Encomienda_kg+") as p", Conexion.getConexion());
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            float retu = float.Parse(reader["p"].ToString());
            reader.Close();
            return retu;
        }

        override public String ToString()
        {
            return "Encomienda - Numero de viaje: " + viajeId + "- Peso: " + Encomienda_kg.ToString() +"Kg - Precio: $" + calcularPrecio().ToString("0.00");
        }

    }
}
