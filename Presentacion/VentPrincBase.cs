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
namespace Presentacion
{
    public partial class VentPrincBase : FormBase
    {
        public VentPrincBase()
        {
            InitializeComponent();
        }
        // esto es para poder mover la ventana con el mouse
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hund, int wmsg, int wparam, int lparam);
        private void VentPrincBase_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //Capturamos posicion y tamaño antes de maximizar para restaurar
        int lx, ly;
        int sw, sh;

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void panelMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            
            btnAulas.BackColor = Color.FromArgb(12, 63, 92);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnMaterias.BackColor = Color.FromArgb(12, 63, 92);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnPersonal.BackColor = Color.FromArgb(12, 63, 92);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
                btnPanel.Location = new Point(70, 0);
            }
            else
            {
                MenuVertical.Width = 250;
                btnPanel.Location = new Point(250, 0);

            }
        }

        public void btnCerrar_Click_1(object sender, EventArgs e)
        {
          
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de querer Cerrar Sesión?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        /*//METODO PARA ABRIR FORM DENTRO DE PANEL-----------------------------------------------------
        public void AbrirFormEnPanel<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = panelformularios.Controls.OfType<Forms>().FirstOrDefault();

            //si el formulario/instancia no existe, creamos nueva instancia y mostramos
            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelformularios.Controls.Add(formulario);
                panelformularios.Tag = formulario;
                formulario.Show();

                formulario.BringToFront();
                //formulario.FormClosed += new FormClosedEventHandler(CloseForms);               
            }
            else
            {

                //si la Formulario/instancia existe, lo traemos a frente
                formulario.BringToFront();

                //Si la instancia esta minimizada mostramos
                if (formulario.WindowState == FormWindowState.Minimized)
                {
                    formulario.WindowState = FormWindowState.Normal;
                }

            }
            //Esto es para cuendo cierre los formularios q me vuelva el boton al mismo color del panel
             void CloseForms(object sender, FormClosedEventArgs e)
            {
                if (Application.OpenForms["Form1"] == null)
                    btnAulas.BackColor = Color.FromArgb(25, 38, 70);
               /* if (Application.OpenForms["Vent"] == null)
                    button2.BackColor = Color.FromArgb(25, 38, 70);
                if (Application.OpenForms["Form3"] == null)
                    button3.BackColor = Color.FromArgb(25, 38, 70);
            }
        }*/
    }
}
