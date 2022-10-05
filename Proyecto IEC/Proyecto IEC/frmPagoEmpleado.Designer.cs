
namespace Proyecto_IEC
{
	partial class frmPagoEmpleado
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPagoEmpleado));
			this.btnImprimir = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.rbnEstatusimodulo = new System.Windows.Forms.RadioButton();
			this.rbnEstatusamodulo = new System.Windows.Forms.RadioButton();
			this.txtEstado = new System.Windows.Forms.TextBox();
			this.txtFecha = new System.Windows.Forms.TextBox();
			this.txtIdEmpleado = new System.Windows.Forms.TextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.navegadorMantenimientos1 = new CapaVistaNavegador.NavegadorMantenimientos();
			this.dgvVistaPrevia = new System.Windows.Forms.DataGridView();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.cbxTipoPago = new System.Windows.Forms.ComboBox();
			this.cbxEmpleado = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtTipoPago = new System.Windows.Forms.TextBox();
			this.txtMonto = new System.Windows.Forms.TextBox();
			this.txtDetalles = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).BeginInit();
			this.SuspendLayout();
			// 
			// btnImprimir
			// 
			this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
			this.btnImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImprimir.BackgroundImage")));
			this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnImprimir.FlatAppearance.BorderSize = 0;
			this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnImprimir.Location = new System.Drawing.Point(247, 1);
			this.btnImprimir.Margin = new System.Windows.Forms.Padding(0);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(50, 50);
			this.btnImprimir.TabIndex = 151;
			this.btnImprimir.UseVisualStyleBackColor = false;
			this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.rbnEstatusimodulo);
			this.panel1.Controls.Add(this.rbnEstatusamodulo);
			this.panel1.Location = new System.Drawing.Point(92, 238);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 28);
			this.panel1.TabIndex = 150;
			// 
			// rbnEstatusimodulo
			// 
			this.rbnEstatusimodulo.AutoSize = true;
			this.rbnEstatusimodulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbnEstatusimodulo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.rbnEstatusimodulo.Location = new System.Drawing.Point(104, 1);
			this.rbnEstatusimodulo.Name = "rbnEstatusimodulo";
			this.rbnEstatusimodulo.Size = new System.Drawing.Size(72, 20);
			this.rbnEstatusimodulo.TabIndex = 3;
			this.rbnEstatusimodulo.TabStop = true;
			this.rbnEstatusimodulo.Text = "Inactivo";
			this.rbnEstatusimodulo.UseVisualStyleBackColor = true;
			this.rbnEstatusimodulo.CheckedChanged += new System.EventHandler(this.rbnEstatusimodulo_CheckedChanged);
			// 
			// rbnEstatusamodulo
			// 
			this.rbnEstatusamodulo.AutoSize = true;
			this.rbnEstatusamodulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbnEstatusamodulo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.rbnEstatusamodulo.Location = new System.Drawing.Point(31, 1);
			this.rbnEstatusamodulo.Name = "rbnEstatusamodulo";
			this.rbnEstatusamodulo.Size = new System.Drawing.Size(63, 20);
			this.rbnEstatusamodulo.TabIndex = 2;
			this.rbnEstatusamodulo.TabStop = true;
			this.rbnEstatusamodulo.Text = "Activo";
			this.rbnEstatusamodulo.UseVisualStyleBackColor = true;
			this.rbnEstatusamodulo.CheckedChanged += new System.EventHandler(this.rbnEstatusamodulo_CheckedChanged);
			// 
			// txtEstado
			// 
			this.txtEstado.Location = new System.Drawing.Point(298, 242);
			this.txtEstado.Name = "txtEstado";
			this.txtEstado.Size = new System.Drawing.Size(39, 20);
			this.txtEstado.TabIndex = 145;
			this.txtEstado.Tag = "estado";
			this.txtEstado.Visible = false;
			this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
			// 
			// txtFecha
			// 
			this.txtFecha.Location = new System.Drawing.Point(373, 135);
			this.txtFecha.Name = "txtFecha";
			this.txtFecha.Size = new System.Drawing.Size(39, 20);
			this.txtFecha.TabIndex = 146;
			this.txtFecha.Tag = "fecha";
			this.txtFecha.Visible = false;
			this.txtFecha.TextChanged += new System.EventHandler(this.txtFecha_TextChanged);
			// 
			// txtIdEmpleado
			// 
			this.txtIdEmpleado.Location = new System.Drawing.Point(373, 86);
			this.txtIdEmpleado.Name = "txtIdEmpleado";
			this.txtIdEmpleado.Size = new System.Drawing.Size(39, 20);
			this.txtIdEmpleado.TabIndex = 144;
			this.txtIdEmpleado.TabStop = false;
			this.txtIdEmpleado.Tag = "fkempleado";
			this.txtIdEmpleado.Visible = false;
			this.txtIdEmpleado.TextChanged += new System.EventHandler(this.txtIdEmpleado_TextChanged);
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(92, 59);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(268, 20);
			this.txtID.TabIndex = 128;
			this.txtID.Tag = "pkid";
			// 
			// navegadorMantenimientos1
			// 
			this.navegadorMantenimientos1.BackColor = System.Drawing.Color.Transparent;
			this.navegadorMantenimientos1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.navegadorMantenimientos1.Location = new System.Drawing.Point(0, 1);
			this.navegadorMantenimientos1.Name = "navegadorMantenimientos1";
			this.navegadorMantenimientos1.Size = new System.Drawing.Size(658, 49);
			this.navegadorMantenimientos1.TabIndex = 149;
			// 
			// dgvVistaPrevia
			// 
			this.dgvVistaPrevia.AllowUserToAddRows = false;
			this.dgvVistaPrevia.AllowUserToDeleteRows = false;
			this.dgvVistaPrevia.AllowUserToResizeRows = false;
			this.dgvVistaPrevia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvVistaPrevia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvVistaPrevia.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
			this.dgvVistaPrevia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVistaPrevia.Location = new System.Drawing.Point(12, 272);
			this.dgvVistaPrevia.Name = "dgvVistaPrevia";
			this.dgvVistaPrevia.ReadOnly = true;
			this.dgvVistaPrevia.RowHeadersWidth = 51;
			this.dgvVistaPrevia.Size = new System.Drawing.Size(644, 192);
			this.dgvVistaPrevia.TabIndex = 148;
			this.dgvVistaPrevia.SelectionChanged += new System.EventHandler(this.dgvVistaPrevia_SelectionChanged);
			// 
			// dtpFecha
			// 
			this.dtpFecha.Location = new System.Drawing.Point(91, 137);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(268, 20);
			this.dtpFecha.TabIndex = 142;
			this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
			// 
			// cbxTipoPago
			// 
			this.cbxTipoPago.FormattingEnabled = true;
			this.cbxTipoPago.Location = new System.Drawing.Point(91, 110);
			this.cbxTipoPago.Name = "cbxTipoPago";
			this.cbxTipoPago.Size = new System.Drawing.Size(268, 21);
			this.cbxTipoPago.TabIndex = 141;
			this.cbxTipoPago.SelectedIndexChanged += new System.EventHandler(this.cbxTipoPago_SelectedIndexChanged);
			// 
			// cbxEmpleado
			// 
			this.cbxEmpleado.FormattingEnabled = true;
			this.cbxEmpleado.Location = new System.Drawing.Point(92, 85);
			this.cbxEmpleado.Name = "cbxEmpleado";
			this.cbxEmpleado.Size = new System.Drawing.Size(268, 21);
			this.cbxEmpleado.TabIndex = 129;
			this.cbxEmpleado.SelectedIndexChanged += new System.EventHandler(this.cbxEmpleado_SelectedIndexChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label8.Location = new System.Drawing.Point(18, 242);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(51, 16);
			this.label8.TabIndex = 140;
			this.label8.Text = "Estado";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label6.Location = new System.Drawing.Point(18, 189);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 16);
			this.label6.TabIndex = 138;
			this.label6.Text = "Detalles";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label5.Location = new System.Drawing.Point(17, 141);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(46, 16);
			this.label5.TabIndex = 137;
			this.label5.Text = "Fecha";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label4.Location = new System.Drawing.Point(12, 86);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 16);
			this.label4.TabIndex = 135;
			this.label4.Text = "Empleado";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label3.Location = new System.Drawing.Point(18, 167);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 16);
			this.label3.TabIndex = 134;
			this.label3.Text = "Monto";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(13, 113);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 16);
			this.label2.TabIndex = 132;
			this.label2.Text = "Tipo Pago";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(13, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 16);
			this.label1.TabIndex = 130;
			this.label1.Text = "ID";
			// 
			// txtTipoPago
			// 
			this.txtTipoPago.Location = new System.Drawing.Point(373, 109);
			this.txtTipoPago.Name = "txtTipoPago";
			this.txtTipoPago.Size = new System.Drawing.Size(39, 20);
			this.txtTipoPago.TabIndex = 152;
			this.txtTipoPago.TabStop = false;
			this.txtTipoPago.Tag = "tipopago";
			this.txtTipoPago.Visible = false;
			this.txtTipoPago.TextChanged += new System.EventHandler(this.txtTipoPago_TextChanged);
			// 
			// txtMonto
			// 
			this.txtMonto.Location = new System.Drawing.Point(91, 163);
			this.txtMonto.Name = "txtMonto";
			this.txtMonto.Size = new System.Drawing.Size(268, 20);
			this.txtMonto.TabIndex = 153;
			this.txtMonto.Tag = "monto";
			// 
			// txtDetalles
			// 
			this.txtDetalles.Location = new System.Drawing.Point(92, 189);
			this.txtDetalles.Multiline = true;
			this.txtDetalles.Name = "txtDetalles";
			this.txtDetalles.Size = new System.Drawing.Size(268, 43);
			this.txtDetalles.TabIndex = 154;
			this.txtDetalles.Tag = "detalles";
			// 
			// frmPagoEmpleado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(668, 476);
			this.Controls.Add(this.txtEstado);
			this.Controls.Add(this.txtDetalles);
			this.Controls.Add(this.txtMonto);
			this.Controls.Add(this.txtFecha);
			this.Controls.Add(this.txtTipoPago);
			this.Controls.Add(this.txtIdEmpleado);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.btnImprimir);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.navegadorMantenimientos1);
			this.Controls.Add(this.dgvVistaPrevia);
			this.Controls.Add(this.dtpFecha);
			this.Controls.Add(this.cbxTipoPago);
			this.Controls.Add(this.cbxEmpleado);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmPagoEmpleado";
			this.Text = "Pago Gastos Empleado";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnImprimir;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton rbnEstatusimodulo;
		private System.Windows.Forms.RadioButton rbnEstatusamodulo;
		private System.Windows.Forms.TextBox txtEstado;
		private System.Windows.Forms.TextBox txtFecha;
		private System.Windows.Forms.TextBox txtIdEmpleado;
		private System.Windows.Forms.TextBox txtID;
		private CapaVistaNavegador.NavegadorMantenimientos navegadorMantenimientos1;
		private System.Windows.Forms.DataGridView dgvVistaPrevia;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.ComboBox cbxTipoPago;
		private System.Windows.Forms.ComboBox cbxEmpleado;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTipoPago;
		private System.Windows.Forms.TextBox txtMonto;
		private System.Windows.Forms.TextBox txtDetalles;
	}
}