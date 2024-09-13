using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion.moldes
{
    internal class Estudiante
    {
        public string[] Alumno = new string[30];

        public void Agregar(string nombre, int i)
        {
            Alumno[i] = nombre;
        }

        public string[] Mostrar()
        {
            return Alumno;
        }
    }
}
