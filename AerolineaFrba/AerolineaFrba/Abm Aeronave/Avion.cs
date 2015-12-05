using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Abm_Aeronave
{
    class Avion
    {
       public String matricula;
        public String servicio;
       public String fabricante;

        public Avion(String m, String s, String f)
        {
            matricula = m;
            servicio = s;
            fabricante = f;
        }

        public String getMatricula() { return matricula; }
        public String getServicio() { return servicio; }
        public String getFabricante() { return fabricante; }

        public override string ToString()
        {
            return matricula + " - " + fabricante + " - " + servicio;
        }
    }
}
