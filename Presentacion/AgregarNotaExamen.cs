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
        int id_asignatura;
        Conexion conexion;
        public AgregarNotaExamen()
        {
            conexion = new Conexion();
            InitializeComponent();
            selector.SelectedIndex = 0;
            ActualizarTabla();

            mostrarElementos(false);

            dataGridView1.DoubleClick += abrirExamenes;
            dataGridView1.AllowUserToOrderColumns = true;
        }

        private void abrirExamenes(object sender, EventArgs e)
        {
            id_asignatura = (int)seleccionado.Cells["id"].Value;
            conexion.tablaExamenesProfesor(dni, id_asignatura, dataGridView1);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoResizeColumns();
            mostrarElementos(true);
            seleccionado = null;
        }

        public void ActualizarTabla()
        {
            conexion.tablaMateriasProfesor(dni, dataGridView1);
        }

        public void mostrarElementos(bool mostrar)
        {
            foreach (Control control in this.Controls)
            {
                if (control.Tag != null)
                {
                    if (control.Tag.Equals("Agregar"))
                    {
                        control.Visible = mostrar;
                    }
                }
            }
        }

        private void buttonSubirNota_Click(object sender, EventArgs e)
        {
            if (seleccionado != null)
            {
                if (this.nota.Text != "")
                {
                    int dni = (int)seleccionado.Cells["dni"].Value;
                    int nota = int.Parse(this.nota.Text);

                    if (!(nota < 1) && !(nota > 10))
                    {
                        switch (selector.SelectedIndex + 1)
                        {
                            case 1: conexion.guardarNotaExamen(dni, "primerParcial", id_asignatura, nota); break;
                            case 2: conexion.guardarNotaExamen(dni, "segundoParcial", id_asignatura, nota); break;
                            case 3: conexion.guardarNotaExamen(dni, "tercerParcial", id_asignatura, nota); break;
                            case 4: conexion.guardarNotaExamen(dni, "primerRecuperatorio", id_asignatura, nota); break;
                            case 5: conexion.guardarNotaExamen(dni, "segundoRecuperatorio", id_asignatura, nota); break;
                        }
                    }
                    else conexion.mostrarMensaje("la nota no puede ser superior a 10 ni inferior a 1");
                    conexion.tablaExamenesProfesor(this.dni, id_asignatura, dataGridView1);
                    //deseleccionar();
                    //seleccionado = null;
                }
                else conexion.mostrarMensaje("no se ha ingresado la nota");
            }
            else conexion.mostrarMensaje("no hay alumno seleccionado. por favor hacer click sobre el alumno al que desea cargarle la nota");
        }
    }
}
