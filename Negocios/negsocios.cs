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
    public class negsocios
    {
        DatosSocios objDatosSocios = new DatosSocios();

        public int abmSocios(string accion, Socio objsocio)
        {
            return objDatosSocios.abmSocios(accion, objsocio);
        }

        public DataTable listadosocios(string cual)
        {
            return objDatosSocios.listadosocios(cual);
        }

        public DataSet LlenoCombosexx(string Lista)
        {
            return objDatosSocios.LlenoCombosexx(Lista);
        }

        public DataSet LlenoComboBarr(string Lista)
        {
            return objDatosSocios.LlenoComboBarr(Lista);
        }
        public int borrosocio(string accion, Socio objsocio, Barrios objbarrios)
        {
            return objDatosSocios.borrosocio(accion, objsocio, objbarrios);
        }
    }
}
