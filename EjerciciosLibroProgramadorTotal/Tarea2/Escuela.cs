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
        private float  suma { get; set; }
        private float minima { get; set; }
        private float maxima { get; set; }

        public Escuela()
        {
            cantidad = 0;
            salones = 0;
            n = 0;
            m = 0;
            valor = "";
            suma = 0.0f;
            minima = 10.0f;
            maxima = 0.0f;
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
                Console.WriteLine("\tEl promedio de calificaciones de este salon es: {0}", calcularPromedio(calif, salones, n));
            }
        }

        private float calcularPromedio(float[][] array, int salones, int n)
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

    }
}
