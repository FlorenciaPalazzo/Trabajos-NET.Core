using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFactura.Entidades
{
    public class DetalleFactura
    {

        public decimal Importe { get; set; }
        public Producto Producto { get; set; }
        public Factura Factura { get; set; }


    }
}
