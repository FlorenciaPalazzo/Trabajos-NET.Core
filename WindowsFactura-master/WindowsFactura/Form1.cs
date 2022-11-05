
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
            //Creo lista de detalles para que lo reciba por parametro Producto
            List <DetalleFactura> listaDetalles= new List<DetalleFactura> ();
            
            //Creo La lista de los productos para que lo reciba por parametro categoria
            List<Producto> listaProductos = new List<Producto>();

            //Creo categoria (recibe el nombre de la categoria y la lista de los productos segun diagrama)
            Categoria categoria = new Categoria("Tecnologia",listaProductos );


            //Creo producto1
            Producto producto1 = new Producto("Impresora",5000, listaDetalles, categoria);
            MessageBox.Show($"{producto1.Nombre},{producto1.Precio}");

            //Creo producto2
            Producto producto2 = new Producto("Scanner", 7050, listaDetalles, categoria);
            MessageBox.Show($"{producto2.Nombre},{producto2.Precio}");

            
        }
    }
}
