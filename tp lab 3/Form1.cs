﻿using System;
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
    }
}
