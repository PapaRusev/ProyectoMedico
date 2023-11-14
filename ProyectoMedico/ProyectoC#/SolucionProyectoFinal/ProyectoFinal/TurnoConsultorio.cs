using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class TurnoConsultorio : Turno
    {
        public Profesional profesional;

        public TurnoConsultorio(int id, int duracion, DateTime fecha, Profesional profesional): base(id, duracion, fecha) 
        {
            this.profesional = profesional;
        }
    }
}
