using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Objetos
{

    class Cliente
    {
       private Int32 Dni;
       private string Nombre;
       private string Apellido;
       private string Direccion;
       private Int32 Telefono;
       private string Mail;
       private string Fecha_nacimiento;
       private Encomienda Encomienda;
       private Pasaje Pasaje;

       public Cliente(Int32 dni, string nombre, string apellido, string direccion, Int32 telefono, string mail, string fecha_nacimiento, Encomienda encomienda, Pasaje pasaje) 
       {

            this.Dni = dni;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Mail = mail;
            this.Fecha_nacimiento = fecha_nacimiento;
            this.Encomienda = encomienda;
            this.Pasaje = pasaje;
        
        }

       public Int32 getDni()
        {
            return this.Dni;
        }

        public string getNombre()
        {
            return this.Nombre;
        }

        public string getApellido()
        {
            return this.Apellido;
        }

       public  string getDireccion()
        { 
            return this.Direccion;
        }

        public Int32 getTelefono()
        {
            return this.Telefono;
        }

        public string getMail()
        {
            return this.Mail;
        }

        public string getFechaNac()
        {
            return this.Fecha_nacimiento;
        }

        public Encomienda getEncomienda()
        {
            return this.Encomienda;
        }

        public Pasaje getPasaje()
        {
            return this.Pasaje;
        }

    }
}
