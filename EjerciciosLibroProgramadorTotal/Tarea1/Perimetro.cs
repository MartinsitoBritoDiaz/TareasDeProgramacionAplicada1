using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLibroProgramadorTotal.Tarea1
{
    class Perimetro
    {
        private int cantLados;
        private float longitudLado;
        private float perimetro;

        public Perimetro()
        {
            cantLados = 0;
            longitudLado = 0;
            perimetro = 0;
        }

        public void CalcularP()
        {            
            Console.WriteLine("\n\t\t!Calcular el perimetro!");

            Console.WriteLine("\nDigite la cantidad de lados: ");
            cantLados = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite la Longitud de uno de sus lados: ");
            longitudLado = float.Parse(Console.ReadLine());

            perimetro = cantLados * longitudLado;
            Console.WriteLine("El perimetro es: " + perimetro);
        }
    }
}
