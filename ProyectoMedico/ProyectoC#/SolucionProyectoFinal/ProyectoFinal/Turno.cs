using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Turno
    {
        public Turno(int id, int duracion, DateTime fecha)
        {
            this.id = id;
            this.duracion = duracion;
            this.fecha = fecha;
        }

        public int id { get; set; };
        public int duracion { get; set; };

        public DateTime fecha { get; set; };

       


    }
}
