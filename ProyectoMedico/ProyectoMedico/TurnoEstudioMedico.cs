using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMedico
{
    internal class TurnoEstudioMedico : Turno
    {
        private String nombre;
        private int cod;
        private Boolean indicacion;

        public TurnoEstudioMedico(String nombre, int cod,  String nroTurno, int duracion, int fecha) {
            base(nroTurno, duracion, fecha);
            this.nombre = nombre;
            this.cod = cod;
            this.indicacion = false;
        }
    }
}
