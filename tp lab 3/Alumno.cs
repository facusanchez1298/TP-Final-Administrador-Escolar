using System;
using System.Collections.Generic;

namespace tp_lab_3
{
    public class Alumno : Persona
    {
        public int matricula { get; set; }
        public string curso;
        public List<Asignatura> materiasAprobadas { get; set; }
        public float nota { get; set; }

        public Alumno(string nombre, string apellido, int dni, string direccion, int telefono, string curso, int matricula) : base(nombre, apellido, dni, direccion, telefono)
        {
            this.matricula = matricula;
            this.curso = curso;
            materiasAprobadas = new List<Asignatura>();
            this.matricula = matricula;
        }



    }
}