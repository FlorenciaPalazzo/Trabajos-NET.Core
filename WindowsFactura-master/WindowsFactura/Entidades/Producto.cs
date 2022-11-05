
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFactura.Entidades
{
    public class Producto
    {
         public Producto(string nombre, double precio, List<DetalleFactura>listaDetalles, Categoria categoria)
        {
            Nombre = nombre;
            Precio = precio;
            Categoria = categoria;
            DetalleFacturas = listaDetalles;
            

        }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public Categoria Categoria { get; set; }

    
        public List<DetalleFactura> DetalleFacturas { get; set; }

    }
}
