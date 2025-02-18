/*
 * Creado por SharpDevelop.
 * Usuario: isis0
 * Fecha: 18/2/2025
 * Hora: 2:24 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace login
{
	partial class FrmGestionProcesos
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ListBox lstDescripcion;
		private System.Windows.Forms.ComboBox cmbAuditor;
		private System.Windows.Forms.ComboBox cmbSistema;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.TextBox txtResultados;
		private System.Windows.Forms.CheckBox chkFalla;
		private System.Windows.Forms.DateTimePicker dtpFechainicio;
		private System.Windows.Forms.DateTimePicker dtpFechaFin;
		private System.Windows.Forms.NumericUpDown numHoras;
		private System.Windows.Forms.Button btnRegistrar;
		private System.Windows.Forms.Button volverbt;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnVerTodos;
		private System.Windows.Forms.Button btnConsultarFecha;
		private System.Windows.Forms.Button btnConsultarAuditor;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionProcesos));
			this.lstDescripcion = new System.Windows.Forms.ListBox();
			this.cmbAuditor = new System.Windows.Forms.ComboBox();
			this.cmbSistema = new System.Windows.Forms.ComboBox();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.txtResultados = new System.Windows.Forms.TextBox();
			this.chkFalla = new System.Windows.Forms.CheckBox();
			this.dtpFechainicio = new System.Windows.Forms.DateTimePicker();
			this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
			this.numHoras = new System.Windows.Forms.NumericUpDown();
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.volverbt = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnVerTodos = new System.Windows.Forms.Button();
			this.btnConsultarFecha = new System.Windows.Forms.Button();
			this.btnConsultarAuditor = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numHoras)).BeginInit();
			this.SuspendLayout();
			// 
			// lstDescripcion
			// 
			this.lstDescripcion.FormattingEnabled = true;
			this.lstDescripcion.Location = new System.Drawing.Point(248, 26);
			this.lstDescripcion.Name = "lstDescripcion";
			this.lstDescripcion.Size = new System.Drawing.Size(296, 17);
			this.lstDescripcion.TabIndex = 0;
			// 
			// cmbAuditor
			// 
			this.cmbAuditor.FormattingEnabled = true;
			this.cmbAuditor.Location = new System.Drawing.Point(248, 105);
			this.cmbAuditor.Name = "cmbAuditor";
			this.cmbAuditor.Size = new System.Drawing.Size(251, 21);
			this.cmbAuditor.TabIndex = 1;
			// 
			// cmbSistema
			// 
			this.cmbSistema.FormattingEnabled = true;
			this.cmbSistema.Location = new System.Drawing.Point(541, 107);
			this.cmbSistema.Name = "cmbSistema";
			this.cmbSistema.Size = new System.Drawing.Size(254, 21);
			this.cmbSistema.TabIndex = 2;
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(12, 107);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(207, 20);
			this.txtDescripcion.TabIndex = 3;
			// 
			// txtResultados
			// 
			this.txtResultados.Location = new System.Drawing.Point(541, 185);
			this.txtResultados.Name = "txtResultados";
			this.txtResultados.Size = new System.Drawing.Size(254, 20);
			this.txtResultados.TabIndex = 4;
			// 
			// chkFalla
			// 
			this.chkFalla.BackColor = System.Drawing.Color.Transparent;
			this.chkFalla.Location = new System.Drawing.Point(101, 250);
			this.chkFalla.Name = "chkFalla";
			this.chkFalla.Size = new System.Drawing.Size(16, 24);
			this.chkFalla.TabIndex = 5;
			this.chkFalla.UseVisualStyleBackColor = false;
			// 
			// dtpFechainicio
			// 
			this.dtpFechainicio.Location = new System.Drawing.Point(12, 185);
			this.dtpFechainicio.Name = "dtpFechainicio";
			this.dtpFechainicio.Size = new System.Drawing.Size(200, 20);
			this.dtpFechainicio.TabIndex = 6;
			// 
			// dtpFechaFin
			// 
			this.dtpFechaFin.Location = new System.Drawing.Point(254, 185);
			this.dtpFechaFin.Name = "dtpFechaFin";
			this.dtpFechaFin.Size = new System.Drawing.Size(200, 20);
			this.dtpFechaFin.TabIndex = 7;
			// 
			// numHoras
			// 
			this.numHoras.DecimalPlaces = 1;
			this.numHoras.Increment = new decimal(new int[] {
			5,
			0,
			0,
			0});
			this.numHoras.Location = new System.Drawing.Point(311, 250);
			this.numHoras.Name = "numHoras";
			this.numHoras.Size = new System.Drawing.Size(120, 20);
			this.numHoras.TabIndex = 11;
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnRegistrar.Location = new System.Drawing.Point(118, 347);
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
			this.btnRegistrar.TabIndex = 12;
			this.btnRegistrar.Text = "Resgitrar";
			this.btnRegistrar.UseVisualStyleBackColor = false;
			this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrarClick);
			// 
			// volverbt
			// 
			this.volverbt.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.volverbt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.volverbt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.volverbt.Location = new System.Drawing.Point(365, 381);
			this.volverbt.Name = "volverbt";
			this.volverbt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.volverbt.Size = new System.Drawing.Size(75, 23);
			this.volverbt.TabIndex = 13;
			this.volverbt.Text = "Volver";
			this.volverbt.UseVisualStyleBackColor = false;
			this.volverbt.Click += new System.EventHandler(this.VolverbtClick);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnLimpiar.Location = new System.Drawing.Point(571, 347);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
			this.btnLimpiar.TabIndex = 14;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = false;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// btnVerTodos
			// 
			this.btnVerTodos.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.btnVerTodos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnVerTodos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnVerTodos.Location = new System.Drawing.Point(473, 347);
			this.btnVerTodos.Name = "btnVerTodos";
			this.btnVerTodos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnVerTodos.Size = new System.Drawing.Size(75, 23);
			this.btnVerTodos.TabIndex = 15;
			this.btnVerTodos.Text = "Ver todo";
			this.btnVerTodos.UseVisualStyleBackColor = false;
			this.btnVerTodos.Click += new System.EventHandler(this.BtnVerTodosClick);
			// 
			// btnConsultarFecha
			// 
			this.btnConsultarFecha.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.btnConsultarFecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnConsultarFecha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnConsultarFecha.Location = new System.Drawing.Point(347, 347);
			this.btnConsultarFecha.Name = "btnConsultarFecha";
			this.btnConsultarFecha.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnConsultarFecha.Size = new System.Drawing.Size(107, 23);
			this.btnConsultarFecha.TabIndex = 16;
			this.btnConsultarFecha.Text = "Consultar fecha";
			this.btnConsultarFecha.UseVisualStyleBackColor = false;
			this.btnConsultarFecha.Click += new System.EventHandler(this.BtnConsultarFechaClick);
			// 
			// btnConsultarAuditor
			// 
			this.btnConsultarAuditor.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.btnConsultarAuditor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnConsultarAuditor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnConsultarAuditor.Location = new System.Drawing.Point(221, 347);
			this.btnConsultarAuditor.Name = "btnConsultarAuditor";
			this.btnConsultarAuditor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnConsultarAuditor.Size = new System.Drawing.Size(111, 23);
			this.btnConsultarAuditor.TabIndex = 17;
			this.btnConsultarAuditor.Text = "Consultar auditor";
			this.btnConsultarAuditor.UseVisualStyleBackColor = false;
			this.btnConsultarAuditor.Click += new System.EventHandler(this.BtnConsultarAuditorClick);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(12, 75);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(181, 20);
			this.label1.TabIndex = 18;
			this.label1.Text = "Descripción del proceso :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(248, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(172, 20);
			this.label3.TabIndex = 20;
			this.label3.Text = "Auditor responsable";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(296, 227);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(144, 20);
			this.label2.TabIndex = 21;
			this.label2.Text = "Cantidad de horas";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.label4.Location = new System.Drawing.Point(12, 162);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(138, 20);
			this.label4.TabIndex = 22;
			this.label4.Text = "Fecha del proceso";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(541, 162);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(172, 20);
			this.label5.TabIndex = 23;
			this.label5.Text = "Resultados obtenidos";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(541, 74);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(147, 20);
			this.label6.TabIndex = 24;
			this.label6.Text = "Sistema auditado";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(12, 227);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(192, 20);
			this.label7.TabIndex = 25;
			this.label7.Text = "?Se detectó una falla¿";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(248, 162);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(192, 20);
			this.label8.TabIndex = 26;
			this.label8.Text = "Fecha de culminación";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FrmGestionProcesos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(832, 416);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnConsultarAuditor);
			this.Controls.Add(this.btnConsultarFecha);
			this.Controls.Add(this.btnVerTodos);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.volverbt);
			this.Controls.Add(this.btnRegistrar);
			this.Controls.Add(this.numHoras);
			this.Controls.Add(this.dtpFechaFin);
			this.Controls.Add(this.dtpFechainicio);
			this.Controls.Add(this.chkFalla);
			this.Controls.Add(this.txtResultados);
			this.Controls.Add(this.txtDescripcion);
			this.Controls.Add(this.cmbSistema);
			this.Controls.Add(this.cmbAuditor);
			this.Controls.Add(this.lstDescripcion);
			this.Name = "FrmGestionProcesos";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = "AuditPro";
			((System.ComponentModel.ISupportInitialize)(this.numHoras)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
