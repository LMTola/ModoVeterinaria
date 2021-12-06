using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio
{
    public class PropietarioMascota
    {
        protected string Nombre;
        protected string Apellido;
        protected double Telefono;
        protected string Direccion;

     public string getNombre()
        {
            return this.Nombre;
        }
     public string getApellido()
        {
            return this.Apellido;
        }
     public double getTelefono()
        {
            return this.Telefono;
        }
     public string getDireccion()
        {
            return this.Direccion;
        }



    }
}
