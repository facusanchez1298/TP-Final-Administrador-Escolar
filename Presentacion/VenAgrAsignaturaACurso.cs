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
    public partial class VenAgrAsignaturaACurso : MostBase
    {
        string año;
        string division;
        Conexion conexion;

        public VenAgrAsignaturaACurso(string año, string division)
        {
            this.año = año;
            this.division = division;
            conexion = new Conexion();
            InitializeComponent();
            actualizarTabla();
            actualizarComboBox();
        }

        public void actualizarTabla()
        {
            conexion.tablaMateriasCurso(año, division, dataGridView1);
        }

        public void actualizarComboBox()
        {
            conexion.comboboxAsignaturas(año, division, comboBox2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id_asignatura = (int)comboBox2.SelectedValue;
            conexion.guardarCurso_asig(año, division, id_asignatura);
            actualizarTabla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (seleccionado != null)
            {
                conexion.removerCurso_asignatura(año, division, (int)seleccionado.Cells["numero identificador"].Value);
                seleccionado = null;
                actualizarTabla();
            }
        }
    }
}
