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
    public partial class VenAgrAlumno : VenAgr
    {
        VentAlumnos padre;
        Conexion conexion;
        public VenAgrAlumno(VentAlumnos padre)
        {
            this.padre = padre;
            conexion = new Conexion();
            InitializeComponent();
            cargarComboBox();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                if (comboBox1.SelectedItem != null)
                {
                    string nombre = errorTxtBox1.Text;
                    string apellido = errorTxtBox2.Text;
                    decimal dni = int.Parse(txtDni.Text);
                    string direccion = txtDireccion.Text;
                    string telefono = txtTelefono.Text;
                    int matricula = int.Parse(txtMatricula.Text);

                    //encuentra el caracter de espacio
                    int espacio = comboBox1.Text.ToString().IndexOf(" ");

                    string division = comboBox1.Text.Substring(espacio + 1);
                    string año = comboBox1.Text.Substring(0, espacio + 1);


                    Alumno alumno = new Alumno(nombre, apellido, dni, direccion, telefono, año, division, matricula);

                    conexion.guardarAlumno(alumno);
                    conexion.crearUsuario((int)dni, matricula.ToString(), "Alumno");

                    padre.actualizarTabla();

                    MessageBox.Show("Se guardo correctamete");
                    this.Close();
                }
                else conexion.mostrarMensaje("Imposible guardar, combobox vacio");
            }
            else
            {
              
                MessageBox.Show("No se pudo guardar");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void cargarComboBox()
        {
            conexion.comboboxCursos(comboBox1);            
        }
    }
}
