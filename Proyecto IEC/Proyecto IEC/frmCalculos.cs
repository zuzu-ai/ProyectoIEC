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
			//dgvVistaPrevia.DataSource = tabla;

			//llamada a funcion;
			CalcularHoras();
		}

		private void btnExportar_Click(object sender, EventArgs e)
		{

		}

		public void CalcularHoras()
		{
			//cn.CalcularHoras();
		}
	}
}
