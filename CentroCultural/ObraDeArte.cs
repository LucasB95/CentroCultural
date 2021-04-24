using System;
using System.Collections.Generic;
using System.Text;

namespace CentroCultural
{
    abstract class  ObraDeArte
    {
        protected int codigo;
        protected String nombre;
        protected String nombreArtista;
        protected int anioCreacion;
        protected Fecha fechaIngreso;

        public ObraDeArte(int codigo, String nombre, String nombreArtista, int anioCreacion, Fecha fechaIngreso)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.nombreArtista = nombreArtista;
            this.anioCreacion = anioCreacion;
            this.fechaIngreso = fechaIngreso;
        }
        public void Codigo(int cod)
        {
            codigo = cod;
        }

        public int Codigo()
        {
            return codigo;
        }

        public void Nombre(String nom)
        {
            nombre = nom;
        }

        public String Nombre()
        {
            return nombre;
        }

        public void NombreArtista(String nomart)
        {
            nombreArtista = nomart;
        }

        public String NombreArtista()
        {
            return nombreArtista;
        }

        public void AnioCreacion(int ancrea)
        {
            anioCreacion = ancrea;
        }

        public int AnioCreacion()
        {
            return anioCreacion;
        }

        public void FechaIngreso(Fecha fecrea)
        {
            fechaIngreso = fecrea;
        }

        public Fecha FechaIngreso()
        {
            return fechaIngreso;
        }

        public override string ToString()
        {
            return "Codigo: " + codigo + "\nNombre de Obra: " + nombre + "\nNombre del Artista: " + nombreArtista + "\nCreacion de Obra: " + anioCreacion + "\nFecha de Ingreso: " + fechaIngreso;
        }

    }
}
