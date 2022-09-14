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
	public partial class frmEmpleado : Form
	{
		public frmEmpleado()
		{
			InitializeComponent();

			TextBox[] alias = navegadorMantenimientos1.ClasificaTextboxsegunParent(this);
			navegadorMantenimientos1.ObtenerCamposdeTabla(alias, "empleado", "IEC");
			navegadorMantenimientos1.MetodoSalirVista(this);
			navegadorMantenimientos1.LlenarCombobox(cbxPuesto, "puesto", "pkid", "nombre", "estado");
			navegadorMantenimientos1.LlenarCombobox(cbxJornada, "jornada", "pkid", "nombre", "estado");

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

        }

        private void rbnEstatusimodulo_CheckedChanged(object sender, EventArgs e)
		{

        }

        private void dgvVistaPrevia_SelectionChanged(object sender, EventArgs e)
		{

			navegadorMantenimientos1.SelecciondeFilaDGV(dgvVistaPrevia);

		}

        private void txtContratacion_TextChanged(object sender, EventArgs e)
        {
			try
			{
				navegadorMantenimientos1.SeleccionarFechaDTP(dtpContratacion, txtContratacion);
				navegadorMantenimientos1.CambiarFormatoFecha(dtpContratacion, txtContratacion);
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
		}

        private void dtpContratacion_ValueChanged(object sender, EventArgs e)
        {
			try
			{
				navegadorMantenimientos1.CambiarFormatoFecha(dtpContratacion, txtContratacion);
				navegadorMantenimientos1.SeleccionarFechaDTP(dtpContratacion, txtContratacion);
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
		}

        private void txtDespido_TextChanged(object sender, EventArgs e)
        {
			try
			{
				navegadorMantenimientos1.SeleccionarFechaDTP(dtpDespido, txtDespido);
				navegadorMantenimientos1.CambiarFormatoFecha(dtpDespido, txtDespido);
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
		}

        private void dtpDespido_ValueChanged(object sender, EventArgs e)
        {
			try
			{
				navegadorMantenimientos1.CambiarFormatoFecha(dtpDespido, txtDespido);
				navegadorMantenimientos1.SeleccionarFechaDTP(dtpDespido, txtDespido);
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
		}

        private void txtIdPuesto_TextChanged(object sender, EventArgs e)
        {
			navegadorMantenimientos1.SeleccionarElementosenCombo(cbxPuesto, txtIdPuesto);
		}

        private void txtJornada_TextChanged(object sender, EventArgs e)
        {
			navegadorMantenimientos1.SeleccionarElementosenCombo(cbxJornada, txtJornada);
		}
    }
}
