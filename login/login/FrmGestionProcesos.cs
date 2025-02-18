using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace login
{
	
	public partial class FrmGestionProcesos : Form
	{
		private ColeccionProcesos coleccionProcesos;
		
    	
	    public FrmGestionProcesos()
	    {
	        InitializeComponent();
	    	coleccionProcesos = new ColeccionProcesos();    
	    
			
		}
		void BtnRegistrarClick(object sender, EventArgs e)
		{
				try
            {
                // Validaciones antes de registrar
                if (string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                    cmbAuditor.SelectedIndex == -1 ||
                    cmbSistema.SelectedIndex == -1 ||
                    numHoras.Value < 1 ||
                    string.IsNullOrWhiteSpace(txtResultados.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Captura de datos
                string descripcion = txtDescripcion.Text;
                string auditor = cmbAuditor.SelectedItem.ToString();
                string sistema = cmbSistema.SelectedItem.ToString();
                DateTime fecha = dtpFechainicio.Value;
                int hora = (int)numHoras.Value;
                string resultado = txtResultados.Text;
                bool fallaDetectada = chkFalla.Checked;

                // Crear objeto y agregar a la colección
               
                // Crear objeto y agregar a la colección
                Proceso proceso = new Proceso(descripcion, auditor, sistema, fecha, hora, resultado, fallaDetectada);
                coleccionProcesos.AgregarProceso(proceso); 
                
                MessageBox.Show("Proceso registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
		}
		void BtnConsultarAuditorClick(object sender, EventArgs e)
		{
			lstDescripcion.Items.Clear(); // Limpia la lista de procesos
            
			List<Proceso> procesos = coleccionProcesos.ConsultarAuditoria(cmbAuditor.Text);
            // Limpia los cuadros de texto
            LimpiarCampos();

            if (procesos.Count == 0)
            {
                MessageBox.Show("No se encontraron procesos para este auditor.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var proceso in procesos)
            {
                // Agrega el elemento a la lista
                string item = "Auditor: " + proceso.Auditor +
                              " - Sistema: " + proceso.Sistema +
                              " - Fecha: " + proceso.Fecha.ToShortDateString() +
                              " - Fallas: " + (proceso.Fallas ? "Sí" : "No");

                lstDescripcion.Items.Add(item); // Agrega el proceso a la ListBox

                // Asignar valores a los cuadros de texto correspondientes
                txtDescripcion.Text = proceso.Descripcion;
                cmbAuditor.SelectedItem = proceso.Auditor; // Asumiendo que el ComboBox contiene los auditores previamente
                cmbSistema.SelectedItem = proceso.Sistema; // Asumiendo que el ComboBox contiene los sistemas previamente
                dtpFechainicio.Value = proceso.Fecha;
                numHoras.Value = proceso.Hora;
                txtResultados.Text = proceso.Resultado;
                chkFalla.Checked = proceso.Fallas;
            }
		}
		void BtnConsultarFechaClick(object sender, EventArgs e)
		{
			lstDescripcion.Items.Clear(); // Limpia la lista de procesos

			    // Se asume que hay dos DateTimePicker: dtpFechainicio y dtpFechaFin
			    DateTime fechaInicio = dtpFechainicio.Value;
			    DateTime fechaFin = dtpFechaFin.Value;
			
			    // Validación de que la fecha de inicio no sea mayor que la fecha final
			    if (fechaInicio > fechaFin)
			    {
			        MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha final.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			        return;
			    }
			
			    // Validación adicional: asegurarse de que las fechas no sean futuras
			    if (fechaFin > DateTime.Now)
			    {
			        MessageBox.Show("La fecha final no puede ser mayor que la fecha actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			        return;
			    }
			
			    // Obtener los procesos en el rango de fechas
			    
			    List<Proceso> procesos = coleccionProcesos.ConsultarPorFecha(fechaInicio, fechaFin);
			
			    if (procesos.Count == 0)
			    {
			        MessageBox.Show("No se encontraron procesos en este rango de fechas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
			        return;
			    }
			
			    // Mostrar los procesos encontrados
			    foreach (var proceso in procesos)
			    {
			        string item = "Auditor: " + proceso.Auditor +
			                      " - Sistema: " + proceso.Sistema +
			                      " - Fecha: " + proceso.Fecha.ToShortDateString() +
			                      " - Fallas: " + (proceso.Fallas ? "Sí" : "No");
			
			        lstDescripcion.Items.Add(item); // Agrega el proceso a la ListBox
			    }
			
			    MessageBox.Show("{procesos.Count} proceso(s) encontrado(s).", "Consulta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);	 
		}
		void BtnVerTodosClick(object sender, EventArgs e)
		{
			lstDescripcion.Items.Clear();
            List<Proceso> procesos = coleccionProcesos.ObtenerTodos();

            if (procesos.Count == 0)
            {
                MessageBox.Show("No hay procesos registrados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var proceso in procesos)
            {
                lstDescripcion.Items.Add("Auditor: " + proceso.Auditor + " - Sistema: " + proceso.Sistema + " - Fecha: " + proceso.Fecha.ToShortDateString() + " - Fallas: " + (proceso.Fallas ? "Sí" : "No"));
            }
		}
		
		private void LimpiarCampos()
        {
        	txtDescripcion.Clear();
            if (cmbAuditor.Items.Count > 0) cmbAuditor.SelectedIndex = -1;
            if (cmbSistema.Items.Count > 0) cmbSistema.SelectedIndex = -1;
            numHoras.Value = 1;
            txtResultados.Clear();
            chkFalla.Checked = false;
            dtpFechainicio.Value = DateTime.Now;
        }
		void BtnLimpiarClick(object sender, EventArgs e)
		{
		lstDescripcion.Items.Clear();
            LimpiarCampos();
		}
		void VolverbtClick(object sender, EventArgs e)
		{
		this.Hide();
		submenu1 ventana = new submenu1();
		ventana.Show();
		}
	
		
	}
}
