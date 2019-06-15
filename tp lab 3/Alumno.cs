using System;
using System.Collections.Generic;

namespace tp_lab_3
{
    public class Alumno : Persona
    {
        public decimal matricula { get; set; }
        public string año;
        public string  division { get; set; }
        public List<Asignatura> materiasAprobadas { get; set; }
        public float nota { get; set; }

        public Alumno(string nombre, string apellido, decimal dni, string direccion, string telefono, string año, string division, int matricula) : base(nombre, apellido, dni, direccion, telefono)
        {
            this.matricula = matricula;
            this.año = año;
            this.division = division;
            materiasAprobadas = new List<Asignatura>();
            this.matricula = matricula;
        }



    }
}