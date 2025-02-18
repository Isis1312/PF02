/*
 * Creado por SharpDevelop.
 * Usuario: isis0
 * Fecha: 15/2/2025
 * Hora: 7:14 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace login
{
	/// <summary>
	/// Description of programo.
	/// </summary>
	public partial class programo : Form
	{
		public programo()
		{
		
			InitializeComponent();
			
		
		}
		void Volver1Click(object sender, EventArgs e)
		{
		this.Hide();
		submenu1 ventana = new submenu1();
		ventana.Show();
		}
	}
}
