using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class CuotasSociales
    {
          #region Atributos
        private string CodSocio;
        private string Anio;
        private char Mes;
        private decimal MontoCuota;
        private char Pagada;

        public CuotasSociales()
        {
        }
        #endregion

        #region Constructores
        public CuotasSociales(string CodiSocio, string Year, char Mmes,decimal MounCuota,char Paid)
        {
            CodSocio = CodiSocio;
            Anio = Year;
            Mes = Mmes;
            MontoCuota = MounCuota;
            Pagada = Paid;
        }
        #endregion


        #region PROPIEDADES
        public string _CodSocio
        {
            get { return CodSocio; }
            set { CodSocio = value; }
        }

        public string _Anio
        {
            get { return Anio; }
            set { Anio = value; }
        }

        public char _Mes
        {
            get { return Mes; }
            set { Mes = value;  }
        }

        public decimal _MontoCuota
        {
            get { return MontoCuota; }
            set { MontoCuota = value; }
        }
        public char _Pagada
        {
            get { return Pagada; }
            set { Pagada = value; }
        }
        #endregion
    }
}
