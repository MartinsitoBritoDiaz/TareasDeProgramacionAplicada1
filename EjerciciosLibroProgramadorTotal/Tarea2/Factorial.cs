using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLibroProgramadorTotal.Tarea2
{
    public class Factorial
    {
        private int numero { get; set; }

        public Factorial()
        {
            numero = 1;
        }

        public void Calcular()
        {
            Console.WriteLine("Clacular el factorial");
            Console.WriteLine("\nDigite un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            for(int i = numero-1; i > 1; i--)
            {
                numero = numero * i;
            }

            Console.WriteLine("El factorial es igual a {0} ", numero);
        }
    }
}
