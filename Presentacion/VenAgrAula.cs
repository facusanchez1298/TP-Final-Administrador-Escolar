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
    public partial class VenAgrAula : VenAgr
    {

        VentAulas padre;
        public VenAgrAula(VentAulas padre)
        {
            this.padre = padre;
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Dentro de esto tenes que poner la conexion a la base de datos
                if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
                {
                Aula au = new Aula(int.Parse(errorTxtBox2.Text), int.Parse(errorTxtBox1.Text), bool.Parse(cBoxProyector.Text), bool.Parse(cBoxInternet.Text));

                
                MessageBox.Show("Se guardo correctamete");

                padre.aulas.Add(au);
                

                this.Close();    

                }
                else
                {
                errorTxtBox1.Text = "";
                errorTxtBox2.Text = "";
                MessageBox.Show("No se pudo guardar");

            }
        }
    }
}
