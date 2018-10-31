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
    public class DatosSexo : DatosConexionDB
    {
        public int abmSexo(string accion, Sexo objsexo)
        {
            int resultado = -1;
            string orden = string.Empty;

            if (accion == "Agregar")
                orden = "insert into sexos(sexo,sexo_cod) values('" + objsexo._Descripcion + "'," + "'" + objsexo._CodSexo + "');";
            if (accion == "Modificar")
                orden = "update sexos set sexo='" + objsexo._Descripcion + "'where sexo_cod=" + objsexo._CodSexo + ";";
            if (accion == "Eliminar")
                orden = "delete from sexos where sexo_cod= '" + objsexo._CodSexo + "';";

            SqlCommand cmd = new SqlCommand(orden, conexion);

            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception(" Error al tratar de guardar, borrar o modificar de Sexos", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }

        public DataTable listadoSexos(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
                orden = "select * from sexos where sexo_cod= '" + int.Parse(cual) + "';";
            else
                orden = "select * from sexos;";
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
                throw new Exception("Error al listar Sexos ", e);
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
