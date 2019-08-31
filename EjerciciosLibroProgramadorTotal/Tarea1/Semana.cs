using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLibroProgramadorTotal.Tarea1
{
    class Semana
    {
        private int numero;

        public Semana()
        {
            numero = 0;
        }

        public void Evaluar()
        {
            do
            {
                Console.WriteLine("Digite un numero entre el 1 y 7");
                numero = Convert.ToInt32(Console.ReadLine());
            }while (numero < 1 || numero > 7);

            if (numero == 1)
            {
                Console.WriteLine("El dia de la semana correspondiente es el Lunes");
            }
            else if (numero == 2)
            {
                Console.WriteLine("El dia de la semana correspondiente es el Martes");
            }
            else if (numero == 3)
            {
                Console.WriteLine("El dia de la semana correspondiente es el Miercoles");
            }
            else if (numero == 4)
            {
                Console.WriteLine("El dia de la semana correspondiente es el Jueves");
            }
            else if(numero == 5)
            {
                Console.WriteLine("El dia de la semana correspondiente es el Viernes");
            }
            else if(numero == 6)
            {
                Console.WriteLine("El dia de la semana correspondiente es el Sabado");
            }
            else if(numero == 7)
            {
                Console.WriteLine("El dia de la semana correspondiente es el Domingo");
            }
        }
    }
}
