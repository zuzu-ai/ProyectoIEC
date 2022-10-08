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
	public partial class frmPagoEmpleado : Form
	{
		CapaContoladorProyectoIEC.Global g = new CapaContoladorProyectoIEC.Global();
		CapaContoladorProyectoIEC.Controlador controlador = new CapaContoladorProyectoIEC.Controlador();
		public frmPagoEmpleado()
		{
			InitializeComponent();
			controlador.bloqueareporte(g.obtienenombretusuario, btnImprimir);
			navegadorMantenimientos1.bloquearBtn(g.obtienenombretusuario);

			TextBox[] alias = navegadorMantenimientos1.ClasificaTextboxsegunParent(this);
			navegadorMantenimientos1.ObtenerCamposdeTabla(alias, "pagoempleado", "IEC");
			navegadorMantenimientos1.MetodoSalirVista(this);
			navegadorMantenimientos1.LlenarCombobox(cbxEmpleado, "empleado", "pkid", "nombre", "estado");
			navegadorMantenimientos1.LlenarCombobox(cbxTipoPago, "tipopago", "pkid", "nombre", "estado");

			//inicio de elementos para dar de baja
			navegadorMantenimientos1.campoEstado = "estado";
			//fin de elementos para dar de baja

			/* Inicio ID Aplicacion usada para reportes y ayudas */
			navegadorMantenimientos1.idAplicacion = "2016";
			navegadorMantenimientos1.idmodulo = "2";
			/* Inicio ID Aplicacion usada para reportes y ayudas */

			//inicio de elementos para ejecutar la ayuda
			navegadorMantenimientos1.tablaAyuda = "Aplicacion";
			navegadorMantenimientos1.campoAyuda = "pkId";
			//fin de elementos para ejecutar la ayuda


			// Inicio datos para ejecurar reportes
			//navegadorMantenimientos1.LlamarRutaReporte("ruta", "idAplicacion", "Reporte");
			// Final datos para ejecutar reportes

			navegadorMantenimientos1.ObtenerNombreDGV(this.dgvVistaPrevia);
			navegadorMantenimientos1.LlenarTabla();
			navegadorMantenimientos1.ObtenerReferenciaFormActual(this);
			//String cadena = txtprueba.Text;
			//navegador1.pruebaMensaje(cadena);
		}

		private void txtEstado_TextChanged(object sender, EventArgs e)
		{
			navegadorMantenimientos1.ActivaRadiobtn(rbnEstatusamodulo, rbnEstatusimodulo, txtEstado);
		}

		private void rbnEstatusamodulo_CheckedChanged(object sender, EventArgs e)
		{
			navegadorMantenimientos1.CambioEstadoTextbox(txtEstado, rbnEstatusamodulo, "1");
		}

		private void rbnEstatusimodulo_CheckedChanged(object sender, EventArgs e)
		{
			navegadorMantenimientos1.CambioEstadoTextbox(txtEstado, rbnEstatusimodulo, "0");
		}

		private void dgvVistaPrevia_SelectionChanged(object sender, EventArgs e)
		{
			navegadorMantenimientos1.SelecciondeFilaDGV(dgvVistaPrevia);
		}

		private void txtFecha_TextChanged(object sender, EventArgs e)
		{
			try
			{
				navegadorMantenimientos1.SeleccionarFechaDTP(dtpFecha, txtFecha);
				navegadorMantenimientos1.CambiarFormatoFecha(dtpFecha, txtFecha);
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
		}

		private void dtpFecha_ValueChanged(object sender, EventArgs e)
		{
			try
			{

				navegadorMantenimientos1.CambiarFormatoFecha(dtpFecha, txtFecha);
				navegadorMantenimientos1.SeleccionarFechaDTP(dtpFecha, txtFecha);
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
		}

		private void txtIdEmpleado_TextChanged(object sender, EventArgs e)
		{
			navegadorMantenimientos1.SeleccionarElementosenCombo(cbxEmpleado, txtIdEmpleado);
		}

		private void txtTipoPago_TextChanged(object sender, EventArgs e)
		{
			navegadorMantenimientos1.SeleccionarElementosenCombo(cbxTipoPago, txtTipoPago);
		}

		private void cbxEmpleado_SelectedIndexChanged(object sender, EventArgs e)
		{
			navegadorMantenimientos1.EnviarDatoComboaTextbox(cbxEmpleado, txtIdEmpleado);
		}

		private void cbxTipoPago_SelectedIndexChanged(object sender, EventArgs e)
		{
			navegadorMantenimientos1.EnviarDatoComboaTextbox(cbxTipoPago, txtTipoPago);
		}

		private void btnImprimir_Click(object sender, EventArgs e)
		{
			Reporte6 reporte = new Reporte6();
			reporte.Show();
		}
	}
}
