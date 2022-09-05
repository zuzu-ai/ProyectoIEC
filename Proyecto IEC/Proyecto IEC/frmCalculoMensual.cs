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
		public frmCalculoMensual()
		{
			InitializeComponent();
			txtfechainicio.Text = dtpInicio.Value.ToString("yyyy-MM-dd");
			txtfechafin.Text = dtpFin.Value.ToString("yyyy-MM-dd");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Calculo();
		}

		public void Calculo()
		{
			DataTable tablafinal = cn.CalculosMes(txtfechafin.Text);
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
	}
}
