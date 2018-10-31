using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datoss
{
    public class DatosCuota : DatosConexionDB
    {
        public int abmCuotas(string accion, CuotasSociales objcuotas)
        {
            int resultado = -1;
            string orden = string.Empty;

            if (accion == "Agregar")
                orden = "insert into cuotas_sociales values('" + objcuotas._CodSocio + "'," + "'" + objcuotas._Anio + "'," + "'" +objcuotas._Mes
                 + "'," + "'" +objcuotas._MontoCuota + "'," + "'" +objcuotas._Pagada +"');";


            if (accion == "Modificar")
                orden = "update cuotas_sociales set socio_cod='" + objcuotas._CodSocio + "'where anio=" + objcuotas._Anio + "', mes=" + objcuotas._Mes
                   + "',monto_cuota=" + objcuotas._MontoCuota + "'pagada=" + objcuotas._Pagada + "';";


            if (accion == "Eliminar")
                orden = "delete from cuotas_sociales where socio_cod= '" + objcuotas._CodSocio + "';";


            SqlCommand cmd = new SqlCommand(orden, conexion);

            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception(" Error al tratar de guardar, borrar o modificar de Cuotas Sociales", e);


            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;

        }


        public DataTable listadoCuotas(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
                orden = "select * from cuotas_sociales where socio_cod= '" + int.Parse(cual) + "';";
            else
                orden = "select * from cuotas_sociales;";
            SqlCommand cmd = new SqlCommand(orden, conexion);
            DataTable ds = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar Socios ", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;

        }

        public DataSet CargoCuota(string Lista)
        {
            string y = string.Empty;
            if (Lista != "Todos")
                y = "select * from socios where socio_cod= '" + int.Parse(Lista) + "';";
            else
                y = "select socio_cod from socios;";
            SqlCommand cmd = new SqlCommand(y, conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar Socios ", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }
    }

   
}
