
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFactura.Entidades
{
    public class Usuario : Persona
    {

        public Cliente Cliente { get; set; }
    }
}
