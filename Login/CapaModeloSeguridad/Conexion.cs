using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModeloSeguridad
{
    public class Conexion
    {
        public OdbcConnection conexion()
        {
            //creacion de la conexion via ODBC
            OdbcConnection conn = new OdbcConnection("Dsn=conexionIEC");
            try
            {
                conn.Open();
                Console.WriteLine("Conexión establecida");
            }
            catch (OdbcException)
            {
                Console.WriteLine("No se establecio Conexión");
            }
            return conn;
        }

        //metodo para cerrar la conexion
        public void desconexion(OdbcConnection conn)
        {
            try
            {
                conn.Close();
                Console.WriteLine("desconexión establecida");
            }
            catch (OdbcException)
            {
                Console.WriteLine("No se establecio Conexión");
            }
        }
    }
}
