
using System;
using System.Drawing;
using System.Windows.Forms;

namespace login
{
	/// <summary>
	/// Description of conocenos.
	/// </summary>
	public partial class conocenos : Form
	{
		public conocenos()
		{
			
			InitializeComponent();
			
			
		}
		void VolverClick(object sender, EventArgs e)
		{
		this.Hide();
		submenu1 ventana = new submenu1();
		ventana.Show();
		}
	}
}
