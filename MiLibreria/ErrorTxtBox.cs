using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiLibreria
{
    public partial class ErrorTxtBox : TextBox
    {
        public ErrorTxtBox()
        {
            InitializeComponent();
        }
        public Boolean Validar // al poner en true esta opcion no me deja guardar algo si este txtbox esta vacio
        {
            set;
            get;
        }

        public Boolean SoloNumeros // al poner en true esta opcion no me deja guardar algo si este txtbox tiene algo que no sean numeros
        {
            set;
            get;
        }

    }
}
