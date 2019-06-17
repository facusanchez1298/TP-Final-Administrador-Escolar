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
    public partial class VentProfesores : FormEdicion
    {
        Conexion conexion = new Conexion();

        public VentProfesores()
        {            
            InitializeComponent();
            actualizarTabla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            VenAgrProfesor NuevaVentana = new VenAgrProfesor(this);
            NuevaVentana.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            VenEdiProfesor NuevaVentana = new VenEdiProfesor(this);
            NuevaVentana.ShowDialog();
        }

        internal void actualizarTabla()
        {
           conexion.tablaProfesor(dataGridView1);
        }

        private void btnElliminar_Click(object sender, EventArgs e)
        {
            if (seleccionado != null)
            {
                conexion.removerProfesor((int)seleccionado.Cells["dni"].Value);
                actualizarTabla();
            }
        }
    }
}
