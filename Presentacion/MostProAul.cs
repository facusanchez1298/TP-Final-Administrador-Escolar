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
    public partial class MostProAul : MostBase
    {

        Conexion conexion;


        public MostProAul()
        {            
            conexion = new Conexion();
            InitializeComponent();
            actualizarTabla();
        }

        public void actualizarTabla()
        {
            conexion.tablaMateriasProfesor(this.dni, dataGridView1);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
           
        }
    }
}
