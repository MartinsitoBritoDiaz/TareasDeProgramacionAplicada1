using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLibroProgramadorTotal.Tarea3
{
    public class Estudiantes
    {
        public string nombre { get; set; }
        public int edad { get; set; }
        public string curso { get; set; }
        public int numero { get; set; }


        public Estudiantes()
        {
            this.nombre = "";
            this.edad = 0;
            this.curso = "";
            this.numero = 0;
        }
    }
}
