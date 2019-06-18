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
    public partial class AgregarNotaExamen : MostBase
    {
        Conexion conexion;
        public AgregarNotaExamen()
        {
            conexion = new Conexion();
            InitializeComponent();
            domainUpDown1.SelectedIndex = 0;
            ActualizarTabla();
        }

        public void ActualizarTabla()
        {
            conexion.tablaExamenesProfesor(dni, dataGridView1);
        }
    }
}
