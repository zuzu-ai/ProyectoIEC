using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using CapaModeloProyectoIEC;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaContoladorProyectoIEC
{
    public class Controlador
    {
        private Sentencias sn = new Sentencias();
        public DataTable EncontrarArchivoExcelControlador(string NombreArchivo, string NombreTabla)
        {
            DataTable table = new DataTable();
            try
            {
                table = sn.EncontrarArchivoExcel(NombreArchivo, NombreTabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar archivo de Excel (Controlador).");
            }
            return table;
        }
        public void guardarTablaBdDetalleControlador(string tiempo, string tipoResgistro, string nombregestion, string idempleadoencabe)
        {
            sn.guardarTablaBdDetalleSentencias(tiempo, tipoResgistro, nombregestion, idempleadoencabe);
        }
        public void guardarTablaBdEncabezadoControlador(string ids, string fkempleado, string fkdispositivo, string estado, string tiempo, string tipoReg, string nombregestion)
        {
            sn.guardarTablaBdEncabezadoSentencias(ids, fkempleado, fkdispositivo, estado, tiempo, tipoReg, nombregestion);
        }
        public void comprobarIdEncabezado(string tabla, string campoB, string nombre, string nombredisp, string tiempo, string tipoReg, string nombregestion)
        {
            sn.comprobarIdEncabezado(tabla, campoB, nombre, nombredisp, tiempo, tipoReg, nombregestion);
        }
        public int idEncabezadoActual(string tabla, string campoB)
        {
            int id = sn.idEncabezadoActual(tabla, campoB);
            return id;
        }
        public DataTable obtenerDatos(string fechatrabajada)
        {
            DataTable tabla = new DataTable();
            tabla = sn.obtenerDatos(fechatrabajada);
            return tabla;
        }
        public int idSiguienteDeNuevoIngreso(string tabla, string campoB)
        {
            int id = sn.idSiguienteDeNuevoIngreso(tabla, campoB);
            return id;
        }
        public void guardarEncabezadoDiarios(string id, string fecha, string estado)
        {
            sn.guardarEncabezadoDiarios(id, fecha, estado);
        }
        public void guardarDetalleDiarios(int idD, string idE, string empleado, string entrada, string salida, string htrabajadas, string hdescontadas, string ausencias, string hextras, string pcomidas, string pcombustible, string pviaticos, string potros, string observaciones)
        {
            sn.guardarDetalleDiarios(idD, idE, empleado, entrada, salida, htrabajadas, hdescontadas, ausencias, hextras, pcomidas, pcombustible, pviaticos, potros, observaciones);
        }
        public DataTable CalculosMes(string primerafecha, string ultimafecha)
        {
            DataTable tabla = new DataTable();
            tabla = sn.CalculosMes(primerafecha, ultimafecha);

            return tabla;
        }

        public void guardarEncabezadoMes(string id, string fechainicio, string fechafin, string mes, string estado)
        {
            sn.guardarEncabezadoMes(id, fechainicio, fechafin, mes, estado);
        }
        public void guardarDetalleMes(int idD, string idE, string empleado, string htrabajadas, string hdescontadas, string ausencias, string hextras, string pcomidas, string pcombustible, string pviaticos, string potros, string observaciones)
        {
            sn.guardarDetalleMes(idD, idE, empleado, htrabajadas, hdescontadas, ausencias, hextras, pcomidas, pcombustible, pviaticos, potros, observaciones);
        }

        //Foto
        public byte[] obtenerByte(string id)
        {
            byte[] imagen = sn.obtenerByte(id);
            return imagen;
        }
        public void insertaNuevaFoto(string id, byte[] foto)
        {
            sn.insertaNuevaFoto(id, foto);
        }
        public void insertaFoto(string id, byte[] foto)
        {
            sn.insertaFoto(id, foto);
        }

        //FORMA CONSULTAS
        public void LlenarCombo(ComboBox cbx, string tabla, string campobuscado)
        {
            try
            {
                sn.LlenarCombo(cbx, tabla, campobuscado);
            }
            catch
            {
                MessageBox.Show("Error en la capa controlador, revisar la funcion metodoLlenarCombo");
            }
        }
        public string BuscaDato(string tabla, string campo, string campobuscado, string datoreferencia)
        {
            string dato = "";
            dato = sn.BuscaDato(tabla, campo, campobuscado, datoreferencia);
            return dato;
        }
        public DataTable ConsultaDiarios(string fechatrabajada, string empleado)
        {
            DataTable tablainicial = new DataTable();
            tablainicial = sn.ConsultaDiarios(fechatrabajada, empleado);

            return tablainicial;
        }
        public DataTable ConsultaMensuales(string fechainicio, string fechafin, string empleado)
        {
            DataTable tablainicial = new DataTable();
            tablainicial = sn.ConsultaMensuales(fechainicio, fechafin, empleado);

            return tablainicial;
        }
        public DataTable ConsultaIntervalosD(string fechainicio, string fechafin, string empleado)
        {
            DataTable tablainicial = new DataTable();
            tablainicial = sn.ConsultaIntervalosD(fechainicio, fechafin, empleado);

            return tablainicial;
        }
        public DataTable ConsultaIntervalosM(string fechainicio, string fechafin, string empleado, string mesinicio, string mesfin)
        {
            DataTable tablainicial = new DataTable();
            tablainicial = sn.ConsultaIntervalosM(fechainicio, fechafin, empleado, mesinicio, mesfin);

            return tablainicial;
        }
    }
}
