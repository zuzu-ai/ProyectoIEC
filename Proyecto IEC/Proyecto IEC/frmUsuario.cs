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
    public partial class frmUsuario : Form
    {
		CapaContoladorProyectoIEC.Global g = new CapaContoladorProyectoIEC.Global();
		CapaContoladorProyectoIEC.Controlador controlador = new CapaContoladorProyectoIEC.Controlador();
		public frmUsuario()
        {
            InitializeComponent();
			controlador.bloqueareporte(g.obtienenombretusuario, btnImprimir);
			navegadorMantenimientos1.bloquearBtn(g.obtienenombretusuario);

			TextBox[] alias = navegadorMantenimientos1.ClasificaTextboxsegunParent(this);
			navegadorMantenimientos1.ObtenerCamposdeTabla(alias, "usuario", "IEC");
			navegadorMantenimientos1.MetodoSalirVista(this);
			navegadorMantenimientos1.LlenarCombobox(cbxPregunta, "pregunta", "pkid", "pregunta", "estado");
			navegadorMantenimientos1.LlenarCombobox(cbxTipoUsuario, "tipousuario", "pkid", "nombre", "estado");
			navegadorMantenimientos1.LlenarCombobox(cbxEmpleado, "empleado", "pkid", "nombre", "estado");

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
		Encriptar encript = new Encriptar();
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

        private void cbxTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
			navegadorMantenimientos1.EnviarDatoComboaTextbox(cbxTipoUsuario, txtIDTipoUsuario);
		}

        private void txtIDTipoUsuario_TextChanged(object sender, EventArgs e)
        {
			navegadorMantenimientos1.SeleccionarElementosenCombo(cbxTipoUsuario, txtIDTipoUsuario);
		}

        private void cbxEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
			navegadorMantenimientos1.EnviarDatoComboaTextbox(cbxEmpleado, txtIDEmpleado);
		}

        private void txtIDEmpleado_TextChanged(object sender, EventArgs e)
        {
			navegadorMantenimientos1.SeleccionarElementosenCombo(cbxEmpleado, txtIDEmpleado);
		}

        private void cbxPregunta_SelectedIndexChanged(object sender, EventArgs e)
        {
			navegadorMantenimientos1.EnviarDatoComboaTextbox(cbxPregunta, txtIDPregunta);
		}

        private void txtIDPregunta_TextChanged(object sender, EventArgs e)
        {
			navegadorMantenimientos1.SeleccionarElementosenCombo(cbxPregunta, txtIDPregunta);
		}

        private void btnPassword_Click(object sender, EventArgs e)
        {
			mtxtContraseña.UseSystemPasswordChar = false;
			mtxtConfirmarContraseña.UseSystemPasswordChar = false;
			btnPassword.Visible = false;
			btnPasswordn.Visible = true;
		}

        private void btnPasswordn_Click(object sender, EventArgs e)
        {
			mtxtContraseña.UseSystemPasswordChar = true;
			mtxtConfirmarContraseña.UseSystemPasswordChar = true;
			btnPassword.Visible = true;
			btnPasswordn.Visible = false;
		}

        private void txtContraseña_EnabledChanged(object sender, EventArgs e)
        {
			if (txtContraseña.Enabled == true)
            {
				mtxtConfirmarContraseña.Enabled = true;
				mtxtContraseña.Enabled = true;
            }
			else if (txtContraseña.Enabled == false)
            {
				mtxtConfirmarContraseña.Enabled = false;
				mtxtContraseña.Enabled = false;
			}
        }

        private void mtxtConfirmarContraseña_Leave(object sender, EventArgs e)
        {
			if (mtxtContraseña.Text == "" && mtxtConfirmarContraseña.Text=="")
			{
				mtxtConfirmarContraseña.Text = "";
				mtxtContraseña.Text = "";
				mtxtContraseña.Focus();
				
			}
			if (mtxtConfirmarContraseña.Text != mtxtContraseña.Text)
			{
				DialogResult respuesta;
				respuesta = MessageBox.Show("Ingrese la misma contraseña en ambas cajas de texto.", "Error en contraseña",
			   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				if (respuesta == DialogResult.OK)
				{
					mtxtConfirmarContraseña.Text = "";
					mtxtContraseña.Text = "";
					mtxtContraseña.Focus();					
				}
			}
			else
			{
				var key = "b14ca5898a4e4133bbce2ea2315a1916";
				Encriptar encriptar = new Encriptar();
				string password = encriptar.metodoEncryptString(key, mtxtContraseña.Text);
				txtContraseña.Text = password;
			}
		
			
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
			
			string password = encript.metodoValidar(txtContraseña.Text);
			mtxtConfirmarContraseña.Text = password;
			mtxtContraseña.Text = password;
        }

        private void mtxtContraseña_Leave(object sender, EventArgs e)
        {

        }

		private void btnImprimir_Click(object sender, EventArgs e)
		{
			Reporte10 reporte = new Reporte10();
			reporte.Show();
		}
	}
}
