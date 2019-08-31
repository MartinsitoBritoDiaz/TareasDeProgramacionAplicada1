using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLibroProgramadorTotal.Tarea1
{
    class ConversorCF
    {
        private double centigrados;
        private double fahrenheit;

        public ConversorCF()
        {
            centigrados = 0.0;
            fahrenheit = 0.0;
        }

        public void Convertir()
        {
            Console.WriteLine("\n\t\t!Convertir de grados centigrados a fahrenheit!");

            Console.WriteLine("\nDigite los grados centigrados: ");
            centigrados = Convert.ToDouble(Console.ReadLine());

            fahrenheit = (centigrados * (1.8) + 32);

            Console.WriteLine("\nEl resultado de la conversion es: " + fahrenheit + "° Fahrenheit");
        }
    }
}
