using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLibroProgramadorTotal.Tarea1
{
    class ConversorGR
    {
        private double grados;
        private double radianes;
        public ConversorGR()
        {
            grados = 0.0;
            radianes = 0.0;
        }

        public void Convertir()
        {
            Console.WriteLine("\n\t\t!Convertir de grados a radianes!");

            Console.WriteLine("\nDigite los grados: ");
            grados = Convert.ToDouble(Console.ReadLine());

            radianes = (grados / 180);

            Console.WriteLine("\nEl resultado de la conversion es: " + radianes + " radianes");
        }
    }
}
