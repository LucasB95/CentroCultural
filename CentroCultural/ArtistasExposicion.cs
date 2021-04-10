using System;
using System.Collections.Generic;
using System.Text;

namespace CentroCultural
{
    class ArtistasExposicion
    {
        public Artista art;
        //public int[] ArtistasExp;
        List<String> ArtistasExp = new List<string> { };


        public ArtistasExposicion(){
           
        }
       public void insertarArtista(Artista a){

            ArtistasExp.Add ("Nombre");
    
                Console.WriteLine("Ingrese artista: ");
                List<string> artistas = new List<string> { Console.ReadLine() };
                
        }

        /*public int cantidadArtistas()
        {
         ffd   
        }*/



    }
}
