/*
 * Creado por SharpDevelop.
 * Usuario: isis0
 * Fecha: 17/2/2025
 * Hora: 1:47 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace login
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnIngresar;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtcontraseña;
		private System.Windows.Forms.Button btnCrear;
		private System.Windows.Forms.Button btnAcceso;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.btnIngresar = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtcontraseña = new System.Windows.Forms.TextBox();
			this.btnCrear = new System.Windows.Forms.Button();
			this.btnAcceso = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnIngresar
			// 
			this.btnIngresar.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIngresar.Location = new System.Drawing.Point(349, 324);
			this.btnIngresar.Name = "btnIngresar";
			this.btnIngresar.Size = new System.Drawing.Size(91, 25);
			this.btnIngresar.TabIndex = 0;
			this.btnIngresar.Text = "Ingresar";
			this.btnIngresar.UseVisualStyleBackColor = false;
			this.btnIngresar.Click += new System.EventHandler(this.BtnIngresarClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.Location = new System.Drawing.Point(189, 25);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(428, 116);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(288, 205);
			this.txtUsuario.Multiline = true;
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(205, 25);
			this.txtUsuario.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(288, 179);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 6;
			this.label1.Text = "Usuario";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(286, 251);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 7;
			this.label2.Text = "Contraseña";
			// 
			// txtcontraseña
			// 
			this.txtcontraseña.Location = new System.Drawing.Point(288, 273);
			this.txtcontraseña.Multiline = true;
			this.txtcontraseña.Name = "txtcontraseña";
			this.txtcontraseña.Size = new System.Drawing.Size(205, 25);
			this.txtcontraseña.TabIndex = 8;
			// 
			// btnCrear
			// 
			this.btnCrear.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCrear.Location = new System.Drawing.Point(339, 386);
			this.btnCrear.Name = "btnCrear";
			this.btnCrear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnCrear.Size = new System.Drawing.Size(113, 25);
			this.btnCrear.TabIndex = 9;
			this.btnCrear.Text = "Crear usuario";
			this.btnCrear.UseVisualStyleBackColor = false;
			this.btnCrear.Click += new System.EventHandler(this.BtnCrearClick);
			// 
			// btnAcceso
			// 
			this.btnAcceso.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btnAcceso.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnAcceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAcceso.Location = new System.Drawing.Point(349, 355);
			this.btnAcceso.Name = "btnAcceso";
			this.btnAcceso.Size = new System.Drawing.Size(91, 25);
			this.btnAcceso.TabIndex = 10;
			this.btnAcceso.Text = "Acceso";
			this.btnAcceso.UseVisualStyleBackColor = false;
			this.btnAcceso.Click += new System.EventHandler(this.BtnAccesoClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(822, 516);
			this.Controls.Add(this.btnAcceso);
			this.Controls.Add(this.btnCrear);
			this.Controls.Add(this.txtcontraseña);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnIngresar);
			this.Name = "MainForm";
			this.Text = "MainForm";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
