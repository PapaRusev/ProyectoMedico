using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMedico
{
    internal class Turno
    {
        private String nroTurno;
        private int duracion;
        private int fecha;
        private Boolean tomado;

        public Turno(String nroTurno, int duracion, int fecha,) {
            this.nroTurno = nroTurno;
            this.duracion = duracion;
            this.fecha = fecha;
            this.tomado = false;

        }

    }
}
