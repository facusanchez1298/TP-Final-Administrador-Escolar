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
    public partial class VenEdiCurso : VenAgr
    {

        VentCursos padre;
        Conexion conexion;

        public VenEdiCurso(VentCursos padre, DataGridViewRow seleccionado)
        {
            conexion = new Conexion();
            this.padre = padre;
            InitializeComponent();

            conexion.comboboxAulas(cBoxAula);

            int index = cBoxAula.FindStringExact(seleccionado.Cells["aulas"].Value.ToString());
            cBoxAula.SelectedIndex = index;

            errorTxtBox1.Text = seleccionado.Cells["año"].Value.ToString();
            errorTxtBox2.Text = seleccionado.Cells["division"].Value.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string aula = cBoxAula.Text;
            conexion.editarCurso(errorTxtBox1.Text, errorTxtBox2.Text, cBoxAula.Text);
            padre.actualizarTabla();
            this.Close();
        }
    }
}
