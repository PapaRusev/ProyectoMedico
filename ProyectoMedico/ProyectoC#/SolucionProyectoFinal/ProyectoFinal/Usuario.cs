using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Usuario : Persona
    {
        public DateTime FechaNac { get; set; }

        public ArrayList turnos;

        public Usuario(int id, string nombre, string apellido, int dni, string email, DateTime fechaNac) : base(id, nombre, apellido, dni, email)
        {
            FechaNac = fechaNac;
            turnos = new ArrayList(10);
        }


    }
