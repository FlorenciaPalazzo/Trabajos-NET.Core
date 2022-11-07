using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApp.Entidades_Caso3;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Autor autor1;     
        public Empleado empleado1;     
        public Venta venta1;  
        public Publicador publicador1;     
        public Titulo titulo1;      
        public Form1()
        {
            InitializeComponent();
        }

       
        private void btnCargar_Click(object sender, EventArgs e)
        {
            autor1 = new Autor();            
            empleado1= new Empleado();          
            venta1 = new Venta();            
            publicador1= new Publicador();          
            titulo1= new Titulo();
            

            autor1.Nombre = "J.K.";
            autor1.Apellido = "Rowlig";

            empleado1.Nombre = "Pedro";
            empleado1.Apellido = "Pompin";

            venta1.Tienda = "El mundo del libro";
            venta1.Fecha = new DateTime(2022, 10, 29);

            publicador1.Contacto = "542231152364";
            publicador1.Nombre = "Sandra";

            titulo1.Nombre = "Animales Fantasticos";
            titulo1.Precio = 2000.5;

            MessageBox.Show($"Autor:\nNombre:{autor1.Nombre}\nApellido:{autor1.Apellido}",
               $"Empleado:\nNombre:{empleado1.Nombre}\nApellido:{empleado1.Apellido}");

            MessageBox.Show($"Venta:\nTienda:{venta1.Tienda}\nFecha:{venta1.Fecha}",
                $"Publicador:\nContacto:{publicador1.Contacto}\nNombre:{publicador1.Nombre}");

            MessageBox.Show($"Titulo:\nTitulo:{titulo1.Nombre}\nPrecio: ${titulo1.Precio}");


        }
    }
}
