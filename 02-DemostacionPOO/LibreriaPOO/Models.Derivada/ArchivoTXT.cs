﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaPOO.Models.Base;
namespace LibreriaPOO.Models.Derivada
{
    public class ArchivoTXT : Archivo
    {
        public override string Registrar(string usuario, string msj, string path)
        {
            //  TODO FALTA COMPLETAR EL CODIGO PARA CREAR UN TXT USANDO SYSTEM.IO
            return "Creando el archivo TXT usando System.IO";
        }
    }
}
