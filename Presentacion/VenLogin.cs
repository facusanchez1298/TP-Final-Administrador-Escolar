using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MiLibreria;
using tp_lab_3;

namespace Presentacion
{
    public partial class VenLogin : FormBase
    {
        Conexion conexion;
        public VenLogin()
        {

            conexion = new Conexion();
            conexion.crearBaseDeDatos();
            InitializeComponent();
            //conexion.crearUsuario(1234, "1234", rBtnAlumno.Text);
            //conexion.crearUsuario(1234, "1234", rBtnProfesor.Text);
            //conexion.crearUsuario(1234, "1234", rBtnAdministrador.Text);
        }


        // esto me permite poder mover la ventana de login con el cursor
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hund, int wmsg, int wparam, int lparam);

        private void VenLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                int usuario = int.Parse(txtUsuario.Text);
                string contraseña = txtContraceña.Text;
                string dni = usuario.ToString();

                if (rBtnAdministrador.Checked)
                {
                    if (conexion.iniciarSesion(usuario, contraseña, rBtnAdministrador.Text))
                    {
                        VentAdministrador NuevaVentana = new VentAdministrador(dni);
                        NuevaVentana.Show();
                        NuevaVentana.FormClosed += cerrarSesion;
                        this.Hide();
                    }
                    else conexion.mostrarMensaje("Usuario o contraseña invalidos");
                }


                else if (rBtnAlumno.Checked)
                {
                    if (conexion.iniciarSesion(usuario, contraseña, rBtnAlumno.Text))
                    {
                        VentAlumno NuevaVentana = new VentAlumno(dni);
                        NuevaVentana.Show();
                        NuevaVentana.FormClosed += cerrarSesion;
                        this.Hide();
                    }
                    else conexion.mostrarMensaje("Usuario o contraseña invalidos");
                }


                else if (rBtnProfesor.Checked)
                {
                    if (conexion.iniciarSesion(usuario, contraseña, rBtnProfesor.Text))
                    {
                        VentProfesor NuevaVentana = new VentProfesor(this.txtUsuario.Text);
                        NuevaVentana.Show();
                        NuevaVentana.FormClosed += cerrarSesion;
                        this.Hide();
                    }
                    else conexion.mostrarMensaje("Usuario o contraseña invalidos");
                }


                else
                {
                    conexion.mostrarMensaje("Usuario o contraseña invalidos");
                    msgError("Error en el Usuario o la Contraseña...Intente de nuevo...");                    
                    txtUsuario.Focus();
                }
            }
            
            
        }




        //esto es para que cuando no encuentre el usuario o le erre en la contraceña muestre un msj de error
        private void msgError(string msg)
        {
            lblErrorConexion.Text = "    " + msg;
            lblErrorConexion.Visible = true;
        }

        private void cerrarSesion(object sender, FormClosedEventArgs e)
        {
            txtUsuario.Clear();
            txtContraceña.Clear();
            lblErrorConexion.Visible = false;
            this.Show();
            txtUsuario.Focus();
            errorProvider1.Clear();
        }



    }
}
