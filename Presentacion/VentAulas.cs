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
    public partial class VentAulas : FormEdicion
    {

        Conexion conexion;
        public VentAulas()
        {
            conexion = new Conexion();
            InitializeComponent();
           
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {            
            VenAgrAula NuevaVentana = new VenAgrAula(this);
            NuevaVentana.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            VenEdiAula NuevaVentana = new VenEdiAula(this);
            NuevaVentana.ShowDialog();
        }

        private void VentAulas_Load(object sender, EventArgs e)
        {
            actualizarTabla();
        }  
        
        public void actualizarTabla()
        {
            conexion.tablaAulas(dataGridView1);
        }

        private void btnElliminar_Click(object sender, EventArgs e)
        {
            if (seleccionado != null)
            {
                conexion.removerAula((int)seleccionado.Cells["numero"].Value);
                actualizarTabla();
            }
        }
    }
}
