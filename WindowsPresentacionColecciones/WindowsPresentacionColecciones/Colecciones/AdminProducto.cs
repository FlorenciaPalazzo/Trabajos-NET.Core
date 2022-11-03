using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsPresentacionColecciones.Models;

namespace WindowsPresentacionColecciones.Colecciones
{
    public static class AdminProducto
    {
        //declarar
        static List<Producto> productos;

        public static List<Producto> Carga()
        {

            // crear la lista
            productos = new List<Producto>();

            //crear objeto producto
            Producto producto = new Producto() { Nombre = "Teclado", Categoria = "Hardware", Precio = 222 };

            //agregar el producto a la lista
            productos.Add(producto);

            //Agregar otro producto a la colección de productos - Tipo Anonimo

            productos.Add(new Producto() { Nombre = "Monitor", Categoria = "Hardware", Precio = 44 });
            productos.Add(new Producto() { Nombre = "Impresora", Categoria = "Hardware", Precio = 414 });

            productos.Add(new Producto() { Nombre = "Corel", Categoria = "Software", Precio = 33 });
            productos.Add(new Producto() { Nombre = "Office", Categoria = "Software", Precio = 22 });

            return productos;

        }

        public static List<Producto> TraerPorCategoria(string categoria)
        {
            //TODO Falta programar el método TraerPorCategoria
            return null;
        }

        public static int Insertar(Producto producto)
        {
            //TODO Falta programar el método Insertar
            return 0;
        }


        public static int Eliminar(Producto producto)
        {
            //TODO Falta programar el método Eliminar
            return 0;
        }
    }

}
