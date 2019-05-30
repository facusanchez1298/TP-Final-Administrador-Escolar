using System;
using System.Collections.Generic;

namespace tp_lab_3
{
    public class Asignatura
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public List<Examen> examenes = new List<Examen>();
        public Correlativas correlativas = new Correlativas();
        public List<Profesor> profesores = new List<Profesor>();


        public Asignatura(int id_asignatura, string nombre, Correlativas correlativas, List<Profesor> profesores)
        {
            this.id = id_asignatura;
            this.nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            this.correlativas = correlativas ?? throw new ArgumentNullException(nameof(correlativas));
            this.profesores = profesores ?? throw new ArgumentNullException(nameof(profesores));

        }

        public Asignatura(int id_asignatura, string nombre, List<Profesor> profesores)
        {
            this.id = id_asignatura;
            this.nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            this.profesores = profesores ?? throw new ArgumentNullException(nameof(profesores));
        }

        public void agregarExamenes(List<Examen> examenes)
        {
            this.examenes.AddRange(examenes);
        }


    }
}