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

   

    public partial class VentAulas : FormEdicion
    {

        public List<Aula> aulas = new List<Aula>();

        public VentAulas()
        {
            
            InitializeComponent();
           
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            VenAgrAula NuevaVentana = new VenAgrAula(this);
            NuevaVentana.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            VenEdiAula NuevaVentana = new VenEdiAula(this);
            NuevaVentana.Show();
        }

        private void VentAulas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = aulas;
        }

        private void VentAulas_Resize(object sender, EventArgs e)
        {
            dataGridView1.DataSource = aulas;
        }
    }
}

