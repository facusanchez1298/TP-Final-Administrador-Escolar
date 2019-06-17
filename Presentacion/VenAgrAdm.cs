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
namespace Presentacion
{
    public partial class VenAgrAdm : VenAgr
    {
        public VenAgrAdm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Dentro de esto tenes que poner la conexion a la base de datos
            if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                MessageBox.Show("Se guardo correctamete");
                this.Close();



            }
            else
            {
                errorTxtBox1.Text = "";
                errorTxtBox2.Text = "";
                MessageBox.Show("No se pudo guardar");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void errorTxtBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
