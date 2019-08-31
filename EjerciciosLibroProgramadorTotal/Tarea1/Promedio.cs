using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLibroProgramadorTotal.Tarea1
{
    class Promedio
    {
        private int cantPersonas;
        private int[] edad = new int[100];

        public Promedio()
        {
            cantPersonas = 0;
        }

        public void Calcular()
        {
            Console.WriteLine("\n\n\tCalcular promedio de edades");

            Console.WriteLine("Digite la cantidad de personas a evaluar: ");
            cantPersonas = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i<cantPersonas; i++)
            {
                Console.WriteLine("Digite la edad: ");
                edad[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nEl promedio de edades es: " + calPromedio(edad, cantPersonas));
            Console.WriteLine("\nLa edad mas grande es: " + Mayor(edad, cantPersonas));
            Console.WriteLine("\nLa edad mas joven es: " + Menor(edad, cantPersonas));

        }

        private float calPromedio(int[] array, int cant)
        {
            float aux = 0; 

            for(int i =0; i<cant; i++)
            {
                aux += array[i];
            }

            return (aux/cant);
        }
        
        private int Mayor(int[] array,int cant)
        {
            int mayor = array[0];

            for (int i = 1; i < cant; i++)
            {
                if(array[i] > mayor)
                {
                    mayor = array[i];
                }
            }

            return mayor;
        }

        private int Menor(int[] array, int cant)
        {
            int menor = array[0];

            for (int i = 1; i < cant; i++)
            {
                if (array[i] < menor)
                {
                    menor = array[i];
                }
            }

            return menor;
        }
    }
}
