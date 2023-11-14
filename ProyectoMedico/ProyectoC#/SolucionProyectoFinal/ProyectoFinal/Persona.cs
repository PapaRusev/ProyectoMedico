using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Persona
    {

        // int id, string nombre, string apellido, int dni, string tel, string email 

        public int id{ get; set; };
        public string nombre { get; set; };

        public string apellido { get; set; };

        public int dni { get; set; };

        public string tel { get; set; };

        public string email { get; set; }; 

       

        public Persona(int id, string nombre, string apellido, int dni, string email)
        { 
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.tel = email;   
            this.email = email; 
        }



    }
}
