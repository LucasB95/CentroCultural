using System;
using System.Collections.Generic;
using System.Text;

namespace CentroCultural
{
    class ArtistasExposicion
    {
        public Artista art;
        //public int[] ArtistasExp;
        List<Artista> ArtistasExp = new List<Artista> { };


        public ArtistasExposicion(){
           
        }
       public void insertarArtista(Artista a){

            ArtistasExp.Add(a);
    
        }


        public int cantidadArtistas()
        {
            int contArtistas = 0;
            foreach (Artista art in ArtistasExp)
            {
                contArtistas++;
            }
            return contArtistas;
        }

        
        public Boolean estaArtista(ObraDeArte o)
        {
            Boolean estaArt = false;
            foreach(Artista art in ArtistasExp)
            {
                if (o.Nombre().Equals(art.Nombre()))
                {
                    estaArt = true;
                }
            }
            return estaArt;
        }

        public Boolean estaLlena()
        {
            Boolean estaLleno = true;
            foreach (Artista art in ArtistasExp)
            {
                if (art == null)
                {
                    estaLleno = false;
                }
            }
            return estaLleno;
        }


        public Boolean hayArtista()
        {
            Boolean hayArt = true;  
                if (ArtistasExp == null || ArtistasExp.Count == 0)
                {
                    hayArt = false;
                }
   
            return hayArt;
        }

        
        public Artista recuperaArtista(String nom){

            Artista recuart = null;
            foreach (Artista art in ArtistasExp)
            {
                if (nom.Equals(art.Nombre()))
                {
                    recuart = art;
                }
            }
            return recuart;
        }

        //Este metodo es el que cumple la funcion del metodo artistasNac pero con otra funcionalidad diferente al de la linea 103
        public Artista recuperaNacionalidad(String Nac)
        {

            Artista recuart = null;
            foreach (Artista art in ArtistasExp)
            {
                if (Nac.Equals(art.Nacionalidad()))
                {
                    recuart = art;
                }
            }
            return recuart;
        }


        public List<Artista> artistasNac(String Nac)
        {
            List<Artista> artnac = new List<Artista> { };
            foreach (Artista art in ArtistasExp)
            {
                if (art.Nacionalidad().Equals(Nac))
                {
                    artnac.Add(art);
                }
            }
            return artnac;
        }

        


    }
}
