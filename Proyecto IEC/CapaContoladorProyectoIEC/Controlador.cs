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
        public void guardarTablaBdDetalleControlador(string tiempo,string estado,string dispositivos,string tipoResgistro)
        {
            sn.guardarTablaBdDetalleSentencias( tiempo, estado, dispositivos, tipoResgistro);
        }
        public void guardarTablaBdEncabezadoControlador(string fkempleado, string fkdispositivo, string estado)
        {
            sn.guardarTablaBdEncabezadoSentencias(fkempleado, fkdispositivo, estado);
        }
    }
}
