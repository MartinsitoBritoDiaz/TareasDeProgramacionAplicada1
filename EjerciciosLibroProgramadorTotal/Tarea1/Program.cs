﻿using EjerciciosLibroProgramadorTotal.Tarea1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLibroProgramadorTotal
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("\n\t\tMenu de los ejercicios");
                Console.WriteLine("\n\tTarea 1");
                Console.WriteLine("\n\n(1)- Imprimir mi nombre nombre y agregarle otro mensaje.");
                Console.WriteLine("(2)- Perimetro de poligono regular.");
                Console.WriteLine("(3)- Conversor de grados a radianes.");
                Console.WriteLine("(4)- Conversor de grados centigrados a fahrenheit.");
                Console.WriteLine("(5)- Conversor de divisas.");
                Console.WriteLine("(6)- Comprobar si un numero es par o impar.");
                Console.WriteLine("(7)- Evaluar numero entre 1 y 7.");
                Console.WriteLine("(8)- Area y perimetro de un poligono.");
                Console.WriteLine("(9)- Tabla de multiplicar.");
                Console.WriteLine("(10)- Potencia de cualquier numero.");
                Console.WriteLine("(11)- Promedio de edad.");
                Console.WriteLine("(12)- Salir.");
                Console.Write("\n|-Digite el numero del programa que desea abrir: ");

                opcion = Convert.ToInt32(Console.ReadLine());         
                switch (opcion)
                {
                    case 1:
                        {
                            Console.Clear();

                            Nombre n = new Nombre();
                            n.metodo();
                            Console.ReadKey();
                            break;
                        }

                    case 2:
                        {
                            Console.Clear();

                            Perimetro p = new Perimetro();
                            p.CalcularP();
                            Console.ReadKey();
                            break;
                        }

                    case 3:
                        {
                            Console.Clear();

                            ConversorGR ObjConversorGR = new ConversorGR();
                            ObjConversorGR.Convertir();
                            Console.ReadKey();
                            break;
                        }

                    case 4:
                        {
                            Console.Clear();

                            ConversorCF ObjConversorCF = new ConversorCF();
                            ObjConversorCF.Convertir();
                            Console.ReadKey();
                            break;
                        }

                    case 5:
                        {
                            Console.Clear();

                            Divisas divisas = new Divisas();
                            divisas.Cambio();
                            Console.ReadKey();
                            break;
                        }

                    case 6:
                        {
                            Console.Clear();

                            Par objPar = new Par();
                            objPar.Comprobar();
                            Console.ReadKey();
                            break;
                        }
                    case 7:
                        {
                            Console.Clear(); 

                            Semana objSemana = new Semana();
                            objSemana.Evaluar();
                            Console.ReadKey();
                            break;
                        }

                    case 8:
                        {
                            Console.Clear();

                            Area area = new Area();
                            area.Metodo();
                            Console.ReadKey();
                            break;
                        }

                    case 9:
                        {
                            Console.Clear();

                            TablaM tabla = new TablaM();
                            tabla.Evaluar();
                            Console.ReadKey();
                            break;
                        }

                    case 10:
                        {
                            Console.Clear();

                            Potencia potencia = new Potencia();
                            potencia.Calcular();
                            Console.ReadKey();
                            break;
                        }

                    case 11:
                        {
                            Console.Clear();

                            Promedio promedio = new Promedio();
                            promedio.Calcular();
                            Console.ReadKey();
                            break;
                        }
                }
            } while (opcion != 12);
        }
    }
}
