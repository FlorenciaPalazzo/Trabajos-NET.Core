using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsLaboratorioExtra.Models
{
    public class Evaluacion
    {
        public int EvaluacionId { get; set; }
        public decimal Nota { get; set; }


        public int IdTipo { get; set; }
        public int IdEstudiante { get; set; }
        public int IdDetalle { get; set; }


    }
}
