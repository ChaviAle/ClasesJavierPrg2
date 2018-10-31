using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Barrios
    {
        #region Atributos
        private char CodBarrio;
        private string Nombre;
        private char CodProvincia;

        public Barrios()
        {
        }
        #endregion

        #region Constructores
        public Barrios(char CodBashio, string Name ,char CodProv)
        {
            CodBarrio = CodBashio;
            Nombre = Name;
            CodProvincia = CodProv;
        }

        public int abmBarrios(string accion, object objbarrios)
        {
            throw new NotImplementedException();
        }
        #endregion


        #region PROPIEDADES

        public char _CodBarrio
        {
            get { return CodBarrio; }
            set { CodBarrio = value; }
        }

        public string _Nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public char _CodProvincia
        {
            get { return CodProvincia; }
            set { CodProvincia = value; }
        }
#endregion






    }
    
}
