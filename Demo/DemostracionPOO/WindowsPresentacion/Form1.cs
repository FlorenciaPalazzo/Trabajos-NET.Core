﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WindowsPresentacion.Models;


namespace WindowsPresentacion
{
    public partial class Form1 : Form
    {
        private Medico medico;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearObjetos_Click(object sender, EventArgs e)
        {
            //Pacientes
            //declarar y crear dos instancias de la clase Paciente
            Paciente paciente1 = new Paciente();
            Paciente paciente2 = new Paciente();

            //set propiedades
            paciente1.Apellido = "Perez";
            paciente1.Nombre = "Maria";
            paciente1.FechaNacimiento = new DateTime(1977, 10, 1);
            paciente1.NroHitoriaClinica = "A1255";

            paciente2.Apellido = "Fernandez";
            paciente2.Nombre = "Gustavo";
            paciente2.NroHitoriaClinica = "B100";

            //crear el objeto
            medico = new Medico();
            medico.Apellido = "Picone";
            medico.Nombre = "Carlos";
            medico.Matricula = 123;

            //Mostrar GET
            MessageBox.Show(paciente1.Apellido + " " + paciente1.Nombre);
            MessageBox.Show(medico.Apellido + " " + medico.Nombre);

        }
    }
}
