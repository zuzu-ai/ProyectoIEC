using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaModeloSeguridad
{
    public class Sentencias
    {
        private Conexion cn = new Conexion();
        private OdbcCommand Comm;
        public int funIniciarSesion(string Usuario, string Contraseña, int validar)
        {
            try
            {
                string con = "";
                string Query = "select * from Usuario where nombre='" + Usuario + "';";

                OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
                consulta.ExecuteNonQuery();

                OdbcDataReader busqueda;
                busqueda = consulta.ExecuteReader();

                if (busqueda.Read())
                {
                    con = busqueda["contraseña"].ToString();
                }

                validar = Contraseña.CompareTo(con);
            }
            catch
            {
            }
            return validar;
        }
        //Kevin Flores 9959-18-17632
        public int funInicio(string Usuario, string Contrasena)
        {
            try
            {
                string Us = "";
                string Con = "";
                Comm = new OdbcCommand("SELECT usuario, contrasena FROM iec.usuario WHERE usuario ='" + Usuario + "' AND contrasena ='" + Contrasena + "' AND estado = '1' ;", cn.conexion());
                OdbcDataReader reader = Comm.ExecuteReader();
                reader.Read();
                Us = reader.GetString(0);
                Con = reader.GetString(1);
                reader.Close();
                if (String.IsNullOrEmpty(Us) || String.IsNullOrEmpty(Con))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al consular usuario:  " + ex);
                return 0;
            }
        }
        public OdbcDataReader funcModificar(string Consulta)
        {
            try
            {
                Comm = new OdbcCommand(Consulta, cn.conexion());
                OdbcDataReader mostrar = Comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception Error)
            {
                Console.WriteLine("Error en modelo-modificar ", Error);
                return null;
            }
        }
    }
}
