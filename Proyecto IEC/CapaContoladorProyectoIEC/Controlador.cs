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
        public void guardarTablaBdDetalleControlador(string tiempo, string tipoResgistro, string nombregestion)
        {
            sn.guardarTablaBdDetalleSentencias(tiempo, tipoResgistro, nombregestion);
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
    }
}
