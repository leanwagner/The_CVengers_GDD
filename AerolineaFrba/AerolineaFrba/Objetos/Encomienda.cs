using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Objetos
{
    public class Encomienda:TipoItem
    {

            private Int32 Encomienda_kg;
            

            public Encomienda(Int32 encomienda_kg)
            {
                this.Encomienda_kg = encomienda_kg;
                
            }
            public Int32 getEncomienda_kg()
            {
                return this.Encomienda_kg;
            }

        public void persistirItem()
        {
        }

    }
}
