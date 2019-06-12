using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class VentAdministrador : VentPrincBase
    {
        public VentAdministrador()
        {
            InitializeComponent();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            btnAlumnos.BackColor = Color.FromArgb(12, 63, 92);
            AbrirFormEnPanel<VentAlumnos>();
        }

        private void btnProf_Click(object sender, EventArgs e)
        {
            btnProf.BackColor = Color.FromArgb(12, 63, 92);
            AbrirFormEnPanel<VentProfesores>();
        }

        private void btnAdm_Click(object sender, EventArgs e)
        {
            btnAdm.BackColor = Color.FromArgb(12, 63, 92);
            AbrirFormEnPanel<VentAdministradores>();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {

        }

       

        private void btnAulas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<VentAulas>();
            
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<VentMaterias>();
        }
        //METODO PARA ABRIR FORM DENTRO DE PANEL-----------------------------------------------------
        private void AbrirFormEnPanel<Forms>() where Forms : Form, new()
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
                formulario.FormClosed += new FormClosedEventHandler(CloseForms );

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
        }
        private void CloseForms(object sender, FormClosedEventArgs e)
        {

             if(Application.OpenForms["VentMaterias"]==null)
             {
                 btnMaterias.BackColor = Color.FromArgb(25, 38, 70);
             }

             if (Application.OpenForms["VentProfesores"]==null)
             {
                 btnProf.BackColor = Color.FromArgb(25, 38, 70);
             }

             if (Application.OpenForms["VentAlumnos"]==null)
             {
                 btnAlumnos.BackColor = Color.FromArgb(25, 38, 70);
             }

             if (Application.OpenForms["VentAdministradores"]==null)
             {
                 btnAdm.BackColor = Color.FromArgb(25, 38, 70);
             }

             if (Application.OpenForms["VentAulas"]==null)
             {
                 btnAulas.BackColor = Color.FromArgb(25, 38, 70);
             }




        }

        private void btnPanel_Click(object sender, EventArgs e)
        {
            //if (btnCerrarSesion.Visible == true) btnCerrarSesion.Visible = false;
            //else btnCerrarSesion.Visible = true;
            
        }
    }
}
