/*
 * Creado por SharpDevelop.
 * Usuario: isis0
 * Fecha: 17/2/2025
 * Hora: 4:42 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace login
{
	partial class Form2
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnRegistrar;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button consultarbt;
		private System.Windows.Forms.Button volverbt;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.TextBox txtEmpresa;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtRIF;
		private System.Windows.Forms.TextBox txtDireccion;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtAuditoria;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dtpInicio;
		private System.Windows.Forms.DateTimePicker dtpFin;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.consultarbt = new System.Windows.Forms.Button();
			this.volverbt = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.txtEmpresa = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtRIF = new System.Windows.Forms.TextBox();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtAuditoria = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.dtpInicio = new System.Windows.Forms.DateTimePicker();
			this.dtpFin = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistrar.Location = new System.Drawing.Point(177, 410);
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.Size = new System.Drawing.Size(89, 30);
			this.btnRegistrar.TabIndex = 0;
			this.btnRegistrar.Text = "Registar";
			this.btnRegistrar.UseVisualStyleBackColor = false;
			this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrarClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.Location = new System.Drawing.Point(188, 44);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(439, 116);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// consultarbt
			// 
			this.consultarbt.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.consultarbt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.consultarbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.consultarbt.Location = new System.Drawing.Point(285, 410);
			this.consultarbt.Name = "consultarbt";
			this.consultarbt.Size = new System.Drawing.Size(89, 30);
			this.consultarbt.TabIndex = 2;
			this.consultarbt.Text = "Consultar";
			this.consultarbt.UseVisualStyleBackColor = false;
			this.consultarbt.Click += new System.EventHandler(this.ConsultarbtClick);
			// 
			// volverbt
			// 
			this.volverbt.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.volverbt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.volverbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.volverbt.Location = new System.Drawing.Point(611, 410);
			this.volverbt.Name = "volverbt";
			this.volverbt.Size = new System.Drawing.Size(89, 30);
			this.volverbt.TabIndex = 3;
			this.volverbt.Text = "Volver";
			this.volverbt.UseVisualStyleBackColor = false;
			this.volverbt.Click += new System.EventHandler(this.VolverbtClick);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpiar.Location = new System.Drawing.Point(500, 410);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(89, 30);
			this.btnLimpiar.TabIndex = 4;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = false;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// btnActualizar
			// 
			this.btnActualizar.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnActualizar.Location = new System.Drawing.Point(393, 410);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(89, 30);
			this.btnActualizar.TabIndex = 5;
			this.btnActualizar.Text = "Actualizar";
			this.btnActualizar.UseVisualStyleBackColor = false;
			this.btnActualizar.Click += new System.EventHandler(this.BtnActualizarClick);
			// 
			// txtEmpresa
			// 
			this.txtEmpresa.Location = new System.Drawing.Point(31, 243);
			this.txtEmpresa.Multiline = true;
			this.txtEmpresa.Name = "txtEmpresa";
			this.txtEmpresa.Size = new System.Drawing.Size(189, 25);
			this.txtEmpresa.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(31, 217);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(218, 23);
			this.label1.TabIndex = 7;
			this.label1.Text = "Nombre de la empresa :";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(285, 217);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 23);
			this.label2.TabIndex = 8;
			this.label2.Text = "RIF :";
			// 
			// txtRIF
			// 
			this.txtRIF.Location = new System.Drawing.Point(285, 243);
			this.txtRIF.Multiline = true;
			this.txtRIF.Name = "txtRIF";
			this.txtRIF.Size = new System.Drawing.Size(155, 25);
			this.txtRIF.TabIndex = 9;
			// 
			// txtDireccion
			// 
			this.txtDireccion.Location = new System.Drawing.Point(563, 243);
			this.txtDireccion.Multiline = true;
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(241, 25);
			this.txtDireccion.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(561, 217);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(218, 23);
			this.label3.TabIndex = 11;
			this.label3.Text = "Direción de la empresa :";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(31, 317);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(175, 23);
			this.label4.TabIndex = 12;
			this.label4.Text = "Sistema de gestión :";
			// 
			// txtAuditoria
			// 
			this.txtAuditoria.Location = new System.Drawing.Point(31, 343);
			this.txtAuditoria.Multiline = true;
			this.txtAuditoria.Name = "txtAuditoria";
			this.txtAuditoria.Size = new System.Drawing.Size(189, 25);
			this.txtAuditoria.TabIndex = 13;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(276, 317);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(186, 23);
			this.label5.TabIndex = 14;
			this.label5.Text = "Fecha inicio";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(561, 321);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(218, 23);
			this.label6.TabIndex = 15;
			this.label6.Text = "Fecha finalizacion";
			// 
			// dtpInicio
			// 
			this.dtpInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpInicio.Location = new System.Drawing.Point(276, 347);
			this.dtpInicio.MaxDate = new System.DateTime(2028, 12, 31, 0, 0, 0, 0);
			this.dtpInicio.MinDate = new System.DateTime(2025, 2, 17, 0, 0, 0, 0);
			this.dtpInicio.Name = "dtpInicio";
			this.dtpInicio.Size = new System.Drawing.Size(243, 21);
			this.dtpInicio.TabIndex = 16;
			// 
			// dtpFin
			// 
			this.dtpFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFin.Location = new System.Drawing.Point(563, 347);
			this.dtpFin.MaxDate = new System.DateTime(2028, 12, 31, 0, 0, 0, 0);
			this.dtpFin.MinDate = new System.DateTime(2025, 2, 17, 0, 0, 0, 0);
			this.dtpFin.Name = "dtpFin";
			this.dtpFin.Size = new System.Drawing.Size(243, 21);
			this.dtpFin.TabIndex = 17;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(834, 481);
			this.Controls.Add(this.dtpFin);
			this.Controls.Add(this.dtpInicio);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtAuditoria);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtDireccion);
			this.Controls.Add(this.txtRIF);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtEmpresa);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.volverbt);
			this.Controls.Add(this.consultarbt);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnRegistrar);
			this.Name = "Form1";
			this.Text = "AUDITPRO";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
