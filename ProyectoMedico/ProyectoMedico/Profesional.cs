using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMedico
{
    internal class Profesional
    {
        public String nombre { get; set; }
        public String apellido { get; set; }
        public int dni { get; set; }
        public String tel { get; set; }
        public String email { get; set; }
        public String codMatricula { get; set; }
        public Especialidad especialidad { get; set; }
        public int id { get; set; }

        public Profesional(String nombre, String apellido, int dni, String tel, String email, String codMatricula, Especialidad especialidad, int id) {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.tel = tel;
            this.email = email;
            this.codMatricula = codMatricula;
            this.especialidad = especialidad;
            this.id = id;
        
        }

    }
}
