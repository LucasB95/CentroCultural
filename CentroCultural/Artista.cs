using System;
using System.Collections.Generic;
using System.Text;

namespace CentroCultural{
    class Artista{

        //private ArtistasExposicion artexp;
        private String nombre;
        private String nacionalidad;
        private Fecha fechaNacimiento;
        private Fecha fechaFallecimiento;

        public Artista(String nombre,String nac, Fecha fechaNacimiento, Fecha fechaFallecimiento){
            //this.artexp = artexp;
            this.nacionalidad = nac; 
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.fechaFallecimiento = fechaFallecimiento;
        }

        //GET Y SET
        public void Nombre(String nom)
        {
            nombre = nom;
        }
        public String Nombre()
        {
            return nombre;
        }
        public void Nacionalidad(String nac)
        {
            nacionalidad = nac;
        }
        public String Nacionalidad()
        {
            return nacionalidad;
        }
        public void FechaNacimiento(Fecha fenac)
        {
            fechaNacimiento = fenac;
        }
        public Fecha FechaNacimiento()
        {
            return fechaNacimiento;
        }
        public void FechaFallecimiento(Fecha fefall)
        {
            fechaFallecimiento = fefall;
        }
        public Fecha FechaFallecimiento()
        {
            return fechaFallecimiento;
        }
        public override string ToString(){
            return "ARTISTA: " + "\n- Nombre: " + nombre + "\n- Nacionalidad: " + nacionalidad + "\n- Nacimiento: " + fechaNacimiento + "\n- Fallecimiento: " + fechaFallecimiento;
        }
    }
}
