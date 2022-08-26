using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaModeloProyectoIEC
{
    public class Sentencias
    {
        DataTable tabla = new DataTable();
        private Conexion cn = new Conexion();
        public DataTable EncontrarArchivoExcel(string NombreArchivo, string NombreTabla)
        {
            DataTable dt = new DataTable();
            try
            {
                string PatCpnn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + NombreArchivo + "; Extended Properties=\"Excel 8.0;HDR=Yes;\";";
                OleDbConnection conn = new OleDbConnection(PatCpnn);
                OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("Select * from [" + NombreTabla + "$]", conn);

                myDataAdapter.Fill(dt);
            }
             catch (Exception ex)
            {
                MessageBox.Show("Error al consultar archivo de Excel (sentencias).");
            }
            return dt;
        }
        public void comprobarIdEncabezado(string tabla, string campoB, string nombre, string nombredisp)
        {
            MessageBox.Show("Se llego a comprobar en sentencias el ID");
            string idEmpleado = BuscaDato("empleado","pkid","nombre",nombre);
            int IdE = idEncabezadoActual(tabla, campoB);
            if (IdE == 0)
            {
                int IdS = idSiguienteDeNuevoIngreso("datosE", "pkid");
                int idNuevoEnca = idSiguienteDeNuevoIngreso("datosE", "pkid");
                string dispositivo = BuscaDato("dispositivo", "pkid", "nombre", nombredisp);
                string estado = "1";
                string IDEmpleadoEncabe = BuscaDato("datosE", "pkid", "fkempleado", idEmpleado);
                guardarTablaBdEncabezadoSentencias(idNuevoEnca.ToString(), idEmpleado, dispositivo, estado);
                MessageBox.Show("Se añadió un encabezado porque esta vacía la tabla");
            }
            else if (IdE != 0)
            {
                string IDEmpleadoEncabe = BuscaDato("datosE", "pkid", "fkempleado", idEmpleado);

                if (IDEmpleadoEncabe == "" || IDEmpleadoEncabe == null)
                {
                    int idNuevoEnca = idSiguienteDeNuevoIngreso("datosE", "pkid");
                    string dispositivo = BuscaDato("dispositivo", "pkid", "nombre", nombredisp);
                    string estado = "1";
                    try
                    {
                        guardarTablaBdEncabezadoSentencias(idNuevoEnca.ToString(), idEmpleado, dispositivo, estado);
                        MessageBox.Show("Se añadió un encabezado más para un nuevo empleado");
                    }
                    catch (Exception e) { MessageBox.Show("No fue posible ingresar el nuevo encabezado o detalle (sentencias)"); }

                }
                else if (IDEmpleadoEncabe != "")
                {
                    MessageBox.Show("Se encontró un encabezado para el empleado actual");
                }
            }
        }
        public void guardarTablaBdEncabezadoSentencias(string IdS, string fkempleado, string fkdispositivo, string estado)
        {
            // int IdS = idSiguienteDeNuevoIngreso("datosD", "pkid");
            //string IDEmpleado = BuscaDato();
            MessageBox.Show(IdS + " " + fkempleado + " " + fkdispositivo + " " + estado);
            try
            {
                string cadena = "INSERT INTO datosE VALUES ('" + IdS + "','" + fkempleado + "','" + fkdispositivo + "','" + estado + "');";
                MessageBox.Show(cadena);
                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                consulta.ExecuteNonQuery();
                MessageBox.Show("Se añadió el encabezado");
            }

            catch (OdbcException ex)
            {
                MessageBox.Show("Error al añadir encabezado (sentencias): " + ex.Message);
            }
        }
        public void guardarTablaBdDetalleSentencias(string tiempo, string tipoReg, string nombregestion)
        {
            int IDdatosE = idEncabezadoActual("datosE","pkid");
            int IdSiguienteDet = idSiguienteDeNuevoIngreso("datosD","pkid");

            string newtime = tiempo.Remove(tiempo.Length - 5, 5);
            MessageBox.Show(newtime);
            DateTime dt = Convert.ToDateTime(newtime);
            MessageBox.Show(dt.ToString());
            string horario = "";
            horario = dt.ToString("yyyy-MM-dd HH:mm:ss");
            MessageBox.Show(horario);
            string IdGestion = BuscaDato("gestion", "pkid", "nombre", nombregestion);
            string estado = "1";
            MessageBox.Show(IDdatosE + " " + IdSiguienteDet + " " + IdGestion + " " + estado);
            try
            {
                string cadena = "INSERT INTO datosD VALUES ('" + IdSiguienteDet + "','" + IDdatosE + "','" + horario + "','" + IdGestion + "','" + tipoReg + "','" + estado + "');";
                MessageBox.Show(cadena);
                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                consulta.ExecuteNonQuery();
                MessageBox.Show("Se añadió el detalle en sentencias");
            }

            catch (OdbcException ex)
            {
                MessageBox.Show("Error al añadir el detalle de horas (sentencias): " + ex.Message);
            }
        }
        public string BuscaDato(string tabla, string campo, string campobuscado, string datoreferencia)
        {
            string dato = "";
            try
            {
                string insertQuery = "SELECT * FROM " + tabla + " WHERE " + campobuscado + " = '" + datoreferencia + "';";
                MessageBox.Show(insertQuery);
                OdbcConnection conect = cn.conexion();
                OdbcCommand command = new OdbcCommand(insertQuery, conect);
                command.ExecuteNonQuery(); OdbcDataReader busquedac;
                busquedac = command.ExecuteReader();
                if (!busquedac.HasRows)
                {
                    throw new Exception("No hay dato guardado.");
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
                MessageBox.Show("Error al obtener " + dato + ".    " + ex);
                return dato;
            }
        }
        public int idEncabezadoActual(string tabla, string campoB)
        {
            string ultimoEntero = ""; int enteroSumado = 0; OdbcDataReader leer = null;
            string sql = "select" + " " + "(" + campoB + "*1" + ")" + " " + "as" + " " + campoB + " " + "FROM" + " " + tabla + " " + "ORDER BY" + " " + campoB + " " + "DESC Limit 1";
            OdbcConnection conect = cn.conexion();
            try
            {
                OdbcCommand comando = new OdbcCommand(sql, conect);
                leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    ultimoEntero = leer.GetString(0);
                    //enteroSumado += ultimoEntero; 
                    enteroSumado = int.Parse(ultimoEntero) ;
                }
            }
            catch (OdbcException ex)
            { MessageBox.Show("Error al cargar los datos" + ex.Message); }
            //finally
            { cn.desconexion(conect); }
           // if (enteroSumado == 0)
           // { enteroSumado = 1; }
            return enteroSumado;
        }
        public int idSiguienteDeNuevoIngreso(string tabla, string campoB)
        {
            string ultimoEntero = ""; int enteroSumado = 0; OdbcDataReader leer = null;
            string sql = "select" + " " + "(" + campoB + "*1" + ")" + " " + "as" + " " + campoB + " " + "FROM" + " " + tabla + " " + "ORDER BY" + " " + campoB + " " + "DESC Limit 1";
            OdbcConnection conect = cn.conexion();
            try
            {
                OdbcCommand comando = new OdbcCommand(sql, conect);
                leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    ultimoEntero = leer.GetString(0);
                    //enteroSumado += ultimoEntero; 
                    enteroSumado = int.Parse(ultimoEntero) + 1;
                }
            }
            catch (OdbcException ex)
            { MessageBox.Show("Error al cargar los datos" + ex.Message); }
            finally
            { cn.desconexion(conect); }
            if (enteroSumado == 0)
            { enteroSumado = 1; }

            return enteroSumado;
        }
    }
}
