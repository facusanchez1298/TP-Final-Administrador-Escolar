using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tp_lab_3;

namespace Presentacion
{
    public partial class VenEdiAula : VenAgr
    {
        DataGridViewRow seleccionado;
        VentAulas padre;
        Conexion conexion;

        public VenEdiAula(VentAulas padre, DataGridViewRow seleccionado)
        {
            this.padre = padre;
            conexion = new Conexion();
            this.seleccionado = seleccionado;
            InitializeComponent();

            errorTxtBox1.ReadOnly = true;

            errorTxtBox1.Text = seleccionado.Cells["numero"].Value.ToString();
            errorTxtBox2.Text = seleccionado.Cells["capacidad"].Value.ToString();
            cBoxInternet.SelectedIndex = seleccionado.Cells["internet"].Value.ToString().Equals("true") ? 1 : 0;
            cBoxProyector.SelectedIndex = seleccionado.Cells["proyector"].Value.ToString().Equals("true") ? 1 : 0;

           
        }
     

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (errorTxtBox1.Text != "")
            {
                int numero = int.Parse(errorTxtBox1.Text);
                int capacidad = int.Parse(errorTxtBox2.Text);
                bool internet = this.cBoxInternet.Text.Equals("SI") ? true : false;
                bool proyector = cBoxProyector.Text.Equals("SI") ? true : false;

                conexion.editarAula(numero, capacidad, internet, proyector);
                padre.actualizarTabla();
                this.Close();
            }
            else conexion.mostrarMensaje("Error, el numero del aula no puede estar vacio");
        }
    }
}
