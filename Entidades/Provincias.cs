using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
   public class Provincias
        
    {
        
         #region Atributos
        private char CodProvincia;
        private string Nombre;
        #endregion


        #region Constructores
        public Provincias(char CodPov, string Name)
        {
            CodProvincia = CodPov;
            Nombre = Name;
        }
        public Provincias()
        {

        }
        #endregion


        #region PROPIEDADES

        public char _CodProvincia
        {
            get { return CodProvincia; }
            set { CodProvincia = value; }
        }

        public string _Nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        


       #endregion



    }
}
