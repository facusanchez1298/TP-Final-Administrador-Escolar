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
    public partial class VentAdministradores : FormEdicion
    {
        public VentAdministradores()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            VenAgrAdm NuevaVentana = new VenAgrAdm();
            NuevaVentana.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            VenEdiAdm NuevaVentana = new VenEdiAdm();
            NuevaVentana.ShowDialog();
        }
    }
}
