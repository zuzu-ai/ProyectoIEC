
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
			this.chbxTodos = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.mtxtDia = new System.Windows.Forms.MaskedTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbxEmpleado = new System.Windows.Forms.ComboBox();
			this.dgvVistaPrevia = new System.Windows.Forms.DataGridView();
			this.txtEmpleado = new System.Windows.Forms.TextBox();
			this.txtbusqueda = new System.Windows.Forms.TextBox();
			this.btnConsultar = new System.Windows.Forms.Button();
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
			this.panel2.Controls.Add(this.chbxTodos);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.mtxtDia);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.cbxEmpleado);
			this.panel2.Location = new System.Drawing.Point(12, 51);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(473, 27);
			this.panel2.TabIndex = 2;
			// 
			// chbxTodos
			// 
			this.chbxTodos.AutoSize = true;
			this.chbxTodos.Location = new System.Drawing.Point(376, 5);
			this.chbxTodos.Name = "chbxTodos";
			this.chbxTodos.Size = new System.Drawing.Size(94, 17);
			this.chbxTodos.TabIndex = 117;
			this.chbxTodos.Text = "Mostrar Todos";
			this.chbxTodos.UseVisualStyleBackColor = true;
			this.chbxTodos.CheckedChanged += new System.EventHandler(this.chbxTodos_CheckedChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(228, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(25, 13);
			this.label3.TabIndex = 116;
			this.label3.Text = "Día";
			// 
			// mtxtDia
			// 
			this.mtxtDia.Location = new System.Drawing.Point(259, 3);
			this.mtxtDia.Mask = "0000-00-00";
			this.mtxtDia.Name = "mtxtDia";
			this.mtxtDia.Size = new System.Drawing.Size(100, 20);
			this.mtxtDia.TabIndex = 115;
			this.mtxtDia.ValidatingType = typeof(System.DateTime);
			this.mtxtDia.TextChanged += new System.EventHandler(this.mtxtDia_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 13);
			this.label2.TabIndex = 114;
			this.label2.Text = "Empleado";
			// 
			// cbxEmpleado
			// 
			this.cbxEmpleado.FormattingEnabled = true;
			this.cbxEmpleado.Location = new System.Drawing.Point(63, 3);
			this.cbxEmpleado.Name = "cbxEmpleado";
			this.cbxEmpleado.Size = new System.Drawing.Size(121, 21);
			this.cbxEmpleado.TabIndex = 3;
			this.cbxEmpleado.SelectedIndexChanged += new System.EventHandler(this.cbxEmpleado_SelectedIndexChanged);
			// 
			// dgvVistaPrevia
			// 
			this.dgvVistaPrevia.AllowUserToAddRows = false;
			this.dgvVistaPrevia.AllowUserToDeleteRows = false;
			this.dgvVistaPrevia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvVistaPrevia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVistaPrevia.Location = new System.Drawing.Point(12, 84);
			this.dgvVistaPrevia.Name = "dgvVistaPrevia";
			this.dgvVistaPrevia.ReadOnly = true;
			this.dgvVistaPrevia.RowHeadersWidth = 51;
			this.dgvVistaPrevia.Size = new System.Drawing.Size(1300, 354);
			this.dgvVistaPrevia.TabIndex = 104;
			// 
			// txtEmpleado
			// 
			this.txtEmpleado.Location = new System.Drawing.Point(491, 54);
			this.txtEmpleado.Name = "txtEmpleado";
			this.txtEmpleado.Size = new System.Drawing.Size(100, 20);
			this.txtEmpleado.TabIndex = 106;
			this.txtEmpleado.Tag = "pkid";
			this.txtEmpleado.Visible = false;
			// 
			// txtbusqueda
			// 
			this.txtbusqueda.Location = new System.Drawing.Point(271, 9);
			this.txtbusqueda.Name = "txtbusqueda";
			this.txtbusqueda.Size = new System.Drawing.Size(100, 20);
			this.txtbusqueda.TabIndex = 109;
			// 
			// btnConsultar
			// 
			this.btnConsultar.Location = new System.Drawing.Point(491, 52);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(75, 23);
			this.btnConsultar.TabIndex = 110;
			this.btnConsultar.Text = "Consultar";
			this.btnConsultar.UseVisualStyleBackColor = true;
			this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
			// 
			// frmConsulta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1324, 450);
			this.Controls.Add(this.btnConsultar);
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
		private System.Windows.Forms.DataGridView dgvVistaPrevia;
		private System.Windows.Forms.TextBox txtEmpleado;
		private System.Windows.Forms.TextBox txtbusqueda;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox chbxTodos;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.MaskedTextBox mtxtDia;
		private System.Windows.Forms.Button btnConsultar;
	}
}