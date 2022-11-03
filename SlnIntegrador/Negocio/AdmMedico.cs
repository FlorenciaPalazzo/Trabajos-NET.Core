using Entidades.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class AdmMedico
    {
        List<Medico> medicos;

        public List<Medico> Listar()
        {
            medicos = new List<Medico>();

            medicos.Add(new Medico(24, "Sirius", "Black", "Callejon sin Salida 54", "23654125", "sirius@gmail.com","Clinico", "895"));
            medicos.Add(new Medico(56, "Minerva" ,"McGonagall", "Confundus 25","12547893","minerva@gmail.com","Clinico","954"));
            medicos.Add(new Medico(12, "Albus", "Dumbledore", "Abracadabra 66", "12365874", "albus@gmail.com", "Pediatra", "988"));
            medicos.Add(new Medico(58, "Edna", "Moda", "Paris 56", "12365874", "edna@gmail.com", "Traumatologo", "236"));
            medicos.Add(new Medico(54, "Eren","Yeager","Murales 521", "25687412","eren@gmail.com", "Traumatologo","526"));


            return medicos;
            
        }

        public List<Medico> Listar(string especialidad)
        {
            List<Medico> espMedicos = new List<Medico>();

            foreach (var item in medicos)
            {
                if (item.Especialidad == especialidad)
                {
                    espMedicos.Add(item);
                }
            }


            return espMedicos;
        }
        public int Insertar(Medico medicos)
        {
            //TODO…return 0

            return 0;
        }
        public int Eliminar(int id)
        {
            //TODO…return 0
            return 0;
        }

        public List<Medico> TraerUno(int id)
        {
            //TODO
            return null;
        }

    }
}
