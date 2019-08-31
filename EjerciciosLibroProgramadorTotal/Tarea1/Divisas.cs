using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLibroProgramadorTotal.Tarea1
{
    class Divisas
    {
        private double dolar;
        private double euro;
        private double cambio;
        private int opcion;
        public Divisas()
        {
            dolar = 0.0;
            euro = 0.0;
            cambio = 1;
            opcion = 0;
        }

        public void Cambio()
        {
            Console.WriteLine("\n\n\t\t**--Cambio de divisas--**");
            Console.WriteLine("\n(1)-Dolar a Euro.");
            Console.WriteLine("\n(2)-Euro a Dolar.");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    {
                        Console.WriteLine("Digite el precio del euro: ");
                        cambio = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Digite la cantidad de dolares a cambiar: ");
                        dolar = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Esta cantidad de dolares hacen " + TransformarDolarEuro(dolar,cambio) + "$ euros.");

                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("Digite el precio del dolar: ");
                        cambio = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Digite la cantidad de euros a cambiar: ");
                        euro = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Esta cantidad de euros hacen " + TransformarEuroDolar(euro,cambio) + "$ dolares.");

                        break;
                    }
            }
        }

        private double TransformarDolarEuro(double dolar,double cambio)
        {
            return dolar * cambio;
        }

        private double TransformarEuroDolar(double euro, double cambio)
        {
            return euro / cambio;
        }
    }
}
