using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaContoladorProyectoIEC;

namespace Proyecto_IEC
{
	public partial class frmCalculos : Form
	{
		private Controlador cn = new Controlador();
		DataTable tabla = new DataTable();
		DataTable tablacalculo = new DataTable();
		private Global datos = new Global();

		public frmCalculos()
		{
			InitializeComponent();
			tabla = datos.obtenertabla;
			txtFechatrabajada.Text = datos.fechatrabajada;
			int id = cn.idSiguienteDeNuevoIngreso("diariosE","pkid");
			txtID.Text = id.ToString();
			//llamada a funcion;
			CalcularHoras();
		}

		private void btnExportar_Click(object sender, EventArgs e)
		{
			try
			{
				cn.guardarEncabezadoDiarios(txtID.Text, txtFechatrabajada.Text, "1");
				MessageBox.Show("Diarios añadidos para la fecha: " + txtFechatrabajada.Text);
			}
			catch (Exception ex) { MessageBox.Show("No se puieron añadir los diarios."); }
		}

		public void CalcularHoras()
		{
			DataTable tablafinal = cn.obtenerDatos(datos.fechatrabajada);
			dgvVistaPrevia.DataSource = tablafinal;
			dgvVistaPrevia.Columns[0].ReadOnly = true;
			dgvVistaPrevia.Columns[1].ReadOnly = true;
			dgvVistaPrevia.Columns[2].ReadOnly = true;
			dgvVistaPrevia.Columns[3].ReadOnly = true;
			dgvVistaPrevia.Columns[4].ReadOnly = true;
			dgvVistaPrevia.Columns[5].ReadOnly = true;
			dgvVistaPrevia.Columns[6].ReadOnly = true;
			dgvVistaPrevia.Columns[7].ReadOnly = true;
			dgvVistaPrevia.Columns[8].ReadOnly = true;
			dgvVistaPrevia.Columns[9].ReadOnly = true;
			dgvVistaPrevia.Columns[10].ReadOnly = true;
			dgvVistaPrevia.Columns[11].ReadOnly = true;
		}
	}
}
