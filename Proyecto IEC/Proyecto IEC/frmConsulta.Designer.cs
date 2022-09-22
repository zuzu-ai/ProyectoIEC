
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
			this.rbnMensual = new System.Windows.Forms.RadioButton();
			this.rbnDiarios = new System.Windows.Forms.RadioButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.chbxEmpleado = new System.Windows.Forms.CheckBox();
			this.chbxMes = new System.Windows.Forms.CheckBox();
			this.cbxAnio = new System.Windows.Forms.ComboBox();
			this.cbxEmpleado = new System.Windows.Forms.ComboBox();
			this.cbxMes = new System.Windows.Forms.ComboBox();
			this.dgvVistaPrevia = new System.Windows.Forms.DataGridView();
			this.txtEmpleado = new System.Windows.Forms.TextBox();
			this.txtbusqueda = new System.Windows.Forms.TextBox();
			this.chbxAnio = new System.Windows.Forms.CheckBox();
			this.chbxDia = new System.Windows.Forms.CheckBox();
			this.cbxDia = new System.Windows.Forms.ComboBox();
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
			// panel2
			// 
			this.panel2.Controls.Add(this.chbxDia);
			this.panel2.Controls.Add(this.cbxDia);
			this.panel2.Controls.Add(this.chbxAnio);
			this.panel2.Controls.Add(this.chbxEmpleado);
			this.panel2.Controls.Add(this.chbxMes);
			this.panel2.Controls.Add(this.cbxAnio);
			this.panel2.Controls.Add(this.cbxEmpleado);
			this.panel2.Controls.Add(this.cbxMes);
			this.panel2.Location = new System.Drawing.Point(12, 51);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(746, 27);
			this.panel2.TabIndex = 2;
			// 
			// chbxEmpleado
			// 
			this.chbxEmpleado.AutoSize = true;
			this.chbxEmpleado.Location = new System.Drawing.Point(540, 7);
			this.chbxEmpleado.Name = "chbxEmpleado";
			this.chbxEmpleado.Size = new System.Drawing.Size(73, 17);
			this.chbxEmpleado.TabIndex = 111;
			this.chbxEmpleado.Text = "Empleado";
			this.chbxEmpleado.UseVisualStyleBackColor = true;
			// 
			// chbxMes
			// 
			this.chbxMes.AutoSize = true;
			this.chbxMes.Location = new System.Drawing.Point(184, 8);
			this.chbxMes.Name = "chbxMes";
			this.chbxMes.Size = new System.Drawing.Size(46, 17);
			this.chbxMes.TabIndex = 110;
			this.chbxMes.Text = "Mes";
			this.chbxMes.UseVisualStyleBackColor = true;
			this.chbxMes.CheckedChanged += new System.EventHandler(this.chbxMes_CheckedChanged);
			// 
			// cbxAnio
			// 
			this.cbxAnio.FormattingEnabled = true;
			this.cbxAnio.Location = new System.Drawing.Point(51, 4);
			this.cbxAnio.Name = "cbxAnio";
			this.cbxAnio.Size = new System.Drawing.Size(121, 21);
			this.cbxAnio.TabIndex = 7;
			this.cbxAnio.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
			// 
			// cbxEmpleado
			// 
			this.cbxEmpleado.FormattingEnabled = true;
			this.cbxEmpleado.Location = new System.Drawing.Point(613, 4);
			this.cbxEmpleado.Name = "cbxEmpleado";
			this.cbxEmpleado.Size = new System.Drawing.Size(121, 21);
			this.cbxEmpleado.TabIndex = 3;
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
			this.cbxMes.Location = new System.Drawing.Point(232, 4);
			this.cbxMes.Name = "cbxMes";
			this.cbxMes.Size = new System.Drawing.Size(121, 21);
			this.cbxMes.TabIndex = 2;
			this.cbxMes.SelectedIndexChanged += new System.EventHandler(this.cbxMes_SelectedIndexChanged);
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
			// txtEmpleado
			// 
			this.txtEmpleado.Location = new System.Drawing.Point(792, 56);
			this.txtEmpleado.Name = "txtEmpleado";
			this.txtEmpleado.Size = new System.Drawing.Size(100, 20);
			this.txtEmpleado.TabIndex = 106;
			// 
			// txtbusqueda
			// 
			this.txtbusqueda.Location = new System.Drawing.Point(271, 9);
			this.txtbusqueda.Name = "txtbusqueda";
			this.txtbusqueda.Size = new System.Drawing.Size(100, 20);
			this.txtbusqueda.TabIndex = 109;
			// 
			// chbxAnio
			// 
			this.chbxAnio.AutoSize = true;
			this.chbxAnio.Location = new System.Drawing.Point(6, 6);
			this.chbxAnio.Name = "chbxAnio";
			this.chbxAnio.Size = new System.Drawing.Size(45, 17);
			this.chbxAnio.TabIndex = 112;
			this.chbxAnio.Text = "Año";
			this.chbxAnio.UseVisualStyleBackColor = true;
			this.chbxAnio.CheckedChanged += new System.EventHandler(this.chbxAnio_CheckedChanged);
			// 
			// chbxDia
			// 
			this.chbxDia.AutoSize = true;
			this.chbxDia.Location = new System.Drawing.Point(364, 7);
			this.chbxDia.Name = "chbxDia";
			this.chbxDia.Size = new System.Drawing.Size(44, 17);
			this.chbxDia.TabIndex = 114;
			this.chbxDia.Text = "Día";
			this.chbxDia.UseVisualStyleBackColor = true;
			this.chbxDia.CheckedChanged += new System.EventHandler(this.chbxDia_CheckedChanged);
			// 
			// cbxDia
			// 
			this.cbxDia.FormattingEnabled = true;
			this.cbxDia.Location = new System.Drawing.Point(409, 4);
			this.cbxDia.Name = "cbxDia";
			this.cbxDia.Size = new System.Drawing.Size(121, 21);
			this.cbxDia.TabIndex = 113;
			// 
			// frmConsulta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1324, 450);
			this.Controls.Add(this.txtbusqueda);
			this.Controls.Add(this.txtEmpleado);
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
		private System.Windows.Forms.ComboBox cbxEmpleado;
		private System.Windows.Forms.ComboBox cbxMes;
		private System.Windows.Forms.ComboBox cbxAnio;
		private System.Windows.Forms.DataGridView dgvVistaPrevia;
		private System.Windows.Forms.TextBox txtEmpleado;
		private System.Windows.Forms.TextBox txtbusqueda;
		private System.Windows.Forms.CheckBox chbxEmpleado;
		private System.Windows.Forms.CheckBox chbxMes;
		private System.Windows.Forms.CheckBox chbxDia;
		private System.Windows.Forms.ComboBox cbxDia;
		private System.Windows.Forms.CheckBox chbxAnio;
	}
}