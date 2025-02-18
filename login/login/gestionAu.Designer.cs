/*
 * Creado por SharpDevelop.
 * Usuario: isis0
 * Fecha: 16/2/2025
 * Hora: 5:48 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace login
{
	partial class gestionAu
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox cedulatb;
		private System.Windows.Forms.TextBox nombretb;
		private System.Windows.Forms.TextBox apellidotb;
		private System.Windows.Forms.TextBox direcciontb;
		private System.Windows.Forms.RadioButton activo;
		private System.Windows.Forms.TextBox titulotb;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button guardarAuditor;
		private System.Windows.Forms.Button buscaraauditorbt;
		private System.Windows.Forms.Button limpiarauditorbt;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button volverbt;
		private System.Windows.Forms.Button eliminarbt;
		private System.Windows.Forms.RadioButton inactivo;
		private System.Windows.Forms.DateTimePicker fechanacido;
		private System.Windows.Forms.DateTimePicker fechaingreso;
		private System.Windows.Forms.TextBox sexotb;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label10;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gestionAu));
			this.cedulatb = new System.Windows.Forms.TextBox();
			this.nombretb = new System.Windows.Forms.TextBox();
			this.apellidotb = new System.Windows.Forms.TextBox();
			this.direcciontb = new System.Windows.Forms.TextBox();
			this.titulotb = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.guardarAuditor = new System.Windows.Forms.Button();
			this.buscaraauditorbt = new System.Windows.Forms.Button();
			this.limpiarauditorbt = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.volverbt = new System.Windows.Forms.Button();
			this.eliminarbt = new System.Windows.Forms.Button();
			this.inactivo = new System.Windows.Forms.RadioButton();
			this.activo = new System.Windows.Forms.RadioButton();
			this.fechanacido = new System.Windows.Forms.DateTimePicker();
			this.fechaingreso = new System.Windows.Forms.DateTimePicker();
			this.sexotb = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label10 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cedulatb
			// 
			this.cedulatb.BackColor = System.Drawing.SystemColors.ControlLight;
			this.cedulatb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cedulatb.Location = new System.Drawing.Point(125, 145);
			this.cedulatb.MaxLength = 8;
			this.cedulatb.Multiline = true;
			this.cedulatb.Name = "cedulatb";
			this.cedulatb.Size = new System.Drawing.Size(132, 31);
			this.cedulatb.TabIndex = 0;
			// 
			// nombretb
			// 
			this.nombretb.BackColor = System.Drawing.SystemColors.ControlLight;
			this.nombretb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nombretb.Location = new System.Drawing.Point(125, 182);
			this.nombretb.Multiline = true;
			this.nombretb.Name = "nombretb";
			this.nombretb.Size = new System.Drawing.Size(132, 31);
			this.nombretb.TabIndex = 1;
			// 
			// apellidotb
			// 
			this.apellidotb.BackColor = System.Drawing.SystemColors.ControlLight;
			this.apellidotb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.apellidotb.Location = new System.Drawing.Point(125, 219);
			this.apellidotb.Multiline = true;
			this.apellidotb.Name = "apellidotb";
			this.apellidotb.Size = new System.Drawing.Size(132, 31);
			this.apellidotb.TabIndex = 2;
			// 
			// direcciontb
			// 
			this.direcciontb.BackColor = System.Drawing.SystemColors.ControlLight;
			this.direcciontb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.direcciontb.Location = new System.Drawing.Point(531, 184);
			this.direcciontb.Multiline = true;
			this.direcciontb.Name = "direcciontb";
			this.direcciontb.Size = new System.Drawing.Size(294, 31);
			this.direcciontb.TabIndex = 3;
			// 
			// titulotb
			// 
			this.titulotb.BackColor = System.Drawing.SystemColors.ControlLight;
			this.titulotb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titulotb.Location = new System.Drawing.Point(531, 145);
			this.titulotb.Multiline = true;
			this.titulotb.Name = "titulotb";
			this.titulotb.Size = new System.Drawing.Size(293, 31);
			this.titulotb.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(28, 190);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 23);
			this.label1.TabIndex = 9;
			this.label1.Text = "Nombre:";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(28, 153);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 23);
			this.label2.TabIndex = 11;
			this.label2.Text = "Cedula:";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(28, 228);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(91, 23);
			this.label3.TabIndex = 12;
			this.label3.Text = "Apellido:";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(425, 190);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 13;
			this.label4.Text = "Dirección:";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(377, 146);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(134, 24);
			this.label5.TabIndex = 14;
			this.label5.Text = "Titulo de grado: ";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(52, 270);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(67, 24);
			this.label6.TabIndex = 15;
			this.label6.Text = "Sexo:";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(181, 314);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(172, 24);
			this.label7.TabIndex = 20;
			this.label7.Text = "Estado del autidor";
			// 
			// guardarAuditor
			// 
			this.guardarAuditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guardarAuditor.Location = new System.Drawing.Point(125, 372);
			this.guardarAuditor.Name = "guardarAuditor";
			this.guardarAuditor.Size = new System.Drawing.Size(102, 36);
			this.guardarAuditor.TabIndex = 21;
			this.guardarAuditor.Text = "GUARDAR";
			this.guardarAuditor.UseVisualStyleBackColor = true;
			this.guardarAuditor.Click += new System.EventHandler(this.GuardarAuditorClick);
			// 
			// buscaraauditorbt
			// 
			this.buscaraauditorbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buscaraauditorbt.Location = new System.Drawing.Point(262, 372);
			this.buscaraauditorbt.Name = "buscaraauditorbt";
			this.buscaraauditorbt.Size = new System.Drawing.Size(102, 36);
			this.buscaraauditorbt.TabIndex = 23;
			this.buscaraauditorbt.Text = "BUSCAR";
			this.buscaraauditorbt.UseVisualStyleBackColor = true;
			this.buscaraauditorbt.Click += new System.EventHandler(this.BuscaraauditorbtClick);
			// 
			// limpiarauditorbt
			// 
			this.limpiarauditorbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.limpiarauditorbt.Location = new System.Drawing.Point(396, 372);
			this.limpiarauditorbt.Name = "limpiarauditorbt";
			this.limpiarauditorbt.Size = new System.Drawing.Size(102, 36);
			this.limpiarauditorbt.TabIndex = 24;
			this.limpiarauditorbt.Text = "LIMPIAR";
			this.limpiarauditorbt.UseVisualStyleBackColor = true;
			this.limpiarauditorbt.Click += new System.EventHandler(this.LimpiarauditorbtClick);
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(340, 228);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(185, 23);
			this.label8.TabIndex = 25;
			this.label8.Text = "Fecha de nacimiento:";
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(372, 265);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(153, 23);
			this.label9.TabIndex = 26;
			this.label9.Text = "Fecha de ingreso:";
			// 
			// volverbt
			// 
			this.volverbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.volverbt.Location = new System.Drawing.Point(359, 421);
			this.volverbt.Name = "volverbt";
			this.volverbt.Size = new System.Drawing.Size(86, 35);
			this.volverbt.TabIndex = 27;
			this.volverbt.Text = "VOLVER";
			this.volverbt.UseVisualStyleBackColor = true;
			this.volverbt.Click += new System.EventHandler(this.VolverbtClick);
			// 
			// eliminarbt
			// 
			this.eliminarbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.eliminarbt.Location = new System.Drawing.Point(535, 372);
			this.eliminarbt.Name = "eliminarbt";
			this.eliminarbt.Size = new System.Drawing.Size(102, 36);
			this.eliminarbt.TabIndex = 28;
			this.eliminarbt.Text = "ELIMINAR";
			this.eliminarbt.UseVisualStyleBackColor = true;
			this.eliminarbt.Click += new System.EventHandler(this.EliminarbtClick);
			// 
			// inactivo
			// 
			this.inactivo.BackColor = System.Drawing.Color.Transparent;
			this.inactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inactivo.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.inactivo.Location = new System.Drawing.Point(80, 7);
			this.inactivo.Name = "inactivo";
			this.inactivo.Size = new System.Drawing.Size(86, 24);
			this.inactivo.TabIndex = 1;
			this.inactivo.TabStop = true;
			this.inactivo.Text = "Inactivo";
			this.inactivo.UseVisualStyleBackColor = false;
			// 
			// activo
			// 
			this.activo.BackColor = System.Drawing.Color.Transparent;
			this.activo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
			this.activo.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.activo.Location = new System.Drawing.Point(6, 7);
			this.activo.Name = "activo";
			this.activo.Size = new System.Drawing.Size(68, 24);
			this.activo.TabIndex = 0;
			this.activo.TabStop = true;
			this.activo.Text = "Activo";
			this.activo.UseVisualStyleBackColor = false;
			// 
			// fechanacido
			// 
			this.fechanacido.CalendarMonthBackground = System.Drawing.Color.DarkGray;
			this.fechanacido.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveBorder;
			this.fechanacido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fechanacido.Location = new System.Drawing.Point(535, 231);
			this.fechanacido.MaxDate = new System.DateTime(2003, 1, 1, 0, 0, 0, 0);
			this.fechanacido.MinDate = new System.DateTime(1985, 1, 1, 0, 0, 0, 0);
			this.fechanacido.Name = "fechanacido";
			this.fechanacido.Size = new System.Drawing.Size(279, 21);
			this.fechanacido.TabIndex = 30;
			this.fechanacido.Value = new System.DateTime(2003, 1, 1, 0, 0, 0, 0);
			// 
			// fechaingreso
			// 
			this.fechaingreso.CalendarMonthBackground = System.Drawing.Color.DarkGray;
			this.fechaingreso.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveBorder;
			this.fechaingreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fechaingreso.Location = new System.Drawing.Point(534, 267);
			this.fechaingreso.MaxDate = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
			this.fechaingreso.MinDate = new System.DateTime(2025, 2, 18, 0, 0, 0, 0);
			this.fechaingreso.Name = "fechaingreso";
			this.fechaingreso.Size = new System.Drawing.Size(279, 21);
			this.fechaingreso.TabIndex = 31;
			this.fechaingreso.Value = new System.DateTime(2025, 2, 18, 0, 0, 0, 0);
			// 
			// sexotb
			// 
			this.sexotb.BackColor = System.Drawing.SystemColors.ControlLight;
			this.sexotb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sexotb.Location = new System.Drawing.Point(125, 257);
			this.sexotb.Multiline = true;
			this.sexotb.Name = "sexotb";
			this.sexotb.Size = new System.Drawing.Size(132, 31);
			this.sexotb.TabIndex = 32;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.Location = new System.Drawing.Point(187, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(438, 118);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 33;
			this.pictureBox1.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.activo);
			this.groupBox1.Controls.Add(this.inactivo);
			this.groupBox1.Location = new System.Drawing.Point(359, 307);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(166, 31);
			this.groupBox1.TabIndex = 34;
			this.groupBox1.TabStop = false;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(125, 290);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(84, 23);
			this.label10.TabIndex = 35;
			this.label10.Text = "Ingrese: F/M";
			// 
			// gestionAu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(830, 475);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.sexotb);
			this.Controls.Add(this.fechaingreso);
			this.Controls.Add(this.fechanacido);
			this.Controls.Add(this.eliminarbt);
			this.Controls.Add(this.volverbt);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.limpiarauditorbt);
			this.Controls.Add(this.buscaraauditorbt);
			this.Controls.Add(this.guardarAuditor);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.titulotb);
			this.Controls.Add(this.direcciontb);
			this.Controls.Add(this.apellidotb);
			this.Controls.Add(this.nombretb);
			this.Controls.Add(this.cedulatb);
			this.Name = "gestionAu";
			this.Text = "Sistema de gestion de auditores";
			this.Load += new System.EventHandler(this.GestionAuLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
