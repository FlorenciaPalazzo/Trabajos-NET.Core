using LibreriaEmpleado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEmpleados.Data;

namespace WindowsEmpleados
{
    public partial class Form1 : Form
    {
            public List<Empleado> listEmpleados = AdminEmpleado.Lista();

            //public DBEmpleadosContext context = new DBEmpleadosContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            gridMostrar.DataSource = listEmpleados;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Empleado empleado1 = new Empleado()
            {
                Id = 4,
                Nombre = "Carlos",
                Apellido = "Sanchez",
                Legajo = "A23",

            };
            Empleado empleado2 = new Empleado()
            {
                Id = 5,
                Nombre = "Julia",
                Apellido = "Perez",
                Legajo = "A25",

            };
            Empleado empleado3 = new Empleado()
            {
                Id = 6,
                Nombre = "Maria",
                Apellido = "Martinez",
                Legajo = "A26",

            };

            AdminEmpleado.Insertar(empleado1);
            AdminEmpleado.Insertar(empleado2);
            AdminEmpleado.Insertar(empleado3);

            if (listEmpleados != null)
            {
                MessageBox.Show("Filas creadas");
            }
        }
    }
}
