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
    public partial class MostBase : Form
    {

        public string dni;
        public VentPrincBase padre;

        public DataGridViewRow seleccionado { get; set; }

        public MostBase()
        {
            InitializeComponent();
            dataGridView1.AutoResizeColumns();
            
        }

        public void darPadre(VentPrincBase padre)
        {
            this.padre = padre;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void darDni(string dni)
        {
            this.dni = dni;
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
    }
}
