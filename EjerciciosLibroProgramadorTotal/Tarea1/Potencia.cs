using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLibroProgramadorTotal.Tarea1
{
    class Potencia
    {
        private int numero;
        private int exponente;
        private int result = 1;
        public Potencia()
        {
            numero = 0;
            exponente = 0;
            result = 1;
        }

        public void Calcular()
        {
            Console.WriteLine("\n\n\t***--Pontencia--***");

            Console.WriteLine("Digite la base: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite el exponente: ");
            exponente = Convert.ToInt32(Console.ReadLine());

            for(int i = 1 ; i<=exponente ; i++)
            {
                result *= numero;
            }

            Console.WriteLine("El resultado de la potencia es: " + result);

        }
    }
}
