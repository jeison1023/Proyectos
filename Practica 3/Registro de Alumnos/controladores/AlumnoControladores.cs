using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registro_de_Alumnos.Entidades;

namespace Registro_de_Alumnos.controladores
{

    internal class AlumnoControladores 
    {
        // Arreglo
        private Alumno[] alumnos = new Alumno[100];
        private int cont = 0;
        public Alumno[] ListarTodo() { return alumnos; }
        public void Registrar(Alumno alumno)
        {
            alumnos[cont] = alumno;
            cont++;
        }
        // Eliminar alumnos del arreglos 
        public void Eliminar(string codigo)
        {
            int posicion = Array.FindIndex(alumnos, alumno => alumno.Codigo == codigo);
            // Logica de eliminacion 
            for (int i = 0; i < cont; i++)
            {
                if (i >= posicion)
                {
                    alumnos[i] = alumnos[i + 1];
                }

            }
            cont--;

        }

        private class MetodoComparacion : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                if (((Alumno)x).Promedio > ((Alumno)y).Promedio)
                { return -1; }
                else if (((Alumno)x).Promedio == ((Alumno)y).Promedio) return 0;
                else { return 1; }
            }
        }
        public Alumno[] Ordenar()
        {
            Array.Sort(alumnos, 0, cont, new MetodoComparacion());
            return alumnos;
        }
        public Alumno[] BuscarPorCodigo(string codigo)
        {
           return Array.FindAll(alumnos, alumno => alumno != null && alumno.Codigo.Contains(codigo));
        }
    }

}
        

 
        

