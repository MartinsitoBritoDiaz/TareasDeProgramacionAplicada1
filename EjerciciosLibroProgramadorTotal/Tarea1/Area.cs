using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLibroProgramadorTotal.Tarea1
{
    class Area
    {
        private int cantLados;

        private float longitudLado;
        private float perimetro;

        private double area;
        private double apotema;
        public Area()
        {
            cantLados = 0;
            longitudLado = 0;
            perimetro = 0;
            area = 0.0;
            apotema = 0.0;
        }

        public void Metodo()
        {   
            Console.WriteLine("\n\n\tArea y perimetro de un poligono regular");

            Console.WriteLine("Digite la cantidad de lados: ");
            cantLados = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite la longitud de uno de sus lados: ");
            longitudLado = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite el apotema: ");
            apotema = Convert.ToDouble(Console.ReadLine());

            perimetro = cantLados * longitudLado;
            /*apotema = longitudLado / (2 * Math.Tan(180 / cantLados));*/

            area = (perimetro * apotema) / 2;

            Console.WriteLine("\nEl perimetro es: " + perimetro);
            Console.WriteLine("El area es: " + area);
        }
    }
}
