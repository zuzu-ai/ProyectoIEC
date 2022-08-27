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
        public void comprobarIdEncabezado(string tabla, string campoB, string nombre, string nombredisp, string tiempo, string tipoReg, string nombregestion)
        {
            string idEmpleado = BuscaDato("empleado", "pkid", "nombre", nombre);
            int IdE = idEncabezadoActual(tabla, campoB);
            if (IdE == 0)
            {
                int idNuevoEnca = idSiguienteDeNuevoIngreso("datosE", "pkid");
                string dispositivo = BuscaDato("dispositivo", "pkid", "nombre", nombredisp);
                string estado = "1";
                guardarTablaBdEncabezadoSentencias(idNuevoEnca.ToString(), idEmpleado, dispositivo, estado, tiempo, tipoReg, nombregestion);
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
                        guardarTablaBdEncabezadoSentencias(idNuevoEnca.ToString(), idEmpleado, dispositivo, estado, tiempo, tipoReg, nombregestion);
                    }
                    catch (Exception e) { MessageBox.Show("No fue posible ingresar el nuevo encabezado o detalle (sentencias)"); }

                }
                else if (IDEmpleadoEncabe != "")
                {
                    guardarTablaBdDetalleSentencias(tiempo, tipoReg, nombregestion);
                }
            }
        }
        public void guardarTablaBdEncabezadoSentencias(string IdS, string fkempleado, string fkdispositivo, string estado, string tiempo, string tipoReg, string nombregestion)
        {
            try
            {
                string cadena = "INSERT INTO datosE VALUES ('" + IdS + "','" + fkempleado + "','" + fkdispositivo + "','" + estado + "');";
                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                consulta.ExecuteNonQuery();
            }

            catch (OdbcException ex)
            {
                MessageBox.Show("Error al añadir encabezado (sentencias): " + ex.Message);
            }
            guardarTablaBdDetalleSentencias(tiempo, tipoReg, nombregestion);
        }
        public void guardarTablaBdDetalleSentencias(string tiempo, string tipoReg, string nombregestion)
        {
            int IDdatosE = idEncabezadoActual("datosE", "pkid");
            int IdSiguienteDet = idSiguienteDeNuevoIngreso("datosD", "pkid");

            string newtime = tiempo.Remove(tiempo.Length - 5, 5);
            DateTime dt = Convert.ToDateTime(newtime);
            string horario = "";
            horario = dt.ToString("yyyy-MM-dd HH:mm:ss");
            string IdGestion = BuscaDato("gestion", "pkid", "nombre", nombregestion);
            string estado = "1";
            try
            {
                string cadena = "INSERT INTO datosD VALUES ('" + IdSiguienteDet + "','" + IDdatosE + "','" + horario + "','" + IdGestion + "','" + tipoReg + "','" + estado + "');";
                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                consulta.ExecuteNonQuery();
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
        public string BuscarEntrada(string tabla, string campo, string campobuscado1, string datoreferencia1, string campobuscado2, string datoreferencia2)
        {
            string dato = "";
            try
            {
                string insertQuery = "SELECT * FROM " + tabla + " WHERE " + campobuscado1 + " = '" + datoreferencia1 + "' AND " + campobuscado2 + " = '" + datoreferencia2 + "';";
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
        public string BuscarSalida(string tabla, string campo, string campobuscado1, string datoreferencia1, string campobuscado2, string datoreferencia2, string campoentrada, string entrada)
        {
            string dato = "";
            try
            {
                string insertQuery = "SELECT * FROM " + tabla + " WHERE " + campobuscado1 + " = '" + datoreferencia1 + "' AND " + campobuscado2 + " = '" + datoreferencia2 + " AND " + campoentrada + " LIKE '" + entrada + "%';";
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
                    enteroSumado = int.Parse(ultimoEntero);
                }
            }
            catch (OdbcException ex)
            { MessageBox.Show("Error al cargar los datos" + ex.Message); }
            { cn.desconexion(conect); }
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
        public int idEncabezadosxEmpleado(string tabla, string campoB, string campoC, string condicion)
        {
            string ultimoEntero = ""; int enteroSumado = 0; OdbcDataReader leer = null;
            string sql = "select" + " " + "(" + campoB + "*1" + ")" + " " + "as" + " " + campoB + " " + "FROM" + " " + tabla + " " + "WHERE" + " " + campoC + " =" + condicion + " " + "ORDER BY" + " " + campoB + " " + "DESC Limit 1";
            OdbcConnection conect = cn.conexion();
            try
            {
                OdbcCommand comando = new OdbcCommand(sql, conect);
                leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    ultimoEntero = leer.GetString(0);
                    enteroSumado = int.Parse(ultimoEntero);
                }
            }
            catch (OdbcException ex)
            { MessageBox.Show("Error al cargar los datos" + ex.Message); }
            { cn.desconexion(conect); }
            return enteroSumado;
        }

        //REALIZACION DE CALCULOS PARA EL REPORTE DE HORAS
        public DataTable obtenerDatos()
        {
            DataTable tablainicial = new DataTable();
            int cantidadEmpleados = idEncabezadoActual("empleado", "pkid");

            tablainicial.Columns.Add("ID");
            tablainicial.Columns.Add("Nombre");
            tablainicial.Columns.Add("Entrada");
            tablainicial.Columns.Add("Salida");
            tablainicial.Columns.Add("Horas Trabajadas");
            tablainicial.Columns.Add("Horas Descontadas");
            tablainicial.Columns.Add("Ausencias");
            tablainicial.Columns.Add("Horas Extras");
            tablainicial.Columns.Add("Pago de Comidas");
            tablainicial.Columns.Add("Pago de Combustible");
            tablainicial.Columns.Add("Observaciones");
            //BUSCAR LA INFORMACIÓN DE LOS EMPLEADOS
            for (int i = 1; i <= cantidadEmpleados; i++)
            {
                DataRow row = tablainicial.NewRow();
                row["ID"] = BuscaDato("empleado", "pkid", "pkid", i.ToString());
                row["Nombre"] = BuscaDato("empleado", "nombre", "pkid", i.ToString());

                //BUSCAR LAS HORAS DE EMPLEADOS POR DÍA
                string encabezado = BuscaDato("datosE", "pkid", "fkempleado", i.ToString());
                int cantidadDetalles = idEncabezadosxEmpleado("datosD", "pkid", "fkdatosE", encabezado);


                string IDentrada = BuscaDato("gestion", "pkid", "nombre", "Entrada");
                string IDsalida = BuscaDato("gestion", "pkid", "nombre", "Salida");
                string entrada, salida;
                //BUSCAR HORAS POR EMPLEADO
                for (int j = 1; j <= (cantidadDetalles / 2); j++)
                {
                    string horaEntrada = BuscarEntrada("datosD", "tiempo", "fkgestion", IDentrada, "fkdatosE", encabezado);
                    DateTime dtEntrada = Convert.ToDateTime(horaEntrada);
                    string fecha = dtEntrada.ToString("yyyy-MM-dd");
                    string tiemposalida = "";
                    string horaSalida = BuscarSalida("datosD", "tiempo", "fkgestion", IDsalida, "fkdatosE", encabezado, "tiempo", tiemposalida);
                    DateTime dtSalida = Convert.ToDateTime(horaSalida);

                    //CALCULO DE HORAS TRABAJADAS
                    string hentrada = dtEntrada.ToString("HH:mm:ss");
                    string hsalida = dtSalida.ToString("HH:mm:ss");
                    DateTime horaentrada = Convert.ToDateTime(hentrada);
                    DateTime horasalida = Convert.ToDateTime(hsalida);
                    var horastrabajadas = (horasalida - horaentrada).TotalSeconds;

                    //CALCULO DIFERENCIA DE HORAS
                    string inicioJornada = "07:00:00";
                    string finJornada = "17:00:00";
                    DateTime iJornada = Convert.ToDateTime(inicioJornada);
                    DateTime fJornada = Convert.ToDateTime(finJornada);
                    var horastotales = (fJornada - iJornada).TotalMinutes;
                    var diferenciahoras = (horastotales - horastrabajadas);
                    string horasExtra, horasDescontadas;

                    // HORAS DESCONTADAS O EXTRAS

                    if (diferenciahoras == 0)
                    {
                        horasExtra = "00:00";
                        horasDescontadas = "00:00";
                    }
                    else if (diferenciahoras != 0)
                    {
                        if (horastotales > horastrabajadas)
                        {
                            horasDescontadas = diferenciahoras.ToString();
                            horasExtra = "00:00";
                        }
                        else if (horastotales < horastrabajadas)
                        {
                            horasDescontadas = "00:00";
                            horasExtra = diferenciahoras.ToString();
                        }
                    }

                    //BUSQUEDA DE AUSENCIAS Y SUSPENCIONES

                    //BUSQUEDA DE PAGO DE COMIDA

                    //BUSQUEDA DE PAGO DE COMBUSTIBLE

                    //BUSQUEDA DE SUSPENCIONES
                }
            }
            return tablainicial;
        }
    }
}
