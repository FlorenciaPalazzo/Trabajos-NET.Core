using LibAjedrez.PiezaBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAjedrez.Piezas
{
    public class Torre: PiezaAjedrez
    {
        public override string Mover(string movimiento)
        {
            return "Torre se mueve hacia " +" " + movimiento;
        }
    }
}
