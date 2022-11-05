using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFactura.Entidades;

namespace WindowsFactura.Entidades
{
    public class Categoria
    {
        public Categoria(string nombre)
        {
            Nombre= nombre;
            
        }
        public string Nombre { get; set; }
        public List<Producto> Productos { get; set; }

    }
}
