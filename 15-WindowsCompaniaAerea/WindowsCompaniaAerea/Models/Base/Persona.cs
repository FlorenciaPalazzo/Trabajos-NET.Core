using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsCompaniaAerea.Models.Base
{
    public class Persona
    {

        public string Apellido { get; set; }
        public string Nombre { get; set; }


        public Persona(string apellido, string nombre)
        {
            Apellido = apellido;
            Nombre = nombre;
        }
    }
}
