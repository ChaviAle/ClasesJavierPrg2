using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
   public class Socio
    {
        #region Atributos
        private string CodSocio;
        private string Nombre;
        private string Apellido;
        private char CodSexo;
        private string Domicilio;
        private int CodBarrio;
        private decimal MontoMes;
        private Decimal FechaAlta;
        private Decimal FechaBaja;
        private char Activo;

        public Socio()
        {
        }
        #endregion

        #region Constructores
        public Socio(string Cod, string Nom, string Lastname,char CodiSexo,string Domi,int CodBashio, decimal MountMes, decimal FechaUP,decimal FechaDown)
        {
            CodSocio = Cod;
            Nombre = Nom;
            Apellido = Lastname;
            CodSexo = CodiSexo;
            Domicilio =Domi;
            CodBarrio = CodBashio;
            MontoMes = MountMes;
            FechaAlta = FechaUP;
            FechaBaja = FechaDown;


        }
        #endregion


        #region Propiedades
        public string _CodSocio
        {
            get { return CodSocio;}
            set { CodSocio = value;}
        }
        public string _Nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public string _Apellido
        {
            get { return Apellido; }
            set { Apellido = value; }
        }
        public char _CodSexo
        {
            get { return CodSexo; }
            set { CodSexo = value; }
        }
        public string _Domicilio
        {
            get { return Domicilio; }
            set { Domicilio = value; }
        }
        public int _CodBarrio
        {
            get { return CodBarrio; }
            set { CodBarrio = value; }
        }
        public decimal _MontoMes
        {
            get { return MontoMes; }
            set { MontoMes = value; }
        }
        public decimal _FechaAlta
        {
            get { return FechaAlta; }
            set { FechaAlta = value; }
        }
        public decimal _FechaBaja
        {
            get { return FechaBaja; }
            set { FechaBaja = value; }
        }
        public char _Activo
        {
            get { return Activo; }
            set { Activo = value; }
        }
#endregion




    }
}
