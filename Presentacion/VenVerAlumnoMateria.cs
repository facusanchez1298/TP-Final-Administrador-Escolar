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
    public partial class VenVerAlumnoMateria : MostBase
    {

        int id_asignatura;

        Conexion conexion;

        public VenVerAlumnoMateria(int id_asignatura)
        {
            conexion = new Conexion();
            this.id_asignatura = id_asignatura;
            InitializeComponent();
            actualizarTabla();
            cargarComboBox();                                 
        }

        public void actualizarTabla()
        {
            conexion.tablaAlumnoMaterias(id_asignatura, dataGridView1);
        }

        public void cargarComboBox()
        {
            conexion.comboboxAlumnos(comboBox1);
        }

        private void guardarAlumno(object sender, EventArgs e)
        {
            int dni = (int)comboBox1.SelectedValue;
            conexion.guardarAlu_Asig(dni, id_asignatura);
            actualizarTabla();
        }

        private void borrarAlumno(object sender, EventArgs e)
        {
            if (seleccionado != null)
            {                
                conexion.removerAlumno_asignatura((int)seleccionado.Cells["dni"].Value, id_asignatura);
                actualizarTabla();
            }
        }
    }
}
