using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFactura.Caso_1
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Password { get; set; }
        public Cliente Cliente {get; set;}
    }

}
