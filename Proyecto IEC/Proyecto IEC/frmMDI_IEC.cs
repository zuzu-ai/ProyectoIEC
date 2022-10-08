using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVistaSeguridad;

namespace Proyecto_IEC
{
	public partial class frmMDI_IEC : Form
	{
        CapaContoladorProyectoIEC.Global g = new CapaContoladorProyectoIEC.Global();
        CapaContoladorProyectoIEC.Controlador controlador = new CapaContoladorProyectoIEC.Controlador();
		public frmMDI_IEC()
		{
			InitializeComponent();
            controlador.bloqueareporte(g.obtienenombretusuario, btnImprimir);
            navegadorMantenimientos1.bloquearBtn(g.obtienenombretusuario);
        }
        
        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmEmpleado form = new frmEmpleado();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void importarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmImportarArchivo form = new frmImportarArchivo();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

		private void calculoMensualToolStripMenuItem_Click(object sender, EventArgs e)
		{
            try
            {
                frmCalculoMensual form = new frmCalculoMensual();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void puestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmPuesto form = new frmPuesto();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void dispositivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmDispositivo form = new frmDispositivo();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void gestiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmGestion form = new frmGestion();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void tipoPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmTipoPago form = new frmTipoPago();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void tipoAusenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmTipoAusencia form = new frmTipoAusencia();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void ausenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {            
                try
                {
                    frmAusencias form = new frmAusencias();
                    form.MdiParent = this;
                    form.Show();
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex); }            
        }

        private void jornadaToolStripMenuItem_Click(object sender, EventArgs e)
        {            
                try
                {
                    frmJornada form = new frmJornada();
                    form.MdiParent = this;
                    form.Show();
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex); }            
        }

		private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
		{
                try
                {
                    frmConsulta form = new frmConsulta();
                    form.MdiParent = this;
                    form.Show();
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Realmente desea salir?", "Salir",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            { 
                this.Close();                
            }
            else { }
           
        }

        private void tipoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmTipoUsuario form = new frmTipoUsuario();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmUsuario form = new frmUsuario();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void frmMDI_IEC_Load(object sender, EventArgs e)
        {
            frmLogin form = new frmLogin();

            if(form.ShowDialog()== DialogResult.OK)
            {
                txtUsuario.Text = form.usuario();
                txtId.Text = form.id();
                CapaContoladorProyectoIEC.Global global = new CapaContoladorProyectoIEC.Global();
                global.obtieneusuario = txtUsuario.Text;
                global.obtieneid = txtId.Text;
                txtidtusuario.Text=controlador.BuscaDato("usuario","fktipousuario","pkid",txtId.Text);
                txtnombretusuario.Text = controlador.BuscaDato("tipousuario", "nombre", "pkid", txtidtusuario.Text);
                global.obtieneidtusuario = txtidtusuario.Text;
                global.obtienenombretusuario = txtnombretusuario.Text;
            }
            else
            {
                this.Close();
            }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin form = new frmLogin();

            if (form.ShowDialog() == DialogResult.OK)
            {
                controlador.bloqueareporte(g.obtienenombretusuario, btnImprimir);
                navegadorMantenimientos1.bloquearBtn(g.obtienenombretusuario);

            }
            else
            {
                this.Close();
            }
        }

		private void pagoGastosEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
		{
            try
            {
                frmPagoEmpleado form = new frmPagoEmpleado();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }
	}
}
