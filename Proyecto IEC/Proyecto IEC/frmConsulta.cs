﻿using System;
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
				label3.Text = "Día";
				mtxtMes.Clear();
				mtxtMes.Visible = false;
				mtxtDia.Visible = true;
				//mtxtDia.Mask = "____-__-__";
			}
		}

		private void rbnMensual_CheckedChanged(object sender, EventArgs e)
		{
			if (rbnMensual.Checked == true)
			{
				txtbusqueda.Text = "2";
				label3.Text = "Mes";
				mtxtDia.Clear();
				mtxtDia.Visible = false;
				mtxtMes.Visible = true;
				//mtxtDia.Mask = "____-__";
			}
		}

		private void cbxEmpleado_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbxEmpleado.Text == "Seleccione un elemento...")
			{
				txtEmpleado.Text = "";
				dgvVistaPrevia.DataSource = limpiadata;
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
				mtxtMes.Clear();
				mtxtMes.Enabled = false;
				//LLAMADA AL METODO PARA BUSCAR TODOS LOS EMPLEADOS EN TODOS LOS DÍAS
			}
			else if (chbxTodos.Checked == true && txtEmpleado.Text != "" && txtEmpleado.Text != "*")
			{
				mtxtDia.Clear();
				mtxtDia.Enabled = false;
				mtxtMes.Clear();
				mtxtMes.Enabled = false;
				//LLAMADA AL METODO PARA BUSCAR UN SOLO EMPLEADO EN TODOS LOS DIAS
			}
			else if (chbxTodos.Checked == false)
			{
				mtxtDia.Enabled = true;
				mtxtMes.Enabled = true;
				dgvVistaPrevia.DataSource = limpiadata;
			}
		}

		private void btnConsultar_Click(object sender, EventArgs e)
		{
			DataTable tablaconsulta = new DataTable();
			if (txtbusqueda.Text == "1")
			{
				if (txtEmpleado.Text == "" && chbxTodos.Checked == false && mtxtDia.Text == "    -  -")
				{
					MessageBox.Show("Debe rellenar los cambios para realizar una búsqueda.");
				}
				else if (txtEmpleado.Text == "" && chbxTodos.Checked == false && mtxtDia.Text != "    -  -")
				{
					MessageBox.Show("Debe elegir un empleado.");
				}
				else if (txtEmpleado.Text != "" && chbxTodos.Checked == false && mtxtDia.Text == "    -  -")
				{
					MessageBox.Show("Debe ingresar una fecha.");
				}
				else if (txtEmpleado.Text == "*" && chbxTodos.Checked == true)
				{
					tablaconsulta = controlador.ConsultaDiarios("*", txtEmpleado.Text);
				}
				else if (txtEmpleado.Text == "*" && chbxTodos.Checked == false && mtxtDia.Text != "    -  -")
				{
					tablaconsulta = controlador.ConsultaDiarios(mtxtDia.Text, txtEmpleado.Text);
				}
				else if (txtEmpleado.Text != "*" && chbxTodos.Checked == true)
				{
					tablaconsulta = controlador.ConsultaDiarios("*", txtEmpleado.Text);
				}
				else if (txtEmpleado.Text != "*" && mtxtDia.Text != "    -  -")
				{
					tablaconsulta = controlador.ConsultaDiarios(mtxtDia.Text, txtEmpleado.Text);
				}
			}
			else if (txtbusqueda.Text == "2")
			{
				if (txtEmpleado.Text == "" && chbxTodos.Checked == false && mtxtMes.Text == "    -")
				{
					MessageBox.Show("Debe rellenar los cambios para realizar una búsqueda.");
				}
				else if (txtEmpleado.Text == "" && chbxTodos.Checked == false && mtxtMes.Text != "    -")
				{
					MessageBox.Show("Debe elegir un empleado.");
				}
				else if (txtEmpleado.Text != "" && chbxTodos.Checked == false && mtxtMes.Text == "    -")
				{
					MessageBox.Show("Debe ingresar un mes y año.");
				}
				else if (txtEmpleado.Text == "*" && chbxTodos.Checked == true)
				{
					tablaconsulta = controlador.ConsultaMensuales("*","*", txtEmpleado.Text);
				}
				else if (txtEmpleado.Text == "*" && chbxTodos.Checked == false && mtxtMes.Text != "    -")
				{
					tablaconsulta = controlador.ConsultaMensuales(mtxtMes.Text, mtxtMes.Text, txtEmpleado.Text);
				}
				else if (txtEmpleado.Text != "*" && chbxTodos.Checked == true)
				{
					tablaconsulta = controlador.ConsultaMensuales("*", "*", txtEmpleado.Text);
				}
				else if (txtEmpleado.Text != "*" && mtxtMes.Text != "    -")
				{
					tablaconsulta = controlador.ConsultaMensuales(mtxtMes.Text, mtxtMes.Text, txtEmpleado.Text);
				}
			}

			dgvVistaPrevia.DataSource = tablaconsulta;
		}

		private void mtxtDia_TextChanged(object sender, EventArgs e)
		{
			if (mtxtDia.Text == "    -  -")
			{
				dgvVistaPrevia.DataSource = limpiadata;
			}
		}

		private void mtxtMes_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{
			if (mtxtMes.Text == "    -  -")
			{
				dgvVistaPrevia.DataSource = limpiadata;
			}
		}
	}
}
