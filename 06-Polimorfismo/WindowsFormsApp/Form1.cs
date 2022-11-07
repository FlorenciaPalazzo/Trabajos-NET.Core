using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibAjedrez.Piezas;
using LibAnimales.Animales;
using LibPersona.Personas;
using Libreria_windows.Instrumentos;
using LibTransporte;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAfinar_Click(object sender, EventArgs e)
        {
            Violin violin = new Violin();
            MessageBox.Show(violin.Afinar("Violín"));

            Piano piano = new Piano();
            MessageBox.Show(piano.Afinar("Piano"));

            Guitarra guitarra = new Guitarra();
            MessageBox.Show(guitarra.Afinar("Guitarra"));
        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            Torre torre = new Torre();
            MessageBox.Show(torre.Mover("hacia adelante"));

            Caballo caballo = new Caballo();
            MessageBox.Show(caballo.Mover("en L"));

            Peon peon = new Peon();
            MessageBox.Show(peon.Mover("hacia la izquierda"));
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente("Maria", "A5503");
            MessageBox.Show($"{paciente}");

            Medico medico = new Medico("Monica", "28558");
            MessageBox.Show($"{medico}");
        }

        private void btnAnimales_Click(object sender, EventArgs e)
        {
            Leon leon = new Leon("30", "1.90", "120", "Alex", "Roaaarr");
            MessageBox.Show($"{leon.Imprimir()}{leon.ImprimirComida("Carnivoro")}");

            Conejo conejo = new Conejo("5", "0.30", "8", "Saltar", "Pelusita");
            MessageBox.Show($"{conejo.Imprimir()}{conejo.ImprimirComida("Hervivoro")}");

            Loro loro = new Loro("35", "0.20", "1", "Pepe", "Plumas");
            MessageBox.Show($"{loro.Imprimir()}{loro.ImprimirComida("Frugívoro")}");
        }

        private void btnTransporte_Click(object sender, EventArgs e)
        {
            Avion avion = new Avion("5000",50,500,1000,4);
            MessageBox.Show($" {avion.ImprimirCaracteristicas()},{avion.Ascender()},{avion.Descender()},{avion.Acelerar(100)},{avion.Desacelerar(200)}");

         
            Auto auto = new Auto("200",4,120,"AZC123");
            MessageBox.Show($"{auto.ImprimirCaracteristicas()},{auto.Acelerar(20)},{auto.Desacelerar(50)},{auto.DoblarAIzq()},{auto.DoblarADcha()}");
        }
    }
}
