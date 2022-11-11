using LibreriaEmpleado;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEmpleados.Data
{
    public class DBEmpleadosContext:DbContext
    {
        public DBEmpleadosContext():base("keyDBEmpleado") {}
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }


    }
}
