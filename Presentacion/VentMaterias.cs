using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class VentMaterias : FormEdicion
    {
        public VentMaterias()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            VenAgrMateria NuevaVentana = new VenAgrMateria();
            NuevaVentana.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            VenEdiMateria NuevaVentana = new VenEdiMateria();
            NuevaVentana.Show();
        }
    }
}
