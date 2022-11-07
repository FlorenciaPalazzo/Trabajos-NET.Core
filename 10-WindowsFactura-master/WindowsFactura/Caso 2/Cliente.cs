using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFactura.Caso_2
{
    public class Cliente
    {

        public string Nombre { get; set; }
        public string Password { get; set; }
        public List<Pedido> Pedidos{ get; set; }


    }
}
