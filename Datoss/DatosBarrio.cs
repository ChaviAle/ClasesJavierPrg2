using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Datoss
{
    public class DatosBarrio : DatosConexionDB
    {
        public int abmBarrios(string accion, Barrios objbarrios, Provincias objprovincias)
        {
            int resultado = -1;
            string orden = string.Empty;

            if (accion == "Agregar")
                orden = "insert into barrios(barr_nombre,barr_cod,prov_cod) values('" + objbarrios._Nombre + "'," + "'" +  objbarrios._CodBarrio + "'," + "'" + objbarrios._CodProvincia
                    + "');";
            if (accion == "Modificar")
                orden = "update barrios set barr_nombre='" + objbarrios._Nombre  +"'where barr_cod=" + objbarrios._CodBarrio/*+ "', prov_cod=" + objbarrios._CodProvincia*/  
                    +"; ";
            if (accion == "Eliminar")
                orden = "delete from barrios where barr_cod= '" + objbarrios._CodBarrio + "';";
            
            

            SqlCommand cmd = new SqlCommand(orden, conexion);

            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception(" Error al tratar de guardar, borrar o modificar de barrios",e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;

        }
        public int borrobarr(string accion, Barrios objbarrios, Provincias objprovincias)
        {
            int resultado = -1;
            string orden = string.Empty;

            if (accion == "Pepe")
                orden = "delete from barrios where prov_cod= '" + objprovincias._CodProvincia + "';";

            SqlCommand cmd = new SqlCommand(orden, conexion);

            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception(" Error al tratar de guardar, borrar o modificar de barrios", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }

        public DataTable listadobarrios(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
                 orden = "select * from barrios where barr_cod= '" + int.Parse(cual) + "';";
              
            else
                orden = "select * from barrios;";
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
                throw new Exception("Error al listar barrios ", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }
        public DataTable ControloSocios(string Lista2)
        {
            string x = string.Empty;
            if (Lista2 != "Todos")
                x = "select * from socios where barr_cod= '" + char.Parse(Lista2) + "';";
            else
                x = "select * from socios;";
            SqlCommand cmd = new SqlCommand(x, conexion);
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
                throw new Exception("Error al listar socios ", e);
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
