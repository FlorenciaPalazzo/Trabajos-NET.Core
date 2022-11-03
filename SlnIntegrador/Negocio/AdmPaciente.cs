using Entidades.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class AdmPaciente
    {
        List<Paciente> pacientes;

        public List<Paciente> Insertar()
        {
            //Creo la lista
            pacientes = new List<Paciente>();

            //Metodo add a la lista pacientes y genero objeto anonimo
            pacientes.Add(new Paciente(5, "Malena", "Gomez", "Algun lado 215", "42598211", "malena@gmail.com", "ASC256"));
            pacientes.Add(new Paciente(2, "Juan Carlos", "Perez", "No se 525", "12543658", "juanCarlos@gmail.com", "SDE123"));
            pacientes.Add(new Paciente(4, "Maria", "Martinez", "San Martin 225", "12358741", "maria@gmail.com", "DFE578"));
            pacientes.Add(new Paciente(1, "Cristian", "Rodriguez", "J.M. Rosas 569", "25698741", "cristian@gmail.com", "GGT587"));
            pacientes.Add(new Paciente(8, "Ronald", "Wisley", "Callejón Mágico 24", "56987412", "Ronald@gmail.com", "FRE256"));

            //TODO
            return pacientes;
        }

        public int Insertar(Paciente pacientes)
        {
            //TODO
            return 0;
        }
        public int Eliminar(int id)
        {
            //TODO
            return 0;
        }
        public List<Paciente> TraerUno(string nroHistoriaClinica){

            //TODO
            return null;
        }
        
    }

    
}
