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
            Author traeAuthor = DacAuthor.TraerUno("22222");
            MessageBox.Show($"{traeAuthor.au_lname}");

        }
        
        
       
        private void btnAgregar_Click(object sender, EventArgs e)
        {


            Author nuevoAutor = new Author()
            {
                au_id = "22222",
                au_lname = "Black",
                au_fname = "White",
                phone = "215489",
                address = "Calle",
                city = "Mendoza",
                state = "AR",
                zip = "9868",
                contract = true,

            };

            int filasAfectadas = DacAuthor.Nuevo(nuevoAutor);
            if (filasAfectadas > 0)
            {
                MessageBox.Show($"Autor agregado con exito");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;

            Author author = new Author();

            author.au_id = id;

            int filasAfectadas= DacAuthor.Eliminar(author);
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Fila eliminada");
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            Author authorModificar = DacAuthor.TraerUno(id);

          


            if (authorModificar.au_id == id)
            {
                authorModificar.au_lname = txtNombre.Text;
                authorModificar.address = txtDireccion.Text;
            }

            int filasAfectadas = DacAuthor.Modificar(authorModificar);

            if(filasAfectadas > 0)
            {
                MessageBox.Show("Fila modificada con exito");
            }
        }

    }
}
