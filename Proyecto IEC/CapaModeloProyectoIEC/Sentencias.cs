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

            int HORAS = 0; string fechaenv = "";
            if (tt == " a.")
            {
                HORAS = 0;
                fechaenv = solofecha + " " + horas + ":" + minutos + ":" + segundos;
            }
            else if (tt == " p.")
            {
                HORAS = Int32.Parse(horas) + 12;
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
        public string BuscaDatoEmpleado(string tabla1, string tabla2, string campo, string campobuscado, string datoreferencia, string campobuscado2, string datoreferencia2, string campobuscado3, string datoreferencia3)
        {
            string dato = "";
            try
            {
                string insertQuery = "SELECT " + campo + " AS campo FROM " + tabla1 + " INNER JOIN " + tabla2 + " WHERE " + campobuscado + " = '" + datoreferencia + "' AND " + campobuscado2 + " = '" + datoreferencia2 + "' AND diariosd.fkdiariosE = diariose.pkid AND " + campobuscado3 + " = '" + datoreferencia3 + "';";
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
                    dato = busquedac["campo"].ToString();
                }
                cn.desconexion(conect);
                return dato;
            }
            catch (Exception ex)
            {
                return dato;
            }
        }
        public string Buscadiario(string campo, string empleado, string fechatrabajada, string datobuscado, string nombrenuevo)
        {
            string dato = "";
            try
            {
                string insertQuery = "select " + datobuscado + " as " + nombrenuevo + " from diariose,diariosd where diariosd.fkempleado = '" + empleado + "' and diariose.fechatrabajada = '" + fechatrabajada + "' and diariosd.fkdiariosE = diariose.pkid;";
                    
                
                MessageBox.Show(insertQuery);
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

                string horaEntrada = "", horaSalida = "", hentrada = "", hsalida = ""; DateTime dtEntrada = new DateTime(), dtSalida = new DateTime();
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
                row["Pago de Comidas"] = montocomida.ToString();
                //BUSQUEDA DE PAGO DE COMBUSTIBLE
                string idcombustible = BuscaDato("tipopago", "pkid", "nombre", "Combustible");
                string montoc = BuscarPagos("pagoempleado", "monto", "fkempleado", i.ToString(), "fecha", fechatrabajada, "tipopago", idcombustible);
                double montocombustible = 0;
                if (montoc == "") { montocombustible = 0; } else { montocombustible = Double.Parse(montoc); }
                row["Pago de Combustible"] = montocombustible.ToString();
                //BUSQUEDA DE PAGO DE VIATICOS
                string idviaticos = BuscaDato("tipopago", "pkid", "nombre", "Viáticos");
                string montov = BuscarPagos("pagoempleado", "monto", "fkempleado", i.ToString(), "fecha", fechatrabajada, "tipopago", idviaticos);
                double montoviaticos = 0;
                if (montov == "") { montoviaticos = 0; } else { montoviaticos = Double.Parse(montov); }
                row["Pago de Viáticos"] = montoviaticos.ToString();
                //BUSQUEDA DE OTROS PAGOS
                string idotros = BuscaDato("tipopago", "pkid", "nombre", "Otros");
                string montoo = BuscarPagos("pagoempleado", "monto", "fkempleado", i.ToString(), "fecha", fechatrabajada, "tipopago", idotros);
                double montootros = 0;
                if (montoo == "") { montootros = 0; } else { montootros = Double.Parse(montoo); };
                row["Otros Pagos"] = montootros.ToString();

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
            //guardarDetalleDiarios(idD, id, empleado, entrada, salida, htrabajadas, hdescontadas, ausencias, hextras, pcomidas, pcombustible, pviaticos, potros, observaciones);
        }
        public void guardarDetalleDiarios(int idD, string idE, string empleado, string entrada, string salida, string htrabajadas, string hdescontadas, string ausencias, string hextras, string pcomidas, string pcombustible, string pviaticos, string potros, string observaciones)
        {
            try
            {
                string cadena = "INSERT INTO diariosD VALUES ('" + idD + "','" + idE + "','" + empleado + "','" + entrada + "','" + salida + "','" + htrabajadas + "','" + hdescontadas + "','" + ausencias + "','" + hextras + "','" + pcomidas + "','" + pcombustible + "','" + pviaticos + "','" + potros + "','" + observaciones + "', '1');";
                //MessageBox.Show(cadena);
                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                consulta.ExecuteNonQuery();
            }

            catch (OdbcException ex)
            {
                MessageBox.Show("Error al añadir detalles (sentencias): " + ex.Message);
            }
        }

        //CALCULO MENSUAL
        public (string, string, string, string, string, string, string, string) obtenerDatosMes(string fechatrabajada, string empleado, string diariose)
        {
            //MessageBox.Show(fechatrabajada + "  " + empleado);

            //CALCULO DE HORAS TRABAJADAS AL MES
            //BUSCAMOS EL ENCABEZADO DE DIARIO SEGÚN LA FECHA
            //string diariose = Buscadiario("diariose", empleado, fechatrabajada,"diariose.pkid","diariose" );
            
            //MessageBox.Show("diariose" + diariose);

            string horastrab = "", horasdesc = "", ausencias = "", horasext = "", comidas = "", combustible = "", viaticos = "", otros = "";

                //BUSCAMOS LAS HORAS TRABAJADAS ESE DÍA
                horastrab = BuscaDatoEmpleado("diariosd", "diariose", "diariosd.htrabajadas", "diariosd.fkdiariose", diariose.ToString(), "diariosd.fkempleado", empleado, "diariose.fechatrabajada", fechatrabajada);
                //MessageBox.Show("horastrab" + horastrab);
                //BUSCAMOS LAS HORAS DESCONTADAS ESE DIA
                horasdesc = BuscaDatoEmpleado("diariosd", "diariose", "diariosd.hdescontadas", "diariosd.fkdiariose", diariose.ToString(), "diariosd.fkempleado", empleado, "diariose.fechatrabajada", fechatrabajada);
                //MessageBox.Show("horasdesc" + horasdesc);
                //BUSCAR AUSENCIAS DEL DIA
                ausencias = BuscaDatoEmpleado("diariosd", "diariose", "diariosd.ausencias", "diariosd.fkdiariose", diariose.ToString(), "diariosd.fkempleado", empleado, "diariose.fechatrabajada", fechatrabajada);
                //MessageBox.Show("ausencias" + ausencias);
                //BUSCAMOS HORAS EXTRAS DEL DIA
                horasext = BuscaDatoEmpleado("diariosd", "diariose", "diariosd.hextras", "diariosd.fkdiariose", diariose.ToString(), "diariosd.fkempleado", empleado, "diariose.fechatrabajada", fechatrabajada);
                //MessageBox.Show("horasext" + horasext);
                //PAGOS DE COMIDA DEL DIA
                comidas = BuscaDatoEmpleado("diariosd", "diariose", "diariosd.pcomidas", "diariosd.fkdiariose", diariose.ToString(), "diariosd.fkempleado", empleado, "diariose.fechatrabajada", fechatrabajada);
                //MessageBox.Show("comidas" + comidas);
                //PAGOS DE COMBUSTIBLE DEL DIA -- COMBUSTILE
                combustible = BuscaDatoEmpleado("diariosd", "diariose", "diariosd.pcombustible", "diariosd.fkdiariose", diariose.ToString(), "diariosd.fkempleado", empleado, "diariose.fechatrabajada", fechatrabajada);
                //MessageBox.Show("combustible" + combustible);
                //PAGO DE VIATICOS DEL DIA
                viaticos = BuscaDatoEmpleado("diariosd", "diariose", "diariosd.pviaticos", "diariosd.fkdiariose", diariose.ToString(), "diariosd.fkempleado", empleado, "diariose.fechatrabajada", fechatrabajada);
                //MessageBox.Show("viaticos" + viaticos);
                //OTROS PAGOS DEL DIA
                otros = BuscaDatoEmpleado("diariosd", "diariose", "diariosd.potros", "diariosd.fkdiariose", diariose.ToString(), "diariosd.fkempleado", empleado, "diariose.fechatrabajada", fechatrabajada);
                //MessageBox.Show("otros" + otros);
                
            //MessageBox.Show("dato1= " + horastrab + " dato2= " + horasdesc + " dato3= " + ausencias + " dato4= " + horasext + " dato5= " + comidas + " dato6=" + combustible + " dato7= " + viaticos + " dato8= " + otros);
            
            return (horastrab, horasdesc, ausencias, horasext, comidas, combustible, viaticos, otros);
        }

        public DataTable CalculosMes(string primerafecha,string ultimafecha)
        {
            DataTable tablainicial = new DataTable();
            int cantidadEmpleados = idEncabezadoActual("empleado", "pkid");
            int cantidadDiarios = idEncabezadoActual("diariose", "pkid");

            tablainicial.Columns.Add("ID");
            tablainicial.Columns.Add("Nombre");
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
                var horast = 0; var horasd = 0; var ausencias = 0; var horase = 0; double pcomidas = 0; double pcomb = 0; double pviat = 0; double otp = 0;

                TimeSpan hotrastotales = new TimeSpan();
                TimeSpan hotrastotalesdescontadas = new TimeSpan();
                TimeSpan hotrastotalesextra = new TimeSpan();

                DataRow row = tablainicial.NewRow();
                for (int d = 1; d <= cantidadDiarios; d++)
                {

                    //CONSEGUIMOS EL MES, LOS DÍAS Y EL AÑO
                    DateTime uf = Convert.ToDateTime(ultimafecha);
                    DateTime pf = Convert.ToDateTime(primerafecha);
                    string dias = uf.ToString("dd");
                    int diasc = Int32.Parse(dias);
                    string mes = uf.ToString("MM");
                    string anio = uf.ToString("yyyy");
                    
                    // for (int j = 1; j <= diasc; j++)
                    
                    for (DateTime j = pf; j <= uf; j = j.AddDays(1))
                    {
                        DateTime diactual = j;
                        string dia = diactual.ToString("dd");
                        string fechaenviada = anio + "-" + mes + "-" + dia;
                        
                        //BUSCAMOS LOS DATOS POR DIA HASTA COMPLETAR EL MES
                        var (dato1, dato2, dato3, dato4, dato5, dato6, dato7, dato8) = obtenerDatosMes(fechaenviada, i.ToString(), d.ToString());
                        try
                        {
                            DateTime datoA = new DateTime();
                            datoA = Convert.ToDateTime(dato1);
                            string horafechacalculo = j.ToString("dd") + "/" + uf.ToString("MM") + "/" + uf.ToString("yyyy") + " " + dato1;
                            string horadescontadacalculo = j.ToString("dd") + "/" + uf.ToString("MM") + "/" + uf.ToString("yyyy") + " " + dato2;
                            string horaextracalculo = j.ToString("dd") + "/" + uf.ToString("MM") + "/" + uf.ToString("yyyy") + " " + dato4;
                            string horacero = j.ToString("dd") + "/" + uf.ToString("MM") + "/" + uf.ToString("yyyy") + " 00:00:00";
                            DateTime datoB = new DateTime();
                            datoB = Convert.ToDateTime(horafechacalculo);
                            DateTime datoC = new DateTime();
                            datoC = Convert.ToDateTime(horacero);
                            DateTime datoD = new DateTime();
                            datoD = Convert.ToDateTime(horadescontadacalculo);
                            DateTime datoE = new DateTime();
                            datoE = Convert.ToDateTime(horaextracalculo);
                            TimeSpan dts = new TimeSpan();
                            TimeSpan htd = new TimeSpan();
                            TimeSpan hte = new TimeSpan();
                            dts = datoB - datoC;
                            hotrastotales = hotrastotales + dts;
                            htd = datoD - datoC;
                            hotrastotalesdescontadas = hotrastotalesdescontadas + htd;
                            hte = datoE - datoC;
                            hotrastotalesextra = hotrastotalesextra + hte;

                            //SUMAMOS RESULTADOS DE TODOS LOS DIAS
                            // datoB =Convert.ToDateTime(dato1);//Convert.ToDateTime(dato1);


                            //datoA.AddHours(datoC);
                            //MessageBox.Show("horas datoA: " + datoB + "  horas pf : " + pf.ToString() + " horas totales= " + hotrastotales);
                            //horast = horast + Int32.Parse(dato1);
                            //horasd = horasd + Int32.Parse(dato2);
                            ausencias = ausencias + Int32.Parse(dato3);
                           // horase = horase + Int32.Parse(dato4);
                            pcomidas = pcomidas + Double.Parse(dato5);
                            pcomb = pcomb + Double.Parse(dato6);
                            pviat = pviat + Double.Parse(dato7);
                            otp = otp + Double.Parse(dato8);
                            
                        }
                        catch (Exception e)
                        {
                            //MessageBox.Show(e.ToString());
                        }
                    }
                    //CONVERTIMOS LAS HORAS
                    TimeSpan ht = new TimeSpan(
                        Convert.ToInt32(Math.Floor(decimal.Parse(horast.ToString()))),
                        Convert.ToInt32((horast - Math.Floor(decimal.Parse(horast.ToString()))) * 60),
                        0);
                    string horastrabajadas = ht.ToString();
                    TimeSpan hd = new TimeSpan(
                        Convert.ToInt32(Math.Floor(decimal.Parse(horasd.ToString()))),
                        Convert.ToInt32((horasd - Math.Floor(decimal.Parse(horasd.ToString()))) * 60),
                        0);
                    string horasdescontadas = ht.ToString();
                    TimeSpan he = new TimeSpan(
                        Convert.ToInt32(Math.Floor(decimal.Parse(horase.ToString()))),
                        Convert.ToInt32((horase - Math.Floor(decimal.Parse(horase.ToString()))) * 60),
                        0);
                    //IMPRIMIMOS EN TABLA
                    string horasextras = he.ToString();
                    

                    
                }
                row["ID"] = i.ToString();
                row["Nombre"] = BuscaDato("empleado", "nombre", "pkid", i.ToString());
                row["Horas Trabajadas"] = hotrastotales.ToString(); //horastrabajadas.ToString();
                row["Horas Descontadas"] = hotrastotalesdescontadas.ToString();//horasdescontadas.ToString();
                row["Ausencias"] = ausencias.ToString();
                row["Horas Extras"] = hotrastotalesextra.ToString(); //horasextras.ToString();
                row["Pago de Comidas"] = pcomidas.ToString();
                row["Pago de Combustible"] = pcomb.ToString();
                row["Pago de Viáticos"] = pviat.ToString();
                row["Otros Pagos"] = otp.ToString();
                tablainicial.Rows.Add(row);
            }

            return tablainicial;
        }
        public void guardarEncabezadoMes(string id, string fechainicio, string fechafin, string mes, string estado)
        {
            try
            {
                string cadena = "INSERT INTO mensualesE VALUES ('" + id + "','" + fechainicio + "','" + fechafin + "','" + mes + "','" + estado + "');";
                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                consulta.ExecuteNonQuery();
            }

            catch (OdbcException ex)
            {
                MessageBox.Show("Error al añadir encabezado (sentencias): " + ex.Message);
            }
            //guardarDetalleDiarios(idD, id, empleado, entrada, salida, htrabajadas, hdescontadas, ausencias, hextras, pcomidas, pcombustible, pviaticos, potros, observaciones);
        }
        public void guardarDetalleMes(int idD, string idE, string empleado, string htrabajadas, string hdescontadas, string ausencias, string hextras, string pcomidas, string pcombustible, string pviaticos, string potros, string observaciones)
        {
            try
            {
                string cadena = "INSERT INTO mensualesD VALUES ('" + idD + "','" + idE + "','" + empleado + "','" + htrabajadas + "','" + hdescontadas + "','" + ausencias + "','" + hextras + "','" + pcomidas + "','" + pcombustible + "','" + pviaticos + "','" + potros + "','" + observaciones + "', '1');";
                //MessageBox.Show(cadena);
                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                consulta.ExecuteNonQuery();
            }

            catch (OdbcException ex)
            {
                MessageBox.Show("Error al añadir detalles (sentencias): " + ex.Message);
            }
        }

        //Foto
        public byte[] obtenerByte(string id)
        {
            int bufferSize = 100; byte[] bytefoto = new byte[bufferSize];
            byte[] binary = null;
            try
            {
                string insertQuery = "SELECT * FROM foto WHERE pkId ='" + id + "';";
                OdbcConnection conect = cn.conexion();
                OdbcCommand command = new OdbcCommand(insertQuery, conect);
                command.ExecuteNonQuery(); OdbcDataReader busquedac;
                busquedac = command.ExecuteReader();
                if (!busquedac.HasRows)
                {
                    throw new Exception("No hay fotografia guardada.");
                }
                if (busquedac.Read())
                {
                    binary = (byte[])busquedac["fotografia"];
                }
                cn.desconexion(conect);
                return binary;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar imagen" + ex);
                return null;
            }
        }

        public void insertaNuevaFoto(string id, byte[] foto)
        {
            try
            {
                string insertQuery = "INSERT INTO foto VALUES ('" + id + "',?);";
                OdbcConnection conect = cn.conexion(); //conect.Open();
                OdbcCommand command = new OdbcCommand(insertQuery, conect);
                OdbcParameter prm = new OdbcParameter("@img", OdbcType.Binary, foto.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, foto);
                command.Parameters.Add(prm);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Foto cargada", "Aviso");
                }
                cn.desconexion(conect);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar imagen" + ex);
            }
        }

        public void insertaFoto(string id, byte[] foto)
        {
            try
            {
                string insertQuery = "UPDATE foto SET fotografia=? where pkId='" + id + "';";
                OdbcConnection conect = cn.conexion(); //conect.Open();
                OdbcCommand command = new OdbcCommand(insertQuery, conect);
                OdbcParameter prm = new OdbcParameter("@img", OdbcType.Binary, foto.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, foto);
                command.Parameters.Add(prm);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Foto cargada", "Aviso");
                }
                cn.desconexion(conect);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar imagen" + ex);
            }
        }

        //FORMA DE CONSULTA
        public void LlenarCombo(ComboBox cbx, string tabla, string campobuscado)
        {
            string dato = "";
            try
            {
                cbx.Items.Clear();
                cbx.Items.Add("Seleccione un elemento...");
                cbx.Items.Add("Todos");
                string insertQuery = "SELECT * FROM " + tabla + " WHERE estado = '1';";
                //MessageBox.Show(insertQuery);
                OdbcConnection conect = cn.conexion();
                OdbcCommand command = new OdbcCommand(insertQuery, conect);
                command.ExecuteNonQuery(); OdbcDataReader busquedac;
                busquedac = command.ExecuteReader();
                if (!busquedac.HasRows)
                {
                    // throw new Exception("No hay dato guardado.");
                }
                while (busquedac.Read())
                {
                    dato = busquedac[campobuscado].ToString();
                    cbx.Items.Add(dato);
                }
                cn.desconexion(conect);
            }
            catch (Exception ex)
            {
            }
        }
        public DataTable ConsultaDiarios(string fechatrabajada, string empleado)
        {
            DataTable tablainicial = new DataTable();

            try
            {
                string consultatodostodos= "select distinct diariosd.pkid as 'ID',diariosd.fkempleado as 'ID Empleado', empleado.nombre as 'Empleado',diariose.fechatrabajada as 'Fecha', diariosd.entrada as 'Hora Entrada', diariosd.salida as 'Hora Salida', diariosd.htrabajadas as 'Horas Trabajadas', diariosd.hdescontadas as 'Horas Descontadas', diariosd.ausencias as 'Ausensias', diariosd.hextras as 'Horas Extras', diariosd.pcomidas as 'Pago de Comidas', diariosd.pcombustible as 'Pago de Combustible', diariosd.pviaticos as 'Pago de Viáticos', diariosd.potros as 'Otros Pagos', diariosd.observaciones as 'Observaciones' from diariose, diariosd, empleado where diariosd.fkempleado = empleado.pkid and diariosd.fkdiariosE = diariose.pkid order by diariosd.fkempleado;";
                string consultatodosfecha = "select distinct diariosd.pkid as 'ID',diariosd.fkempleado as 'ID Empleado', empleado.nombre as 'Empleado',diariose.fechatrabajada as 'Fecha', diariosd.entrada as 'Hora Entrada', diariosd.salida as 'Hora Salida', diariosd.htrabajadas as 'Horas Trabajadas', diariosd.hdescontadas as 'Horas Descontadas', diariosd.ausencias as 'Ausensias', diariosd.hextras as 'Horas Extras', diariosd.pcomidas as 'Pago de Comidas', diariosd.pcombustible as 'Pago de Combustible', diariosd.pviaticos as 'Pago de Viáticos', diariosd.potros as 'Otros Pagos', diariosd.observaciones as 'Observaciones' from diariose, diariosd, empleado where diariosd.fkempleado = empleado.pkid and diariosd.fkdiariosE = diariose.pkid and diariose.fechatrabajada = '" + fechatrabajada + "' order by diariosd.fkempleado;";
                string consultaempleadotodos= "select distinct diariosd.pkid as 'ID',diariosd.fkempleado as 'ID Empleado', empleado.nombre as 'Empleado',diariose.fechatrabajada as 'Fecha', diariosd.entrada as 'Hora Entrada', diariosd.salida as 'Hora Salida', diariosd.htrabajadas as 'Horas Trabajadas', diariosd.hdescontadas as 'Horas Descontadas', diariosd.ausencias as 'Ausensias', diariosd.hextras as 'Horas Extras', diariosd.pcomidas as 'Pago de Comidas', diariosd.pcombustible as 'Pago de Combustible', diariosd.pviaticos as 'Pago de Viáticos', diariosd.potros as 'Otros Pagos', diariosd.observaciones as 'Observaciones' from diariose, diariosd, empleado where diariosd.fkempleado = empleado.pkid and diariosd.fkdiariosE = diariose.pkid and diariosd.fkempleado = '" + empleado + "' order by diariose.fechatrabajada;";
                string consultaempleadofecha= "select distinct diariosd.pkid as 'ID',diariosd.fkempleado as 'ID Empleado', empleado.nombre as 'Empleado',diariose.fechatrabajada as 'Fecha', diariosd.entrada as 'Hora Entrada', diariosd.salida as 'Hora Salida', diariosd.htrabajadas as 'Horas Trabajadas', diariosd.hdescontadas as 'Horas Descontadas', diariosd.ausencias as 'Ausensias', diariosd.hextras as 'Horas Extras', diariosd.pcomidas as 'Pago de Comidas', diariosd.pcombustible as 'Pago de Combustible', diariosd.pviaticos as 'Pago de Viáticos', diariosd.potros as 'Otros Pagos', diariosd.observaciones as 'Observaciones' from diariose, diariosd, empleado where diariosd.fkempleado = empleado.pkid and diariosd.fkdiariosE = diariose.pkid and diariosd.fkempleado = '" + empleado + "' and diariose.fechatrabajada = '" + fechatrabajada + "' order by diariose.fechatrabajada;";
                string insertQuery = "";


                if (fechatrabajada == "*" && empleado == "*")
                {
                    insertQuery = consultatodostodos;
                }
                else if (fechatrabajada != "*" && empleado == "*")
                {
                    insertQuery = consultatodosfecha;
                }
                else if (fechatrabajada == "*" && empleado != "*")
                {
                    insertQuery = consultaempleadotodos;
                }
                else if (fechatrabajada != "*" && empleado != "*")
                {
                    insertQuery = consultaempleadofecha;
                }
                //MessageBox.Show(insertQuery);
                OdbcConnection conect = cn.conexion();
                OdbcDataAdapter adapter = new OdbcDataAdapter(insertQuery, conect);
                adapter.Fill(tablainicial);
                cn.desconexion(conect);
            }
            catch (Exception ex)
            {
            }
            
            return tablainicial;
        }
        public DataTable ConsultaMensuales(string fechainicio, string fechafin, string empleado)
        {
            DataTable tablainicial = new DataTable();

            try
            {
                string consultatodostodos = "select distinct mensualesd.pkid as 'ID',mensualesd.fkempleado as 'ID Empleado', empleado.nombre as 'Empleado',mensualese.fechainicio as 'Fecha Inical', mensualese.fechafin as 'Fecha Final', mensualesd.htrabajadas as 'Horas Trabajadas', mensualesd.hdescontadas as 'Horas Descontadas', mensualesd.ausencias as 'Ausensias', mensualesd.hextras as 'Horas Extras', mensualesd.pcomidas as 'Pago de Comidas', mensualesd.pcombustible as 'Pago de Combustible', mensualesd.pviaticos as 'Pago de Viáticos', mensualesd.potros as 'Otros Pagos', mensualesd.observaciones as 'Observaciones' from mensualese, mensualesd, empleado where mensualesd.fkempleado = empleado.pkid and mensualesd.fkmensualesE = mensualese.pkid order by mensualesd.fkempleado;";
                string consultatodosfecha = "select distinct mensualesd.pkid as 'ID',mensualesd.fkempleado as 'ID Empleado', empleado.nombre as 'Empleado',mensualese.fechainicio as 'Fecha Inical', mensualese.fechafin as 'Fecha Final', mensualesd.htrabajadas as 'Horas Trabajadas', mensualesd.hdescontadas as 'Horas Descontadas', mensualesd.ausencias as 'Ausensias', mensualesd.hextras as 'Horas Extras', mensualesd.pcomidas as 'Pago de Comidas', mensualesd.pcombustible as 'Pago de Combustible', mensualesd.pviaticos as 'Pago de Viáticos', mensualesd.potros as 'Otros Pagos', mensualesd.observaciones as 'Observaciones' from mensualese, mensualesd, empleado where mensualesd.fkempleado = empleado.pkid and mensualesd.fkmensualesE = mensualese.pkid and mensualese.fechainicio like '" + fechainicio + "-%' and mensualese.fechafin like '" + fechafin + "-%' order by mensualesd.fkempleado;";
                string consultaempleadotodos = "select distinct mensualesd.pkid as 'ID',mensualesd.fkempleado as 'ID Empleado', empleado.nombre as 'Empleado',mensualese.fechainicio as 'Fecha Inical', mensualese.fechafin as 'Fecha Final', mensualesd.htrabajadas as 'Horas Trabajadas', mensualesd.hdescontadas as 'Horas Descontadas', mensualesd.ausencias as 'Ausensias', mensualesd.hextras as 'Horas Extras', mensualesd.pcomidas as 'Pago de Comidas', mensualesd.pcombustible as 'Pago de Combustible', mensualesd.pviaticos as 'Pago de Viáticos', mensualesd.potros as 'Otros Pagos', mensualesd.observaciones as 'Observaciones' from mensualese, mensualesd, empleado where mensualesd.fkempleado = empleado.pkid and mensualesd.fkmensualesE = mensualese.pkid and mensualesd.fkempleado = '" + empleado + "' order by mensualesd.fkempleado;";
                string consultaempleadofecha = "select distinct mensualesd.pkid as 'ID',mensualesd.fkempleado as 'ID Empleado', empleado.nombre as 'Empleado',mensualese.fechainicio as 'Fecha Inical', mensualese.fechafin as 'Fecha Final', mensualesd.htrabajadas as 'Horas Trabajadas', mensualesd.hdescontadas as 'Horas Descontadas', mensualesd.ausencias as 'Ausensias', mensualesd.hextras as 'Horas Extras', mensualesd.pcomidas as 'Pago de Comidas', mensualesd.pcombustible as 'Pago de Combustible', mensualesd.pviaticos as 'Pago de Viáticos', mensualesd.potros as 'Otros Pagos', mensualesd.observaciones as 'Observaciones' from mensualese, mensualesd, empleado where mensualesd.fkempleado = empleado.pkid and mensualesd.fkmensualesE = mensualese.pkid and mensualese.fechainicio like '" + fechainicio + "-%' and mensualese.fechafin like '" + fechafin + "-%' and mensualesd.fkempleado = '"+ empleado + "' order by mensualesd.fkempleado;";
                string insertQuery = "";


                if (fechainicio == "*" && fechafin == "*" && empleado == "*")
                {
                    insertQuery = consultatodostodos;
                }
                else if (fechainicio != "*" && fechafin != "*" && empleado == "*")
                {
                    insertQuery = consultatodosfecha;
                }
                else if (fechainicio == "*" && fechafin == "*" && empleado != "*")
                {
                    insertQuery = consultaempleadotodos;
                }
                else if (fechainicio != "*" && fechafin != "*" && empleado != "*")
                {
                    insertQuery = consultaempleadofecha;
                }
                //MessageBox.Show(insertQuery);
                OdbcConnection conect = cn.conexion();
                OdbcDataAdapter adapter = new OdbcDataAdapter(insertQuery, conect);
                adapter.Fill(tablainicial);
                cn.desconexion(conect);
            }
            catch (Exception ex)
            {
            }

            return tablainicial;
        }
        public DataTable ConsultaIntervalosD(string fechainicio, string fechafin, string empleado)
        {
            DataTable tablainicial = new DataTable();

            try
            {
                //string consultatodostodos = "select distinct mensualesd.pkid as 'ID',mensualesd.fkempleado as 'ID Empleado', empleado.nombre as 'Empleado',mensualese.fechainicio as 'Fecha Inical', mensualese.fechafin as 'Fecha Final', mensualesd.htrabajadas as 'Horas Trabajadas', mensualesd.hdescontadas as 'Horas Descontadas', mensualesd.ausencias as 'Ausensias', mensualesd.hextras as 'Horas Extras', mensualesd.pcomidas as 'Pago de Comidas', mensualesd.pcombustible as 'Pago de Combustible', mensualesd.pviaticos as 'Pago de Viáticos', mensualesd.potros as 'Otros Pagos', mensualesd.observaciones as 'Observaciones' from mensualese, mensualesd, empleado where mensualesd.fkempleado = empleado.pkid and mensualesd.fkmensualesE = mensualese.pkid order by mensualesd.fkempleado;";
                string consultatodosfecha = "select distinct diariosd.pkid as 'ID',diariosd.fkempleado as 'ID Empleado', empleado.nombre as 'Empleado',diariose.fechatrabajada as 'Fecha', diariosd.entrada as 'Hora Entrada', diariosd.salida as 'Hora Salida', diariosd.htrabajadas as 'Horas Trabajadas', diariosd.hdescontadas as 'Horas Descontadas', diariosd.ausencias as 'Ausensias', diariosd.hextras as 'Horas Extras', diariosd.pcomidas as 'Pago de Comidas', diariosd.pcombustible as 'Pago de Combustible', diariosd.pviaticos as 'Pago de Viáticos', diariosd.potros as 'Otros Pagos', diariosd.observaciones as 'Observaciones' from diariose, diariosd, empleado where diariosd.fkempleado = empleado.pkid and diariosd.fkdiariosE = diariose.pkid and diariose.fechatrabajada between '" + fechainicio + "' and '" + fechafin + "' order by diariosd.fkempleado;";
                //string consultaempleadotodos = "select distinct mensualesd.pkid as 'ID',mensualesd.fkempleado as 'ID Empleado', empleado.nombre as 'Empleado',mensualese.fechainicio as 'Fecha Inical', mensualese.fechafin as 'Fecha Final', mensualesd.htrabajadas as 'Horas Trabajadas', mensualesd.hdescontadas as 'Horas Descontadas', mensualesd.ausencias as 'Ausensias', mensualesd.hextras as 'Horas Extras', mensualesd.pcomidas as 'Pago de Comidas', mensualesd.pcombustible as 'Pago de Combustible', mensualesd.pviaticos as 'Pago de Viáticos', mensualesd.potros as 'Otros Pagos', mensualesd.observaciones as 'Observaciones' from mensualese, mensualesd, empleado where mensualesd.fkempleado = empleado.pkid and mensualesd.fkmensualesE = mensualese.pkid and mensualesd.fkempleado = '" + empleado + "' order by mensualesd.fkempleado;";
                string consultaempleadofecha = "select distinct diariosd.pkid as 'ID',diariosd.fkempleado as 'ID Empleado', empleado.nombre as 'Empleado',diariose.fechatrabajada as 'Fecha', diariosd.entrada as 'Hora Entrada', diariosd.salida as 'Hora Salida', diariosd.htrabajadas as 'Horas Trabajadas', diariosd.hdescontadas as 'Horas Descontadas', diariosd.ausencias as 'Ausensias', diariosd.hextras as 'Horas Extras', diariosd.pcomidas as 'Pago de Comidas', diariosd.pcombustible as 'Pago de Combustible', diariosd.pviaticos as 'Pago de Viáticos', diariosd.potros as 'Otros Pagos', diariosd.observaciones as 'Observaciones' from diariose, diariosd, empleado where diariosd.fkempleado = empleado.pkid and diariosd.fkdiariosE = diariose.pkid and diariose.fechatrabajada between '" + fechainicio + "' and '" + fechafin + "' and diariosd.fkempleado = '" + empleado + "' order by diariosd.fkempleado;";
                string insertQuery = "";


                if (fechainicio != "*" && fechafin != "*" && empleado == "*")
                {
                    insertQuery = consultatodosfecha;
                }
                else if (fechainicio != "*" && fechafin != "*" && empleado != "*")
                {
                    insertQuery = consultaempleadofecha;
                }
                //MessageBox.Show(insertQuery);
                OdbcConnection conect = cn.conexion();
                OdbcDataAdapter adapter = new OdbcDataAdapter(insertQuery, conect);
                adapter.Fill(tablainicial);
                cn.desconexion(conect);
            }
            catch (Exception ex)
            {
            }

            return tablainicial;
        }
        public DataTable ConsultaIntervalosM(string fechainicio, string fechafin, string empleado, string mesinicio, string mesfin)
        {
            DataTable tablainicial = new DataTable();

            try
            {
                //string consultatodostodos = "select distinct mensualesd.pkid as 'ID',mensualesd.fkempleado as 'ID Empleado', empleado.nombre as 'Empleado',mensualese.fechainicio as 'Fecha Inical', mensualese.fechafin as 'Fecha Final', mensualesd.htrabajadas as 'Horas Trabajadas', mensualesd.hdescontadas as 'Horas Descontadas', mensualesd.ausencias as 'Ausensias', mensualesd.hextras as 'Horas Extras', mensualesd.pcomidas as 'Pago de Comidas', mensualesd.pcombustible as 'Pago de Combustible', mensualesd.pviaticos as 'Pago de Viáticos', mensualesd.potros as 'Otros Pagos', mensualesd.observaciones as 'Observaciones' from mensualese, mensualesd, empleado where mensualesd.fkempleado = empleado.pkid and mensualesd.fkmensualesE = mensualese.pkid order by mensualesd.fkempleado;";
                string consultatodosfecha = "select distinct mensualesd.pkid as 'ID',mensualesd.fkempleado as 'ID Empleado', empleado.nombre as 'Empleado',mensualese.fechainicio as 'Fecha Inical', mensualese.fechafin as 'Fecha Final', mensualesd.htrabajadas as 'Horas Trabajadas', mensualesd.hdescontadas as 'Horas Descontadas', mensualesd.ausencias as 'Ausensias', mensualesd.hextras as 'Horas Extras', mensualesd.pcomidas as 'Pago de Comidas', mensualesd.pcombustible as 'Pago de Combustible', mensualesd.pviaticos as 'Pago de Viáticos', mensualesd.potros as 'Otros Pagos', mensualesd.observaciones as 'Observaciones' from mensualese, mensualesd, empleado where mensualesd.fkempleado = empleado.pkid and mensualesd.fkmensualesE = mensualese.pkid and (mensualese.fechainicio like '" + fechainicio + "-%' and mensualese.fechafin like '" + fechainicio + "-%' or mensualese.fechainicio like '" + fechafin + "-%' and mensualese.fechafin like '" + fechafin + "-%') and mensualese.mes between '" + mesinicio + "' and '" + mesfin + "' order by mensualesd.fkempleado;";
                //string consultaempleadotodos = "select distinct mensualesd.pkid as 'ID',mensualesd.fkempleado as 'ID Empleado', empleado.nombre as 'Empleado',mensualese.fechainicio as 'Fecha Inical', mensualese.fechafin as 'Fecha Final', mensualesd.htrabajadas as 'Horas Trabajadas', mensualesd.hdescontadas as 'Horas Descontadas', mensualesd.ausencias as 'Ausensias', mensualesd.hextras as 'Horas Extras', mensualesd.pcomidas as 'Pago de Comidas', mensualesd.pcombustible as 'Pago de Combustible', mensualesd.pviaticos as 'Pago de Viáticos', mensualesd.potros as 'Otros Pagos', mensualesd.observaciones as 'Observaciones' from mensualese, mensualesd, empleado where mensualesd.fkempleado = empleado.pkid and mensualesd.fkmensualesE = mensualese.pkid and mensualesd.fkempleado = '" + empleado + "' order by mensualesd.fkempleado;";
                string consultaempleadofecha = "select distinct mensualesd.pkid as 'ID',mensualesd.fkempleado as 'ID Empleado', empleado.nombre as 'Empleado',mensualese.fechainicio as 'Fecha Inical', mensualese.fechafin as 'Fecha Final', mensualesd.htrabajadas as 'Horas Trabajadas', mensualesd.hdescontadas as 'Horas Descontadas', mensualesd.ausencias as 'Ausensias', mensualesd.hextras as 'Horas Extras', mensualesd.pcomidas as 'Pago de Comidas', mensualesd.pcombustible as 'Pago de Combustible', mensualesd.pviaticos as 'Pago de Viáticos', mensualesd.potros as 'Otros Pagos', mensualesd.observaciones as 'Observaciones' from mensualese, mensualesd, empleado where mensualesd.fkempleado = empleado.pkid and mensualesd.fkmensualesE = mensualese.pkid and (mensualese.fechainicio like '" + fechainicio + "-%' and mensualese.fechafin like '" + fechainicio + "-%' or mensualese.fechainicio like '" + fechafin + "-%' and mensualese.fechafin like '" + fechafin + "-%') and mensualese.mes between '" + mesinicio + "' and '" + mesfin + "' and mensualesd.fkempleado = '" + empleado + "' order by mensualesd.fkempleado;";
                string insertQuery = "";


                if (fechainicio != "*" && fechafin != "*" && empleado == "*")
                {
                    insertQuery = consultatodosfecha;
                }
                else if (fechainicio != "*" && fechafin != "*" && empleado != "*")
                {
                    insertQuery = consultaempleadofecha;
                }
                MessageBox.Show(insertQuery);
                OdbcConnection conect = cn.conexion();
                OdbcDataAdapter adapter = new OdbcDataAdapter(insertQuery, conect);
                adapter.Fill(tablainicial);
                cn.desconexion(conect);
            }
            catch (Exception ex)
            {
            }

            return tablainicial;
        }
    }
}