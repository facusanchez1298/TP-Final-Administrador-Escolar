using System.Collections.Generic;

namespace tp_lab_3
{
    public class Correlativas
    {
        public List<Asignatura> regulares = new List<Asignatura>();
        public List<Asignatura> aprobadas = new List<Asignatura>();

        public void agregarRegular(Asignatura asignatura)
        {
            regulares.Add(asignatura);
        }

        public void agregarAprobada(Asignatura asignatura)
        {
            aprobadas.Add(asignatura);
        }
    }
}