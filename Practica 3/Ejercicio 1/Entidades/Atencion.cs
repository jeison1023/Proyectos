using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Entidades
{
    internal class Atencion
    {
        /// <summary>
        /// Constructor por defecto de la clase Atencion.
        /// </summary>
        public Atencion() { }
        /// <summary>
        /// Propiedad que representa el identificador de la atencion 
        /// </summary>
        public string Tipodevehiculo { get; set; }

        public string Tipodeservicios { get; set; }

        public double Monto { get; set; }

    }
}
