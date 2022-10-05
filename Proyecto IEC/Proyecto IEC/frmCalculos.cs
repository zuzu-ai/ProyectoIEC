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
		DataTable table = new DataTable();
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
			table = (DataTable)dgvVistaPrevia.DataSource;
			int contador = dgvVistaPrevia.Rows.Count;
			try
			{
				cn.guardarEncabezadoDiarios(txtID.Text, txtFechatrabajada.Text, "1");

				try
				{
					for (int i = 0; i < contador; i++)
					{
						int idD = cn.idSiguienteDeNuevoIngreso("diariosD", "pkid");
						string idE = table.Rows[i]["ID"].ToString();
						string entrada = table.Rows[i]["Entrada"].ToString();
						string salida = table.Rows[i]["Salida"].ToString();
						string htrabajadas = table.Rows[i]["Horas Trabajadas"].ToString();
						string hdescontadas = table.Rows[i]["Horas Descontadas"].ToString();
						string ausencias = table.Rows[i]["Ausencias"].ToString();
						string hextras = table.Rows[i]["Horas Extras"].ToString();
						string pcomidas = table.Rows[i]["Pago de Comidas"].ToString();
						string pcombustible = table.Rows[i]["Pago de Combustible"].ToString();
						string pviaticos = table.Rows[i]["Pago de Viáticos"].ToString();
						string potros = table.Rows[i]["Otros Pagos"].ToString();
						string observaciones = table.Rows[i]["Observaciones"].ToString();
						cn.guardarDetalleDiarios(idD, txtID.Text,idE,entrada,salida,htrabajadas,hdescontadas,ausencias,hextras,pcomidas,pcombustible,pviaticos,potros,observaciones);

					}
				}
				catch (Exception ex) { MessageBox.Show("No se puieron añadir los detalles de diario."); }
				MessageBox.Show("Se añadieron los diarios correctamente.");
			}
			catch (Exception ex) { MessageBox.Show("No se puieron añadir los diarios."); }
			this.Close();
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

		private void btnImprimir_Click(object sender, EventArgs e)
		{
			DGVPrinterHelper.DGVPrinter printer = new DGVPrinterHelper.DGVPrinter();
			printer.Title = "Reporte de Calculo Diarios";

			printer.SubTitle = string.Format("Fecha: {0}", DateTime.Now.Date.ToString("dd/MM/yyyy")) + "\n" + " ID Reporte: "
				+ txtID.Text.ToString();
			printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
			printer.PageNumbers = true;
			printer.PageNumberInHeader = false;
			printer.PorportionalColumns = true;
			printer.HeaderCellAlignment = StringAlignment.Near;
			printer.Footer = "IEC";
			printer.FooterSpacing = 15;
			printer.PrintDataGridView(dgvVistaPrevia);
		}
	}
}
