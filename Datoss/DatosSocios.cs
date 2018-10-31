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
   public class DatosSocios : DatosConexionDB
    {
        public int abmSocios(string accion, Socio objsocio)
        {
            int resultado = -1;
            string orden = string.Empty;

            if (accion == "Agregar")
                orden = "insert into socios values('" + objsocio._CodSocio + "'," + "'" + objsocio._Nombre + "'," + "'"+objsocio._Domicilio
                   + "'," + "'" +objsocio._Apellido+ "'," + "'" + objsocio._FechaAlta + "'," + "'" + objsocio._FechaBaja+ "'," + "'" + objsocio._MontoMes+ "'," + "'" + objsocio._CodSexo
                   + "'," + "'" + objsocio._CodBarrio+ "'," + "'" + objsocio._Activo + "');";


            if (accion == "Modificar")
                orden = "update socios set nombre='" + objsocio._Nombre + "'where socio_cod=" + objsocio._CodSocio +"and apellido= '"+objsocio._Apellido+"'"+ "and sexo_cod= '"+objsocio._CodSexo+"'"
                   + "and domicilio= '" + objsocio._Domicilio + "'" + "and barr_cod= '" + objsocio._CodBarrio + "'" + "and monto_mes= '" + objsocio._MontoMes + "'" + "and fecha_alta= '" + objsocio._FechaAlta + "'"
                   + "and fecha_baja= '" + objsocio._FechaBaja + "'" + "and activo= '" + objsocio._Activo + "'" + ";";


            if (accion == "Eliminar")
                orden = "delete from socios where socio_cod= '" + objsocio._CodSocio + "';";


            SqlCommand cmd = new SqlCommand(orden, conexion);

            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception(" Error al tratar de guardar, borrar o modificar de Socios", e);


            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;

        }
        public int borrosocio(string accion, Socio objsocio, Barrios objbarrios)
        {
            int resultado = -1;
            string orden = string.Empty;

            if (accion == "Pepe")
                orden = "delete from socios where barr_cod= '" + objbarrios._CodBarrio + "';";

            SqlCommand cmd = new SqlCommand(orden, conexion);

            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception(" Error al tratar de guardar, borrar o modificar de socios", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }
        public DataTable listadosocios(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
                orden = "select * from socios where socio_cod= '" + int.Parse(cual) + "';";
            else
                orden = "select * from socios;";
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
        public DataSet LlenoCombosexx(string Lista)
        {
            string y = string.Empty;
            if (Lista != "Todos")
                y = "select * from sexos where sexo_cod= '" + int.Parse(Lista) + "';";
            else
                y = "select sexo_cod from sexos;";
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
                throw new Exception("Error al listar Sexos ", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }

        public DataSet LlenoComboBarr(string Lista)
        {
            string y = string.Empty;
            if (Lista != "Todos")
                y = "select * from barrios where barr_cod= '" + int.Parse(Lista) + "';";
            else
                y = "select barr_cod from barrios;";
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
                throw new Exception("Error al listar Barrios ", e);
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
