using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado
{
    public class Departamento
    {
        public Departamento(int id, string nombre, List<Empleado>empleadosList)
        {
            id = Id;
            nombre = Nombre;
            EmpleadosList = empleadosList;

        }
        public int Id { get; set; }
        public string Nombre { get; set; }

        #region
        public List<Empleado> EmpleadosList { get; set; }
        #endregion
    }
}
