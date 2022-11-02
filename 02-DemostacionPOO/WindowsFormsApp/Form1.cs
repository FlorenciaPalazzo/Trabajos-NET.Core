using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaPOO.Models.Derivada;

using LibreriaPOO.Escuela.ModelsBase;
using LibreriaPOO.Escuela.Models;


namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            ArchivoTXT archivo = new ArchivoTXT();

            MessageBox.Show(archivo.Registrar("Gaby", "Hola", "C:/"));

            ArchivoXML archivoXml = new ArchivoXML();

            MessageBox.Show(archivoXml.Registrar("GabyXML", "Hola XML", "C:/"));

        }

        private void btnCrearPersonas_Click(object sender, EventArgs e)
        {
            //Notación declarativa
            Alumno alumno = new Alumno()
            {
                Apellido = "Rosa",
                Nombre = "Margarita",
                Matricula = "A111"
            };

            Profesor profesor = new Profesor()
            {
                Apellido = "DiPaola",
                Nombre = "Diana",
                Titulo = "Profe de Italiano"
            };

            MessageBox.Show(alumno.Imprimir());
            MessageBox.Show(profesor.Imprimir());


        }
    }
}
