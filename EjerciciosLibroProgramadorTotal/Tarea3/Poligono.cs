using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLibroProgramadorTotal.Tarea3
{
    public class Poligono
    {
        public float longitudLados { get; set; }
        public int cantidadLados { get; set; }
        public float apotema { get; set; }

        public Poligono()
        {
            this.longitudLados = 0.0f;
            this.cantidadLados = 0;
            this.apotema = 0.0f;
        }

        public Poligono(float longitudLados, int cantidadLados, float apotema)
        {
            this.longitudLados = longitudLados;
            this.cantidadLados = cantidadLados;
            this.apotema = apotema;
        }
    }
}
