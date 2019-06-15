using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_lab_3
{
    public abstract class Persona
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public decimal dni { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }

        public Persona(string nombre, string apellido, decimal dni, string direccion, string telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.direccion = direccion;
            this.telefono = telefono;
        }
    }
}
