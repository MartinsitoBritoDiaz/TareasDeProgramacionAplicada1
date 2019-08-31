using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLibroProgramadorTotal.Tarea1
{
    class TablaM
    {
        private int numero;
        private int result;

        public TablaM()
        {
            numero = 0;
            result = 0;
        }

        public void Evaluar()
        {
            Console.WriteLine("\n\n\tTabla de multiplicar");

            Console.WriteLine("Digite el numero a calcular: ");
            numero = Convert.ToInt32(Console.ReadLine());

            for(int i=1; i <= 12; i++)
            {
                result = numero * i;
                Console.WriteLine(numero + " * " + i + " = " + result);
            }
        }

    }
}
