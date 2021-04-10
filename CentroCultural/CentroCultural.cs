using System;

namespace CentroCultural
{
    class CentroCultural
    {
        private String nombre;
        public ObrasExposicion obras;
        private ArtistasExposicion artistas;

        public CentroCultural(String nombre,ObrasExposicion obras,ArtistasExposicion art)
        {
            this.nombre = nombre;
            this.obras = obras;
            this.artistas = art;

        }

        public void Nombre(String nombre)
        {
            this.nombre = nombre;
        }
        public String Nombre()
        {
            return nombre;
        }
        public void Obras(ObrasExposicion obra)
        {
            this.obras = obra;
        }
        public ObrasExposicion Obras()
        {
            return obras;
        }
        public void Artistas(ArtistasExposicion art)
        {
            this.artistas = art;
        }
        public ArtistasExposicion Artistas()
        {
            return artistas;
        }

        public String nombresObrasNacionalidad(String Nac)
        {
            return Nac;
        }
        public String nombreCuadrosGaleria(String Gal)
        {
            return Gal;
        }

        //metodo nombresObrasNacionalidad
        //metodo nombresCuadrosGaleria

    }
}
