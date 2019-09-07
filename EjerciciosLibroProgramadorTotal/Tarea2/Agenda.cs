using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLibroProgramadorTotal.Tarea2
{
    class Agenda
    {
        private int opcion { get; set; }
        private string nombre { get; set; }
        private string numero { get; set; }


        public Agenda()
        {
            opcion = 0;
            nombre = "";
            numero = "";
        }

        public void metodo()
        {
            int contador = 0;
            Hashtable agenda = new Hashtable();
            do
            {
                Console.Clear();
                Console.WriteLine("1- Agregar Contacto");
                Console.WriteLine("2- Mostrar Contactos");
                Console.WriteLine("3- Salir: ");
                Console.WriteLine("\nDigite la opcion deseada: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        {
                            Console.Clear();
                            contador = 1;
                            Console.WriteLine("***---Añadir contacto---***");
                            Console.WriteLine("Digite el nombre: ");
                            nombre = Console.ReadLine();

                            Console.WriteLine("Digite el numero: ");
                            numero = Console.ReadLine();

                            agenda.Add(nombre, numero);
                            Console.ReadKey();
                            break;
                        }

                    case 2:
                        {
                            Console.Clear();
                            if (contador != 0)
                            {
                                Console.WriteLine("***--Contactos guardados--***");
                                Console.WriteLine("Nombre : Numero\n");
                                foreach (DictionaryEntry contacto in agenda)
                                    Console.WriteLine(contacto.Key + " : " + contacto.Value);
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
