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
            table = (DataTable)dgvVistaPrevia.DataSource;
            respuesta = MessageBox.Show("Realmente desea importar la tabla", "Importar Tabla",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    cn.comprobarIdEncabezado("datosE", "pkid", table.Rows[i]["Nombre"].ToString(), table.Rows[i]["Dispositivos"].ToString());
                    MessageBox.Show("Se comprobó el encabezado");
                    GuardarTablaBdDetalle();
                    MessageBox.Show("Se ingreso el detalle");
                }
            }
            else { }
        }
        
        void GuardarTablaBdDetalle()
        {
            string tiempo, tipoResgistro, nombregestion;
            try
            {
                //Se guarda el encabezado generado.
                table= (DataTable)dgvVistaPrevia.DataSource;
                MessageBox.Show(table.Rows.Count.ToString());
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    tiempo = table.Rows[i]["Tiempo"].ToString();
                    tipoResgistro= table.Rows[i]["Tipo de Registro"].ToString();
                    nombregestion = table.Rows[i]["Estado"].ToString();
                    MessageBox.Show("Se obtuvieron los datos");
                    MessageBox.Show(tiempo + " " + tipoResgistro + " " + nombregestion);
                    //cn.guardarTablaBdEncabezadoControlador( string fkempleado, string fkdispositivo, string estado)
                    cn.guardarTablaBdDetalleControlador(tiempo, tipoResgistro, nombregestion);
                    MessageBox.Show("Se guardó un detalle");

                }
                MessageBox.Show("Nomina Guardada correctamente.");
            }
            catch (Exception ex) { MessageBox.Show("No fue posible guardar el encabezado de la nómina " + ex); }
        }
    }
}
