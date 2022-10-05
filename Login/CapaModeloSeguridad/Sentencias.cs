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
        public int funIniciarSesion(string Usuario, string Contraseña,  int validar)
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
        //Carol Monterroso 0901-17-5961
        public int funInicio(string Usuario, string Contrasena)
        {
            try
            {
                string Us = "";
                string Con = "";
                Comm = new OdbcCommand("SELECT usuario, contrasena FROM iec.usuario WHERE usuario ='" + Usuario + "' AND contrasena ='" + Contrasena + "' AND estado = '1' ;", cn.conexion()); //+ Email + "'AND email ='"
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


        public string BuscaDato(string tabla, string campo, string campobuscado, string datoreferencia)
        {
            string dato = "";
            try
            {
                string insertQuery = "SELECT * FROM " + tabla + " WHERE " + campobuscado + " = '" + datoreferencia + "';";
                //MessageBox.Show(insertQuery);
                OdbcConnection conect = cn.conexion();
                OdbcCommand command = new OdbcCommand(insertQuery, conect);
                command.ExecuteNonQuery(); OdbcDataReader busquedac;
                busquedac = command.ExecuteReader();
                if (!busquedac.HasRows)
                {
                    // throw new Exception("No hay dato guardado.");
                }
                if (busquedac.Read())
                {
                    dato = busquedac[campo].ToString();
                }
                cn.desconexion(conect);
                return dato;
            }
            catch (Exception ex)
            {
                return dato;
            }
        }
        

    }

}
