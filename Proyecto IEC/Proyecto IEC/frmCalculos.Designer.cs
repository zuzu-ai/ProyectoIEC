
namespace Proyecto_IEC
{
	partial class frmCalculos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculos));
			this.btnExportar = new System.Windows.Forms.Button();
			this.dgvVistaPrevia = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.txtFechatrabajada = new System.Windows.Forms.TextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).BeginInit();
			this.SuspendLayout();
			// 
			// btnExportar
			// 
			this.btnExportar.BackColor = System.Drawing.Color.Transparent;
			this.btnExportar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExportar.BackgroundImage")));
			this.btnExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnExportar.FlatAppearance.BorderSize = 0;
			this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExportar.Location = new System.Drawing.Point(733, -2);
			this.btnExportar.Margin = new System.Windows.Forms.Padding(0);
			this.btnExportar.Name = "btnExportar";
			this.btnExportar.Size = new System.Drawing.Size(50, 50);
			this.btnExportar.TabIndex = 104;
			this.btnExportar.UseVisualStyleBackColor = false;
			this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
			// 
			// dgvVistaPrevia
			// 
			this.dgvVistaPrevia.AllowUserToAddRows = false;
			this.dgvVistaPrevia.AllowUserToDeleteRows = false;
			this.dgvVistaPrevia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvVistaPrevia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVistaPrevia.Location = new System.Drawing.Point(12, 51);
			this.dgvVistaPrevia.Name = "dgvVistaPrevia";
			this.dgvVistaPrevia.RowHeadersWidth = 51;
			this.dgvVistaPrevia.Size = new System.Drawing.Size(776, 387);
			this.dgvVistaPrevia.TabIndex = 103;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 105;
			this.label1.Text = "Fecha:";
			// 
			// txtFechatrabajada
			// 
			this.txtFechatrabajada.Location = new System.Drawing.Point(58, 25);
			this.txtFechatrabajada.Name = "txtFechatrabajada";
			this.txtFechatrabajada.Size = new System.Drawing.Size(155, 20);
			this.txtFechatrabajada.TabIndex = 106;
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(58, 1);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(155, 20);
			this.txtID.TabIndex = 108;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 4);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(21, 13);
			this.label2.TabIndex = 107;
			this.label2.Text = "ID:";
			// 
			// frmCalculos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtFechatrabajada);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnExportar);
			this.Controls.Add(this.dgvVistaPrevia);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmCalculos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Calcular Horas";
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnExportar;
		private System.Windows.Forms.DataGridView dgvVistaPrevia;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtFechatrabajada;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Label label2;
	}
}