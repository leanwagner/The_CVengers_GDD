using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Objetos
{
    class Pasaje
    {
        private Int32 Pasaje_codigo;
        private Int32 Pasaje_cliente;
        private Int32 Pasaje_viaje;
        private Int32 Pasaje_compra;

        public Pasaje(Int32 pasaje_codigo, Int32 pasaje_cliente, Int32 pasaje_viaje, Int32 pasaje_compra)
        {
            this.Pasaje_codigo = pasaje_codigo;
            this.Pasaje_cliente = pasaje_cliente;
            this.Pasaje_viaje = pasaje_viaje;
            this.Pasaje_compra = pasaje_compra;
        }

        public Int32 getPasaje_codigo()
        {
            return this.Pasaje_codigo;
        }

        private Int32 getPasaje_cliente()
        {
            return this.Pasaje_cliente;
        }

        private Int32 getPasaje_viaje()
        {
            return this.Pasaje_viaje;
        }

        private Int32 getPasaje_compra()
        {
            return this.Pasaje_compra;
        }


    }
}
