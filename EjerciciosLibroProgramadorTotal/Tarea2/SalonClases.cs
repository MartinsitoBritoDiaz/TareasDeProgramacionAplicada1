using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLibroProgramadorTotal.Tarea2
{
    class SalonClases
    {
        private float promedio { get; set; }
        private float maxima { get; set; }
        private float minima { get; set; }
        private int cantidad { get; set; }
        private float calificacion { get; set; }
        private float sumatoria { get; set; }

        public SalonClases()
        {
            promedio = 0.0f;
            maxima = 0.0f;
            minima = 0.0f;
            cantidad = 0;
        }

        public void Clases()
        {
            int i;

            ArrayList alumnos = new ArrayList();

            Console.WriteLine("Digite la cantidad de estudiantes: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            for(i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Digite la calificacion: ");
                calificacion = Convert.ToSingle(Console.ReadLine());
                alumnos.Add(calificacion);
            }

            maxima = 0;
            minima = calificacion;

            foreach (float n in alumnos)
            {
                if (n > maxima)
                    maxima = n;

                if (n < minima)
                    minima = n;

                sumatoria += n;
            }

            promedio = sumatoria / cantidad;



            Console.WriteLine("\n\nEl promedio es:{0}", promedio);
            Console.WriteLine("La calificacion maxima es: {0}", maxima);
            Console.WriteLine("La calificacion minima es: {0}", minima);
        }
    }
}
