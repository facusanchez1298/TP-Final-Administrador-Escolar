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
    public partial class VenEdiMateria : VenAgr
    {
        VentMaterias padre;
        DataGridViewRow seleccionado;
        Conexion conexion;

        public VenEdiMateria(VentMaterias padre, DataGridViewRow seleccionado)
        {
            conexion = new Conexion();
            this.padre = padre;
            this.seleccionado = seleccionado;
            InitializeComponent();

            errorTxtBox1.ReadOnly = true;

            errorTxtBox2.Text = seleccionado.Cells["Asignatura"].Value.ToString();
            errorTxtBox1.Text = seleccionado.Cells["Identificador"].Value.ToString();
            conexion.comboBoxProfesores(cBoxProfesor);

            cBoxProfesor.FindString(seleccionado.Cells[2].Value.ToString());
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string id_asignatura = errorTxtBox1.Text;
            string materia = errorTxtBox2.Text;
            string profesor = cBoxProfesor.SelectedValue.ToString();

            conexion.editarMateria(id_asignatura, materia, profesor);

            padre.actualizarTabla();
            this.Close();
        }
    }
}
