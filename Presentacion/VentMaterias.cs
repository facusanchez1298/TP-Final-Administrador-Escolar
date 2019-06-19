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
    public partial class VentMaterias : FormEdicion
    {                

        Conexion conexion;
        public VentMaterias()
        {
            conexion = new Conexion();
            InitializeComponent();
            actualizarTabla();
            dataGridView1.CellMouseDoubleClick += agregarAlumno;
        }

        private void agregarAlumno(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id_asignatura;

            if (e.Button == MouseButtons.Left)
            {                
                id_asignatura = (int)dataGridView1.Rows[e.RowIndex].Cells[1].Value;
                                
                VenVerAlumnoMateria agrAlumnoAMateria = new VenVerAlumnoMateria(id_asignatura);
                agrAlumnoAMateria.ShowDialog();
            }            
        }




        private void btnAgregar_Click(object sender, EventArgs e)
        {
            VenAgrMateria NuevaVentana = new VenAgrMateria(this);
            NuevaVentana.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (seleccionado != null)
            {
                VenEdiMateria NuevaVentana = new VenEdiMateria(this, seleccionado);
                NuevaVentana.ShowDialog();
            }
            else conexion.mostrarMensaje("Debe seleccionar la materia que quiere editar");
        }

        internal void actualizarTabla()
        {
            conexion.tablaMaterias(dataGridView1);
        }

        private void btnElliminar_Click(object sender, EventArgs e)
        {
            if (seleccionado != null)
            {
                conexion.removerAsignatura((int)seleccionado.Cells["id_asignatura"].Value);
                actualizarTabla();
            }
        }

        private void errorTxtBox1_TextChanged(object sender, EventArgs e)
        {
            conexion.tablaMaterias(dataGridView1).DefaultView.RowFilter = $"Asignatura LIKE '{errorTxtBox1.Text}%'";
        }
    }
}
