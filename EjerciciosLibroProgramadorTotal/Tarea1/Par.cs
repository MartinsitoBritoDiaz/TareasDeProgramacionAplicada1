using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLibroProgramadorTotal.Tarea1
{
    class Par
    {
        private int numero;

        public Par()
        {
            numero = 0; 
        }

        public void Comprobar()
        {
            Console.WriteLine("\n\n\tComprobar si un numero es par o impar");

            Console.WriteLine("Digite el numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if(numero % 2 == 0)
            {
                Console.WriteLine("Si es par");
            }
            else
            {
                Console.WriteLine("Es impar");
            }
        }
    }
}
