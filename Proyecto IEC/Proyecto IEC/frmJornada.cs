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
    public partial class frmJornada : Form
    {
        public frmJornada()
        {
            InitializeComponent();
        }

		private void dtpInicio_ValueChanged(object sender, EventArgs e)
		{
			navegadorMantenimientos1.ColocaHora(dtpInicio, txtInicio);   
		}

		private void dtpFin_ValueChanged(object sender, EventArgs e)
		{
			navegadorMantenimientos1.ColocaHora(dtpFin, txtFin);
		}

		private void txtInicio_TextChanged(object sender, EventArgs e)
		{
			navegadorMantenimientos1.RecibeHora(dtpInicio, txtInicio);
		}

		private void txtFin_TextChanged(object sender, EventArgs e)
		{
			navegadorMantenimientos1.RecibeHora(dtpFin, txtFin);
		}
	}
}
