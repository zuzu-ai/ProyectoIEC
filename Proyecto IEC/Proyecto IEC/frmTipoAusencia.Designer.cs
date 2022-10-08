
namespace Proyecto_IEC
{
    partial class frmTipoAusencia
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoAusencia));
			this.txtEstado = new System.Windows.Forms.TextBox();
			this.txtNombres = new System.Windows.Forms.TextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.rbnEstatusimodulo = new System.Windows.Forms.RadioButton();
			this.rbnEstatusamodulo = new System.Windows.Forms.RadioButton();
			this.label8 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvVistaPrevia = new System.Windows.Forms.DataGridView();
			this.navegadorMantenimientos1 = new CapaVistaNavegador.NavegadorMantenimientos();
			this.btnImprimir = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).BeginInit();
			this.SuspendLayout();
			// 
			// txtEstado
			// 
			this.txtEstado.Location = new System.Drawing.Point(456, 116);
			this.txtEstado.Name = "txtEstado";
			this.txtEstado.Size = new System.Drawing.Size(39, 20);
			this.txtEstado.TabIndex = 124;
			this.txtEstado.Tag = "estado";
			this.txtEstado.Visible = false;
			this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
			// 
			// txtNombres
			// 
			this.txtNombres.Location = new System.Drawing.Point(175, 92);
			this.txtNombres.Name = "txtNombres";
			this.txtNombres.Size = new System.Drawing.Size(268, 20);
			this.txtNombres.TabIndex = 118;
			this.txtNombres.Tag = "nombre";
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(175, 66);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(268, 20);
			this.txtID.TabIndex = 117;
			this.txtID.Tag = "pkid";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.rbnEstatusimodulo);
			this.panel1.Controls.Add(this.rbnEstatusamodulo);
			this.panel1.Location = new System.Drawing.Point(175, 118);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 28);
			this.panel1.TabIndex = 123;
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
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label8.Location = new System.Drawing.Point(23, 117);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(51, 16);
			this.label8.TabIndex = 122;
			this.label8.Text = "Estado";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(23, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(150, 16);
			this.label2.TabIndex = 121;
			this.label2.Text = "Nombre del dispositivo:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(23, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(111, 16);
			this.label1.TabIndex = 120;
			this.label1.Text = "ID de dispositivo:";
			// 
			// dgvVistaPrevia
			// 
			this.dgvVistaPrevia.AllowUserToAddRows = false;
			this.dgvVistaPrevia.AllowUserToDeleteRows = false;
			this.dgvVistaPrevia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvVistaPrevia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvVistaPrevia.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
			this.dgvVistaPrevia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVistaPrevia.Location = new System.Drawing.Point(12, 167);
			this.dgvVistaPrevia.Name = "dgvVistaPrevia";
			this.dgvVistaPrevia.ReadOnly = true;
			this.dgvVistaPrevia.RowHeadersWidth = 51;
			this.dgvVistaPrevia.Size = new System.Drawing.Size(646, 271);
			this.dgvVistaPrevia.TabIndex = 119;
			this.dgvVistaPrevia.SelectionChanged += new System.EventHandler(this.dgvVistaPrevia_SelectionChanged);
			// 
			// navegadorMantenimientos1
			// 
			this.navegadorMantenimientos1.BackColor = System.Drawing.Color.Transparent;
			this.navegadorMantenimientos1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.navegadorMantenimientos1.Location = new System.Drawing.Point(12, 11);
			this.navegadorMantenimientos1.Name = "navegadorMantenimientos1";
			this.navegadorMantenimientos1.Size = new System.Drawing.Size(658, 49);
			this.navegadorMantenimientos1.TabIndex = 125;
			// 
			// btnImprimir
			// 
			this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
			this.btnImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImprimir.BackgroundImage")));
			this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnImprimir.FlatAppearance.BorderSize = 0;
			this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnImprimir.Location = new System.Drawing.Point(259, 9);
			this.btnImprimir.Margin = new System.Windows.Forms.Padding(0);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(50, 50);
			this.btnImprimir.TabIndex = 127;
			this.btnImprimir.UseVisualStyleBackColor = false;
			this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
			// 
			// frmTipoAusencia
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(670, 450);
			this.Controls.Add(this.btnImprimir);
			this.Controls.Add(this.txtEstado);
			this.Controls.Add(this.txtNombres);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.navegadorMantenimientos1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvVistaPrevia);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(686, 489);
			this.Name = "frmTipoAusencia";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tipo de ausencia";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbnEstatusimodulo;
        private System.Windows.Forms.RadioButton rbnEstatusamodulo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvVistaPrevia;
        private CapaVistaNavegador.NavegadorMantenimientos navegadorMantenimientos1;
		private System.Windows.Forms.Button btnImprimir;
	}
}