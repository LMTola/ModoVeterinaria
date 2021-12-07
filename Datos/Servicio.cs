using System;
using System.Collections.Generic;
using System.Text;

namespace Datos
{
    public class Servicio
    {
        private string categoria;
        private string Categoria
        {
            get
            {
                return categoria;
            }
            set
            {
                categoria = value;
            }
        }

        public Servicio(string categoria)
        {
            Categoria = categoria;
        }
    }
}
