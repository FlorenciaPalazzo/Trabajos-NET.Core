using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsPresentacionColecciones.Models;
using WindowsPresentacionColecciones.Colecciones;

namespace WindowsPresentacionColecciones
{
    public partial class Form1 : Form
    {
        List<Producto> productos;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ////declarar y crear la lista
            //productos = new List<Producto>();

            ////crear objeto producto
            //Producto producto = new Producto() { Nombre = "Teclado", Categoria = "Hardware", Precio = 222 };

            ////agregar el producto a la lista
            //productos.Add(producto);

            ////Agregar otro producto a la colección de productos - Tipo Anonimo

            //productos.Add(new Producto() { Nombre = "Monitor", Categoria = "Hardware", Precio = 44 });
            //productos.Add(new Producto() { Nombre = "Impresora", Categoria = "Hardware", Precio = 414 });

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            List<Producto> lista;

            AdminProducto adminProducto = new AdminProducto();

            lista = adminProducto.Carga();


            gridProductos.DataSource = lista;

            foreach (Producto producto in lista)
            {
                lstPrecioProducto.Items.Add(producto.Nombre + " Precio:" + producto.Precio.ToString());
            }

        }
    }
}
