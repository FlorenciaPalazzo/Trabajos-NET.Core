using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsCompaniaAerea.Models.Base;

namespace WindowsCompaniaAerea.Models.Derivada
{
    public class Copiloto: Persona
    {
        public Copiloto(string apellido, string nombre) : base(apellido, nombre) { }

        public Piloto Piloto { get; set; }
        public List <Azafata> Azafatas { get; set; }
    }
}
