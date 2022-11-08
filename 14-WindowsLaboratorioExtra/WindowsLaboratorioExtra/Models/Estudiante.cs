using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsLaboratorioExtra.Models
{
    public class Estudiante
    {
        public int EstudianteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono{ get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }


        public int IdLocalidad { get; set; }



    }
}
