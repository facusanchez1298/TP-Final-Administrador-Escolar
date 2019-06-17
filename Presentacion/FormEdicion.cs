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
    public partial class FormEdicion : Form
    {
       
        Conexion conexion;

        public DataGridViewRow seleccionado { get; set; }

        public FormEdicion()
        {
            conexion = new Conexion();
            InitializeComponent();
            dataGridView1.RowHeadersVisible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void seleccionarFila(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left && e.RowIndex > -1)
            {
                //Para evitar multiselección

                foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
                {

                    dr.Selected = false;
                }

                //Para seleccionar
                dataGridView1.Rows[e.RowIndex].Selected = true;
                seleccionado = dataGridView1.Rows[e.RowIndex];

            }
        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            seleccionado = null;
        }
    }
}
