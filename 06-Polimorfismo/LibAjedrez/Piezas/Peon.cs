using LibAjedrez.PiezaBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAjedrez.Piezas
{
    public class Peon : PiezaAjedrez
    {
        public override string Mover(string movimiento)
        {
            return "Peon mueve hacia " + " " + movimiento ; 
        }
    }
}
