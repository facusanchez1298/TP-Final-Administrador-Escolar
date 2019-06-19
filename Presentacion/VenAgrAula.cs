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
        Conexion conexion;

        public VenAgrAula(FormEdicion padre)
        {
            conexion = new Conexion();
            InitializeComponent();

            this.padre = (VentAulas)padre;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Dentro de esto tenes que poner la conexion a la base de datos
            if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                int numero = int.Parse(errorTxtBox1.Text);
                int capacidad = int.Parse(errorTxtBox2.Text);
                bool proyector = (cBoxProyector.Text == "SI") ? true : false;
                bool internet = (cBoxInternet.Text == "SI") ? true : false;

               

                conexion.guardarAula(numero, capacidad, internet, proyector);

                padre.actualizarTabla();
                MessageBox.Show("Se guardo correctamete");                
            }
            else MessageBox.Show("No se pudo guardar");

            this.Close();
        }

      
    }
}
