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
    public partial class VentAlumnos : FormEdicion
    {
        public VentAlumnos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            VenAgrAlumno NuevaVentana = new VenAgrAlumno();
            NuevaVentana.Show();
        }
    }
}
