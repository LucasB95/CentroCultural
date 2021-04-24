using System;
using System.Collections.Generic;
using System.Text;

namespace CentroCultural
{
    class Escultura : ObraDeArte
    {
        private float peso;
        private float volumen;


        public Escultura(int codigo, String nombre, String nombreArtista, int anioCreacion, Fecha fechaIngreso, float peso, float volumen)
            : base(codigo, nombre, nombreArtista, anioCreacion, fechaIngreso)
        {
            this.peso = peso;
            this.volumen = volumen;
        }

        public void Peso(float pes)
        {
            peso = pes;
        }
        public float Peso()
        {
            return peso;
        }
        public void Volumen(float vol)
        {
            volumen = vol;
        }
        public float Volumen()
        {
            return volumen;
        }



        public override string ToString()

        {
            return base.ToString() + "\nPeso" + peso + "\nVolumen" + volumen;
        }
    }
}
