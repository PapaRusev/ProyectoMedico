using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal

internal class TurnoEstudioMedico : Turno

{
    public TurnoEstudioMedico(int id, int duracion, DateTime fecha, Estudio estudio) : base(id, duracion, fecha)
    {
        this.estudio = estudio;
    }

    public Estudio estudio { get; set; };


}
