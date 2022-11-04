using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFactura.Entidades
{
    public class Producto
    {

        public Categoria Categoria { get; set; }

        public List<DetalleFactura> DetalleFacturas { get; set; }

    }
}
