
namespace Proyecto_IEC
{
    partial class frmImportarArchivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportarArchivo));
            this.dgvVistaPrevia = new System.Windows.Forms.DataGridView();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.txtNombreHoja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCnacelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVistaPrevia
            // 
            this.dgvVistaPrevia.AllowUserToAddRows = false;
            this.dgvVistaPrevia.AllowUserToDeleteRows = false;
            this.dgvVistaPrevia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVistaPrevia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVistaPrevia.Location = new System.Drawing.Point(12, 62);
            this.dgvVistaPrevia.Name = "dgvVistaPrevia";
            this.dgvVistaPrevia.ReadOnly = true;
            this.dgvVistaPrevia.RowHeadersWidth = 51;
            this.dgvVistaPrevia.Size = new System.Drawing.Size(709, 401);
            this.dgvVistaPrevia.TabIndex = 100;
            // 
            // btnImportar
            // 
            this.btnImportar.BackColor = System.Drawing.Color.Transparent;
            this.btnImportar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImportar.BackgroundImage")));
            this.btnImportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImportar.FlatAppearance.BorderSize = 0;
            this.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportar.Location = new System.Drawing.Point(506, 9);
            this.btnImportar.Margin = new System.Windows.Forms.Padding(0);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(50, 50);
            this.btnImportar.TabIndex = 101;
            this.btnImportar.UseVisualStyleBackColor = false;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.Transparent;
            this.btnExportar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExportar.BackgroundImage")));
            this.btnExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Location = new System.Drawing.Point(606, 9);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(0);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(50, 50);
            this.btnExportar.TabIndex = 102;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // txtNombreHoja
            // 
            this.txtNombreHoja.Location = new System.Drawing.Point(190, 26);
            this.txtNombreHoja.Name = "txtNombreHoja";
            this.txtNombreHoja.Size = new System.Drawing.Size(301, 20);
            this.txtNombreHoja.TabIndex = 103;
            this.txtNombreHoja.Text = "Sheet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 104;
            this.label1.Text = "Nombre de la hoja:";
            // 
            // btnCnacelar
            // 
            this.btnCnacelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCnacelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCnacelar.BackgroundImage")));
            this.btnCnacelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCnacelar.FlatAppearance.BorderSize = 0;
            this.btnCnacelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCnacelar.Location = new System.Drawing.Point(556, 9);
            this.btnCnacelar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCnacelar.Name = "btnCnacelar";
            this.btnCnacelar.Size = new System.Drawing.Size(50, 50);
            this.btnCnacelar.TabIndex = 102;
            this.btnCnacelar.UseVisualStyleBackColor = false;
            this.btnCnacelar.Click += new System.EventHandler(this.btnCnacelar_Click);
            // 
            // frmImportarArchivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 475);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreHoja);
            this.Controls.Add(this.btnCnacelar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.dgvVistaPrevia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmImportarArchivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importar archivo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVistaPrevia;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.TextBox txtNombreHoja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCnacelar;
    }
}