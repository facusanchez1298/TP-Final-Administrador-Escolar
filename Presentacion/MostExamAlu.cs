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
    public partial class MostExamAlu : MostBase
    {

        Conexion conexion;
        public MostExamAlu()
        {
            conexion = new Conexion();
            InitializeComponent();
            actualizarTabla();
        }

        private void actualizarTabla()
        {
            conexion.tablaExamenes(this.dni, dataGridView1);
        }
    }
}
