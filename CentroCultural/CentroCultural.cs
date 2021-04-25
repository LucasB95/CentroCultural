using System;
using System.Collections.Generic;

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


        public List<String> nombresObrasNacionalidad(String nac)
        {
            List<String> nombres = new List<String> { };
       
            List<Artista> listaArtistas = artistas.artistasNac(nac);
            foreach (Artista art in listaArtistas)
            {
                nombres.Add(art.Nombre());
            }
            return nombres;
        }
     
        //public List<String> nombresCuadrosGaleria(String Gal)
        //{
        //    List<String> nombres = new List<String> { };

        //    List<ObraDeArte> listacuadros;

        //    foreach (ObraDeArte obr in listacuadros)
        //    {
        //        nombres.Add(obr.Nombre());
        //    }
        //    return nombres;
        //}

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

      
        public String nombreCuadrosGaleria(String Gal)
        {
            return Gal;
        }

    }
}
