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
    public class DatosProvincias: DatosConexionDB
    {
        public int abmProvincias(string accion, Provincias objprovincias)
        {
            int resultado=-1;
            string orden = string.Empty;

            if (accion == "Agregar")
                orden = "insert into provincias values('" + objprovincias._CodProvincia + "'," + "'"+ objprovincias._Nombre + "');";
            if (accion == "Modificar")
                orden = "update Provincias set prov_nombre='" + objprovincias._Nombre + "'where prov_cod=" + objprovincias._CodProvincia + ";";
            if (accion == "Eliminar")
                orden = "delete from Provincias where prov_cod= '" + objprovincias._CodProvincia + "';";


            SqlCommand cmd = new SqlCommand(orden, conexion);

            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception (" Error al tratar de guardar, borrar o modificar de Provincias",e);
               

            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
           
        }


        public DataTable listadoProvincias(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
                orden = "select * from provincias where prov_cod= '" + cual + "';";
            else
                orden = "select * from provincias;";
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
                throw new Exception("Error al listar provincias ", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
            
        }

        
        public List<Provincias> CargoCombo2()
        {

            List<Provincias> lista = new List<Provincias>();

            SqlCommand cmd;

            string orden = "select prov_cod,prov_nombre from provincias";

            cmd = new SqlCommand(orden, conexion);
            SqlDataReader dr;

            try
            {
                Abrirconexion();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Provincias P = new Provincias();
                    P._CodProvincia = Convert.ToChar(dr["prov_cod"]);
                    P._Nombre = dr.GetString(1);
                    lista.Add(P);

                }

            }
            catch (Exception e)
            {
                throw new Exception("Error", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return lista;



        }

        public DataTable ControloBarrios(string Lista1)
        {
            string x = string.Empty;
            if (Lista1 != "Todos")
                x = "select * from barrios where prov_cod= '" + int.Parse(Lista1) + "';";
            else
                x = "select * from barrios;";
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
                throw new Exception("Error al listar barrios ", e);
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
