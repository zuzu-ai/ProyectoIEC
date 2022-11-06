
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
			this.jornadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dispositivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gestiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tipoPagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tipoAusenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pagoGastosEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ausenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.importarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.calculoMensualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tipoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.txtId = new System.Windows.Forms.TextBox();
			this.txtnombretusuario = new System.Windows.Forms.TextBox();
			this.txtidtusuario = new System.Windows.Forms.TextBox();
			this.btnImprimir = new System.Windows.Forms.Button();
			this.navegadorMantenimientos1 = new CapaVistaNavegador.NavegadorMantenimientos();
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
			this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
			this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.salirToolStripMenuItem.Text = "Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
			// 
			// catálogosToolStripMenuItem
			// 
			this.catálogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.puestoToolStripMenuItem,
            this.jornadaToolStripMenuItem,
            this.empleadoToolStripMenuItem,
            this.dispositivoToolStripMenuItem,
            this.gestiónToolStripMenuItem,
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
			this.puestoToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.puestoToolStripMenuItem.Text = "Puesto";
			this.puestoToolStripMenuItem.Click += new System.EventHandler(this.puestoToolStripMenuItem_Click);
			// 
			// jornadaToolStripMenuItem
			// 
			this.jornadaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("jornadaToolStripMenuItem.Image")));
			this.jornadaToolStripMenuItem.Name = "jornadaToolStripMenuItem";
			this.jornadaToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.jornadaToolStripMenuItem.Text = "Jornada";
			this.jornadaToolStripMenuItem.Click += new System.EventHandler(this.jornadaToolStripMenuItem_Click);
			// 
			// empleadoToolStripMenuItem
			// 
			this.empleadoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("empleadoToolStripMenuItem.Image")));
			this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
			this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.empleadoToolStripMenuItem.Text = "Empleado";
			this.empleadoToolStripMenuItem.Click += new System.EventHandler(this.empleadoToolStripMenuItem_Click);
			// 
			// dispositivoToolStripMenuItem
			// 
			this.dispositivoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dispositivoToolStripMenuItem.Image")));
			this.dispositivoToolStripMenuItem.Name = "dispositivoToolStripMenuItem";
			this.dispositivoToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.dispositivoToolStripMenuItem.Text = "Dispositivo";
			this.dispositivoToolStripMenuItem.Click += new System.EventHandler(this.dispositivoToolStripMenuItem_Click);
			// 
			// gestiónToolStripMenuItem
			// 
			this.gestiónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gestiónToolStripMenuItem.Image")));
			this.gestiónToolStripMenuItem.Name = "gestiónToolStripMenuItem";
			this.gestiónToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.gestiónToolStripMenuItem.Text = "Gestión";
			this.gestiónToolStripMenuItem.Click += new System.EventHandler(this.gestiónToolStripMenuItem_Click);
			// 
			// tipoPagoToolStripMenuItem
			// 
			this.tipoPagoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tipoPagoToolStripMenuItem.Image")));
			this.tipoPagoToolStripMenuItem.Name = "tipoPagoToolStripMenuItem";
			this.tipoPagoToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.tipoPagoToolStripMenuItem.Text = "Tipo pago";
			this.tipoPagoToolStripMenuItem.Click += new System.EventHandler(this.tipoPagoToolStripMenuItem_Click);
			// 
			// tipoAusenciaToolStripMenuItem
			// 
			this.tipoAusenciaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tipoAusenciaToolStripMenuItem.Image")));
			this.tipoAusenciaToolStripMenuItem.Name = "tipoAusenciaToolStripMenuItem";
			this.tipoAusenciaToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.tipoAusenciaToolStripMenuItem.Text = "Tipo ausencia";
			this.tipoAusenciaToolStripMenuItem.Click += new System.EventHandler(this.tipoAusenciaToolStripMenuItem_Click);
			// 
			// procesosToolStripMenuItem
			// 
			this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pagoGastosEmpleadosToolStripMenuItem,
            this.ausenciasToolStripMenuItem,
            this.importarDatosToolStripMenuItem,
            this.calculoMensualToolStripMenuItem,
            this.consultaToolStripMenuItem});
			this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
			this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
			this.procesosToolStripMenuItem.Text = "Procesos";
			// 
			// pagoGastosEmpleadosToolStripMenuItem
			// 
			this.pagoGastosEmpleadosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pagoGastosEmpleadosToolStripMenuItem.Image")));
			this.pagoGastosEmpleadosToolStripMenuItem.Name = "pagoGastosEmpleadosToolStripMenuItem";
			this.pagoGastosEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
			this.pagoGastosEmpleadosToolStripMenuItem.Text = "Pago Gastos Empleados";
			this.pagoGastosEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.pagoGastosEmpleadosToolStripMenuItem_Click);
			// 
			// ausenciasToolStripMenuItem
			// 
			this.ausenciasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ausenciasToolStripMenuItem.Image")));
			this.ausenciasToolStripMenuItem.Name = "ausenciasToolStripMenuItem";
			this.ausenciasToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
			this.ausenciasToolStripMenuItem.Text = "Ausencias";
			this.ausenciasToolStripMenuItem.Click += new System.EventHandler(this.ausenciasToolStripMenuItem_Click);
			// 
			// importarDatosToolStripMenuItem
			// 
			this.importarDatosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("importarDatosToolStripMenuItem.Image")));
			this.importarDatosToolStripMenuItem.Name = "importarDatosToolStripMenuItem";
			this.importarDatosToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
			this.importarDatosToolStripMenuItem.Text = "Importar Datos";
			this.importarDatosToolStripMenuItem.Click += new System.EventHandler(this.importarDatosToolStripMenuItem_Click);
			// 
			// calculoMensualToolStripMenuItem
			// 
			this.calculoMensualToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("calculoMensualToolStripMenuItem.Image")));
			this.calculoMensualToolStripMenuItem.Name = "calculoMensualToolStripMenuItem";
			this.calculoMensualToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
			this.calculoMensualToolStripMenuItem.Text = "Calculo Mensual";
			this.calculoMensualToolStripMenuItem.Click += new System.EventHandler(this.calculoMensualToolStripMenuItem_Click);
			// 
			// consultaToolStripMenuItem
			// 
			this.consultaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultaToolStripMenuItem.Image")));
			this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
			this.consultaToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
			this.consultaToolStripMenuItem.Text = "Consulta";
			this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
			// 
			// ayudaToolStripMenuItem
			// 
			this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
			this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
			this.ayudaToolStripMenuItem.Text = "Ayuda";
			this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.catálogosToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.seguridadToolStripMenuItem,
            this.ayudaToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// seguridadToolStripMenuItem
			// 
			this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.tipoUsuarioToolStripMenuItem});
			this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
			this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
			this.seguridadToolStripMenuItem.Text = "Seguridad";
			// 
			// usuariosToolStripMenuItem
			// 
			this.usuariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usuariosToolStripMenuItem.Image")));
			this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
			this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.usuariosToolStripMenuItem.Text = "Usuario";
			this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
			// 
			// tipoUsuarioToolStripMenuItem
			// 
			this.tipoUsuarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tipoUsuarioToolStripMenuItem.Image")));
			this.tipoUsuarioToolStripMenuItem.Name = "tipoUsuarioToolStripMenuItem";
			this.tipoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.tipoUsuarioToolStripMenuItem.Text = "Tipo usuario";
			this.tipoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.tipoUsuarioToolStripMenuItem_Click);
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(70, 418);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(100, 20);
			this.txtUsuario.TabIndex = 3;
			this.txtUsuario.Visible = false;
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(200, 418);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(100, 20);
			this.txtId.TabIndex = 4;
			this.txtId.Visible = false;
			// 
			// txtnombretusuario
			// 
			this.txtnombretusuario.Location = new System.Drawing.Point(447, 418);
			this.txtnombretusuario.Name = "txtnombretusuario";
			this.txtnombretusuario.Size = new System.Drawing.Size(100, 20);
			this.txtnombretusuario.TabIndex = 7;
			this.txtnombretusuario.Visible = false;
			// 
			// txtidtusuario
			// 
			this.txtidtusuario.Location = new System.Drawing.Point(317, 418);
			this.txtidtusuario.Name = "txtidtusuario";
			this.txtidtusuario.Size = new System.Drawing.Size(100, 20);
			this.txtidtusuario.TabIndex = 6;
			this.txtidtusuario.Visible = false;
			// 
			// btnImprimir
			// 
			this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
			this.btnImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImprimir.BackgroundImage")));
			this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnImprimir.FlatAppearance.BorderSize = 0;
			this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnImprimir.Location = new System.Drawing.Point(317, -26);
			this.btnImprimir.Margin = new System.Windows.Forms.Padding(0);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(50, 10);
			this.btnImprimir.TabIndex = 129;
			this.btnImprimir.UseVisualStyleBackColor = false;
			// 
			// navegadorMantenimientos1
			// 
			this.navegadorMantenimientos1.BackColor = System.Drawing.Color.Transparent;
			this.navegadorMantenimientos1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.navegadorMantenimientos1.Location = new System.Drawing.Point(72, -26);
			this.navegadorMantenimientos1.Name = "navegadorMantenimientos1";
			this.navegadorMantenimientos1.Size = new System.Drawing.Size(658, 10);
			this.navegadorMantenimientos1.TabIndex = 128;
			// 
			// frmMDI_IEC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnImprimir);
			this.Controls.Add(this.navegadorMantenimientos1);
			this.Controls.Add(this.txtnombretusuario);
			this.Controls.Add(this.txtidtusuario);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmMDI_IEC";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sistema de Horas";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmMDI_IEC_Load);
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
		private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoUsuarioToolStripMenuItem;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.ToolStripMenuItem pagoGastosEmpleadosToolStripMenuItem;
		private System.Windows.Forms.TextBox txtnombretusuario;
		private System.Windows.Forms.TextBox txtidtusuario;
		private System.Windows.Forms.Button btnImprimir;
		private CapaVistaNavegador.NavegadorMantenimientos navegadorMantenimientos1;
	}
}

