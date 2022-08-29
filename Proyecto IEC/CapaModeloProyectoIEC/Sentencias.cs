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
                    guardarTablaBdDetalleSentencias(tiempo, tipoReg, nombregestion, IDEmpleadoEncabe);
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
            guardarTablaBdDetalleSentencias(tiempo, tipoReg, nombregestion, IdS);
        }
        public void guardarTablaBdDetalleSentencias(string tiempo, string tipoReg, string nombregestion, string idempleadoencabe)
        {
            int IdSiguienteDet = idSiguienteDeNuevoIngreso("datosD", "pkid");
            //REMOVER .m
            string newtime = tiempo.Remove(tiempo.Length - 2, 2);
            //GUARDAMOS a. o p.
            string tt = newtime.Remove(newtime.Length - 22, 19);
            //ELIMINAMOS a.m o p.m
            string timeconv = tiempo.Remove(tiempo.Length - 5, 5);
            //CONVERTIMOS EL TEXTO A FORMATO DE FECHA PARA EL ORDEN yyy-MM-dd HH:mm:ss
            DateTime dt = Convert.ToDateTime(timeconv);
            //DEJAR SOLO LA FECHA LUEGO DE CONVERTIR EL DATIME A STRING
            string dtconv = dt.ToString("yyyy-MM-dd HH:mm:ss");
            string solofecha = dtconv.Remove(dtconv.Length - 9, 9);
            //SEPARAMOS LAS HORAS, MINUTOS Y SEGUNDOS
            string prehoras = dtconv.Remove(dtconv.Length - 19, 11);
            string horas = prehoras.Remove(prehoras.Length - 6, 6);

            string preminutos = dtconv.Remove(dtconv.Length - 19, 14);
            string minutos = preminutos.Remove(preminutos.Length - 3, 3);

            string segundos = dtconv.Remove(dtconv.Length - 19, 17);

            int HORAS = 0; string fechaenv="";
            if (tt == " a.")
            {
                HORAS = 0;
                fechaenv = solofecha + " " + horas + ":" + minutos + ":" + segundos;
            }
            else if (tt == " p.")
            {
                HORAS = Int32.Parse(horas)+12;
                fechaenv = solofecha + " " + HORAS.ToString() + ":" + minutos + ":" + segundos;
            }

            string IdGestion = BuscaDato("gestion", "pkid", "nombre", nombregestion);
            string estado = "1";
            try
            {
                string cadena = "INSERT INTO datosD VALUES ('" + IdSiguienteDet + "','" + idempleadoencabe + "','" + fechaenv + "','" + IdGestion + "','" + tipoReg + "','" + estado + "');";
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
        public string BuscarPagos(string tabla, string campo, string campobuscado1, string datoreferencia1, string campobuscado2, string datoreferencia2, string campobuscado3, string datoreferencia3)
        {
            string dato = "";
            try
            {
                string insertQuery = "SELECT (SUM(" + campo + ")) FROM " + tabla + " WHERE " + campobuscado1 + " = '" + datoreferencia1 + "' AND " + campobuscado2 + " LIKE '" + datoreferencia2 + "%' AND " + campobuscado3 + " ='" + datoreferencia3 + "';";
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
                    dato = busquedac["(SUM(monto))"].ToString();
                }
                cn.desconexion(conect);
                return dato;
            }
            catch (Exception ex)
            {
                return dato;
            }
        }
        public string BuscarFechaGestion(string tabla, string campo, string campobuscado1, string datoreferencia1, string campobuscado2, string datoreferencia2, string campoentrada, string entrada)
        {
            string dato = "";
            try
            {
                string insertQuery = "SELECT * FROM " + tabla + " WHERE " + campobuscado1 + " = '" + datoreferencia1 + "' AND " + campobuscado2 + " = '" + datoreferencia2 + "' AND " + campoentrada + " LIKE '" + entrada + " %';";
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
        public int cantidadTB(string tabla, string campo, string dato, string campo2, string dato2)
        {
            string contador = ""; int CT = 0; OdbcDataReader leer = null;
                string query = "SELECT count(*) from " + tabla + " where " + campo + "= '" + dato + "' AND " + campo2 + "= '" + dato2 + "';";
            OdbcConnection conect = cn.conexion();
            OdbcCommand command = new OdbcCommand(query, conect);
            leer = command.ExecuteReader();
            if (!leer.HasRows)
            {
                contador = "0";
            }
            if (leer.Read())
            {
                contador = leer["count(*)"].ToString();
            }
            { cn.desconexion(conect); }
            CT = Int32.Parse(contador);
            return (CT);
        }
        public int cantidadTB2(string tabla, string campo, string dato, string campo2, string dato2, string campo3, string dato3)
        {
            string contador = ""; int CT = 0; OdbcDataReader leer = null;
            string query = "SELECT count(*) from " + tabla + " where " + campo + "= '" + dato + "' AND " + campo2 + "= '" + dato2 + "' AND " + campo3 + "= '" + dato3 + "';";
            OdbcConnection conect = cn.conexion();
            try
            {
                OdbcCommand comando = new OdbcCommand(query, conect);
                leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    contador = leer.GetString(0);
                    CT = int.Parse(contador);
                }
            }
            catch (OdbcException ex)
            { /*MessageBox.Show("Error al buscar la cantidad de ausencias" + ex.Message); */}
            { cn.desconexion(conect); }
            return (CT);
        }
        //REALIZACION DE CALCULOS PARA EL REPORTE DE HORAS
        public DataTable obtenerDatos(string fechatrabajada)
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
            tablainicial.Columns.Add("Pago de Viáticos");
            tablainicial.Columns.Add("Otros Pagos");
            tablainicial.Columns.Add("Observaciones");
            //DataRow row = tablainicial.NewRow();
            //BUSCAR LA INFORMACIÓN DE LOS EMPLEADOS
            for (int i = 1; i <= cantidadEmpleados; i++)
            {
                DataRow row = tablainicial.NewRow();
                row["ID"] = i.ToString();
                row["Nombre"] = BuscaDato("empleado", "nombre", "pkid", i.ToString());

                //BUSCAR LAS HORAS DE EMPLEADOS POR DÍA
                string encabezado = BuscaDato("datosE", "pkid", "fkempleado", i.ToString());
                int cantidadDetalles = idEncabezadosxEmpleado("datosD", "pkid", "fkdatosE", encabezado);

                string IDentrada = BuscaDato("gestion", "pkid", "nombre", "Entrada");
                string IDsalida = BuscaDato("gestion", "pkid", "nombre", "Salida");

                string horaEntrada="", horaSalida="", hentrada ="", hsalida=""; DateTime dtEntrada=new DateTime(), dtSalida= new DateTime();
                //BUSCAR HORAS POR EMPLEADO
                for (int j = 1; j <= (cantidadDetalles / 2); j++)
                {
                    horaEntrada = BuscarFechaGestion("datosD", "tiempo", "fkgestion", IDentrada, "fkdatosE", encabezado, "tiempo", fechatrabajada);
                    dtEntrada = Convert.ToDateTime(horaEntrada);
                    horaSalida = BuscarFechaGestion("datosD", "tiempo", "fkgestion", IDsalida, "fkdatosE", encabezado, "tiempo", fechatrabajada);
                    dtSalida = Convert.ToDateTime(horaSalida);
                     hentrada = dtEntrada.ToString("HH:mm:ss");
                     hsalida = dtSalida.ToString("HH:mm:ss");
                    if (horaEntrada == "") { hentrada = "00-00-00 00:00:00"; }
                    if (horaSalida == "") { hsalida = "00-00-00 00:00:00"; }
                    row["Entrada"] = hentrada;
                    row["Salida"] = hsalida;
                }
                    //CALCULO DE HORAS TRABAJADAS
                    var horast = (dtSalida - dtEntrada).TotalHours;
                    TimeSpan tiempo = new TimeSpan(
                        Convert.ToInt32(Math.Floor(horast)),
                        Convert.ToInt32((horast - Math.Floor(horast)) * 60),
                        0);
                    string horastrabajadas = tiempo.ToString();
                    row["Horas Trabajadas"] = horastrabajadas;
                    //CALCULO DIFERENCIA DE HORAS
                    //BUSCAMOS JORNADA DEL EMPLEADO Y PROCESAMOS LOS HORARIOS
                    string idjornada = BuscaDato("empleado", "fkjornada", "pkid", i.ToString());
                    string horainicioj = BuscaDato("jornada", "horainicio", "pkid", idjornada);
                    string horafinj = BuscaDato("jornada", "horafin", "pkid", idjornada);

                    DateTime hinicio = Convert.ToDateTime(horainicioj);
                    DateTime hfin = Convert.ToDateTime(horafinj);

                    //CALCULAMOS EL TOTAL DE HORAS ESPERADO
                    var hesperadas = (hfin - hinicio).TotalHours;
                    TimeSpan horaseperadas = new TimeSpan(
                        Convert.ToInt32(Math.Floor(hesperadas)),
                        Convert.ToInt32((hesperadas - Math.Floor(hesperadas)) * 60),
                        0);

                    //CALCULAMOS LA DIFERENCIA ENTRE HORAS ESPERADAS Y HORAS TRABAJADAS
                    string solohoraini = hinicio.ToString("HH:mm:ss");
                    string solohorafin = hfin.ToString("HH:mm:ss");
                    string solohoraentrada = dtEntrada.ToString("HH:mm:ss");
                    string solohorasalida = dtSalida.ToString("HH:mm:ss");

                    DateTime solohini = Convert.ToDateTime(solohoraini);
                    DateTime solohfin = Convert.ToDateTime(solohorafin);
                    DateTime solohentrada = Convert.ToDateTime(solohoraentrada);
                    DateTime solohsalida = Convert.ToDateTime(solohorasalida);

                    var difh = ((solohsalida - solohentrada) - (solohfin - solohini)).TotalHours;
                    TimeSpan difhoras = new TimeSpan(
                        Convert.ToInt32(Math.Floor(difh)),
                        Convert.ToInt32((difh - Math.Floor(difh)) * 60),
                        0);
                    string diferenciahoras = difhoras.ToString();

                    string horasExtra = "", horasDescontadas = "";
                    // HORAS DESCONTADAS O EXTRAS

                    if (difh == 0)
                    {
                        horasExtra = "00:00:00";
                        horasDescontadas = "00:00:00";
                    }
                    else if (difh != 0)
                    {
                        if ((difh.ToString()).Contains("-"))
                        {
                            string predescontadas = diferenciahoras;
                            horasDescontadas = predescontadas.Remove(predescontadas.Length - 9, 1);
                            horasExtra = "00:00:00";
                        }
                        else
                        {
                            horasDescontadas = "00:00:00";
                            horasExtra = diferenciahoras.ToString();
                        }
                    }
                    row["Horas Descontadas"] = horasDescontadas;
                    row["Horas Extras"] = horasExtra;

                    //BUSQUEDA DE AUSENCIAS Y SUSPENCIONES
                    int ausencias = cantidadTB("ausencia", "fkempleado", i.ToString(), "estado", "1");
                    row["Ausencias"] = ausencias.ToString();

                    //BUSQUEDA DE PAGO DE COMIDA
                    string idcomida = BuscaDato("tipopago", "pkid", "nombre", "Comida");
                    string montoco = BuscarPagos("pagoempleado", "monto", "fkempleado", i.ToString(), "fecha", fechatrabajada, "tipopago", idcomida);
                    double montocomida = 0;
                    if (montoco == "") { montocomida = 0; } else { montocomida = Double.Parse(montoco); }
                    row["Pago de Comidas"] = "Q." + montocomida.ToString();
                    //BUSQUEDA DE PAGO DE COMBUSTIBLE
                    string idcombustible = BuscaDato("tipopago", "pkid", "nombre", "Combustible");
                    string montoc = BuscarPagos("pagoempleado", "monto", "fkempleado", i.ToString(), "fecha", fechatrabajada, "tipopago", idcombustible);
                    double montocombustible = 0;
                    if (montoc == "") { montocombustible = 0; } else { montocombustible = Double.Parse(montoc); }
                    row["Pago de Combustible"] = "Q." + montocombustible.ToString();
                    //BUSQUEDA DE PAGO DE VIATICOS
                    string idviaticos = BuscaDato("tipopago", "pkid", "nombre", "Viáticos");
                    string montov = BuscarPagos("pagoempleado", "monto", "fkempleado", i.ToString(), "fecha", fechatrabajada, "tipopago", idviaticos);
                    double montoviaticos = 0;
                    if (montov == "") { montoviaticos = 0; } else { montoviaticos = Double.Parse(montov); }
                    row["Pago de Viáticos"] = "Q." + montoviaticos.ToString();
                    //BUSQUEDA DE OTROS PAGOS
                    string idotros = BuscaDato("tipopago", "pkid", "nombre", "Otros");
                    string montoo = BuscarPagos("pagoempleado", "monto", "fkempleado", i.ToString(), "fecha", fechatrabajada, "tipopago", idotros);
                    double montootros = 0;
                    if (montoo == "") { montootros = 0; } else { montootros = Double.Parse(montoo); };
                    row["Otros Pagos"] = "Q." + montootros.ToString();

                    //BUSQUEDA DE SUSPENCIONES
                tablainicial.Rows.Add(row);
            }
            
            return tablainicial;
        }
        public void guardarEncabezadoDiarios(string id, string fecha, string estado)
        {
            try
            {
                string cadena = "INSERT INTO diariosE VALUES ('" + id + "','" + fecha + "','" + estado + "');";
                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                consulta.ExecuteNonQuery();
            }

            catch (OdbcException ex)
            {
                MessageBox.Show("Error al añadir encabezado (sentencias): " + ex.Message);
            }
            //guardarTablaBdDetalleSentencias(tiempo, tipoReg, nombregestion, IdS);
        }
    }
}
