using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio_1.Controles;
using Ejercicio_1.Entidades;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        private AtencionControles atencionControles = new AtencionControles();
        public string Tipovehiculo { get; set; }
        public string Tiposervicios { get; set; }

        public Form1()
        {
            InitializeComponent();
        }
        private void MostrarAtenciones(Atencion[] atenciones)
       
        {
            dgatencion.DataSource = null;    
            dgatencion.DataSource = atenciones;
            totalservivio1.Text = atencionControles.ObtenerTotalservicio1().ToString();
            totalservivio2.Text = atencionControles.ObtenerTotalservicio2().ToString();
            totalservivio3.Text = atencionControles.ObtenerTotalservicio3().ToString();
            lblserviciomenordemanda.Text = atencionControles.ObtenerServicioMenorDemanda();
            montoTotallamado.Text = atencionControles.ObtenerMontoPromediolavado().ToString();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void lblmontopromedio_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(cbvehiculo.Text== ""|| cbServicios.Text=="")
            {
                MessageBox.Show("ingrese todos los campos");
                    return;
            }
            Atencion atencion = new Atencion();
            {
                Tipovehiculo = cbvehiculo.Text;
                Tiposervicios = cbServicios.Text;
            }
            atencionControles.Registrar(atencion);

            MostrarAtenciones(atencionControles.ListarTodo());
        }   
    }  
}
