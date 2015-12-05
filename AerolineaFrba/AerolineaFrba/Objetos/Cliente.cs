using AerolineaFrba.Compra;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Objetos
{

    public class Cliente
    {
       private int clienteId;
       private Int32 Dni;
       private string Nombre;
       private string Apellido;
       private string Direccion;
       private Int32 Telefono;
       private string Mail;
       private string Fecha_nacimiento;
       private TipoItem item;
       

       public Cliente(int id,Int32 dni, string nombre, string apellido, string direccion, Int32 telefono, string mail, string fecha_nacimiento, TipoItem item) 
       {

            this.clienteId = id;
            this.Dni = dni;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Mail = mail;
            this.Fecha_nacimiento = fecha_nacimiento;
            this.item = item;
        
        }

       public Cliente(int id, Int32 dni, string nombre, string apellido, string direccion, Int32 telefono, string mail, string fecha_nacimiento)
       {

           this.clienteId = id;
           this.Dni = dni;
           this.Nombre = nombre;
           this.Apellido = apellido;
           this.Direccion = direccion;
           this.Telefono = telefono;
           this.Mail = mail;
           this.Fecha_nacimiento = fecha_nacimiento;
       }

       override public String ToString()
       {
           return item.ToString();
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

        public TipoItem getItem()
        {
            return item;
        }

        public int persistirme() 
        {
            string command = "EXEC THE_CVENGERS.ingresarOModificarCliente @id =" + clienteId.ToString() +
                ", @nombre = '" + Nombre +
                "', @apellido = '" + Apellido +
                "', @dni = " + Dni.ToString() +
                ", @dir = '" + Direccion +
                "', @telefono = " + Telefono.ToString() +
                ", @mail = '" + Mail +
                "', @fechanac = '" + Fecha_nacimiento.ToString(CultureInfo.InvariantCulture) + "'";
            SqlCommand sqlCmd = new SqlCommand(command,Conexion.getConexion());
            sqlCmd.Transaction = Carrito.tran;
            sqlCmd.ExecuteNonQuery();
            sqlCmd.CommandText = "select CLIENTE_ID from THE_CVENGERS.CLIENTE where CLIENTE_NOMBRE ='" + Nombre + "' and CLIENTE_APELLIDO =  '" + Apellido + "' and CLIENTE_DNI = " + Dni;
            return Int32.Parse(sqlCmd.ExecuteScalar().ToString());
        }
    }
}
