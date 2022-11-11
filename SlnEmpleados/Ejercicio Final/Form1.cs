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

namespace Ejercicio_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            List<Empleado> listEmpleados = new List<Empleado> ();

            Empleado empleado1= new Empleado()
            {
                Id= 1,
                Nombre= "Carlos",
                Apellido= "Sanchez",
                Legajo= "A23",

            };
            Empleado empleado2 = new Empleado()
            {
                Id = 2,
                Nombre = "Julia",
                Apellido = "Perez",
                Legajo = "A25",

            };
            Empleado empleado3 = new Empleado()
            {
                Id = 3,
                Nombre = "Maria",
                Apellido = "Martinez",
                Legajo = "A26",

            };

            listEmpleados.Add(empleado1);
            listEmpleados.Add(empleado2);
            listEmpleados.Add(empleado3);

            Departamento departamento1 = new Departamento(1,"Maipu", listEmpleados);

            gridMostrar.DataSource = departamento1.EmpleadosList;

        }
    }
}
