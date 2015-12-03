using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Objetos
{
    public interface TipoItem
    {
        void persistirItem(int cliente_id);
        float calcularPrecio();
        String ToString();
        void actualizarValoresCancelados();
    }
}
