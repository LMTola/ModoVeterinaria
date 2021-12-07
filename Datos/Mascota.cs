using System;
using System.Collections.Generic;
using System.Text;

namespace Datos
{
    public class Mascota
    {
        private string nombre;
        private string raza;

        private string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        private string Raza
        {
            get
            {
                return raza;
            }
            set
            {
                raza = value;
            }
        }

        public Mascota(string nombre, string raza)
        {
            Nombre = nombre;
            Raza = raza;

        }





    }
}
