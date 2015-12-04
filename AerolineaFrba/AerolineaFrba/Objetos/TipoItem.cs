using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Objetos
{
    public interface TipoItem
    {
        void persistirItem();
        float calcularPrecio();
        String ToString();
        void actualizarValoresCancelados();
    }
}
