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
    public class negbarrios
    {

        DatosBarrio objDatosBarrio = new DatosBarrio();

        public int abmBarrios(string accion, Barrios objbarrios,Provincias objprovincias)
        {
            return objDatosBarrio.abmBarrios(accion, objbarrios,objprovincias);
        }

        public DataTable listadobarrios (string cual)
        {
        return objDatosBarrio.listadobarrios(cual);
        }

        public int borrobarr(string accion, Barrios objbarrios, Provincias objprovincias)
        {
            return objDatosBarrio.borrobarr(accion, objbarrios, objprovincias);
        }
        public DataTable ControloSocios(string Lista2)
        {
            return objDatosBarrio.ControloSocios(Lista2);
        }
    }
}
