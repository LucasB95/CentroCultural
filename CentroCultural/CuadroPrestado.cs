using System;
using System.Collections.Generic;
using System.Text;

namespace CentroCultural
{
    class CuadroPrestado : Cuadro
    {
        private Fecha fechaDevolucion;
        private String nombreGaleria;

        public CuadroPrestado(int codigo, String nombre, String nombreArtista, int anioCreacion, Fecha fechaIngreso, float baseCuadro, float altura, Fecha fechaDevolucion, String nombreGaleria)
        : base(codigo, nombre, nombreArtista, anioCreacion, fechaIngreso, baseCuadro, altura)
        {
            this.fechaDevolucion = fechaDevolucion;
            this.nombreGaleria = nombreGaleria;
        }

        public void FechaDevolucion(Fecha fecdev)
        {
            fechaDevolucion = fecdev;
        }
        public Fecha FechaDevolucion()
        {
            return fechaDevolucion;
        }
        public void NombreGaleria(String nomgal)
        {
            nombreGaleria = nomgal;
        }
        public String NombreGaleria()
        {
            return nombreGaleria;
        }


        public override string ToString()

        {
            return base.ToString() + "\nFecha de Devolucion" + fechaDevolucion + "\nNombre de la Galeria" + nombreGaleria;
        }
    }
}
