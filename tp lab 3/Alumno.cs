using System;
using System.Collections.Generic;

namespace tp_lab_3
{
    class Alumno : Persona
    {
        public int matricula { get; set; }
        public Curso curso;
        public List<Asignatura> materiasAprobadas { get; set; }
        public float nota { get; set; }

        public Alumno(string nombre, string apellido, int dni, string direccion, int telefono, Curso curso, int matricula) : base(nombre, apellido, dni, direccion, telefono)
        {
            this.matricula = matricula;
            this.curso = curso ?? throw new ArgumentNullException(nameof(curso));
            materiasAprobadas = new List<Asignatura>();
            this.matricula = matricula;
        }



    }
}