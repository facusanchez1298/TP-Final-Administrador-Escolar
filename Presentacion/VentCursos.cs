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
    public partial class VentCursos : FormEdicion
    {
        Conexion conexion;

        public VentCursos()
        {
            conexion = new Conexion();
            InitializeComponent();
            conexion.tablaCursos(dataGridView1);
            dataGridView1.CellMouseDoubleClick += agregarAlumno;
        }

        private void agregarAlumno(object sender, DataGridViewCellMouseEventArgs e)
        {
            

            if (e.Button == MouseButtons.Left)
            {
                string año = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string division = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

                VenAgrAsignaturaACurso agrAlumnoAMateria = new VenAgrAsignaturaACurso(año, division);
                agrAlumnoAMateria.ShowDialog();
            }
        }

        public void actualizarTabla()
        {
            conexion.tablaCursos(dataGridView1);
        }

        private void agregarCurso(object sender, EventArgs e)
        {
            VenAgrCurso NuevaVentana = new VenAgrCurso(this);
            NuevaVentana.ShowDialog();
        }

        private void editarCurso(object sender, EventArgs e)
        {
            VenEdiCurso NuevaVentana = new VenEdiCurso(this);
            NuevaVentana.ShowDialog();
        }

        private void eliminarCurso(object sender, EventArgs e)
        {
            if (seleccionado != null)
            {
                string año = seleccionado.Cells["año"].Value.ToString(); ;
                string division = seleccionado.Cells["division"].Value.ToString();

                conexion.removerCurso(año, division);
                actualizarTabla();
            }
        }
    }
}
