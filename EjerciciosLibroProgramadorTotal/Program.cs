using EjerciciosLibroProgramadorTotal.Tarea1;
using EjerciciosLibroProgramadorTotal.Tarea2;
using EjerciciosLibroProgramadorTotal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosLibroProgramadorTotal1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("\n\t\tMenu de los ejercicios");
                Console.WriteLine("\n\t**------Tarea 1------**");
                Console.WriteLine("\n(1)- Imprimir mi nombre nombre y agregarle otro mensaje.");
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

                Console.WriteLine("\n\n\t**------Tarea 2------**");
                Console.WriteLine("\n(12)-Calcular factorial de un numero.");
                Console.WriteLine("(13)-Cadena de numeros escritos en palabras.");
                Console.WriteLine("(14)-Ejercicios del capitulo 6.");
                Console.WriteLine("(15)-Pasar un arreglo Jagged como parametro en funcion.");
                Console.WriteLine("(16)-Calcular promedio, maxima y minima calificaion ArrayList.");
                Console.WriteLine("(17)-Diccionario de palabras.");
                Console.WriteLine("(18)-Agenda telefonica.");
                Console.WriteLine("(19)-Formato de hora AM/PM.");
                Console.WriteLine("(20)-Comparar cadenas.");

                Console.WriteLine("\n\n\t**--------Tarea 3---------**");
                Console.WriteLine("(21)- Menu tarea 3");
                Console.WriteLine("\n\n(22)- Salir.");
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

                    case 12:
                        {
                            Console.Clear();

                            Factorial factorial = new Factorial();
                            factorial.Calcular();
                            Console.ReadKey();
                            break;
                        }
                    case 13:
                        {
                            Console.Clear();

                            Numeros numeros = new Numeros();
                            numeros.Evaluar();
                            Console.ReadKey();
                            break;
                        }
                    case 14:
                        {
                            Console.Clear();

                            Escuela escuela = new Escuela();
                            escuela.principal();
                            Console.ReadKey();
                            break;
                        }
                    case 15:
                        {
                            Console.Clear();

                            Jagged jagged = new Jagged();
                            jagged.Comprobar();
                            Console.ReadKey();
                            break;
                        }
                    case 16:
                        {
                            Console.Clear();

                            SalonClases salonDeClases = new SalonClases();
                            salonDeClases.Clases();
                            Console.ReadKey();
                            break;
                        }
                    case 17:
                        {
                            Console.Clear();
                            Diccionario diccionario = new Diccionario();
                            diccionario.metodo();
                            Console.ReadKey();
                            break;
                        }
                    case 18:
                        {
                            Console.Clear();
                            Agenda agenda = new Agenda();
                            agenda.metodo();
                            Console.ReadKey();
                            break;
                        }
                    case 19:
                        {
                            Console.Clear();
                            FormatoAMPM formato = new FormatoAMPM();
                            formato.Metodo();
                            Console.ReadKey();
                            break;
                        }
                    case 20:
                        {
                            Console.Clear();
                            Cadenas cadena = new Cadenas();
                            cadena.metodo();
                            Console.ReadKey();
                            break;
                        }

                    case 21:
                        {
                            Application.EnableVisualStyles();
                            Application.SetCompatibleTextRenderingDefault(false);
                            Application.Run(new MenuTarea());
                            Console.ReadKey();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("El ejercicio selecionado no esta disponible");
                            break;
                        }
                }
            } while (opcion != 22);
            

            
        }
    }
}