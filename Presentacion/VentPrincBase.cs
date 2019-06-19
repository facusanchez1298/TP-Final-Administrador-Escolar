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

        //          esto era para que cuando pasas el mouse se muestre el menu y cuando lo sacaras se ocultara
        //    this.MenuVertical.Controls.Cast<Control>().ToList().ForEach(q => q.MouseHover += Q_MouseHover);
        //    this.MenuVertical.Controls.Cast<Control>().ToList().ForEach(q => q.MouseLeave += Q_MouseLeave);

        //}

        //private void Q_MouseLeave(object sender, EventArgs e)
        //{
        //    MenuVertical.Width = 250;
        //    btnPanel.Location = new Point(250, 0);
        //}

        //private void Q_MouseHover(object sender, EventArgs e)
        //{
        //    MenuVertical.Width = 250;
        //    btnPanel.Location = new Point(250, 0);
        //}

        // esto es para poder mover la ventana con el mouse
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hund, int wmsg, int wparam, int lparam);
        private void VentPrincBase_Load(object sender, EventArgs e)
        {

        }

       
        //Capturamos posicion y tamaño antes de maximizar para restaurar
        int lx, ly;
        int sw, sh;

       

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
                MenuVertical.Width = 55;
                btnPanel.Location = new Point(55, 0);
            }
            else
            {
                MenuVertical.Width = 250;
                btnPanel.Location = new Point(250, 0);

            }
        }



        private void MenuVertical_MouseLeave(object sender, EventArgs e)
        {
            MenuVertical.Width = 55;
            btnPanel.Location = new Point(55, 0);
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

       
    }
}
