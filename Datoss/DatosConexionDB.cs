using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datoss
{
    public class DatosConexionDB
    {
        public SqlConnection conexion;

        //public string cadenadeconexion = @"Data Source=DESKTOP-PH3NBRP\SQLEXPRESS;Initial Catalog=socios;Integrated Security=True"; //Base datos facu
        public string cadenadeconexion = @"Data Source=DESKTOP-F8PC2IJ\SQLEXPRESS;Initial Catalog=socios;Integrated Security=True"; //Base Datos Casa

        public DatosConexionDB()
        {
            conexion = new SqlConnection(cadenadeconexion);
        }
        public void Abrirconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Broken || conexion.State == ConnectionState.Closed)
                    conexion.Open();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de abrir la conexion ", e);
            }
        }
        public void Cerrarconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de cerrar la conexion ", e);

            }
        }
    }
}


