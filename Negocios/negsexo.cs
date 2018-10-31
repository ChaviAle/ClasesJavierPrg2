using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datoss;
using Entidades;

namespace Negocios
{
    public class negsexo
    {
        DatosSexo objDatosSexo = new DatosSexo();

        public int abmSexo(string accion, Sexo objsexo)
        {
            return objDatosSexo.abmSexo(accion, objsexo);
        }
        public DataTable listadoSexos (string cual)
        {
            return objDatosSexo.listadoSexos(cual);
        }
    }
}
