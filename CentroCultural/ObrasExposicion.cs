using System;
using System.Collections.Generic;
using System.Text;

namespace CentroCultural
{
    class ObrasExposicion
    {
        public CentroCultural cul;
        public ObraDeArte[] obras;


        public ObrasExposicion()
        {
           
            this.obras =  new ObraDeArte[5];
        }

        public void insertarObra(ObraDeArte o)          

        {
            //creo una lista de obras y le asigno la obra q se ingresa
            //List<ObraDeArte> obrass = new List<ObraDeArte> { };
            //obrass.Add(o);


            for (int i = 0; i < obras.Length; i++)
            {
                obras[i] = null;
                if (obras[i] == null)
                {
                    obras[i] = o;
                        break;
                }
            }
        }


        public int cantidadObras()
        {
            int contObras = 0;
            foreach (ObraDeArte obra in obras)
            {
                contObras++;
            }
            return contObras;
        }


        public Boolean existeObra(ObraDeArte o)
        {
            Boolean existe = false;
            foreach (ObraDeArte obra in obras)
            {
                if (obra == o)
                {
                    existe = true;
                }
            }
            return existe;
        }

        public Boolean estaLlena()
        {
            Boolean estaLleno = true;
            foreach (ObraDeArte obra in obras)
            {
                if (obra == null)
                {
                    estaLleno = false;
                }
            }
            return estaLleno;
        }


        public Boolean hayObras()
        {
            Boolean hayObra = false;
            foreach (ObraDeArte obra in obras)
            {
                if (obra != null)
                {
                    hayObra = true;
                }
            }
            return hayObra;
        }


        public ObraDeArte recuperaObra(int codigo){

            ObraDeArte obr = null;
            foreach (ObraDeArte obra in obras)
            {
                if (obra != null && obra.Codigo() == codigo)
                {
                    obr = obra;
                   
                }
            }
            return obr;
        }

        public List<ObraDeArte> obrasArtista(String nom)
        {
            List<ObraDeArte> artnac = new List<ObraDeArte> { };
            foreach (ObraDeArte obra in obras)
            {
                if (obra != null && obra.NombreArtista().Equals(nom))
                {
                    artnac.Add(obra);
                }
            }
            return artnac;
        }

     

        public ObraDeArte[] todosLosCuadrosPrestados()
        {
            ObraDeArte[] obrasPrest;
            int contador = obras.Length;
            obrasPrest = new ObraDeArte[contador];
            for(int i=0; i < obras.Length; i++)
            {
                if(obras[i] != null && obras[i] is CuadroPrestado)
                {
                    obrasPrest[i] = obras[i];
                }
               
            }


            return obrasPrest;


        }



    }
}
