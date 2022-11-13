using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsCompaniaAerea.Models.Base;

namespace WindowsCompaniaAerea.Models.Derivada
{
    public class Azafata: Persona
    {

        public Azafata(string apellido, string nombre) : base(apellido, nombre) {

            ABordo = false;
        }

        public bool ABordo { get; set; }

        public Piloto Piloto { get; set; }
        public Copiloto Copiloto { get; set; }
    }
}
