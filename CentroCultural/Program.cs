using System;
using System.Collections.Generic;
using System.Text;

namespace CentroCultural
{
    class Program
    {


        static void Main(string[] args)
        {
            Fecha fart1 = new Fecha(1970, 11, 02); // creo la fecha de nacimiento para artista 1
            Fecha fart1fa = new Fecha(2001, 07, 15);  // creo la fecha de fallecimiento para artista 1
            Artista art1 = new Artista("Juan", "Argentino", fart1, fart1fa); // creacion de artista 1

            Fecha fart2 = new Fecha(1962, 12, 22);       // creo la fecha de nacimiento para artista 2
            Fecha fart2fa = new Fecha(1999, 06, 17);   // creo la fecha de fallecimiento para artista 2
            Artista art2 = new Artista("Smith", "EEUU", fart2, fart2fa); // creacion de artista 2

            ArtistasExposicion artexp1 = new ArtistasExposicion();  // creo artistas exposicion


            // inserto los 2 artistas a la lista de artistas exposicion
            artexp1.insertarArtista(art1);
            artexp1.insertarArtista(art2);

            Console.WriteLine("La cantidad de Artistas ingresados son :" + artexp1.cantidadArtistas());

            // Console.WriteLine(artexp1.estaArtista());

            Console.WriteLine(artexp1.estaLlena());

            Console.WriteLine(artexp1.hayArtista());

            Console.WriteLine(artexp1.recuperaArtista("Juan"));

            Console.WriteLine(artexp1.recuperaNacionalidad("EEUU"));

            //si se usa el metodo de abajo no tira error pero no encuentra lo q se le pide en el parametro
            //Console.WriteLine(artexp1.artistasNac("EEUU"));

            Fecha fc1 = new Fecha(2021, 1, 15);
            Cuadro c1 = new Cuadro(001, "Harry", "Juan", 1997,fc1, 4, 15);

            Fecha fe1 = new Fecha(2021, 1, 17);
            Escultura e1 = new Escultura(002, "Elvis", "Smith", 1997,fe1, 15, 2);

            Fecha fcp1 = new Fecha(2021, 2, 20);
            CuadroPrestado cp1 = new CuadroPrestado(001, "Harry", "Juan", 1997, fc1, 4, 15, fcp1, "Galeon"); // Galeon es el nombre de la Galeria

            ObrasExposicion oe1 = new ObrasExposicion();

            oe1.insertarObra(e1);
            oe1.insertarObra(c1);

            oe1.existeObra(e1);
            oe1.existeObra(c1);

           Console.WriteLine(oe1.estaLlena());

           Console.WriteLine(oe1.hayObras());

            ///Console.WriteLine(oe1.recuperaObra(002)); tira error en el metodo diciendo q obras es null

            //Console.WriteLine(oe1.obrasArtista("Juan")); tira error en el metodo diciendo q obras es null

            //Console.WriteLine(oe1.todosLosCuadrosPrestados()); tira error en el metodo diciendo q obras es null



            CentroCultural centro1 = new CentroCultural("Perseo", oe1, artexp1);

            





        }





    }
}
