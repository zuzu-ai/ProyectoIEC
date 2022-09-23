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

			LlenarCombo(cbxEmpleado, "empleado", "nombre");
			cbxEmpleado.SelectedIndex = 0;
		}
		Controlador controlador = new Controlador();
		DataTable limpiadata = new DataTable();

		public void LlenarCombo(ComboBox cbx, string tabla, string campobuscado)
		{
			try
			{
				controlador.LlenarCombo(cbx, tabla, campobuscado);
			}
			catch
			{

			}
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

		private void cbxEmpleado_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbxEmpleado.Text == "Seleccione un elemento...")
			{
				txtEmpleado.Text = "";
				mtxtDia.Text = "";
				chbxTodos.Checked = false;
				dgvVistaPrevia.Rows.Clear();
			}
			else if (cbxEmpleado.Text == "Todos")
			{
				txtEmpleado.Text = "*";
			}
			else
			{
				txtEmpleado.Text = controlador.BuscaDato("empleado", "pkid", "nombre", cbxEmpleado.Text.Trim());
			}
		}

		private void chbxTodos_CheckedChanged(object sender, EventArgs e)
		{
			if (chbxTodos.Checked == true && txtEmpleado.Text == "")
			{
				MessageBox.Show("Debe seleccionar una opción para empleado");
				chbxTodos.Checked = false;
			}
			else if (chbxTodos.Checked == true && txtEmpleado.Text == "*")
			{
				mtxtDia.Clear();
				mtxtDia.Enabled = false;
				//LLAMADA AL METODO PARA BUSCAR TODOS LOS EMPLEADOS EN TODOS LOS DÍAS
			}
			else if (chbxTodos.Checked == true && txtEmpleado.Text != "" && txtEmpleado.Text != "*")
			{
				mtxtDia.Clear();
				mtxtDia.Enabled = false;
				//LLAMADA AL METODO PARA BUSCAR UN SOLO EMPLEADO EN TODOS LOS DIAS
			}
			else if (chbxTodos.Checked == false)
			{
				mtxtDia.Enabled = true;
				dgvVistaPrevia.DataSource = limpiadata;
			}
		}

		private void btnConsultar_Click(object sender, EventArgs e)
		{
			DataTable tablaconsulta = new DataTable();
			if (txtEmpleado.Text == "*" && chbxTodos.Checked == true)
			{
				tablaconsulta = controlador.ConsultaDiarios("*", txtEmpleado.Text);
			}
			dgvVistaPrevia.DataSource = tablaconsulta;
		}
	}
}
