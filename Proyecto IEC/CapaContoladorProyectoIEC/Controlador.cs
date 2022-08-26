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
            MessageBox.Show("Se trasladó el detalle a controlador");
        }
        public void guardarTablaBdEncabezadoControlador(string ids, string fkempleado, string fkdispositivo, string estado)
        {
            sn.guardarTablaBdEncabezadoSentencias(ids, fkempleado, fkdispositivo, estado);
        }
        public void comprobarIdEncabezado(string tabla, string campoB, string nombre, string nombredisp)
        {
            sn.comprobarIdEncabezado(tabla, campoB, nombre, nombredisp);
            MessageBox.Show("Se comprobó el encabezado en controlador");
        }
    }
}
