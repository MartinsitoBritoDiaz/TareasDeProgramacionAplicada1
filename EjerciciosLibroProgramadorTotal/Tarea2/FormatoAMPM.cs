using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLibroProgramadorTotal.Tarea2
{
    class FormatoAMPM
    {
        public FormatoAMPM()
        {

        }

        public void Metodo()
        {
            string hora;

            hora = string.Format("La fecha actual es: {0: h: m tt yyy / d / m} ", DateTime.Now);

            Console.WriteLine(hora);

        }
    }
}
