using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_1.Entidades;

namespace Ejercicio_1.Controles
{
    internal class AtencionControles
    {
        // Arreglos
        private Atencion[] atenciones = new Atencion[100];
        int contador = 0;

        private int totalservivio1 = 0;
        private int totalservivio2 = 0;
        private int totalservivio3 = 0;
        private double totalMonto = 0;

        public double montoTotallamado { get; private set; }

        /// <summary>
        /// Lista todas las atenciones 
        /// </summary> 
        /// <returns></returns>
        public Atencion[] ListarTodo() { return atenciones; }

        public int ObtenerTotalservicio1() { return totalservivio1; }

        public int ObtenerTotalservicio2() { return totalservivio2; }

        public int ObtenerTotalservicio3() { return totalservivio3; }

        // registra una atencion

        public void Registrar(Atencion atencion)
        {
            switch (atencion.Tipodeservicios)
            {
                case "1":
                    atencion.Monto = 10;
                    totalservivio1++;
                    break;

                case "2":
                    atencion.Monto = 15;
                    totalservivio2++;
                    break;

                case "3":
                    atencion.Monto = 10;
                    totalservivio3++;
                    break;

            }

            // Aplicar incremento del 5% si el tipo de servicio es "c"
            if (atencion.Tipodeservicios == "c") atencion.Monto *= 1.05;

            // Agregar el monto de lavado 
            {
                if (atencion.Tipodeservicios == "1") montoTotallamado += atencion.Monto;
                atenciones[contador] = atencion;
                contador++;
            }


        }

        //Obtener el servicio con menor demanda
        public String ObtenerServicioMenorDemanda()
        {
            if (totalservivio1 < totalservivio2 && totalservivio1 < totalservivio3)
                return "lavado";
            else if (totalservivio2 < totalservivio1 && totalservivio2 < totalservivio3)
                return "Encerado";
            else if (totalservivio3 < totalservivio1 && totalservivio3 < totalservivio2)
                return "Silicona";
            else if (totalservivio1 == totalservivio2 && totalservivio1 < totalservivio3)
                return "lavado y encerado";
            else if (totalservivio2 == totalservivio3 && totalservivio3 < totalservivio1)
                return "Encerado y silicona";
            else if (totalservivio1 == totalservivio3 && totalservivio3 < totalservivio2)
                return "lavado y silicona";
            else return "Todos tienen la misma demanda ";
            
        }
         
        
    }
}
