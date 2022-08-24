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
    }
}
