﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CentroCultural
{
    class ObrasExposicion
    {
        public CentroCultural cul;
        public ObraDeArte[] obras;


        public ObrasExposicion(CentroCultural cul)
        {
            this.cul = cul;
            this.obras =  new ObraDeArte[5];
        }

        public void insertarObra(ObraDeArte o)          

        {
            //creo una lista de obras y le asigno la obra q se ingresa
            //List<ObraDeArte> obrass = new List<ObraDeArte> { };
            //obrass.Add(o);


            for (int i = 0; i < 5; i++)
            {
                if (i == null)
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
                if (obra.Equals(o))
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
                if (codigo == obra.Codigo())
                {
                    obr = obra;
                    break;
                }
            }
            return obr;
        }

        public List<ObraDeArte> obrasArtista(String nom)
        {
            List<ObraDeArte> artnac = new List<ObraDeArte> { };
            foreach (ObraDeArte obra in obras)
            {
                if (obra.NombreArtista().Equals(nom))
                {
                    artnac.Add(obra);
                }
            }
            return artnac;
        }

        public List<ObraDeArte> todosLosCuadrosPrestados()
        {
            List<ObraDeArte> obrasPrestadas = new List<ObraDeArte> { };
            foreach (ObraDeArte obra in obras)
            {
                if(obra is CuadroPrestado)
                {
                    obrasPrestadas.Add(obra);
                }
            }
            return obrasPrestadas;

        }



    }
}
