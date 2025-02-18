/*
 * Creado por SharpDevelop.
 * Usuario: isis0
 * Fecha: 15/2/2025
 * Hora: 7:11 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace login
{
	partial class submenu1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem conoceNuestroSistemaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quienNosProgramoToolStripMenuItem;
		private System.Windows.Forms.Button gauditorbt;
		private System.Windows.Forms.Label quedeseasrealizar;
		private System.Windows.Forms.Label bienvido;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button procesobt;
		private System.Windows.Forms.Button sistemabt;
		private System.Windows.Forms.Button cypbt;
		private System.Windows.Forms.PictureBox pictureBox1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(submenu1));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.conoceNuestroSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quienNosProgramoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gauditorbt = new System.Windows.Forms.Button();
			this.quedeseasrealizar = new System.Windows.Forms.Label();
			this.bienvido = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.procesobt = new System.Windows.Forms.Button();
			this.sistemabt = new System.Windows.Forms.Button();
			this.cypbt = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.acercaDeToolStripMenuItem,
			this.salirToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(778, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// acercaDeToolStripMenuItem
			// 
			this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.conoceNuestroSistemaToolStripMenuItem,
			this.quienNosProgramoToolStripMenuItem});
			this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
			this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
			this.acercaDeToolStripMenuItem.Text = "Acerca de...";
			// 
			// conoceNuestroSistemaToolStripMenuItem
			// 
			this.conoceNuestroSistemaToolStripMenuItem.Name = "conoceNuestroSistemaToolStripMenuItem";
			this.conoceNuestroSistemaToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
			this.conoceNuestroSistemaToolStripMenuItem.Text = "Conoce nuestro sistema";
			this.conoceNuestroSistemaToolStripMenuItem.Click += new System.EventHandler(this.ConoceNuestroSistemaToolStripMenuItemClick);
			// 
			// quienNosProgramoToolStripMenuItem
			// 
			this.quienNosProgramoToolStripMenuItem.Name = "quienNosProgramoToolStripMenuItem";
			this.quienNosProgramoToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
			this.quienNosProgramoToolStripMenuItem.Text = "Quien nos programo ?";
			this.quienNosProgramoToolStripMenuItem.Click += new System.EventHandler(this.QuienNosProgramoToolStripMenuItemClick);
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
			this.salirToolStripMenuItem.Text = "Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItemClick);
			// 
			// gauditorbt
			// 
			this.gauditorbt.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.gauditorbt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.gauditorbt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.gauditorbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gauditorbt.ForeColor = System.Drawing.SystemColors.InfoText;
			this.gauditorbt.Location = new System.Drawing.Point(14, 345);
			this.gauditorbt.Name = "gauditorbt";
			this.gauditorbt.Size = new System.Drawing.Size(165, 26);
			this.gauditorbt.TabIndex = 1;
			this.gauditorbt.Text = "Administrar audittores";
			this.gauditorbt.UseVisualStyleBackColor = false;
			this.gauditorbt.Click += new System.EventHandler(this.GauditorbtClick);
			// 
			// quedeseasrealizar
			// 
			this.quedeseasrealizar.BackColor = System.Drawing.Color.Transparent;
			this.quedeseasrealizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.quedeseasrealizar.ForeColor = System.Drawing.Color.White;
			this.quedeseasrealizar.Location = new System.Drawing.Point(77, 223);
			this.quedeseasrealizar.Name = "quedeseasrealizar";
			this.quedeseasrealizar.Size = new System.Drawing.Size(613, 20);
			this.quedeseasrealizar.TabIndex = 2;
			this.quedeseasrealizar.Text = "Lee las opciones que puede realizar en nuestro sistema y haz click en un boton";
			// 
			// bienvido
			// 
			this.bienvido.BackColor = System.Drawing.Color.Transparent;
			this.bienvido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bienvido.ForeColor = System.Drawing.Color.White;
			this.bienvido.Location = new System.Drawing.Point(180, 183);
			this.bienvido.Name = "bienvido";
			this.bienvido.Size = new System.Drawing.Size(452, 30);
			this.bienvido.TabIndex = 3;
			this.bienvido.Text = "Bienvedio al sistema de gestion AuditPro\r\n";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(16, 264);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(175, 48);
			this.label1.TabIndex = 5;
			this.label1.Text = "Gestionar auditores:\r\nAgregar, modificar, buscar, o desactivar un auditor.";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(220, 251);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(185, 69);
			this.label2.TabIndex = 6;
			this.label2.Text = "Gestión de sistemas:\r\nActualización y consulta de los sistemas que están en proce" +
	"so de auditoría";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(429, 264);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(185, 51);
			this.label3.TabIndex = 7;
			this.label3.Text = "Gestión de proceso:\r\nRegistro y consulta de los procesos de auditorías.";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(630, 292);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(135, 20);
			this.label4.TabIndex = 8;
			this.label4.Text = "Consultas y reportes";
			// 
			// procesobt
			// 
			this.procesobt.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.procesobt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.procesobt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.procesobt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.procesobt.ForeColor = System.Drawing.SystemColors.InfoText;
			this.procesobt.Location = new System.Drawing.Point(442, 346);
			this.procesobt.Name = "procesobt";
			this.procesobt.Size = new System.Drawing.Size(127, 26);
			this.procesobt.TabIndex = 9;
			this.procesobt.Text = "Ver Auditorías";
			this.procesobt.UseVisualStyleBackColor = false;
			this.procesobt.Click += new System.EventHandler(this.Button1Click);
			// 
			// sistemabt
			// 
			this.sistemabt.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.sistemabt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.sistemabt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.sistemabt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sistemabt.ForeColor = System.Drawing.SystemColors.InfoText;
			this.sistemabt.Location = new System.Drawing.Point(220, 345);
			this.sistemabt.Name = "sistemabt";
			this.sistemabt.Size = new System.Drawing.Size(149, 26);
			this.sistemabt.TabIndex = 10;
			this.sistemabt.Text = "Panel de Sistemas";
			this.sistemabt.UseVisualStyleBackColor = false;
			this.sistemabt.Click += new System.EventHandler(this.SistemabtClick);
			// 
			// cypbt
			// 
			this.cypbt.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.cypbt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.cypbt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cypbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cypbt.ForeColor = System.Drawing.SystemColors.InfoText;
			this.cypbt.Location = new System.Drawing.Point(630, 346);
			this.cypbt.Name = "cypbt";
			this.cypbt.Size = new System.Drawing.Size(127, 26);
			this.cypbt.TabIndex = 11;
			this.cypbt.Text = "Explorar datos";
			this.cypbt.UseVisualStyleBackColor = false;
			this.cypbt.Click += new System.EventHandler(this.CypbtClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.Location = new System.Drawing.Point(167, 39);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(421, 127);
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
			// 
			// submenu1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(778, 402);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.cypbt);
			this.Controls.Add(this.sistemabt);
			this.Controls.Add(this.procesobt);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.bienvido);
			this.Controls.Add(this.quedeseasrealizar);
			this.Controls.Add(this.gauditorbt);
			this.Controls.Add(this.menuStrip1);
			this.ForeColor = System.Drawing.SystemColors.InfoText;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "submenu1";
			this.Text = "submenu1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
