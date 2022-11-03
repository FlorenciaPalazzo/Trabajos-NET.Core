using Entidades.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DacMedico
    {
        List<Medico> medicos;

        public List<Medico> Select()
        {
            //TODO
            medicos = new List<Medico>();
            return null;
        }
        public List<Medico> Select(string especialidad)
        {
            //TODO
            medicos = new List<Medico>();
            return null;
        }
        public int Insert(Medico medicos)
        {
            //TODO
            return 0;
        }
        public int Eliminar(int id)
        {
            //TODO
            return 0;
        }

        public List<Medico> SelectById(int id)
        {
            //TODO
            return null;

        }

    }
}
