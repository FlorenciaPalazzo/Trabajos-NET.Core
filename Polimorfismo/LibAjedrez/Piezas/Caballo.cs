using LibAjedrez.PiezaBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAjedrez.Piezas
{
    public class Caballo :PiezaAjedrez
    {
        public override string Mover(string movimiento)
        {
            return "Caballo mueve hacia " + " " + movimiento;
        }
    }
}
