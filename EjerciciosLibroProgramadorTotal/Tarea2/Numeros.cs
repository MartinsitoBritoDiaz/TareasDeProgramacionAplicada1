using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLibroProgramadorTotal.Tarea2
{
    class Numeros
    {
        private int numero { get; set; }

        public Numeros()
        {
            numero = 0;
        }

        public void Evaluar()
        {
            do
            {
                Console.WriteLine("\n\nDigite un numero entre (0 - 9): ");
                numero = Convert.ToInt32(Console.ReadLine());
            } while (numero < 0 || numero > 9);


            switch (numero)
            {
                case 0:
                    {
                        Console.WriteLine("El {0} escrito en palabras es cero.", numero);
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("El {0} escrito en palabras es uno.", numero);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("El {0} escrito en palabras es dos.", numero);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("El {0} escrito en palabras es tres.", numero);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("El {0} escrito en palabras es cuatro.", numero);
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("El {0} escrito en palabras es cinco.", numero);
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("El {0} escrito en palabras es seis.", numero);
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("El {0} escrito en palabras es siete.", numero);
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("El {0} escrito en palabras es ocho.", numero);
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("El {0} escrito en palabras es nueve.", numero);
                        break;
                    }
            }
        }
    }
}
