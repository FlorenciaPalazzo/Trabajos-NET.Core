using Entidades.PersonaBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Personas
{
    public class Paciente:Persona
    {
        public Paciente(int id, string nombre, string apellido, string domicilio, string telefono, string email, string nroHistoriaClinica) : base(id, nombre, apellido, domicilio, telefono, email)
        {
            NroHistoriaClinica = nroHistoriaClinica;
        }

        public string NroHistoriaClinica { get; set; }
    }
}
