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
            //conexion.crearUsuario(1234, "1234",rBtnProfesor.Text);
            //conexion.crearUsuario(1234, "1234", rBtnAdministrador.Text);
        }

        //Conexion con = new Conexion; 

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
                               
                if (rBtnAdministrador.Checked)
                {
                    if (conexion.iniciarSesion(usuario, contraseña, rBtnAdministrador.Text))
                    {
                        VentAdministrador NuevaVentana = new VentAdministrador();
                        NuevaVentana.Show();
                        NuevaVentana.FormClosed += cerrarCecion;
                        this.Hide();
                    }                    
                }

                else if (rBtnAlumno.Checked)
                {
                    if (conexion.iniciarSesion(usuario, contraseña, rBtnAlumno.Text))
                    {
                        VentAlumnos NuevaVentana = new VentAlumnos();
                        NuevaVentana.Show();
                        NuevaVentana.FormClosed += cerrarCecion;
                        this.Hide();
                    }
                }
                else if (rBtnProfesor.Checked)
                {
                    if (conexion.iniciarSesion(usuario, contraseña, rBtnProfesor.Text))
                    {
                        VentProfesores NuevaVentana = new VentProfesores();
                        NuevaVentana.Show();
                        NuevaVentana.FormClosed += cerrarCecion;
                        this.Hide();
                    }
                }
                else
                {
                    msgError("Error en el Usuario o la Contraseña...Intente de nuevo...");
                    txtUsuario.Text = "";
                    txtContraceña.Text = "";
                    txtUsuario.Focus();
                }

            }



                //if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
                //{                    
                //   

                //}
                //else
                //{
                //    //msgError("Error en el Usuario o la Contraseña...Intente de nuevo...");
                //    txtUsuario.Text = "";
                //    txtContraceña.Text = "";
                //    txtUsuario.Focus();
                //}
                
        }
        
        //esto es para que cuando no encuentre el usuario o le erre en la contraceña muestre un msj de error
        private void msgError(string msg)
        {
            lblErrorConexion.Text = "    " + msg;
            lblErrorConexion.Visible = true;
        }

        private void cerrarCecion(object sender, FormClosedEventArgs e)
        {
            txtUsuario.Clear();
            txtContraceña.Clear();
            lblErrorConexion.Visible = false;
            this.Show();
            txtUsuario.Focus();
            errorProvider1.Clear();
        }

        private void rBtnAlumno_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
