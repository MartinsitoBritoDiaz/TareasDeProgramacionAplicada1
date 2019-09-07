using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLibroProgramadorTotal.Tarea2
{
    class Cadenas
    {
        public Cadenas()
        {

        }
        
        public void metodo()
        {
            string cadena1, cadena2;
            int comparar;

            Console.WriteLine("Digite la cadena 1 : ");
            cadena1 = Console.ReadLine();
            Console.WriteLine("Digite la cadena 2: ");
            cadena2 = Console.ReadLine();

            comparar = string.Compare(cadena2, cadena2);

            if(comparar > 0)
            {
                Console.WriteLine("\t {0} \n\t {1}", cadena2, cadena1);
            }
            else
            {
                Console.WriteLine("\t {0} \n\t {1}", cadena1, cadena2);
            }
        }
    }
}
