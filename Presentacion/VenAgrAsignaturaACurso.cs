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
    public partial class VenAgrAsignaturaACurso : MostBase
    {
        string año;
        string division;
        Conexion conexion;

        public VenAgrAsignaturaACurso(string año, string division)
        {
            this.año = año;
            this.division = division;
            conexion = new Conexion();
            InitializeComponent();
            actualizarTabla();
        }

        public void actualizarTabla()
        {
            conexion.tablaMateriasCurso(año, division, dataGridView1);
        }

      
    }
}
