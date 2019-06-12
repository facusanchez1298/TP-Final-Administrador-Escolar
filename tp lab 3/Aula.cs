using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_lab_3
{
    public class Aula
    {
        public int capacidad { get; set; }
        public int numero { get; set; }
        public bool Proyector { get; set; }
        public bool internet { get; set; }

        public Aula(int capacidad, int numero, bool proyector, bool internet)
        {
            this.capacidad = capacidad;
            this.numero = numero;
            this.Proyector = Proyector;
            this.internet = internet;
        }
    }
}
