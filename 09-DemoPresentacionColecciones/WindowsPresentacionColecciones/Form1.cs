﻿using System;
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
using WindowsPresentacionColecciones.PruebaStatic;
using LibEmpleado;

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

            lista = AdminProducto.Carga();

            gridProductos.DataSource = lista;

            foreach (Producto producto in lista)
            {
                lstPrecioProducto.Items.Add(producto.Nombre + " Precio:" + producto.Precio.ToString());
            }

        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente1 = new Cliente("Florencia");
            Cliente cliente2 = new Cliente("Maria");

            MessageBox.Show($"{Cliente.Instancias.ToString()}");

            Cliente cliente3 = new Cliente("Carlos");
            Cliente cliente4 = new Cliente("Ruben");

            MessageBox.Show($"{Cliente.Instancias.ToString()}");

        }

       //Trabajo Clientes:Practica static
        private void btnComision_Click(object sender, EventArgs e)
        {
            Empleado empleado1 = new Empleado(25, "Jose", "Perez");
            MessageBox.Show($"{Empleado.Comision.ToString()}");


            Empleado empleado2 = new Empleado(28, "Martin", "Gomez");
            Empleado.Comision = 5002;
            MessageBox.Show($"{Empleado.Comision.ToString()}");

            Empleado empleado3 = new Empleado(25, "Jose", "Perez");
            MessageBox.Show($"{Empleado.Comision.ToString()}");

            Empleado.Comision = 6000;
            MessageBox.Show($"{Empleado.Comision.ToString()}");

        }
    }
}
