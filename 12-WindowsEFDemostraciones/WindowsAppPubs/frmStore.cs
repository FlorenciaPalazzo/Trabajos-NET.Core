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
    public partial class frmStore : Form
    {
     
        public frmStore()
        {
            InitializeComponent();
        }

        private void btnMostrarLista_Click(object sender, EventArgs e)
        {
             List<Store> listaStore = DacStore.Lista();
             gridMostrar.DataSource = listaStore;

        }

        private void btnTraerUno_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            Store traerUno = DacStore.TraerUno(id);
            MessageBox.Show(traerUno.stor_name.ToString());
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
          
                Store agregarStore = new Store()
                {
                    stor_id = "7777",
                    stor_name= "Prueba2",
                    stor_address="La Prueba2 256",
                    city= "Prueba2",
                    state= "AR",
                    zip="1246",
           
                };
                int filasAfectadas = DacStore.Nuevo(agregarStore);

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Nuevo store agregado");
                }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            Store store = DacStore.TraerUno(id);

            if (store != null)
            {
                store.stor_name = txtNombre.Text;
                store.stor_address = txtDireccion.Text;
                store.city = txtCiudad.Text;
                store.state = txtEstado.Text;
                store.zip = txtZip.Text;

                int filasAfectadas= DacStore.Modificar(store);

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Store modificado");
                }
            }
               
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;

            Store eliminarId = new Store();

            eliminarId.stor_id = id;

            int filasAfectadas= DacStore.Eliminar(eliminarId);

            if (filasAfectadas>0)
            {
                MessageBox.Show("Fila eliminada");
            }
        }
    }
}
