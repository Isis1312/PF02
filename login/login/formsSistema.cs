/*using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;*/

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;

namespace login
{
	public partial class Form2 : Form
	{
		private coleccion coleccionSistemas;
		
		public Form2()
		{
			
			InitializeComponent();
			
			
		}
		
		//metodos
		
		//metodo limpiar
        
       private void LimpiarCampos()
        {
            txtEmpresa.Clear();
            txtRIF.Clear();
            txtDireccion.Clear();
            txtAuditoria.Clear();
            dtpInicio.Value = DateTime.Now;
            dtpFin.Value = DateTime.Now;
        }
		
		//botn registar
		void BtnRegistrarClick(object sender, EventArgs e)
		{
			try
            {
                // Capturar datos del formulario
                string empresa = txtEmpresa.Text;
                string rif = txtRIF.Text;
                string direccion = txtDireccion.Text;
                string auditoria = txtAuditoria.Text;
                DateTime inicio = dtpInicio.Value;
                DateTime final = dtpFin.Value;

                // Crear nuevo sistema
                Sistema sistema = new Sistema();
                // Se agrega a la colección
                coleccionSistemas.agregar(sistema);

                // Mostrar mensaje de éxito
                MessageBox.Show("Sistema registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (Exception ex)
            {
            	// Mostrar mensaje de error en caso de excepción
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
		}
		
		//botn consultar
		void ConsultarbtClick(object sender, EventArgs e)
					{
			    // Validar que el RIF esté ingresado
			    if (string.IsNullOrWhiteSpace(txtRIF.Text))
			    {
			        MessageBox.Show("Por favor, ingrese el RIF del sistema a buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			        return;
			    }
			
			    try
			    {
			        // Capturar el RIF del sistema a consultar
			        string rif = txtRIF.Text;
			
			        // Consultar el sistema en la colección
			        Sistema sistema = coleccionSistemas.Consultar(rif);
			
			        if (sistema != null)
			        {
			            // Llenar los campos del formulario con los datos del sistema encontrado
			            txtEmpresa.Text = sistema.Empresa;
			            txtRIF.Text = sistema.RIF;
			            txtDireccion.Text = sistema.Direccion;
			            txtAuditoria.Text = sistema.Auditoria;
  
			            dtpInicio.Text= sistema.Inicio;
			            dtpFin.Text = sistema.Final;
			
			            // Habilitar el botón de actualización
			            btnRegistrar.Enabled = false;;
			            
			        }
			        else
			        {
			            MessageBox.Show("Sistema no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			            btnRegistrar.Enabled = false; // Deshabilitar el botón de actualización si no se encuentra
			        }
			    }
			    catch (Exception ex)
			    {
			        // Mostrar mensaje de error en caso de excepción
			        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			    }
} 
			
			
		//boton actualizar
		void BtnActualizarClick(object sender, EventArgs e)
		{
			 try
            {
                // Capturar el RIF del sistema a actualizar
                string rif = txtRIF.Text;

                // Crear un nuevo sistema con los datos del formulario
                Sistema nuevoSistema = new Sistema();
         

                // Actualizar el sistema en la colección
                coleccionSistemas.Actualizar(rif, nuevoSistema);
                // Mostrar mensaje de éxito
                MessageBox.Show("Sistema actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
			 catch (Exception ex)
            {
                // Mostrar mensaje de error en caso de excepción
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
		}
		
		
		//boton limpiar
		void BtnLimpiarClick(object sender, EventArgs e)
		{
		LimpiarCampos();
		}
		
		//volver al sub menu
		void VolverbtClick(object sender, EventArgs e)
		{
		this.Hide();
		submenu1 ventana = new submenu1();
		ventana.Show();	
		}	
		
		
	}
}
