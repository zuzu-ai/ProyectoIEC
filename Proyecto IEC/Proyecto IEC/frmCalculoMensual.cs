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
	public partial class frmCalculoMensual : Form
	{
		private Controlador cn = new Controlador();
		DataTable table = new DataTable();
		DataTable limpiadata = new DataTable();
		public frmCalculoMensual()
		{
			InitializeComponent();
			txtfechainicio.Text = dtpInicio.Value.ToString("yyyy-MM-dd");
			txtfechafin.Text = dtpFin.Value.ToString("yyyy-MM-dd");
			int id = cn.idSiguienteDeNuevoIngreso("mensualesE", "pkid");
			txtID.Text = id.ToString();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Calculo();
		}

		public void Calculo()
		{
			DataTable tablafinal = cn.CalculosMes(txtfechainicio.Text,txtfechafin.Text);
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
		}

		private void dtpInicio_ValueChanged(object sender, EventArgs e)
		{
			txtfechainicio.Text = dtpInicio.Value.ToString("yyyy-MM-dd");
		}

		private void dtpFin_ValueChanged(object sender, EventArgs e)
		{
			txtfechafin.Text = dtpFin.Value.ToString("yyyy-MM-dd");
		}

		private void btnExportar_Click(object sender, EventArgs e)
		{
			table = (DataTable)dgvVistaPrevia.DataSource;
			int contador = dgvVistaPrevia.Rows.Count;
			try
			{
				cn.guardarEncabezadoMes(txtID.Text, txtfechainicio.Text, txtfechafin.Text, txtMesTrabajado.Text, "1");

				try
				{
					for (int i = 0; i < contador; i++)
					{
						int idD = cn.idSiguienteDeNuevoIngreso("mensualesD", "pkid");
						string empleado = cn.BuscaDato("empleado", "pkid", "nombre", table.Rows[i]["Nombre"].ToString());
						string htrabajadas = table.Rows[i]["Horas Trabajadas"].ToString();
						string hdescontadas = table.Rows[i]["Horas Descontadas"].ToString();
						string ausencias = table.Rows[i]["Ausencias"].ToString();
						string hextras = table.Rows[i]["Horas Extras"].ToString();
						string pcomidas = table.Rows[i]["Pago de Comidas"].ToString();
						string pcombustible = table.Rows[i]["Pago de Combustible"].ToString();
						string pviaticos = table.Rows[i]["Pago de Viáticos"].ToString();
						string potros = table.Rows[i]["Otros Pagos"].ToString();
						string observaciones = table.Rows[i]["Observaciones"].ToString();
						cn.guardarDetalleMes(idD, txtID.Text,empleado, htrabajadas, hdescontadas, ausencias, hextras, pcomidas, pcombustible, pviaticos, potros, observaciones);

					}
				}
				catch (Exception ex) { MessageBox.Show("No se puieron añadir los detalles de diario."); }
				MessageBox.Show("Se añadieron los diarios correctamente.");
			}
			catch (Exception ex) { MessageBox.Show("No se puieron añadir los diarios."); }
			dgvVistaPrevia.DataSource = limpiadata;
			int idrefresh = cn.idSiguienteDeNuevoIngreso("mensualesE", "pkid");
			txtID.Text = idrefresh.ToString();
			dtpInicio.Value = DateTime.Now;
			dtpFin.Value = DateTime.Now;
		}

		private void txtfechainicio_TextChanged(object sender, EventArgs e)
		{
			txtMesTrabajado.Text = dtpInicio.Value.ToString("MM");
		}

		private void btnImprimir_Click(object sender, EventArgs e)
		{
			DGVPrinterHelper.DGVPrinter printer = new DGVPrinterHelper.DGVPrinter();
			printer.Title = "Reporte de Calculo Mensual";

			printer.SubTitle = string.Format("Fecha de Informe: {0}", DateTime.Now.Date.ToString("dd/MM/yyyy")) + " ID Reporte: "
				+ txtID.Text.ToString() + "\n" + "Periodo del " + txtfechainicio.Text + " al " + txtfechafin.Text;
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
