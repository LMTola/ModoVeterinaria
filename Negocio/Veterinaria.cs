using Datos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio
{
    public class Veterinaria
    {
        private Servicio servicio1 = new Servicio("Peluquería");
        private Servicio servicio2 = new Servicio("Vacunación");

        private Usuario usuario1 = new Usuario("Ana","Lopez", "Rioja 678 Ciudad", "10568955", "155896658");
        private Usuario usuario2 = new Usuario("Ignacio", "Ibañez", "Lavalle 975 Ciudad", "20589674", "157569452");

        private Mascota mascota1 = new Pez("Arturo", "Guppy");



    }
}
