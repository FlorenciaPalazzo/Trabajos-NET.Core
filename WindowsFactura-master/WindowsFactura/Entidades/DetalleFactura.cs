using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFactura.Entidades;

namespace WindowsFactura.Entidades
{
    public class DetalleFactura
    {
              
        public Producto Producto { get; set; }
        public Factura Factura { get; set; }

    }
}
