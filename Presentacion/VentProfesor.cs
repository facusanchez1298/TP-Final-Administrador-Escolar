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
    public partial class VentProfesor : VentPrincBase
    {
        public string dni;

        public VentProfesor(string dni)
        {
            this.dni = dni;
            InitializeComponent();
        }

        private void btnCargarExamenes_Click(object sender, EventArgs e)
        {
            btnCargarExamenes.BackColor = Color.FromArgb(12, 63, 92);
        }


        //METODO PARA ABRIR FORM DENTRO DE PANEL-----------------------------------------------------
        public void AbrirFormEnPanel<Form>(string dni) where Form :  MostBase, new()
        {
            Form formulario;
            formulario = panelformularios.Controls.OfType<Form>().FirstOrDefault();

            //si el formulario/instancia no existe, creamos nueva instancia y mostramos
            if (formulario == null)
            {
                formulario = new Form();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;                
                formulario.darDni(dni);
                panelformularios.Controls.Add(formulario);
                panelformularios.Tag = formulario;
                formulario.Show();
                formulario.FormClosed += closeForms;

                if(formulario.GetType() == typeof(MostProMat)) (formulario as MostProMat).dni = dni; 
                else if (formulario.GetType() == typeof(MostProAul)) (formulario as MostProAul).dni = dni;



                formulario.BringToFront();               
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


        //arregla el color
        private void closeForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["MostProMat"] == null)
                btnMaterias.BackColor = Color.FromArgb(25, 38, 70);
            if (Application.OpenForms["MostProAul"] == null)
                btnAulas.BackColor = Color.FromArgb(25, 38, 70);
        }

        private void btnAulas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<MostProAul>(dni);
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<MostProMat>(dni);
        }
    }
}
