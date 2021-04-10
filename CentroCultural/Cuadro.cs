using System;
using System.Collections.Generic;
using System.Text;

namespace CentroCultural
{
    class Cuadro : ObraDeArte
    {
        private float baseCuadro;
        private float altura;

        public Cuadro(int codigo, String nombre, String nombreArtista, int anioCreacion, Fecha fechaIngreso, float baseCuadro, float altura)
            : base(codigo, nombre, nombreArtista, anioCreacion, fechaIngreso)
        {
            this.baseCuadro = baseCuadro;
            this.altura = altura;
        }


        public void BaseCuadro(float basec)
        {
            baseCuadro = basec;
        }
        public float BaseCuadro()
        {
            return baseCuadro;

        }
        public void Altura(float alt)
        {
            altura = alt;
        }
        public float Altura()
        {
            return altura;
        }

        public override string ToString()

        {
            return base.ToString() + "\nBase del Cuadro" + baseCuadro + "\nAltura" + altura;
        }


    }
}
