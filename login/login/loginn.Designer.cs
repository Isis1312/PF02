/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 15/2/2025
 * Time: 10:58 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PF01
{
	partial class login
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
			this.btnCrear = new System.Windows.Forms.Button();
			this.btnAcceso = new System.Windows.Forms.Button();
			this.btnIngresar = new System.Windows.Forms.Button();
			this.lblContraseña = new System.Windows.Forms.Label();
			this.txtcontraseña = new System.Windows.Forms.TextBox();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnCrear
			// 
			this.btnCrear.Location = new System.Drawing.Point(254, 352);
			this.btnCrear.Name = "btnCrear";
			this.btnCrear.Size = new System.Drawing.Size(147, 28);
			this.btnCrear.TabIndex = 13;
			this.btnCrear.Text = "Crear Usuario";
			this.btnCrear.UseVisualStyleBackColor = true;
			this.btnCrear.Click += new System.EventHandler(this.BtnCrearClick);
			// 
			// btnAcceso
			// 
			this.btnAcceso.Location = new System.Drawing.Point(256, 301);
			this.btnAcceso.Name = "btnAcceso";
			this.btnAcceso.Size = new System.Drawing.Size(146, 27);
			this.btnAcceso.TabIndex = 12;
			this.btnAcceso.Text = "Acceso";
			this.btnAcceso.UseVisualStyleBackColor = true;
			this.btnAcceso.Click += new System.EventHandler(this.BtnAccesoClick);
			this.btnAcceso.MouseEnter += new System.EventHandler(this.BtnAccesoMouseEnter);
			// 
			// btnIngresar
			// 
			this.btnIngresar.Location = new System.Drawing.Point(256, 246);
			this.btnIngresar.Name = "btnIngresar";
			this.btnIngresar.Size = new System.Drawing.Size(147, 30);
			this.btnIngresar.TabIndex = 11;
			this.btnIngresar.Text = "Ingresar";
			this.btnIngresar.UseVisualStyleBackColor = true;
			this.btnIngresar.Click += new System.EventHandler(this.BtnIngresarClick);
			// 
			// lblContraseña
			// 
			this.lblContraseña.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblContraseña.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblContraseña.Location = new System.Drawing.Point(171, 157);
			this.lblContraseña.Name = "lblContraseña";
			this.lblContraseña.Size = new System.Drawing.Size(119, 18);
			this.lblContraseña.TabIndex = 10;
			this.lblContraseña.Text = "Contraseña:";
			// 
			// txtcontraseña
			// 
			this.txtcontraseña.Location = new System.Drawing.Point(171, 178);
			this.txtcontraseña.Name = "txtcontraseña";
			this.txtcontraseña.Size = new System.Drawing.Size(329, 22);
			this.txtcontraseña.TabIndex = 9;
			// 
			// lblUsuario
			// 
			this.lblUsuario.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblUsuario.Location = new System.Drawing.Point(171, 92);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(119, 18);
			this.lblUsuario.TabIndex = 8;
			this.lblUsuario.Text = "Usuario:";
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(171, 113);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(329, 22);
			this.txtUsuario.TabIndex = 7;
			// 
			// login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(719, 473);
			this.Controls.Add(this.btnCrear);
			this.Controls.Add(this.btnAcceso);
			this.Controls.Add(this.btnIngresar);
			this.Controls.Add(this.lblContraseña);
			this.Controls.Add(this.txtcontraseña);
			this.Controls.Add(this.lblUsuario);
			this.Controls.Add(this.txtUsuario);
			this.Name = "login";
			this.Text = "login";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.TextBox txtcontraseña;
		private System.Windows.Forms.Label lblContraseña;
		private System.Windows.Forms.Button btnIngresar;
		private System.Windows.Forms.Button btnAcceso;
		private System.Windows.Forms.Button btnCrear;
	}
}
