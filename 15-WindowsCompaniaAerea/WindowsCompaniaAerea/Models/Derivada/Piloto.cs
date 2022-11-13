using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsCompaniaAerea.Models.Base;

namespace WindowsCompaniaAerea.Models.Derivada
{
    public class Piloto: Persona
    {
        public Piloto(string apellido, string nombre) : base(apellido, nombre) { }

        public Copiloto Copiloto { get; set; }
        public List<Azafata> Azafatas { get; set; }
    }

}
