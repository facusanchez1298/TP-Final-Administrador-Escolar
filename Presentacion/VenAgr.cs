using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiLibreria;
namespace Presentacion
{
    public partial class VenAgr : FormBase
    {
        public VenAgr()
        {
            InitializeComponent();
        }
        
        public void btnCerrar_Click_1(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
               /* Dentro de esto tenes que poner la conexion a la base de datos
                if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
                {



                    

                }
                else
                {
                    //msgError("Error no se puede realizar la acción...");
                  
                }*/

            
        }
    }
}
