﻿using LibPersona.PersonaBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPersona.Personas
{
    public class Medico :Persona
    {
        public Medico(string nombre, string especialidad): base(nombre)
        {
            Especialidad = especialidad;
        }

        public string Especialidad { get; set; }

        public override string ToString()
        {
            return base.ToString() +" " +"Especialidad:" +" " + Especialidad ;
        }
    }
}
