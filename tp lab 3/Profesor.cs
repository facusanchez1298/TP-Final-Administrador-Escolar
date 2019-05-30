using System;
using System.Collections.Generic;

namespace tp_lab_3
{
    public class Profesor : Persona
    {
        public bool delCentro { get; set; }
        public List<Asignatura> asignaturas = new List<Asignatura>();


        public Profesor(string nombre, string apellido, int dni, string direccion, int telefono, bool delCentro) : base(nombre, apellido, dni, direccion, telefono)
        {
            this.delCentro = delCentro;
        }

        public Profesor(string nombre, string apellido, int dni, string direccion, int telefono, bool delCentro, Asignatura asignatura) : base(nombre, apellido, dni, direccion, telefono)
        {
            if (asignatura == null) throw new Exception("asignatura nula o no existente");

            this.delCentro = delCentro;
            this.asignaturas.Add(asignatura);
        }

        public Profesor(string nombre, string apellido, int dni, string direccion, int telefono, bool delCentro, List<Asignatura> asignaturas) : base(nombre, apellido, dni, direccion, telefono)
        {
            if (asignaturas == null) throw new Exception("asignatura nula o no existente");

            this.delCentro = delCentro;
            this.asignaturas.AddRange(asignaturas);
        }
    }
}