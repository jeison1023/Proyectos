using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Registro_de_Alumnos.Entidades
{
    internal class Alumno
    {
        public Alumno() { }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public double Promedio { get; set; }
    }
}
