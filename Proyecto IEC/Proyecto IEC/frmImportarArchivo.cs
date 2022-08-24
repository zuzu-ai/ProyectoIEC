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


namespace Proyecto_IEC
{
    public partial class frmImportarArchivo : Form
    {
        public frmImportarArchivo()
        {
            InitializeComponent();
        }
        string NombreHoja="";
        DataView ImportarDatos(string nombrearchivo, string Nombre)
        {
            DataSet ds = new DataSet();
            try 
            { 
            string conexion = string.Format("Provider = Microsoft.ACE.OLEDB.12.0; Data Sourse = {0}; Extended Properties = 'Excel 12.0;'", nombrearchivo);

            OleDbConnection conector = new OleDbConnection(conexion);
            conector.Open();

            OleDbCommand consulta = new OleDbCommand("select * from ["+Nombre+"]", conector);

            OleDbDataAdapter adaptador = new OleDbDataAdapter
            {
                SelectCommand = consulta
            };                       
            adaptador.Fill(ds);

            conector.Close();
        }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }

            return ds.Tables[0].DefaultView;
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            NombreHoja = txtNombreHoja.Text.Trim()+"$";
            MessageBox.Show(NombreHoja);
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel | *.xls;*xlsx;",
                Title = "Seleccionar archivo"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try 
                { 

                dgvVistaPrevia.DataSource = ImportarDatos(openFileDialog.FileName.ToString(), NombreHoja);

                }catch (Exception ex) { MessageBox.Show("Error: " + ex); }

            }


        }
    }
}
