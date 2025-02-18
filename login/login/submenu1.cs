
using System;
using System.Drawing;
using System.Windows.Forms;

namespace login
{
	/// <summary>
	/// Description of submenu1.
	/// </summary>
	public partial class submenu1 : Form
	{
		public submenu1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void ConoceNuestroSistemaToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Hide();
			conocenos ventana = new conocenos();
			ventana.Show();
		}
		void QuienNosProgramoToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Hide();
			programo ventana = new programo();
			ventana.Show();
		}
		void Button1Click(object sender, EventArgs e)
		{
			this.Hide();
			FrmGestionProcesos ventana = new FrmGestionProcesos();
			ventana.Show();
	
		}
		void CypbtClick(object sender, EventArgs e)
		{
	
		}
		void GauditorbtClick(object sender, EventArgs e)
		{
			this.Hide();
			gestionAu ventana = new gestionAu();
			ventana.Show();
		}
		void SalirToolStripMenuItemClick(object sender, EventArgs e)
		{
		this.Hide();
			MainForm ventana = new MainForm();
			ventana.Show();
		}
		void SistemabtClick(object sender, EventArgs e)
		{
		this.Hide();
		Form2 ventana = new Form2();
		ventana.Show();
		}
		
	}
}
