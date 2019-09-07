using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLibroProgramadorTotal.Tarea2
{
    class Diccionario
    {
        private int opcion { get; set; }
        private string palabra { get; set; }
        private string definicion { get; set; }


        public Diccionario()
        {
            opcion = 0;
        }

        public void metodo()
        {
            int contador = 0;
            Hashtable diccionario = new Hashtable();
            do
            {
                Console.WriteLine("1- Agregar definiciones");
                Console.WriteLine("2- Mostrar palabras");
                Console.WriteLine("3- Salir: ");
                Console.WriteLine("\nDigite la opcion deseada: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        {
                            contador = 1;
                            Console.WriteLine("Digite la palabra: ");
                            palabra = Console.ReadLine();

                            Console.WriteLine("Digite la definicion: ");
                            definicion = Console.ReadLine();

                            diccionario.Add(palabra, definicion);
                            Console.ReadKey();
                            break;
                        }

                    case 2:
                        {
                            if(contador != 0)
                            {
                                Console.WriteLine("**--Las palabras guardadas--***");
                                foreach (DictionaryEntry aux in diccionario)
                                    Console.WriteLine(aux.Key + " : " + aux.Value);
                            }
                            else
                            {
                                Console.WriteLine("Debe de agregar una palabra con su definicion antes de buscar");
                            }
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Opcion mal");
                            break;
                        }
                }

            } while (opcion != 3);
        }
    }
}
