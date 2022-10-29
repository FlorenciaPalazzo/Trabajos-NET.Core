using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApp.Entidades;
using WindowsApp.Entidades_Caso1;

namespace WindowsApp.Entidades_Caso1
{
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Producto producto1 = new Producto();

            producto1.PrecioBruto = producto1.PrecioCosto + Convert.ToDecimal(producto1.Margen);
            producto1.PrecioVenta = producto1.PrecioBruto + Convert.ToDecimal(producto1.IVA);

            Convert.ToDecimal(1 + producto1.IVA);
        }
    }
}
