using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            producto1.PrecioCosto = 100.5m;
            producto1.IVA = 0.21;


            MessageBox.Show($"Precio Bruto:{producto1.PrecioBruto}\n" +
                $"Precio Venta: {producto1.PrecioVenta}");    
        }
    }
}
