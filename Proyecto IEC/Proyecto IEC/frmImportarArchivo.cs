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
        private Global datos = new Global();
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
                string NombreArchivo = openFileDialog.FileName.ToString();
                string NombreHoja = "Sheet";
                txtNombreHoja.Text = NombreHoja;
                txtRuta.Text = NombreArchivo;
                
                try 
                {
                    dgvVistaPrevia.DataSource = cn.EncontrarArchivoExcelControlador(NombreArchivo,NombreHoja);

                }catch (Exception ex) { MessageBox.Show("Error al cargar archivo." + ex); }
            }
        }

        private void btnCnacelar_Click(object sender, EventArgs e)
        {
            respuesta = MessageBox.Show("Realmente desea borrar la tabla", "Borrar Tabla",
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
                    try
                    {
                        string tiempo, tipoRegistro, nombregestion;
                        tiempo = table.Rows[i]["Tiempo"].ToString();
                        tipoRegistro = table.Rows[i]["Tipo de Registro"].ToString();
                        nombregestion = table.Rows[i]["Estado"].ToString();
                        cn.comprobarIdEncabezado("datosE", "pkid", table.Rows[i]["Nombre"].ToString(), table.Rows[i]["Dispositivos"].ToString(), tiempo, tipoRegistro, nombregestion);
                    }
                    catch (Exception exep) { }
                }
                MessageBox.Show("Importación Exitosa");
                string fechaglobal = table.Rows[0]["Tiempo"].ToString();
                string fechatrabajada = fechaglobal.Remove(fechaglobal.Length - 14, 14);
                DateTime dtt = Convert.ToDateTime(fechatrabajada);
                string fechat = dtt.ToString("yyyy-MM-dd");
                
                datos.obtenertabla = table;
                datos.fechatrabajada = fechat;
               
                //llamar a la forma de calculo
                try
                {
                    frmCalculos form = new frmCalculos();
                    form.Show();

                    DataTable dt = new DataTable();
                    dt.Clear();
                    dgvVistaPrevia.DataSource = dt;
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex); }
            }
            else { }
        }

        public void refrescar()
        {
            try
            {
                dgvVistaPrevia.DataSource = cn.EncontrarArchivoExcelControlador(txtRuta.Text, txtNombreHoja.Text);

            }
            catch (Exception ex) { MessageBox.Show("Error al cargar archivo." + ex); }
        }

		private void button1_Click(object sender, EventArgs e)
		{
            refrescar();
        }
	}
}
