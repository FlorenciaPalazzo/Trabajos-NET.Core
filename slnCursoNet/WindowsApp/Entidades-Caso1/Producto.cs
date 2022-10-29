using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Entidades
{
    public class Producto
    {
        public string Nombre { set; get; }
        public string Descripcion { set; get; } 
        public decimal PrecioCosto { set; get; }
        public double Margen { set; get; }  
        public double IVA { set; get; }
        public decimal PrecioBruto { set; get; }
        public decimal PrecioVenta { set; get; }
        public string Proveedor { set; get; }
        public string Categoria { set; get; }   
        public string SubCategoria { set; get; }

    }
}
