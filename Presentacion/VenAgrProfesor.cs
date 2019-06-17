using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiLibreria;
using tp_lab_3;

namespace Presentacion
{
    public partial class VenAgrProfesor : VenAgr
    {
        VentProfesores padre;
        Conexion conexion;

        public VenAgrProfesor(VentProfesores padre)
        {

            this.padre = padre;
            conexion = new Conexion();
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Dentro de esto tenes que poner la conexion a la base de datos
            if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                string nombre = errorTxtBox1.Text;
                string apellido = errorTxtBox2.Text;
                int dni = int.Parse(txtdni.Text);
                string direccion = txtDireccion.Text;
                string telefono = txtTelefono.Text;
                bool delCentro = (cBoxDelCentro.Text == "true")? true:false;


                Profesor profesor = new Profesor(nombre, apellido, dni, direccion, telefono, delCentro);

                conexion.guardarProfesor(profesor);

                padre.actualizarTabla();
                MessageBox.Show("Se guardo correctamete");
                this.Close();



            }
            else
            {
                errorTxtBox1.Text = "";
                errorTxtBox2.Text = "";
                MessageBox.Show("No se pudo guardar");

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
