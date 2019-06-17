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
    public partial class VentAlumnos : FormEdicion
    {
        Conexion conexion = new Conexion();


        public VentAlumnos()
        {
            InitializeComponent();
            conexion.tablaAlumnos(dataGridView1);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            VenAgrAlumno NuevaVentana = new VenAgrAlumno(this);
            NuevaVentana.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            VenEdiAlumno NuevaVentana = new VenEdiAlumno(this);
            NuevaVentana.ShowDialog();
        }

        public void actualizarTabla()
        {
            conexion.tablaAlumnos(dataGridView1);
        }

        private void btnElliminar_Click(object sender, EventArgs e)
        {
            if (seleccionado != null)
            {
                conexion.removerAlumno((int)seleccionado.Cells["dni"].Value);
                actualizarTabla();
                
            }
        }
    }
}
