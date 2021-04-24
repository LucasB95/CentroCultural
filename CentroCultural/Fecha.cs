using System;
using System.Collections.Generic;
using System.Text;

namespace CentroCultural
{
    class Fecha {
        private int anio;
        private int mes;
        private int dia;

        public Fecha(int anio, int mes, int dia){
            this.anio = anio;
            this.mes = mes;
            this.dia = dia;
        }

        //Get y Set
        public void setAnio(int anio)
        {
            this.anio = anio;
        }

        public int getAnio()
        {
            return this.anio;
        }
        
        public void setMes(int mes)
        {
            this.mes = mes;
        }

        public int getMes()
        {
            return this.mes;
        }

        public void setDia(int dia)
        {
            this.dia = dia;
        }

        public int getDia()
        {
            return this.dia;
        }

        public override string ToString()
        {
            return dia + "-" + mes + "-" + anio;
        }

    }
}
