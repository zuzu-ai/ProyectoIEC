using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_IEC
{
	public partial class frmConsulta : Form
	{
		public frmConsulta()
		{
			InitializeComponent();
		}

		private void radioButton6_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void rbnDiarios_CheckedChanged(object sender, EventArgs e)
		{
			if (rbnDiarios.Checked == true)
			{
				txtbusqueda.Text = "1";
			}
		}

		private void rbnMensual_CheckedChanged(object sender, EventArgs e)
		{
			if (rbnMensual.Checked == true)
			{
				txtbusqueda.Text = "2";
			}
		}
	}
}
