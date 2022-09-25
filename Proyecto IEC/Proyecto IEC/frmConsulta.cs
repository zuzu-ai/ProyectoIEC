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
				label3.Text = "Día";
				mtxtMes.Clear();
				mtxtMes.Visible = false;
				mtxtFinD.Clear();
				mtxtDia.Visible = true;
				mtxtFinM.Visible = false;
				mtxtFinM.Clear();
				//mtxtDia.Mask = "____-__-__";
				if (chbxIntervalos.Checked == true)
				{
					label3.Visible = false;
					label5.Visible = true;
					label4.Visible = true;
					mtxtFinD.Visible = true;
					mtxtFinM.Visible = false;
				}
				else
				{
					label3.Visible = true;
					label5.Visible = false;
					label4.Visible = false;
					mtxtFinD.Visible = false;
					
				}
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
				mtxtFinD.Clear();
				mtxtFinD.Visible = false;
				mtxtFinM.Clear();
				mtxtMes.Visible = true;
				//mtxtDia.Mask = "____-__";
				if (chbxIntervalos.Checked == true)
				{
					label3.Visible = false;
					label5.Visible = true;
					label4.Visible = true;
					mtxtFinM.Visible = true;
				}
				else
				{
					label3.Visible = true;
					label5.Visible = false;
					label4.Visible = false;
					mtxtFinM.Visible = false;
				}
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
				mtxtFinD.Clear();
				mtxtFinD.Enabled = false;
				mtxtFinM.Clear();
				mtxtFinM.Enabled = false;
				//LLAMADA AL METODO PARA BUSCAR TODOS LOS EMPLEADOS EN TODOS LOS DÍAS
			}
			else if (chbxTodos.Checked == true && txtEmpleado.Text != "" && txtEmpleado.Text != "*")
			{
				mtxtDia.Clear();
				mtxtDia.Enabled = false;
				mtxtMes.Clear();
				mtxtMes.Enabled = false;
				mtxtFinD.Clear();
				mtxtFinD.Enabled = false;
				mtxtFinM.Clear();
				mtxtFinM.Enabled = false;
				//LLAMADA AL METODO PARA BUSCAR UN SOLO EMPLEADO EN TODOS LOS DIAS
			}
			else if (chbxTodos.Checked == false)
			{
				mtxtDia.Enabled = true;
				mtxtMes.Enabled = true;
				mtxtFinD.Enabled = true;
				mtxtFinM.Enabled = true;

				dgvVistaPrevia.DataSource = limpiadata;
			}
		}

		private void btnConsultar_Click(object sender, EventArgs e)
		{
			DataTable tablaconsulta = new DataTable();
			if (chbxIntervalos.Checked == true)
			{
				if (txtbusqueda.Text == "1")
				{
					if (txtEmpleado.Text == "" && mtxtDia.Text == "    -  -" && mtxtFinD.Text == "    -  -")
					{
						MessageBox.Show("Debe rellenar los cambios para realizar una búsqueda.");
					}
					else if (txtEmpleado.Text == "" && mtxtDia.Text != "    -  -" && mtxtFinD.Text != "    -  -")
					{
						MessageBox.Show("Debe elegir un empleado.");
					}
					else if (txtEmpleado.Text != "" && mtxtDia.Text == "    -  -" && mtxtFinD.Text == "    -  -")
					{
						MessageBox.Show("Debe ingresar un intervalo de fechas.");
					}
					else if (txtEmpleado.Text != "" && mtxtDia.Text == "    -  -" && mtxtFinD.Text != "    -  -")
					{
						MessageBox.Show("Debe ingresar una fecha inicial.");
					}
					else if (txtEmpleado.Text != "" && mtxtDia.Text != "    -  -" && mtxtFinD.Text == "    -  -")
					{
						MessageBox.Show("Debe ingresar una fecha final.");
					}
					else if (txtEmpleado.Text == "*" && mtxtDia.Text != "    -  -" && mtxtFinD.Text != "    -  -")
					{
						tablaconsulta = controlador.ConsultaIntervalosD(mtxtDia.Text, mtxtFinD.Text, txtEmpleado.Text);
					}
					else if (txtEmpleado.Text != "*" && mtxtDia.Text != "    -  -" && mtxtFinD.Text != "    -  -")
					{
						tablaconsulta = controlador.ConsultaIntervalosD(mtxtDia.Text, mtxtFinD.Text, txtEmpleado.Text);
					}
				}
				else if (txtbusqueda.Text == "2")
				{
					if (txtEmpleado.Text == "" && mtxtMes.Text == "    -  -" && mtxtFinM.Text == "    -  -")
					{
						MessageBox.Show("Debe rellenar los cambios para realizar una búsqueda.");
					}
					else if (txtEmpleado.Text == "" && mtxtMes.Text != "    -  -" && mtxtFinM.Text != "    -  -")
					{
						MessageBox.Show("Debe elegir un empleado.");
					}
					else if (txtEmpleado.Text != "" && mtxtMes.Text == "    -  -" && mtxtFinM.Text == "    -  -")
					{
						MessageBox.Show("Debe ingresar un intervalo de meses.");
					}
					else if (txtEmpleado.Text != "" && mtxtMes.Text == "    -  -" && mtxtFinM.Text != "    -  -")
					{
						MessageBox.Show("Debe ingresar un mes inicial");
					}
					else if (txtEmpleado.Text != "" && mtxtMes.Text != "    -  -" && mtxtFinM.Text == "    -  -")
					{
						MessageBox.Show("Debe ingresar mes final.");
					}
					else if (txtEmpleado.Text == "*" && mtxtMes.Text != "    -  -" && mtxtFinM.Text != "    -  -")
					{
						tablaconsulta = controlador.ConsultaIntervalosM(txtAnio.Text, txtAnio2.Text, txtEmpleado.Text, txtMesInicio.Text, txtMesFin.Text);
					}
					else if (txtEmpleado.Text != "*" && mtxtMes.Text != "    -  -" && mtxtFinM.Text != "    -  -")
					{
						tablaconsulta = controlador.ConsultaIntervalosM(txtAnio.Text, txtAnio2.Text, txtEmpleado.Text, txtMesInicio.Text, txtMesFin.Text);
					}
				}
			}
			else if (chbxIntervalos.Checked == false)
			{
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
						tablaconsulta = controlador.ConsultaMensuales("*", "*", txtEmpleado.Text);
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
			if (mtxtMes.Text == "    -")
			{
				dgvVistaPrevia.DataSource = limpiadata;
			}
		}

		private void chbxIntervalos_CheckedChanged(object sender, EventArgs e)
		{
			if (chbxIntervalos.Checked == true)
			{
				if (txtbusqueda.Text == "1")
				{
					label3.Visible = false;
					label4.Visible = true;
					label5.Visible = true;
					label5.Visible = true;
					mtxtFinD.Visible = true;
				}
				else if (txtbusqueda.Text == "2")
				{
					label3.Visible = false;
					label4.Visible = true;
					label5.Visible = true;
					mtxtFinM.Visible = true;
				}
				chbxTodos.Checked = false;
				chbxTodos.Visible = false;
			}
			else if (chbxIntervalos.Checked == false)
			{
				label3.Visible = true;
				label4.Visible = false;
				label5.Visible = false;
				mtxtFinD.Visible = false;
				mtxtFinM.Visible = false;
				chbxTodos.Checked = true;
				chbxTodos.Visible = true;
			}
		}

		private void mtxtFinM_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{
			if (mtxtFinM.Text == "    -")
			{
				dgvVistaPrevia.DataSource = limpiadata;
			}
		}

		private void mtxtFinD_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{
			if (mtxtFinD.Text == "    -  -")
			{
				dgvVistaPrevia.DataSource = limpiadata;
			}
		}

		private void mtxtFinM_TextChanged(object sender, EventArgs e)
		{
			try
			{
				if (chbxIntervalos.Checked == true)
				{
					DateTime fecha = new DateTime();
					fecha = Convert.ToDateTime(mtxtFinM.Text);
					txtMesFin.Text = fecha.ToString("MM");
					txtAnio2.Text = fecha.ToString("yyyy");
				}
			}
			catch (Exception exe) { }
		}

		private void mtxtMes_TextChanged(object sender, EventArgs e)
		{
			if (chbxIntervalos.Checked == true)
			{
				try
				{
					DateTime fecha = new DateTime();
					fecha = Convert.ToDateTime(mtxtMes.Text);
					txtMesInicio.Text = fecha.ToString("MM");
					txtAnio.Text = fecha.ToString("yyyy");
				}
				catch (Exception exe) { }
			}
		}
	}
}
