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
    public partial class VentAlumno : VentPrincBase
    {
        public VentAlumno()
        {
            InitializeComponent();
        }
        //METODO PARA ABRIR FORM DENTRO DE PANEL-----------------------------------------------------
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

               formulario.FormClosed += new FormClosedEventHandler(CloseForms);               
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
               if (Application.OpenForms["MostMatAlum"] == null)
                   btnMaterias.BackColor = Color.FromArgb(25, 38, 70);
                if (Application.OpenForms["MostAulAlum"] == null)
                    btnAulas.BackColor = Color.FromArgb(25, 38, 70);
            }
       }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<MostMatAlum>();
        }

        private void btnAulas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<MostExamAlu>();
        }
    }
}
