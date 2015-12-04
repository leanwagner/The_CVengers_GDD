using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Devolucion
{
    class ItemsDevolucion
    {
            String numero;
            String tipo;
            String precio;

       public ItemsDevolucion(String n,String t,String p)
       {
           numero = n;
           tipo = t;
           precio = p;
       }

       override public String ToString() 
       {
           return "N° " + numero+" - "+tipo + " - $" + precio; 
       }

       public String getNumero() { return this.numero; }

       public String getTipo() { return this.tipo; }

       public String getPrecio() { return this.precio; }
    
    }
}
