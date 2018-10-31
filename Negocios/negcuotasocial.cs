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
    public class negcuotasocial
    {
        DatosCuota objDatosCuota = new DatosCuota();

        public int abmCuotas(string accion, CuotasSociales objcuotas)
        {
            return objDatosCuota.abmCuotas(accion, objcuotas);
        }

        public DataTable listadoCuotas(string cual)
        {
            return objDatosCuota.listadoCuotas(cual);
        }

        public DataSet CargoCuota(string Lista)
        {
            return objDatosCuota.CargoCuota(Lista);
        }
    }
}
