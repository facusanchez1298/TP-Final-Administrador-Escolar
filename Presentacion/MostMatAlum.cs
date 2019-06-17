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
    public partial class MostMatAlum : MostBase
    {
        Conexion conexion;
        public MostMatAlum()
        {
            conexion = new Conexion();
            InitializeComponent();
            actualizarTabla();
        }

        public void actualizarTabla()
        {
            conexion.tablaMateriasAlumno(this.dni, dataGridView1);
        }
    }
}
