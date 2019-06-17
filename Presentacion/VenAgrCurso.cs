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
    public partial class VenAgrCurso : VenAgr
    {
        Conexion conexion = new Conexion();

        VentCursos padre;

        public VenAgrCurso(FormEdicion padre)
        {

            this.padre = (VentCursos) padre;
            InitializeComponent();

           
            conexion.comboboxAulas(this.cBoxAula);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Dentro de esto tenes que poner la conexion a la base de datos
            if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                string año = errorTxtBox1.Text;
                string division = errorTxtBox2.Text;
                int aula = int.Parse(cBoxAula.Text);


                conexion.guardarCurso(año, division, aula);

                padre.actualizarTabla();

                MessageBox.Show("Se guardo correctamete");
                this.Close();



            }
            else
            {
                errorTxtBox1.Text = "";
                errorTxtBox2.Text = "";
                MessageBox.Show("No se pudo guardar");

            }

            padre.actualizarTabla();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
