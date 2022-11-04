using Entidades.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Ayudantes
{
    public static class UtilidadesFechas
    {
        public static int CalcularEdad(DateTime fechaDeNacimiento)
        {
            int edad= DateTime.Today.Year -fechaDeNacimiento.Year;
            return edad;
        }
    }
}


//En el proyecto Entidades agregar una carpeta Ayudantes
//En la carpeta 

//Ayudantes agregar una clase estática y llamarla UtilidadesFechas
//Programar un método CalcularEdad, recibe por parámetro la fecha de nacimiento.
//En la clase Paciente agregar la propiedad Fecha de Nacimiento y Edad de solo lectura. Edad usa el método calcularEdad(fechaNacimiento)
//Crear una instancia de Paciente
//Luego imprimir su nombre y edad