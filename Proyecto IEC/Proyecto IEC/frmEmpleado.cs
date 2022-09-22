using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaContoladorProyectoIEC;
using System.Threading;

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
		Controlador controlador = new Controlador();
		
		private void txtEstado_TextChanged(object sender, EventArgs e)
		{
			navegadorMantenimientos1.ActivaRadiobtn(rbnEstatusamodulo, rbnEstatusimodulo, txtEstado);
		}

		private void rbnEstatusamodulo_CheckedChanged(object sender, EventArgs e)
		{
			navegadorMantenimientos1.CambioEstadoTextbox(txtEstado,rbnEstatusamodulo,"1");
        }

        private void rbnEstatusimodulo_CheckedChanged(object sender, EventArgs e)
		{
			navegadorMantenimientos1.CambioEstadoTextbox(txtEstado, rbnEstatusimodulo, "0");
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
			if (chbxNoContratacion.Checked == false)
			{
				try
				{
					navegadorMantenimientos1.CambiarFormatoFecha(dtpContratacion, txtContratacion);
					navegadorMantenimientos1.SeleccionarFechaDTP(dtpContratacion, txtContratacion);
				}
				catch (Exception ex) { MessageBox.Show("Error: " + ex); }
			}
			else if (chbxNoContratacion.Checked == true) {
				txtContratacion.Text = "";
			}
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
			if (chbxNoDespido.Checked == false)
			{
				try
				{
					navegadorMantenimientos1.CambiarFormatoFecha(dtpDespido, txtDespido);
					navegadorMantenimientos1.SeleccionarFechaDTP(dtpDespido, txtDespido);
				}
				catch (Exception ex) { MessageBox.Show("Error: " + ex); }
			}
			else if (chbxNoDespido.Checked==true)
			{
				txtDespido.Text = "";
			}
		}

        private void txtIdPuesto_TextChanged(object sender, EventArgs e)
        {
			navegadorMantenimientos1.SeleccionarElementosenCombo(cbxPuesto, txtIdPuesto);
		}

        private void txtJornada_TextChanged(object sender, EventArgs e)
        {
			navegadorMantenimientos1.SeleccionarElementosenCombo(cbxJornada, txtJornada);
		}

        private void btnFoto_Click(object sender, EventArgs e)
        {
			try
			{
				OpenFileDialog dialog = new OpenFileDialog();
				dialog.Title = "Selecione una imagen";
				dialog.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					pbFoto.ImageLocation = dialog.FileName;					
				}
				else
				{ MessageBox.Show("Error al cargar imagen."); }
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
			
			
		}
		public byte[] imagenAbyte()
		{
			byte[] imagen = null; MemoryStream ms = new MemoryStream();
			try
			{
				pbFoto.Image.Save(ms, ImageFormat.Png);
				ms.Seek(0, SeekOrigin.Begin);
				imagen = ms.ToArray();
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
			return imagen;
		}
		public void obtienByte(string id)
		{
			byte[] imagen = null;
			pbFoto.Image = null;
			try
			{
				imagen = controlador.obtenerByte(id);
				using (MemoryStream ms = new MemoryStream())
				{
					ms.Write(imagen, 0, imagen.Length);
					Image returnImage = Image.FromStream(ms, true);
					pbFoto.Image = returnImage;
				}
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
		}

        private void txtIdFoto_TextChanged(object sender, EventArgs e)
        {
			if (txtIdFoto.Text != "")
			{
				string id = txtIdFoto.Text;
				obtienByte(id);
			}
			else if (txtIdFoto.Text == "")
			{
				pbFoto.Image = null;
			}
		}
		private void guardarfoto()
		{
			try
			{
				if (txtIdFoto.Text == "")
				{
					int id = controlador.idSiguienteDeNuevoIngreso("foto", "pkId");
					byte[] imagen = imagenAbyte();
					controlador.insertaNuevaFoto(id.ToString(), imagen);
					txtIdFoto.Text = id.ToString();
				}
				else if (txtIdFoto.Text != "")
				{
					string id = txtIdFoto.Text;
					byte[] imagen = imagenAbyte();
					controlador.insertaFoto(id, imagen);
				}
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
		}

        private void pbFoto_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
			guardarfoto();
        }

		private void chbxNoContratacion_CheckedChanged(object sender, EventArgs e)
		{
			if (chbxNoContratacion.Checked == true)
			{
				dtpContratacion.Enabled = false;
			}
			else if (chbxNoContratacion.Checked == false)
			{
				dtpContratacion.Enabled = true;
				try
				{
					navegadorMantenimientos1.CambiarFormatoFecha(dtpContratacion, txtContratacion);
					navegadorMantenimientos1.SeleccionarFechaDTP(dtpContratacion, txtContratacion);
				}
				catch (Exception ex) { MessageBox.Show("Error: " + ex); }
			}
		}

		private void chbxNoDespido_CheckedChanged(object sender, EventArgs e)
		{
			if (chbxNoDespido.Checked == true)
			{
				dtpDespido.Enabled = false;
			}
			else if (chbxNoDespido.Checked == false)
			{
				dtpDespido.Enabled = true;
				try
				{
					navegadorMantenimientos1.CambiarFormatoFecha(dtpDespido, txtDespido);
					navegadorMantenimientos1.SeleccionarFechaDTP(dtpDespido, txtDespido);
				}
				catch (Exception ex) { MessageBox.Show("Error: " + ex); }
			}
		}

		private void cbxPuesto_SelectedIndexChanged(object sender, EventArgs e)
		{
			navegadorMantenimientos1.EnviarDatoComboaTextbox(cbxPuesto, txtIdPuesto);
		}

		private void cbxJornada_SelectedIndexChanged(object sender, EventArgs e)
		{
			navegadorMantenimientos1.EnviarDatoComboaTextbox(cbxJornada, txtJornada);
		}
	}
}
