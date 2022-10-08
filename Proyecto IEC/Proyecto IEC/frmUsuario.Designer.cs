
namespace Proyecto_IEC
{
    partial class frmUsuario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbnEstatusimodulo = new System.Windows.Forms.RadioButton();
            this.rbnEstatusamodulo = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvVistaPrevia = new System.Windows.Forms.DataGridView();
            this.txtIDPregunta = new System.Windows.Forms.TextBox();
            this.cbxPregunta = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxEmpleado = new System.Windows.Forms.ComboBox();
            this.txtIDEmpleado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxTipoUsuario = new System.Windows.Forms.ComboBox();
            this.txtIDTipoUsuario = new System.Windows.Forms.TextBox();
            this.btnPassword = new System.Windows.Forms.Button();
            this.btnPasswordn = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mtxtContraseña = new System.Windows.Forms.MaskedTextBox();
            this.tpMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.btnImprimir = new System.Windows.Forms.Button();
            this.mtxtConfirmarContraseña = new System.Windows.Forms.MaskedTextBox();
            this.navegadorMantenimientos1 = new CapaVistaNavegador.NavegadorMantenimientos();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(433, 199);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(39, 20);
            this.txtEstado.TabIndex = 126;
            this.txtEstado.Tag = "estado";
            this.txtEstado.Visible = false;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(152, 159);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(268, 20);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.Tag = "usuario";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(152, 77);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(268, 20);
            this.txtID.TabIndex = 118;
            this.txtID.Tag = "pkid";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.rbnEstatusimodulo);
            this.panel1.Controls.Add(this.rbnEstatusamodulo);
            this.panel1.Location = new System.Drawing.Point(152, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 28);
            this.panel1.TabIndex = 125;
            // 
            // rbnEstatusimodulo
            // 
            this.rbnEstatusimodulo.AutoSize = true;
            this.rbnEstatusimodulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnEstatusimodulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbnEstatusimodulo.Location = new System.Drawing.Point(100, 1);
            this.rbnEstatusimodulo.Name = "rbnEstatusimodulo";
            this.rbnEstatusimodulo.Size = new System.Drawing.Size(72, 20);
            this.rbnEstatusimodulo.TabIndex = 9;
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
            this.rbnEstatusamodulo.TabIndex = 8;
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
            this.label8.Location = new System.Drawing.Point(23, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 124;
            this.label8.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(23, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 123;
            this.label2.Text = "Nombre de usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(23, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 121;
            this.label1.Text = "ID de usuario:";
            // 
            // dgvVistaPrevia
            // 
            this.dgvVistaPrevia.AllowUserToAddRows = false;
            this.dgvVistaPrevia.AllowUserToDeleteRows = false;
            this.dgvVistaPrevia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVistaPrevia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVistaPrevia.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvVistaPrevia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVistaPrevia.Location = new System.Drawing.Point(12, 235);
            this.dgvVistaPrevia.Name = "dgvVistaPrevia";
            this.dgvVistaPrevia.ReadOnly = true;
            this.dgvVistaPrevia.RowHeadersWidth = 51;
            this.dgvVistaPrevia.Size = new System.Drawing.Size(880, 282);
            this.dgvVistaPrevia.TabIndex = 120;
            this.dgvVistaPrevia.SelectionChanged += new System.EventHandler(this.dgvVistaPrevia_SelectionChanged);
            // 
            // txtIDPregunta
            // 
            this.txtIDPregunta.Location = new System.Drawing.Point(607, 132);
            this.txtIDPregunta.Name = "txtIDPregunta";
            this.txtIDPregunta.Size = new System.Drawing.Size(268, 20);
            this.txtIDPregunta.TabIndex = 129;
            this.txtIDPregunta.TabStop = false;
            this.txtIDPregunta.Tag = "fkpregunta";
            this.txtIDPregunta.Visible = false;
            this.txtIDPregunta.TextChanged += new System.EventHandler(this.txtIDPregunta_TextChanged);
            // 
            // cbxPregunta
            // 
            this.cbxPregunta.FormattingEnabled = true;
            this.cbxPregunta.Location = new System.Drawing.Point(607, 132);
            this.cbxPregunta.Name = "cbxPregunta";
            this.cbxPregunta.Size = new System.Drawing.Size(268, 21);
            this.cbxPregunta.TabIndex = 6;
            this.cbxPregunta.SelectedIndexChanged += new System.EventHandler(this.cbxPregunta_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(478, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 128;
            this.label4.Text = "Pregunta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(23, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 128;
            this.label3.Text = "Empleado:";
            // 
            // cbxEmpleado
            // 
            this.cbxEmpleado.FormattingEnabled = true;
            this.cbxEmpleado.Location = new System.Drawing.Point(152, 132);
            this.cbxEmpleado.Name = "cbxEmpleado";
            this.cbxEmpleado.Size = new System.Drawing.Size(268, 21);
            this.cbxEmpleado.TabIndex = 2;
            this.cbxEmpleado.SelectedIndexChanged += new System.EventHandler(this.cbxEmpleado_SelectedIndexChanged);
            // 
            // txtIDEmpleado
            // 
            this.txtIDEmpleado.Location = new System.Drawing.Point(433, 133);
            this.txtIDEmpleado.Name = "txtIDEmpleado";
            this.txtIDEmpleado.Size = new System.Drawing.Size(39, 20);
            this.txtIDEmpleado.TabIndex = 129;
            this.txtIDEmpleado.TabStop = false;
            this.txtIDEmpleado.Tag = "fkempleado";
            this.txtIDEmpleado.Visible = false;
            this.txtIDEmpleado.TextChanged += new System.EventHandler(this.txtIDEmpleado_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(478, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 123;
            this.label5.Text = "Conrtraseña:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(478, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 123;
            this.label6.Text = "Confirmar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(478, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 123;
            this.label7.Text = "Respuesta:";
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Location = new System.Drawing.Point(607, 160);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(268, 20);
            this.txtRespuesta.TabIndex = 7;
            this.txtRespuesta.Tag = "repuesta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(23, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 16);
            this.label9.TabIndex = 128;
            this.label9.Text = "Tipo usuario:";
            // 
            // cbxTipoUsuario
            // 
            this.cbxTipoUsuario.FormattingEnabled = true;
            this.cbxTipoUsuario.Location = new System.Drawing.Point(152, 103);
            this.cbxTipoUsuario.Name = "cbxTipoUsuario";
            this.cbxTipoUsuario.Size = new System.Drawing.Size(268, 21);
            this.cbxTipoUsuario.TabIndex = 1;
            this.cbxTipoUsuario.SelectedIndexChanged += new System.EventHandler(this.cbxTipoUsuario_SelectedIndexChanged);
            // 
            // txtIDTipoUsuario
            // 
            this.txtIDTipoUsuario.Location = new System.Drawing.Point(433, 104);
            this.txtIDTipoUsuario.Name = "txtIDTipoUsuario";
            this.txtIDTipoUsuario.Size = new System.Drawing.Size(39, 20);
            this.txtIDTipoUsuario.TabIndex = 129;
            this.txtIDTipoUsuario.TabStop = false;
            this.txtIDTipoUsuario.Tag = "fktipousuario";
            this.txtIDTipoUsuario.Visible = false;
            this.txtIDTipoUsuario.TextChanged += new System.EventHandler(this.txtIDTipoUsuario_TextChanged);
            // 
            // btnPassword
            // 
            this.btnPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPassword.BackgroundImage")));
            this.btnPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPassword.FlatAppearance.BorderSize = 0;
            this.btnPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassword.Location = new System.Drawing.Point(878, 70);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(19, 19);
            this.btnPassword.TabIndex = 132;
            this.btnPassword.TabStop = false;
            this.btnPassword.UseVisualStyleBackColor = false;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // btnPasswordn
            // 
            this.btnPasswordn.BackColor = System.Drawing.Color.Transparent;
            this.btnPasswordn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPasswordn.BackgroundImage")));
            this.btnPasswordn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPasswordn.FlatAppearance.BorderSize = 0;
            this.btnPasswordn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasswordn.Location = new System.Drawing.Point(878, 70);
            this.btnPasswordn.Name = "btnPasswordn";
            this.btnPasswordn.Size = new System.Drawing.Size(19, 19);
            this.btnPasswordn.TabIndex = 131;
            this.btnPasswordn.TabStop = false;
            this.btnPasswordn.UseVisualStyleBackColor = false;
            this.btnPasswordn.Visible = false;
            this.btnPasswordn.Click += new System.EventHandler(this.btnPasswordn_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.White;
            this.txtContraseña.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtContraseña.Location = new System.Drawing.Point(607, 68);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(268, 26);
            this.txtContraseña.TabIndex = 130;
            this.txtContraseña.Tag = "contrasena";
            this.txtContraseña.Text = "Nombre usuario";
            this.txtContraseña.UseSystemPasswordChar = true;
            this.txtContraseña.Visible = false;
            this.txtContraseña.EnabledChanged += new System.EventHandler(this.txtContraseña_EnabledChanged);
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(478, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 16);
            this.label10.TabIndex = 123;
            this.label10.Text = "Conrtraseña:";
            // 
            // mtxtContraseña
            // 
            this.mtxtContraseña.Location = new System.Drawing.Point(607, 70);
            this.mtxtContraseña.Name = "mtxtContraseña";
            this.mtxtContraseña.Size = new System.Drawing.Size(268, 20);
            this.mtxtContraseña.TabIndex = 4;
            this.mtxtContraseña.Tag = "tag";
            this.mtxtContraseña.UseSystemPasswordChar = true;
            // 
            // tpMensaje
            // 
            this.tpMensaje.BackColor = System.Drawing.Color.LightBlue;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImprimir.BackgroundImage")));
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Location = new System.Drawing.Point(249, 1);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(0);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(50, 50);
            this.btnImprimir.TabIndex = 133;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // mtxtConfirmarContraseña
            // 
            this.mtxtConfirmarContraseña.Location = new System.Drawing.Point(607, 103);
            this.mtxtConfirmarContraseña.Name = "mtxtConfirmarContraseña";
            this.mtxtConfirmarContraseña.Size = new System.Drawing.Size(268, 20);
            this.mtxtConfirmarContraseña.TabIndex = 5;
            this.mtxtConfirmarContraseña.Tag = "tag1";
            this.mtxtConfirmarContraseña.UseSystemPasswordChar = true;
            this.mtxtConfirmarContraseña.Leave += new System.EventHandler(this.mtxtConfirmarContraseña_Leave);
            // 
            // navegadorMantenimientos1
            // 
            this.navegadorMantenimientos1.BackColor = System.Drawing.Color.Transparent;
            this.navegadorMantenimientos1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.navegadorMantenimientos1.Location = new System.Drawing.Point(2, 2);
            this.navegadorMantenimientos1.Name = "navegadorMantenimientos1";
            this.navegadorMantenimientos1.Size = new System.Drawing.Size(658, 49);
            this.navegadorMantenimientos1.TabIndex = 122;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(904, 529);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtRespuesta);
            this.Controls.Add(this.txtIDPregunta);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtIDEmpleado);
            this.Controls.Add(this.txtIDTipoUsuario);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.mtxtContraseña);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.mtxtConfirmarContraseña);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.btnPasswordn);
            this.Controls.Add(this.cbxTipoUsuario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxEmpleado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxPregunta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.navegadorMantenimientos1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVistaPrevia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(920, 568);
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbnEstatusimodulo;
        private System.Windows.Forms.RadioButton rbnEstatusamodulo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private CapaVistaNavegador.NavegadorMantenimientos navegadorMantenimientos1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvVistaPrevia;
        private System.Windows.Forms.TextBox txtIDPregunta;
        private System.Windows.Forms.ComboBox cbxPregunta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxEmpleado;
        private System.Windows.Forms.TextBox txtIDEmpleado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxTipoUsuario;
        private System.Windows.Forms.TextBox txtIDTipoUsuario;
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.Button btnPasswordn;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mtxtContraseña;
        private System.Windows.Forms.ToolTip tpMensaje;
		private System.Windows.Forms.Button btnImprimir;
		private System.Windows.Forms.MaskedTextBox mtxtConfirmarContraseña;
    }
}