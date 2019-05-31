namespace tp_lab_3
{
    public class Examen
    {
        public int dni { get; set; }
        public int id_asignatura { get; set; }
        public int primerParcial { get; set; }
        public int segundoParcial { get; set; }
        public int tercerParcial { get; set; }
        public int primerRecuperatorio { get; set; }
        public int segundoRecuperatorio { get; set; }

        public Examen(int dni, int id_asignatura)
        {
            this.dni = dni;
            this.id_asignatura = id_asignatura;
            primerParcial = -1;
            segundoParcial = -1;
            tercerParcial = -1;
            primerRecuperatorio = -1;
            segundoRecuperatorio = -1;
        }

        public void agregarNotaExamen(int nota)
        {
            if (nota > 0)
            {
                if (primerParcial == -1) primerParcial = nota;
                else if (segundoParcial == -1) segundoParcial = nota;
                else if (tercerParcial == -1) tercerParcial = nota;               
            }
        }

        public void agregarNotaRecuperatorio(int nota)
        {
            if (nota > 0)
            {
                if (primerRecuperatorio == -1) primerRecuperatorio = nota;
                else segundoRecuperatorio = nota;
            }
        }
       



    }
}