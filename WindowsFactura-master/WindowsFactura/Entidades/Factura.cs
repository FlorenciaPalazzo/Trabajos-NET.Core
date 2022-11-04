using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFactura.Entidades
{
    public class Factura
    {

        public string Tipo { get; set; }
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public List<DetalleFactura> DetalleFacturas { get; set; }
        public Empleado Empleado { get; set; }

        public Cliente Cliente { get; set; }

    }
}
