using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMedico
{
    internal class Especialidad
    {
        private String nombre;
        private String codEspecialidad;

        public Especialidad(String nombre, String codEspecialidad) {
            this.nombre = nombre;
            this.codEspecialidad = codEspecialidad;
        }
    }
}
