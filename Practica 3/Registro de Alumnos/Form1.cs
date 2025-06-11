using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registro_de_Alumnos.controladores;
using Registro_de_Alumnos.Entidades;

namespace Registro_de_Alumnos
{
    public partial class Form1 : Form
    {
        private AlumnoControladores alumnoControladores = new AlumnoControladores();
        public Form1()
        {
            InitializeComponent();
        }

        private void MostrarAlumnos(Alumno[] alumnos)
        {
            dgAlumnos.DataSource = null;
            dgAlumnos.DataSource = alumnos;
        }
            
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegitrar_Click(object sender, EventArgs e)
        {
            // Validar campos de entrada
            if (tbCodigo.Text == "" || tbNomdre.Text == "" || tbPromedio.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }
            // Crear un nuevo alumno
            Alumno alumno = new Alumno()
            {
                Codigo = tbCodigo.Text,
                Nombre = tbNomdre.Text,
                Promedio= double.Parse(tbPromedio.Text)

            };
            //Registrar alumno en el arreglo
            alumnoControladores.Registrar(alumno);

            //Mostrar los alumnos registrados 
            MostrarAlumnos(alumnoControladores.ListarTodo());

            limpiarCampos();
        }
        public void limpiarCampos()
        {
            tbCodigo.Clear();
            tbNomdre.Clear();
            tbPromedio.Clear();
            tbBuscar.Clear();
        
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Validacion de seleccion de registro
            if(dgAlumnos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleciones un registro para eliminar");
                return;
            }
            //Obtener el codigo
            string codigo = dgAlumnos.SelectedRows[0].Cells[0].Value.ToString();
            //Eliminar la fila seleccionada
            alumnoControladores.Eliminar(codigo);

            //Mostrar
            MostrarAlumnos(alumnoControladores.ListarTodo());
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            MostrarAlumnos(alumnoControladores.Ordenar());

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Validar campo de busqueda
            if (tbBuscar.Text == "")
            {
                MessageBox.Show("Ingrese un codigo para buscar");
                return;
            
            }
            //Buscar por codigo
            string codigo = tbBuscar.Text;

            //Mostrar los alumnos de la busqueda
            MostrarAlumnos(alumnoControladores.BuscarPorCodigo(codigo));
        }
    }
}
