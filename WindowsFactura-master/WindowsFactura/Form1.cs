
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFactura.Entidades;

namespace WindowsFactura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            #region
            ////Creo lista de detalles para que lo reciba por parametro Producto
            //List <DetalleFactura> listaDetalles= new List<DetalleFactura> ();

            ////Creo La lista de los productos para que lo reciba por parametro categoria
            //List<Producto> listaProductos = new List<Producto>();

            ////Creo categoria (recibe el nombre de la categoria y la lista de los productos segun diagrama)
            //Categoria categoria = new Categoria("Tecnologia",listaProductos );


            ////Creo producto1
            //Producto producto1 = new Producto("Impresora",5000, listaDetalles, categoria);
            //MessageBox.Show($"{producto1.Nombre},{producto1.Precio}");

            ////Creo producto2
            //Producto producto2 = new Producto("Scanner", 7050, listaDetalles, categoria);
            //MessageBox.Show($"{producto2.Nombre},{producto2.Precio}");
            #endregion
            List<Producto> listaProductos = new List<Producto>();

            Producto producto1 = new Producto("Impresora", 10500);
            producto1.Categoria = new Categoria("Tecnologia");
            listaProductos.Add(producto1);

            MessageBox.Show($"Nombre:{producto1.Nombre}\nPrecio:{producto1.Precio}\nCategoria:{producto1.Categoria.Nombre}");



            Producto producto2 = new Producto("Scanner", 12800.5);
            producto2.Categoria = new Categoria("Tecnologia");
            listaProductos.Add(producto2);

            MessageBox.Show($"Nombre:{producto2.Nombre}\nPrecio:{producto2.Precio}\nCategoria:{producto2.Categoria.Nombre}");
                

                        
        }
    }
}
