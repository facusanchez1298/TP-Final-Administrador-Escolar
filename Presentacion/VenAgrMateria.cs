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
    public partial class VenAgrMateria : VenAgr
    {
        VentMaterias padre;
        Conexion conexion;

        public VenAgrMateria(VentMaterias padre)
        {
            this.padre = padre;
            conexion = new Conexion();
            InitializeComponent();

            conexion.comboBoxProfesores(cBoxProfesor);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Dentro de esto tenes que poner la conexion a la base de datos
            if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
            {


                conexion.guardarAsignatura(int.Parse(errorTxtBox1.Text), errorTxtBox2.Text, (int)cBoxProfesor.SelectedValue);

                padre.actualizarTabla();
                MessageBox.Show("Se guardo correctamete");
                this.Close();
            }
            else
            {
                
                MessageBox.Show("No se pudo guardar");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}