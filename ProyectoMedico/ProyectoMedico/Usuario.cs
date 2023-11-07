using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMedico
{
    internal class Usuario
    {
        private String nombre;
        private String apellido;
        private int dni;
        private int fechaNac;
        private String tel;
        private String email;
        private ArrayList turnosTomados;
        private int id;

        public Usuario(String nombre, String apellido, int dni, int fechaNac, String tel, String email, int id) {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.fechaNac = fechaNac;
            this.tel = tel;
            this.email = email;
            this.id = id;
        }
    }
}
