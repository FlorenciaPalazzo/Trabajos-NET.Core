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
            Producto producto1 = new Producto("Mouse", 505.5,);
            MessageBox.Show($"{producto1}");

            Producto producto2 = new Producto("Teclado", 2500.10);
            MessageBox.Show($"{producto2}");
        }
    }
}
