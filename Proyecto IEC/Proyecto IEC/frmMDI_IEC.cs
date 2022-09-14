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
	public partial class frmMDI_IEC : Form
	{
		public frmMDI_IEC()
		{
			InitializeComponent();
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
            {
                try
                {
                    frmAusencias form = new frmAusencias();
                    form.MdiParent = this;
                    form.Show();
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex); }
            }
        }

        private void jornadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    frmJornada form = new frmJornada();
                    form.MdiParent = this;
                    form.Show();
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex); }
            }
        }
    }
}
