using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado
{
    public class Empleado
    {
       
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string Legajo { get; set; }

        Departamento Departamento { get; set; }

    }
}
