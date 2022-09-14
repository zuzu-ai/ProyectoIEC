
namespace Proyecto_IEC
{
	partial class frmMDI_IEC
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDI_IEC));
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catálogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dispositivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculoMensualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tipoPagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoAusenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ausenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jornadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cerrarSesiónToolStripMenuItem.Image")));
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // catálogosToolStripMenuItem
            // 
            this.catálogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dispositivoToolStripMenuItem,
            this.empleadoToolStripMenuItem,
            this.gestiónToolStripMenuItem,
            this.jornadaToolStripMenuItem,
            this.puestoToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.tipoPagoToolStripMenuItem,
            this.tipoAusenciaToolStripMenuItem});
            this.catálogosToolStripMenuItem.Name = "catálogosToolStripMenuItem";
            this.catálogosToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.catálogosToolStripMenuItem.Text = "Catálogos";
            // 
            // puestoToolStripMenuItem
            // 
            this.puestoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("puestoToolStripMenuItem.Image")));
            this.puestoToolStripMenuItem.Name = "puestoToolStripMenuItem";
            this.puestoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.puestoToolStripMenuItem.Text = "Puesto";
            this.puestoToolStripMenuItem.Click += new System.EventHandler(this.puestoToolStripMenuItem_Click);
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("empleadoToolStripMenuItem.Image")));
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.empleadoToolStripMenuItem.Text = "Empleado";
            this.empleadoToolStripMenuItem.Click += new System.EventHandler(this.empleadoToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usuarioToolStripMenuItem.Image")));
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // dispositivoToolStripMenuItem
            // 
            this.dispositivoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dispositivoToolStripMenuItem.Image")));
            this.dispositivoToolStripMenuItem.Name = "dispositivoToolStripMenuItem";
            this.dispositivoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dispositivoToolStripMenuItem.Text = "Dispositivo";
            this.dispositivoToolStripMenuItem.Click += new System.EventHandler(this.dispositivoToolStripMenuItem_Click);
            // 
            // gestiónToolStripMenuItem
            // 
            this.gestiónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gestiónToolStripMenuItem.Image")));
            this.gestiónToolStripMenuItem.Name = "gestiónToolStripMenuItem";
            this.gestiónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestiónToolStripMenuItem.Text = "Gestión";
            this.gestiónToolStripMenuItem.Click += new System.EventHandler(this.gestiónToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ausenciasToolStripMenuItem,
            this.calculoMensualToolStripMenuItem,
            this.importarDatosToolStripMenuItem});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // importarDatosToolStripMenuItem
            // 
            this.importarDatosToolStripMenuItem.Name = "importarDatosToolStripMenuItem";
            this.importarDatosToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.importarDatosToolStripMenuItem.Text = "Importar Datos";
            this.importarDatosToolStripMenuItem.Click += new System.EventHandler(this.importarDatosToolStripMenuItem_Click);
            // 
            // calculoMensualToolStripMenuItem
            // 
            this.calculoMensualToolStripMenuItem.Name = "calculoMensualToolStripMenuItem";
            this.calculoMensualToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.calculoMensualToolStripMenuItem.Text = "Calculo Mensual";
            this.calculoMensualToolStripMenuItem.Click += new System.EventHandler(this.calculoMensualToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.catálogosToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tipoPagoToolStripMenuItem
            // 
            this.tipoPagoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tipoPagoToolStripMenuItem.Image")));
            this.tipoPagoToolStripMenuItem.Name = "tipoPagoToolStripMenuItem";
            this.tipoPagoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tipoPagoToolStripMenuItem.Text = "Tipo pago";
            this.tipoPagoToolStripMenuItem.Click += new System.EventHandler(this.tipoPagoToolStripMenuItem_Click);
            // 
            // tipoAusenciaToolStripMenuItem
            // 
            this.tipoAusenciaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tipoAusenciaToolStripMenuItem.Image")));
            this.tipoAusenciaToolStripMenuItem.Name = "tipoAusenciaToolStripMenuItem";
            this.tipoAusenciaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tipoAusenciaToolStripMenuItem.Text = "Tipo ausencia";
            this.tipoAusenciaToolStripMenuItem.Click += new System.EventHandler(this.tipoAusenciaToolStripMenuItem_Click);
            // 
            // ausenciasToolStripMenuItem
            // 
            this.ausenciasToolStripMenuItem.Name = "ausenciasToolStripMenuItem";
            this.ausenciasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ausenciasToolStripMenuItem.Text = "Ausencias";
            this.ausenciasToolStripMenuItem.Click += new System.EventHandler(this.ausenciasToolStripMenuItem_Click);
            // 
            // jornadaToolStripMenuItem
            // 
            this.jornadaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("jornadaToolStripMenuItem.Image")));
            this.jornadaToolStripMenuItem.Name = "jornadaToolStripMenuItem";
            this.jornadaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.jornadaToolStripMenuItem.Text = "Jornada";
            this.jornadaToolStripMenuItem.Click += new System.EventHandler(this.jornadaToolStripMenuItem_Click);
            // 
            // frmMDI_IEC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMDI_IEC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Horas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem catálogosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem puestoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dispositivoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gestiónToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem importarDatosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem calculoMensualToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoPagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoAusenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ausenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jornadaToolStripMenuItem;
    }
}

