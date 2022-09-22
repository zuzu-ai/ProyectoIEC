using System;
using System.Collections;
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
	public partial class frmConsulta : Form
	{
		public frmConsulta()
		{
			InitializeComponent();
			cbxAnio.Enabled = false;
			cbxMes.Enabled = false;
			cbxDia.Enabled = false;
			cbxEmpleado.Enabled = false;

			//cbxAnio.SelectedIndex = 0;
			//cbxMes.SelectedIndex = 0;
			//cbxDia.SelectedIndex = 0;
			//cbxEmpleado.SelectedIndex = 0;
		}
		Controlador controlador = new Controlador();
		ArrayList referencia0 = new ArrayList();
		ArrayList referencia1 = new ArrayList();
		ArrayList referencia2 = new ArrayList();
		public void SeleccionaDatoFecha(ComboBox cbx, string value, string display, string partefecha, string tabla)
		{
				try
				{
					referencia1.Add(value);
					referencia2.Add(display);
					referencia0.Add(cbx);
					controlador.SeleccionaDatoFecha(cbx, value, display,partefecha,tabla);
				}
				catch
				{



				}
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

		private void cbxMes_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbxMes.Text == "")
			{
				txtMes.Text = "";
			}
			else if (cbxMes.Text == "enero")
			{
				txtMes.Text = "01";
			}
			else if (cbxMes.Text == "febrero")
			{
				txtMes.Text = "02";
			}
			else if (cbxMes.Text == "marzo")
			{
				txtMes.Text = "03";
			}
			else if (cbxMes.Text == "abril")
			{
				txtMes.Text = "04";
			}
			else if (cbxMes.Text == "mayo")
			{
				txtMes.Text = "05";
			}
			else if (cbxMes.Text == "junio")
			{
				txtMes.Text = "06";
			}
			else if (cbxMes.Text == "julio")
			{
				txtMes.Text = "07";
			}
			else if (cbxMes.Text == "agosto")
			{
				txtMes.Text = "08";
			}
			else if (cbxMes.Text == "septiembre")
			{
				txtMes.Text = "09";
			}
			else if (cbxMes.Text == "octubre")
			{
				txtMes.Text = "10";
			}
			else if (cbxMes.Text == "noviembre")
			{
				txtMes.Text = "11";
			}
			else if (cbxMes.Text == "diciembre")
			{
				txtMes.Text = "12";
			}
		}

		private void chbxAnio_CheckedChanged(object sender, EventArgs e)
		{
			if (chbxAnio.Checked == true && rbnDiarios.Checked == true)
			{
				cbxAnio.Enabled = true;
				SeleccionaDatoFecha(cbxAnio, "fechatrabajada", "date_format(fechatrabajada, '%Y')", "Y","diariose");
			}
			else
			{
				cbxAnio.Enabled = false;
			}
		}

		private void chbxMes_CheckedChanged(object sender, EventArgs e)
		{
			if (chbxMes.Checked == true && rbnDiarios.Checked == true)
			{
				cbxMes.Enabled = true;
				SeleccionaDatoFecha(cbxMes, "fechatrabajada", "date_format(fechatrabajada, '%M')", "m","diariose");
			}
			else
			{
				cbxMes.Enabled = false;
			}
		}

		private void chbxDia_CheckedChanged(object sender, EventArgs e)
		{
			if (chbxDia.Checked == true && rbnDiarios.Checked == true)
			{
				cbxDia.Enabled = true;
				SeleccionaDatoFecha(cbxDia, "fechatrabajada", "date_format(fechatrabajada, '%d')","d", "diariose");
			}
			else
			{
				cbxDia.Enabled = false;
			}
		}
	}
}
