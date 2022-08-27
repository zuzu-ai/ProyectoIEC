
namespace Proyecto_IEC
{
	partial class frmEmpleado
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleado));
			this.txtID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNombres = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtApellidos = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtDPI = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.cbxPuesto = new System.Windows.Forms.ComboBox();
			this.dtpContratacion = new System.Windows.Forms.DateTimePicker();
			this.dtpDespido = new System.Windows.Forms.DateTimePicker();
			this.panel1 = new System.Windows.Forms.Panel();
			this.rbnInactivo = new System.Windows.Forms.RadioButton();
			this.rbnActivo = new System.Windows.Forms.RadioButton();
			this.txtIdPuesto = new System.Windows.Forms.TextBox();
			this.txtEstado = new System.Windows.Forms.TextBox();
			this.txtContratacion = new System.Windows.Forms.TextBox();
			this.txtDespido = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtIdFoto = new System.Windows.Forms.TextBox();
			this.pbFoto = new System.Windows.Forms.PictureBox();
			this.btnAyuda = new System.Windows.Forms.Button();
			this.dgvVistaPrevia = new System.Windows.Forms.DataGridView();
			this.navegadorMantenimientos1 = new CapaVistaNavegador.NavegadorMantenimientos();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).BeginInit();
			this.SuspendLayout();
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(165, 83);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(200, 20);
			this.txtID.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(51, 83);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "ID de empleado:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(51, 137);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Nombres:";
			// 
			// txtNombres
			// 
			this.txtNombres.Location = new System.Drawing.Point(165, 135);
			this.txtNombres.Name = "txtNombres";
			this.txtNombres.Size = new System.Drawing.Size(200, 20);
			this.txtNombres.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label3.Location = new System.Drawing.Point(51, 163);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 16);
			this.label3.TabIndex = 6;
			this.label3.Text = "Apellidos:";
			// 
			// txtApellidos
			// 
			this.txtApellidos.Location = new System.Drawing.Point(166, 162);
			this.txtApellidos.Name = "txtApellidos";
			this.txtApellidos.Size = new System.Drawing.Size(199, 20);
			this.txtApellidos.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label4.Location = new System.Drawing.Point(50, 110);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 16);
			this.label4.TabIndex = 8;
			this.label4.Text = "Puesto:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label5.Location = new System.Drawing.Point(50, 188);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(33, 16);
			this.label5.TabIndex = 10;
			this.label5.Text = "DPI:";
			// 
			// txtDPI
			// 
			this.txtDPI.Location = new System.Drawing.Point(166, 188);
			this.txtDPI.Name = "txtDPI";
			this.txtDPI.Size = new System.Drawing.Size(199, 20);
			this.txtDPI.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label6.Location = new System.Drawing.Point(50, 213);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(86, 16);
			this.label6.TabIndex = 12;
			this.label6.Text = "Contratación:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label7.Location = new System.Drawing.Point(50, 240);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(63, 16);
			this.label7.TabIndex = 14;
			this.label7.Text = "Despido:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label8.Location = new System.Drawing.Point(50, 266);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(51, 16);
			this.label8.TabIndex = 16;
			this.label8.Text = "Estado";
			// 
			// cbxPuesto
			// 
			this.cbxPuesto.FormattingEnabled = true;
			this.cbxPuesto.Location = new System.Drawing.Point(165, 109);
			this.cbxPuesto.Name = "cbxPuesto";
			this.cbxPuesto.Size = new System.Drawing.Size(200, 21);
			this.cbxPuesto.TabIndex = 17;
			// 
			// dtpContratacion
			// 
			this.dtpContratacion.Location = new System.Drawing.Point(165, 213);
			this.dtpContratacion.Name = "dtpContratacion";
			this.dtpContratacion.Size = new System.Drawing.Size(200, 20);
			this.dtpContratacion.TabIndex = 18;
			// 
			// dtpDespido
			// 
			this.dtpDespido.Location = new System.Drawing.Point(165, 239);
			this.dtpDespido.Name = "dtpDespido";
			this.dtpDespido.Size = new System.Drawing.Size(200, 20);
			this.dtpDespido.TabIndex = 19;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.rbnInactivo);
			this.panel1.Controls.Add(this.rbnActivo);
			this.panel1.Location = new System.Drawing.Point(165, 265);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 28);
			this.panel1.TabIndex = 20;
			// 
			// rbnInactivo
			// 
			this.rbnInactivo.AutoSize = true;
			this.rbnInactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbnInactivo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.rbnInactivo.Location = new System.Drawing.Point(104, 1);
			this.rbnInactivo.Name = "rbnInactivo";
			this.rbnInactivo.Size = new System.Drawing.Size(72, 20);
			this.rbnInactivo.TabIndex = 1;
			this.rbnInactivo.TabStop = true;
			this.rbnInactivo.Text = "Inactivo";
			this.rbnInactivo.UseVisualStyleBackColor = true;
			// 
			// rbnActivo
			// 
			this.rbnActivo.AutoSize = true;
			this.rbnActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbnActivo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.rbnActivo.Location = new System.Drawing.Point(31, 1);
			this.rbnActivo.Name = "rbnActivo";
			this.rbnActivo.Size = new System.Drawing.Size(63, 20);
			this.rbnActivo.TabIndex = 0;
			this.rbnActivo.TabStop = true;
			this.rbnActivo.Text = "Activo";
			this.rbnActivo.UseVisualStyleBackColor = true;
			// 
			// txtIdPuesto
			// 
			this.txtIdPuesto.Location = new System.Drawing.Point(371, 110);
			this.txtIdPuesto.Name = "txtIdPuesto";
			this.txtIdPuesto.Size = new System.Drawing.Size(39, 20);
			this.txtIdPuesto.TabIndex = 21;
			this.txtIdPuesto.Visible = false;
			// 
			// txtEstado
			// 
			this.txtEstado.Location = new System.Drawing.Point(371, 263);
			this.txtEstado.Name = "txtEstado";
			this.txtEstado.Size = new System.Drawing.Size(39, 20);
			this.txtEstado.TabIndex = 22;
			this.txtEstado.Visible = false;
			// 
			// txtContratacion
			// 
			this.txtContratacion.Location = new System.Drawing.Point(371, 213);
			this.txtContratacion.Name = "txtContratacion";
			this.txtContratacion.Size = new System.Drawing.Size(39, 20);
			this.txtContratacion.TabIndex = 23;
			this.txtContratacion.Visible = false;
			// 
			// txtDespido
			// 
			this.txtDespido.Location = new System.Drawing.Point(371, 239);
			this.txtDespido.Name = "txtDespido";
			this.txtDespido.Size = new System.Drawing.Size(39, 20);
			this.txtDespido.TabIndex = 24;
			this.txtDespido.Visible = false;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label9.Location = new System.Drawing.Point(574, 56);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(69, 16);
			this.label9.TabIndex = 97;
			this.label9.Text = "Fotografía";
			// 
			// txtIdFoto
			// 
			this.txtIdFoto.Location = new System.Drawing.Point(694, 273);
			this.txtIdFoto.Name = "txtIdFoto";
			this.txtIdFoto.Size = new System.Drawing.Size(32, 20);
			this.txtIdFoto.TabIndex = 95;
			this.txtIdFoto.Tag = "fotografia";
			this.txtIdFoto.Visible = false;
			// 
			// pbFoto
			// 
			this.pbFoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbFoto.BackgroundImage")));
			this.pbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pbFoto.Cursor = System.Windows.Forms.Cursors.Default;
			this.pbFoto.Location = new System.Drawing.Point(524, 83);
			this.pbFoto.Name = "pbFoto";
			this.pbFoto.Size = new System.Drawing.Size(164, 210);
			this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbFoto.TabIndex = 96;
			this.pbFoto.TabStop = false;
			// 
			// btnAyuda
			// 
			this.btnAyuda.BackColor = System.Drawing.Color.Transparent;
			this.btnAyuda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAyuda.BackgroundImage")));
			this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnAyuda.FlatAppearance.BorderSize = 0;
			this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAyuda.Location = new System.Drawing.Point(667, 0);
			this.btnAyuda.Margin = new System.Windows.Forms.Padding(0);
			this.btnAyuda.Name = "btnAyuda";
			this.btnAyuda.Size = new System.Drawing.Size(50, 50);
			this.btnAyuda.TabIndex = 98;
			this.btnAyuda.UseVisualStyleBackColor = false;
			// 
			// dgvVistaPrevia
			// 
			this.dgvVistaPrevia.AllowUserToAddRows = false;
			this.dgvVistaPrevia.AllowUserToDeleteRows = false;
			this.dgvVistaPrevia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVistaPrevia.Location = new System.Drawing.Point(20, 299);
			this.dgvVistaPrevia.Name = "dgvVistaPrevia";
			this.dgvVistaPrevia.ReadOnly = true;
			this.dgvVistaPrevia.RowHeadersWidth = 51;
			this.dgvVistaPrevia.Size = new System.Drawing.Size(726, 311);
			this.dgvVistaPrevia.TabIndex = 99;
			// 
			// navegadorMantenimientos1
			// 
			this.navegadorMantenimientos1.BackColor = System.Drawing.Color.Transparent;
			this.navegadorMantenimientos1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.navegadorMantenimientos1.Location = new System.Drawing.Point(54, 0);
			this.navegadorMantenimientos1.Name = "navegadorMantenimientos1";
			this.navegadorMantenimientos1.Size = new System.Drawing.Size(610, 53);
			this.navegadorMantenimientos1.TabIndex = 25;
			// 
			// frmEmpleado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(763, 622);
			this.Controls.Add(this.dgvVistaPrevia);
			this.Controls.Add(this.btnAyuda);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtIdFoto);
			this.Controls.Add(this.pbFoto);
			this.Controls.Add(this.navegadorMantenimientos1);
			this.Controls.Add(this.txtDespido);
			this.Controls.Add(this.txtContratacion);
			this.Controls.Add(this.txtEstado);
			this.Controls.Add(this.txtIdPuesto);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dtpDespido);
			this.Controls.Add(this.dtpContratacion);
			this.Controls.Add(this.cbxPuesto);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtDPI);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtApellidos);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtNombres);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtID);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmEmpleado";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Empleado";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNombres;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtApellidos;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtDPI;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cbxPuesto;
		private System.Windows.Forms.DateTimePicker dtpContratacion;
		private System.Windows.Forms.DateTimePicker dtpDespido;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton rbnInactivo;
		private System.Windows.Forms.RadioButton rbnActivo;
		private System.Windows.Forms.TextBox txtIdPuesto;
		private System.Windows.Forms.TextBox txtEstado;
		private System.Windows.Forms.TextBox txtContratacion;
		private System.Windows.Forms.TextBox txtDespido;
        private CapaVistaNavegador.NavegadorMantenimientos navegadorMantenimientos1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIdFoto;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.DataGridView dgvVistaPrevia;
    }
}