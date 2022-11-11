using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsAppPubs.Models;

namespace WindowsAppPubs
{
    public partial class Form1 : Form
    {
        private PubContext context = new PubContext(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Publisher publisher = new Publisher() { pub_id="4444", pub_name="Books", city="New York",state="NY",country="USA"};
            
            context.Publishers.Add(publisher);
            
            int filasAfectadas = context.SaveChanges();
            
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Fila agregada");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string id = "9999";
            Publisher publisherDB= context.Publishers.Find(id);

            if(publisherDB != null)
            {
                publisherDB.pub_name = "Lucerne Publishing Editado";
                publisherDB.city = "Paris Modificado";
            }

            int filasAfectadas = context.SaveChanges();
            if (filasAfectadas >0)
            {
                MessageBox.Show("Fila Actualizada");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = txtEliminar.Text;
            Publisher publisherDB= context.Publishers.Find(id);

            if (publisherDB != null)
            {
                context.Publishers.Remove(publisherDB);
                int filasAfectadas= context.SaveChanges();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Fila Actualizada");
                }
            }
        }

        private void btnTraerTodos_Click(object sender, EventArgs e)
        {
            List<Publisher> listaPublisher = context.Publishers.ToList();

            gridMostrar.DataSource = listaPublisher;


        }

    }
}
