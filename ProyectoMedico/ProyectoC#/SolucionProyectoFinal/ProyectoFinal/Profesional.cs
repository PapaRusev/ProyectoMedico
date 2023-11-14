using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Profesional : Persona
    {
        public string codMatricula { get; set; };
        public Especialidad especialidad { get; set; };


        public Profesional(int id, string nombre, string apellido, int dni, string email, string codMatricula, Especialidad especialidad): base(id, nombre, apellido, dni, email)
        {
            this.codMatricula = codMatricula;
            this.especialidad = especialidad;
        }



    }
}
