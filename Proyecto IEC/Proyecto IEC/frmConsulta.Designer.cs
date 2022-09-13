
namespace Proyecto_IEC
{
	partial class frmConsulta
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsulta));
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.rbnDiarios = new System.Windows.Forms.RadioButton();
			this.rbnMensual = new System.Windows.Forms.RadioButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.cbxMes = new System.Windows.Forms.ComboBox();
			this.cbxEmpleado = new System.Windows.Forms.ComboBox();
			this.rbnFecha = new System.Windows.Forms.RadioButton();
			this.dgvVistaPrevia = new System.Windows.Forms.DataGridView();
			this.txtMes = new System.Windows.Forms.TextBox();
			this.txtEmpleado = new System.Windows.Forms.TextBox();
			this.txtFecha = new System.Windows.Forms.TextBox();
			this.cbxAnio = new System.Windows.Forms.ComboBox();
			this.rbnAnio = new System.Windows.Forms.RadioButton();
			this.txtAnio = new System.Windows.Forms.TextBox();
			this.txtbusqueda = new System.Windows.Forms.TextBox();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tipo de Búsqueda";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.rbnMensual);
			this.panel1.Controls.Add(this.rbnDiarios);
			this.panel1.Location = new System.Drawing.Point(115, 7);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(150, 22);
			this.panel1.TabIndex = 1;
			// 
			// rbnDiarios
			// 
			this.rbnDiarios.AutoSize = true;
			this.rbnDiarios.Location = new System.Drawing.Point(3, 3);
			this.rbnDiarios.Name = "rbnDiarios";
			this.rbnDiarios.Size = new System.Drawing.Size(55, 17);
			this.rbnDiarios.TabIndex = 0;
			this.rbnDiarios.TabStop = true;
			this.rbnDiarios.Text = "Darios";
			this.rbnDiarios.UseVisualStyleBackColor = true;
			this.rbnDiarios.CheckedChanged += new System.EventHandler(this.rbnDiarios_CheckedChanged);
			// 
			// rbnMensual
			// 
			this.rbnMensual.AutoSize = true;
			this.rbnMensual.Location = new System.Drawing.Point(79, 3);
			this.rbnMensual.Name = "rbnMensual";
			this.rbnMensual.Size = new System.Drawing.Size(65, 17);
			this.rbnMensual.TabIndex = 1;
			this.rbnMensual.TabStop = true;
			this.rbnMensual.Text = "Mensual";
			this.rbnMensual.UseVisualStyleBackColor = true;
			this.rbnMensual.CheckedChanged += new System.EventHandler(this.rbnMensual_CheckedChanged);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.checkBox2);
			this.panel2.Controls.Add(this.checkBox1);
			this.panel2.Controls.Add(this.dtpFecha);
			this.panel2.Controls.Add(this.cbxAnio);
			this.panel2.Controls.Add(this.rbnAnio);
			this.panel2.Controls.Add(this.rbnFecha);
			this.panel2.Controls.Add(this.cbxEmpleado);
			this.panel2.Controls.Add(this.cbxMes);
			this.panel2.Location = new System.Drawing.Point(12, 51);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(883, 27);
			this.panel2.TabIndex = 2;
			// 
			// cbxMes
			// 
			this.cbxMes.FormattingEnabled = true;
			this.cbxMes.Items.AddRange(new object[] {
            "Seleccione un mes...",
            "ENERO",
            "FEBRERO",
            "MARZO",
            "ABRIL",
            "MAYO",
            "JUNIO",
            "JULIO",
            "AGOSTO",
            "SEPTIEMBRE",
            "OCTUBRE",
            "NOVIEMBRE",
            "DICIEMBRE"});
			this.cbxMes.Location = new System.Drawing.Point(55, 3);
			this.cbxMes.Name = "cbxMes";
			this.cbxMes.Size = new System.Drawing.Size(121, 21);
			this.cbxMes.TabIndex = 2;
			// 
			// cbxEmpleado
			// 
			this.cbxEmpleado.FormattingEnabled = true;
			this.cbxEmpleado.Location = new System.Drawing.Point(269, 3);
			this.cbxEmpleado.Name = "cbxEmpleado";
			this.cbxEmpleado.Size = new System.Drawing.Size(121, 21);
			this.cbxEmpleado.TabIndex = 3;
			// 
			// rbnFecha
			// 
			this.rbnFecha.AutoSize = true;
			this.rbnFecha.Location = new System.Drawing.Point(410, 5);
			this.rbnFecha.Name = "rbnFecha";
			this.rbnFecha.Size = new System.Drawing.Size(55, 17);
			this.rbnFecha.TabIndex = 4;
			this.rbnFecha.TabStop = true;
			this.rbnFecha.Text = "Fecha";
			this.rbnFecha.UseVisualStyleBackColor = true;
			// 
			// dgvVistaPrevia
			// 
			this.dgvVistaPrevia.AllowUserToAddRows = false;
			this.dgvVistaPrevia.AllowUserToDeleteRows = false;
			this.dgvVistaPrevia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvVistaPrevia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVistaPrevia.Location = new System.Drawing.Point(12, 84);
			this.dgvVistaPrevia.Name = "dgvVistaPrevia";
			this.dgvVistaPrevia.RowHeadersWidth = 51;
			this.dgvVistaPrevia.Size = new System.Drawing.Size(1300, 354);
			this.dgvVistaPrevia.TabIndex = 104;
			// 
			// txtMes
			// 
			this.txtMes.Location = new System.Drawing.Point(901, 53);
			this.txtMes.Name = "txtMes";
			this.txtMes.Size = new System.Drawing.Size(100, 20);
			this.txtMes.TabIndex = 105;
			// 
			// txtEmpleado
			// 
			this.txtEmpleado.Location = new System.Drawing.Point(1007, 53);
			this.txtEmpleado.Name = "txtEmpleado";
			this.txtEmpleado.Size = new System.Drawing.Size(100, 20);
			this.txtEmpleado.TabIndex = 106;
			// 
			// txtFecha
			// 
			this.txtFecha.Location = new System.Drawing.Point(1113, 53);
			this.txtFecha.Name = "txtFecha";
			this.txtFecha.Size = new System.Drawing.Size(100, 20);
			this.txtFecha.TabIndex = 107;
			// 
			// cbxAnio
			// 
			this.cbxAnio.FormattingEnabled = true;
			this.cbxAnio.Location = new System.Drawing.Point(750, 3);
			this.cbxAnio.Name = "cbxAnio";
			this.cbxAnio.Size = new System.Drawing.Size(121, 21);
			this.cbxAnio.TabIndex = 7;
			this.cbxAnio.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
			// 
			// rbnAnio
			// 
			this.rbnAnio.AutoSize = true;
			this.rbnAnio.Location = new System.Drawing.Point(700, 6);
			this.rbnAnio.Name = "rbnAnio";
			this.rbnAnio.Size = new System.Drawing.Size(44, 17);
			this.rbnAnio.TabIndex = 6;
			this.rbnAnio.TabStop = true;
			this.rbnAnio.Text = "Año";
			this.rbnAnio.UseVisualStyleBackColor = true;
			this.rbnAnio.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
			// 
			// txtAnio
			// 
			this.txtAnio.Location = new System.Drawing.Point(1219, 53);
			this.txtAnio.Name = "txtAnio";
			this.txtAnio.Size = new System.Drawing.Size(100, 20);
			this.txtAnio.TabIndex = 108;
			// 
			// txtbusqueda
			// 
			this.txtbusqueda.Location = new System.Drawing.Point(271, 9);
			this.txtbusqueda.Name = "txtbusqueda";
			this.txtbusqueda.Size = new System.Drawing.Size(100, 20);
			this.txtbusqueda.TabIndex = 109;
			// 
			// dtpFecha
			// 
			this.dtpFecha.Location = new System.Drawing.Point(471, 5);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(200, 20);
			this.dtpFecha.TabIndex = 8;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(3, 6);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(46, 17);
			this.checkBox1.TabIndex = 110;
			this.checkBox1.Text = "Mes";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new System.Drawing.Point(190, 7);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(73, 17);
			this.checkBox2.TabIndex = 111;
			this.checkBox2.Text = "Empleado";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// frmConsulta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1324, 450);
			this.Controls.Add(this.txtbusqueda);
			this.Controls.Add(this.txtAnio);
			this.Controls.Add(this.txtFecha);
			this.Controls.Add(this.txtEmpleado);
			this.Controls.Add(this.txtMes);
			this.Controls.Add(this.dgvVistaPrevia);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmConsulta";
			this.Text = "Consulta";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton rbnMensual;
		private System.Windows.Forms.RadioButton rbnDiarios;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.RadioButton rbnFecha;
		private System.Windows.Forms.ComboBox cbxEmpleado;
		private System.Windows.Forms.ComboBox cbxMes;
		private System.Windows.Forms.ComboBox cbxAnio;
		private System.Windows.Forms.RadioButton rbnAnio;
		private System.Windows.Forms.DataGridView dgvVistaPrevia;
		private System.Windows.Forms.TextBox txtMes;
		private System.Windows.Forms.TextBox txtEmpleado;
		private System.Windows.Forms.TextBox txtFecha;
		private System.Windows.Forms.TextBox txtAnio;
		private System.Windows.Forms.TextBox txtbusqueda;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox1;
	}
}