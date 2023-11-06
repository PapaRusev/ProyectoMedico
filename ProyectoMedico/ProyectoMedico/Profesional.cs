using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMedico
{
    internal class Profesional
    {
        private String nombre;
        private String apellido;
        private int dni;
        private String tel;
        private String email;
        private String codMatricula;
        private Especialidad especialidad;
        private int id;

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
