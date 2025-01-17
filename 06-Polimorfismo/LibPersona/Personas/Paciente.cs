﻿using LibPersona.PersonaBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPersona.Personas
{
    public class Paciente: Persona
    {
        public Paciente(string nombre, string numeroPaciente):base(nombre)
        {
            NumeroPaciente = numeroPaciente;
        }

        public string NumeroPaciente { get; set; }

        public override string ToString()
        {
            return base.ToString() +"Numero Paciente: " + NumeroPaciente ;
        }
    }

    
}
