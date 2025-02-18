using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace PF01
{
	public partial class MainForm : Form
	{
		
		
		public MainForm()
		{
			InitializeComponent();
			IniciarSesion();
			
		}
		private void IniciarSesion()
        {
        try
    	{
        	using(login login = new login())
        	{
        		if (login.ShowDialog() == DialogResult.OK)
        		{
            		MessageBox.Show("¡Bienvenido al sistema de gestión de auditorías!");
       	 		}	
        		else
        		{
            		MessageBox.Show("Acceso denegado. La aplicación se cerrará.");
            		
        		}
        	}
    	}
    	catch (ObjectDisposedException ex)
    	{
        	MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    	}
       }
            		
	}
}
