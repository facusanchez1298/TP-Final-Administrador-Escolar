﻿using System;
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
    public partial class VentMaterias : FormEdicion
    {

        DataGridViewRow seleccionada;

        Conexion conexion;
        public VentMaterias()
        {
            conexion = new Conexion();
            InitializeComponent();
            actualizarTabla();
            dataGridView1.CellMouseDoubleClick += agregarAlumno;
        }

        private void agregarAlumno(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id_asignatura;

            if (e.Button == MouseButtons.Left)
            {                
                id_asignatura = (int)dataGridView1.Rows[e.RowIndex].Cells[1].Value;
                                
                VenVerAlumnoMateria agrAlumnoAMateria = new VenVerAlumnoMateria(id_asignatura);
                agrAlumnoAMateria.ShowDialog();
            }            
        }




        private void btnAgregar_Click(object sender, EventArgs e)
        {
            VenAgrMateria NuevaVentana = new VenAgrMateria(this);
            NuevaVentana.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            VenEdiMateria NuevaVentana = new VenEdiMateria(this);
            NuevaVentana.ShowDialog();
        }

        internal void actualizarTabla()
        {
            conexion.tablaMaterias(dataGridView1);
        }

        private void btnElliminar_Click(object sender, EventArgs e)
        {
            if (seleccionado != null)
            {
                conexion.removerAsignatura((int)seleccionado.Cells["id_asignatura"].Value);
                actualizarTabla();
            }
        }
    }
}
