using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Objetos
{
    class Encomienda
    {

            private Int32 Encomienda_codigo;
            private Int32 Encomienda_cliente_id;
            private Int32 Encomienda_viaje_id;
            private Int32 Encomienda_kg;
            private Int32 Encomienda_compra;

            public Encomienda(Int32 encomienda_codigo, Int32 encomienda_cliente_id, Int32 encomienda_viaje_id, Int32 encomienda_kg, Int32 encomienda_compra)
            {
                this.Encomienda_codigo = encomienda_codigo;
                this.Encomienda_cliente_id = encomienda_cliente_id;
                this.Encomienda_viaje_id = encomienda_viaje_id;
                this.Encomienda_kg = encomienda_kg;
                this.Encomienda_compra = encomienda_compra;
            }

            public Int32 getEncomienda_codigo()
            {
                return this.Encomienda_codigo;
            }

            public Int32 getEncomienda_cliente()
            {
                return this.Encomienda_cliente_id;
            }

            public Int32 getEncomienda_viaje()
            {
                return this.Encomienda_viaje_id;
            }

            public Int32 getEncomienda_kg()
            {
                return this.Encomienda_kg;
            }

            public Int32 getEncomienda_compra()
            {
                return this.Encomienda_compra;
            }


    }
}
