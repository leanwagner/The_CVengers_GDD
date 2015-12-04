using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Objetos
{
    public class Pasaje : TipoItem
    {
        private Int32 Pasaje_butaca;
        

        public Pasaje(Int32 butaca)
        {
            Pasaje_butaca = butaca;
        }

        public Int32 getPasaje_butaca()
        {
            return this.Pasaje_butaca;
        }

        public void persistirItem()
        {
        }

    }
}
