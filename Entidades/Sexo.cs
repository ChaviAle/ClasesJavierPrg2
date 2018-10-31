using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Sexo
    {
        #region Atributos
        private char CodSexo;
        private string Descripcion;

        public Sexo()
        {
        }
        #endregion


        #region Constructores
        public Sexo(char CodSex, string Desc)
        {
            CodSexo = CodSex;
            Descripcion = Desc;
        }
        #endregion


        #region Propiedades
        public char _CodSexo
        {
            get { return CodSexo; }
            set { CodSexo = value; }
        }

        public string _Descripcion
        {
            get { return Descripcion; }
            set { Descripcion= value; }
          
        }
#endregion
    }

}
