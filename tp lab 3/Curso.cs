using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_lab_3
{
    class Curso
    {
        public int año { get; set; }
        public char division { get; set; }
        public List<Asignatura> asignaturas { get; set; }
        public List<Alumno> alumnos { get; set; }
        public Aula aula { get; set; }

        public Curso(int año, char division, Aula aula)
        {
            this.año = año;
            this.division = division;
            this.aula = aula;
        }

        /// <summary>
        /// agrega un nuevo alumno al curso
        /// </summary>
        /// <param name="alumno">alumno que vamos a agregar</param>
        public void agregarAlumno( Alumno alumno)
        {
            if (hayEspacio()) alumnos.Add(alumno);
        }

        /// <summary>
        /// agrega una lista de alumnos al curso
        /// </summary>
        /// <param name="alumnos"></param>
        public void agregarAlumnos(List<Alumno> alumnos)
        {
            if (hayEspacio(alumnos.Count)) this.alumnos.AddRange(alumnos);
        }

        /// <summary>
        /// agrega una asignatura nueva al curso
        /// </summary>
        /// <param name="asignatura"></param>
        public void agregarAsignatura(Asignatura asignatura)
        {
            asignaturas.Add(asignatura);
        }

        /// <summary>
        /// agrega un grupo de asignaturas al curso
        /// </summary>
        /// <param name="asignaturas">grupo de asignaturas que vamos a guardar</param>
        public void agregarAsignaturas(List<Asignatura> asignaturas)
        {
            this.asignaturas.AddRange(asignaturas);
        }


        /// <summary>
        /// cambia el aula del curso si el aula nueva tiene suficiente capacidad
        /// </summary>
        /// <param name="aula">aula nueva</param>
        /// <returns> retorna true si se logro realizar el cambio y false en el caso contrario</returns>
        public bool cambiarAula(Aula aula)
        {
            if (aula.capacidad > this.alumnos.Count)
            {
                this.aula = aula;
                return true;
            }
            return false;
        }

        /// <summary>
        /// verifica si hay espacio en el aula para mas alumnos
        /// </summary>
        /// <returns></returns>
        private bool hayEspacio(int cantidad = 1)
        {
            return this.aula.capacidad >= alumnos.Count + cantidad;
        }

    }
}
