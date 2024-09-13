using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion.clase
{
    internal class Alumno
    {
        public string Nombre { get; set; }
        public double Puntaje { get; set; }
        public Alumno(string nombre, double nota)
        {
            Nombre = nombre;
            Puntaje = nota;
        }
    }
}

