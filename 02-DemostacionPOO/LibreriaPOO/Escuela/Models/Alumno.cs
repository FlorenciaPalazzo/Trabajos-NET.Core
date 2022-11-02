using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using LibreriaPOO.Escuela.Models;

namespace LibreriaPOO.Escuela.ModelsBase
{
    public class Alumno: Persona
    {
        public string Matricula { get; set; }
        public override string Imprimir()
        {
            return base.Imprimir() + " "+Matricula;
        }

    }
}
