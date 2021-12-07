using System;
using System.Collections.Generic;
using System.Text;

namespace Datos
{
    public class Usuario
    {
        private List<Mascota> lmascotas = new List<Mascota>();
        private string nombre;
        private string apellido;
        private string direccion;
        private string dni;
        private string telefono;

        public Usuario(string nombre, string apellido, string direccion, string dni, string telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.dni = dni;
            this.telefono = telefono;
        }

        public void AgregarMascota(Mascota mascota)
        {
            lmascotas.Add(mascota);
        }
    }
}
