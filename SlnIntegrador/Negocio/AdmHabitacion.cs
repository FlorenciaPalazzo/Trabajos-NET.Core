using Entidades.Lugares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class AdmHabitacion
    {
        List<Habitacion> habitaciones;

        public List<Habitacion> Listar()
        {
            //TODO
            habitaciones = new List<Habitacion>();

            habitaciones.Add(new Habitacion(2, "256","Ocupado"));
            habitaciones.Add(new Habitacion(3, "635", "Ocupado"));
            habitaciones.Add(new Habitacion(5, "356", "Desocupado"));
            habitaciones.Add(new Habitacion(4, "89", "Ocupado"));
            habitaciones.Add(new Habitacion(1, "120", "Desocupado"));

            return habitaciones;
        }

        public List<Habitacion> Listar(string estado)
        {
            //TODO
            habitaciones = new List<Habitacion>();
            return null;
        }

        public int Insertar(Habitacion habitaciones)
        {
            //TODO
            return 0;
        }

        public int Eliminar(int id)
        {
            //TODO
            return 0;
        }
        public List<Habitacion>TraerUno(string numero){
            //TODO
            return null;
        }
    }
}
