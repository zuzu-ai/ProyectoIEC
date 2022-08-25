using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using CapaContoladorProyectoIEC;
using System.Activities.Expressions;
using System.Data.Odbc;

namespace Proyecto_IEC
{
    public partial class frmImportarArchivo : Form
    {
        private Controlador cn = new Controlador();
        public frmImportarArchivo()
        {
            InitializeComponent();
        }
        string NombreHoja="";
        DialogResult respuesta;
        DataTable table = new DataTable();
        private void btnImportar_Click(object sender, EventArgs e)
        {
            NombreHoja = txtNombreHoja.Text.Trim();
            MessageBox.Show(NombreHoja);
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel | *.xls;*xlsx;",
                Title = "Seleccionar archivo"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string NombreArcivo = openFileDialog.FileName.ToString();
                try 
                {
                    dgvVistaPrevia.DataSource = cn.EncontrarArchivoExcelControlador(NombreArcivo,NombreHoja);

                }catch (Exception ex) { MessageBox.Show("Error al ceragar archivo." + ex); }
            }
        }

        private void btnCnacelar_Click(object sender, EventArgs e)
        {
            respuesta = MessageBox.Show("Realmente desea borrar la tabla", "Imporat Tabla",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(respuesta==DialogResult.Yes)
            {
                DataTable dt = new DataTable();
                dt.Clear();
                dgvVistaPrevia.DataSource = dt;
            }
            else { }                          
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            respuesta = MessageBox.Show("Realmente desea importar la tabla", "Imporat Tabla",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                GuardarTablaBdDetalle();
            }
            else { }
        }
        
        void GuardarTablaBdDetalle()
        {
            string numero = "", nombre = "", tiempo = "", estado = "",dispositivos="", tipoResgistro;
            try
            {
                //Se guarda el encabezado generado.
                table= (DataTable)dgvVistaPrevia.DataSource;
                
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    numero = table.Rows[i]["Número"].ToString();
                    nombre = table.Rows[i]["Nombre"].ToString();
                    tiempo = table.Rows[i]["Tiempo"].ToString();
                    estado = table.Rows[i]["Estado"].ToString();
                    dispositivos = table.Rows[i]["Dispositivos"].ToString();
                    tipoResgistro= table.Rows[i]["Tipo de Registro"].ToString();
                   // cn.guardarTablaBdEncabezadoControlador( string fkempleado, string fkdispositivo, string estado)
                    cn.guardarTablaBdDetalleControlador(tiempo, estado, dispositivos, tipoResgistro);
                    
                    
                }
                MessageBox.Show("Nomina Guardada correctamente.");
            }
            catch (Exception ex) { MessageBox.Show("No fue posible guardar el encabezado de la nómina " + ex); }
        }
    }
}
