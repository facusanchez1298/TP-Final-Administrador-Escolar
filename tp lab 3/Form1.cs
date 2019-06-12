using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_lab_3
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// objeto conexion que vamos a usar
        /// </summary>
        Conexion conexion = new Conexion();


        public Form1()
        {
            InitializeComponent();
            conexion.crearBaseDeDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //conexion.reinstalarBaseDeDatos();
            //MessageBox.Show("reinstalada");

            MessageBox.Show(conexion.iniciarSesion(1234, "1234", "Alumno").ToString());
        }
    }
}
