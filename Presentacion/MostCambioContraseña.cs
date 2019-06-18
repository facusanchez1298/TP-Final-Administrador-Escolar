using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tp_lab_3;

namespace Presentacion
{
    public partial class MostCambioContraseña : MostBase
    {
        Conexion conexion;

        public MostCambioContraseña()
        {
            conexion = new Conexion();
            InitializeComponent();
            dataGridView1.Hide();
            pictureBox1.Hide();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            string tipo;
            if (padre.GetType() == typeof(VentAlumno))
            {
                tipo = "Alumno";
            }
            else if (padre.GetType() == typeof(VentProfesor))
            {
                tipo = "Profesor";
            }
            else tipo = "Administrador";


            if (!(nueva.Text.Length < 4) || !(nuevaRepetida.Text.Length < 4))
            {
                if (conexion.iniciarSesion(int.Parse(dni), actual.Text, tipo))
                {
                    if (nueva.Text.Equals(nuevaRepetida.Text))
                    {
                        if (!actual.Text.Equals(nueva.Text))
                        {
                            conexion.cambiarContraseña(dni, actual.Text, nueva.Text);
                            conexion.mostrarMensajeGuardado("contraseña cambiada con exito");
                            vaciarCampos();
                        }
                        else conexion.mostrarMensaje("contraseña anterior y actual iguales");
                    }
                    else conexion.mostrarMensaje("la nueva contraseña y su repeticion no coinciden");
                }
                else conexion.mostrarMensaje("el usuario y la contraseña no coinciden");
            }
            else conexion.mostrarMensaje("la contraseña no puede tener menos de 4 caracteres");
        }


        public void vaciarCampos()
        {
            actual.Text = "";
            nueva.Text = "";
            nuevaRepetida.Text = "";
        }

    }
}
