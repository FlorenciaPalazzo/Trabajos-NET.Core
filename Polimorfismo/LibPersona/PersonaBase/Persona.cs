using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPersona.PersonaBase
{
    public class Persona
    {
        public Persona(string nombre){
            Nombre= nombre;
        }

        public string Nombre { get; set; }

        public override string ToString()
        {
            return "Nombre" +" " + Nombre;
        }
    }
}
