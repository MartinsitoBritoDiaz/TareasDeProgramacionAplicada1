using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLibroProgramadorTotal.Tarea3
{
    public class PoligonoValidar
    {
        public float longitudLados { get; set; }
        public int cantidadLados { get; set; }
        public float apotema { get; set; }

        public PoligonoValidar()
        {
            this.longitudLados = 0.0f;
            this.cantidadLados = 0;
            this.apotema = 0.0f;
        }

        public PoligonoValidar(float longitudLados, int cantidadLados, float apotema)
        {
            this.longitudLados = longitudLados;
            this.cantidadLados = cantidadLados;
            this.apotema = apotema;
        }


        //Este es el metodo toString del ejercicio numero 5 del capitulo 10
        public override string ToString()
        {
            String mensaje =  "";
            mensaje += "\nLongitud Lados, " + longitudLados.ToString() + " \nCantidad Lados: " +
            cantidadLados.ToString() + "\nApotema " + apotema.ToString();

            return mensaje;
        }

        

    }
}
