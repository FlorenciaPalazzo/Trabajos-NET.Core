using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsAppPubs.AdminDatos;
using WindowsAppPubs.Models;

namespace WindowsAppPubs
{
    public partial class frmAuthor : Form
    {
        public frmAuthor()
        {
            InitializeComponent();
        }

        private void btnMostrarLista_Click(object sender, EventArgs e)
        {
            List<Author> listaAutores = DacAuthor.Lista();
            gridMostrar.DataSource = listaAutores;
        }

        private void btnTraerUno_Click(object sender, EventArgs e)
        {
            Author traeAuthor = DacAuthor.TraerUno("427-17-2319");
            MessageBox.Show($"{traeAuthor.au_lname}");

        }
        
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            Author nuevoAutor = new Author()
            {
                au_id = "10-555",
                au_lname = "Black",
                au_fname = "White",
                phone = "215489",
                address = "Calle",
                city = "Mendoza",
                state = "AR",
                zip = "9868",
                contract = true,

            };

            int filasAfectadas = DacAuthor.Nuevo( nuevoAutor);
            if (filasAfectadas > 0)
            {
                MessageBox.Show($"Autor agregado con exito");
            }
        }
    }
}
