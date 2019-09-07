using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLibroProgramadorTotal.Tarea2
{
    class Escuela
    {
        private int cantidad { get; set; }
        private int salones { get; set; }
        private int n { get; set; }
        private int m { get; set; }
        private string valor { get; set; }

        public Escuela()
        {
            cantidad = 0;
            salones = 0;
            n = 0;
            m = 0;
            valor = "";
        }

        public void principal()
        {
            Console.WriteLine("\n\nDame la cantidad de salones");
            valor = Console.ReadLine();
            salones = Convert.ToInt32(valor);


            float[][] calif = new float[salones][];

            for(n = 0; n<salones; n++)
            {
                Console.WriteLine("Dame la cantidad de alumnos para el salon {0}", n);
                valor = Console.ReadLine();
                cantidad = Convert.ToInt32(valor);

                calif[n] = new float[cantidad];
            }

            for(n = 0; n<salones; n++)
            {
                Console.WriteLine("Salon {0}", n);
                for(m = 0; m<calif[n].GetLength(0); m++)
                {
                    Console.Write("Dame la calificación: ");
                    valor = Console.ReadLine();
                    calif[n][m] = Convert.ToSingle(valor);
                }
            }

            Console.WriteLine("____ Información_____");
            for(n = 0; n < salones; n++)
            {
                Console.WriteLine("\nSalon {0}", n);
                for(m = 0; m < calif[n].GetLength(0); m++)
                {
                    Console.WriteLine("\tEl alumno {0} tiene {1} ", m, calif[n][m]);
                }
                Console.WriteLine("\tEl promedio de calificaciones de este salon es: {0}", calcularPromedio(calif, n));
                Console.WriteLine("\tLa calificacion menor de este salon es: {0}", Menor(calif, n));
                Console.WriteLine("\tLa calificacion mayor de este salon es: {0}", Mayor(calif, n));
            }
        }

        private float calcularPromedio(float[][] array, int n)
        {
            int m;
            float suma = 0;
            int cantidad = array[n].GetLength(0);

            for (m = 0; m< array[n].GetLength(0); m++)
            {
                suma += array[n][m];
            }

            return (suma / cantidad);
        }

        private float Menor(float[][] array, int n)
        {
            int m;
            float menor = array[n][0];

            for (m = 1; m < array[n].GetLength(0); m++)
            {
                 if(array[n][m] < menor)
                {
                    menor = array[n][m];
                }
            }

            return menor;
        }

        private float Mayor(float[][] array, int n)
        {
            int m;
            float mayor = array[n][0];

            for (m = 1; m < array[n].GetLength(0); m++)
            {
                if (array[n][m] > mayor)
                {
                    mayor = array[n][m];
                }
            }

            return mayor;
        }
    }
}
