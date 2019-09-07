using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLibroProgramadorTotal.Tarea2
{
    class Jagged
    {
        public Jagged()
        {

        }

        public void Comprobar()
        {
            int[][] arreglo = new int[][] {
                new int[] {8,6,7,4,5,2},
                new int[] {7,2},
                new int[] {2,3,4}
            };

            mostrar(arreglo,0);
            mostrar(arreglo, 1);
            mostrar(arreglo, 2);
        }

        private void mostrar(int[][] arreglo, int n)
        {
            int m;

            for (m = 0; m < arreglo[n].GetLength(0); m++)
            {
                Console.WriteLine("\n{0}", arreglo[n][m]);
            }
        }
    }
}
