using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibEmpleado
{
    public class Empleado
    {
        public Empleado(int id,string nombre, string apellido)
        {
            Id = id;    
            Nombre = nombre;
            Apellido = apellido;
            //Comision = 5000;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }


        //Inicio la comision en el constructor, siempre va a ser 5000 cada vez que se agrege un empleado
        // public static decimal Comision { get; set; }

        // Inicio la comision en 100 pero si se cambia se le cambia a todos los empleados
        private static int comision = 100;

        public static int Comision
        {
            get { return comision; }
            set { comision = value; }
        }

    }
}


