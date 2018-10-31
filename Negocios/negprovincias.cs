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
   
   public class negprovincias
    {
        

        DatosProvincias objDatosProv = new DatosProvincias();
        public int abmProvincias(string accion,Provincias objprovincias)
        {
            return objDatosProv.abmProvincias(accion,objprovincias);
        }

        public DataTable listadoProvincias(string cual) 
        //Para llenar el datagrid de provincias con lo que tengfo en la base
        {
            return objDatosProv.listadoProvincias(cual);
        }

        

        public DataTable ControloBarrios(string Lista1)
            //Para controlar si un barrio tiene el codprovincia
        {
            return objDatosProv.ControloBarrios(Lista1);
        }

        
        //Para llenar combobox de la pestaña barrio con los cod prov
        public List<Provincias> CargoCombo2()
        {
            return objDatosProv.CargoCombo2();
        }
    }
}
