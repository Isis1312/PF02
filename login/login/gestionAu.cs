using System;
using System.Collections.Generic;
using System.IO;
using System.Linq; // Proporciona funcionalidades para realizar consultas sobre colecciones de datos.
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms; 
using sisAuditor;
using System.Drawing;

namespace login
{
	public partial class gestionAu : Form
	{
		
		public enum Genero //
	    {
	        Masculino,
	        Femenino,
	       
	    }
		private const string arch_auditores = @"auditores.bin"; // Ruta del archivo
		private List<Auditor> auditoresList = new List<Auditor>();
		public gestionAu()
		{
			
			InitializeComponent();
			eliminarbt.Enabled = false;
    		modificarbt.Enabled = false;	
    		limpiarauditorbt.Enabled = true;
    		buscaraauditorbt.Enabled = true;
    		CargarAuditores();
		}
		
		
		void GestionAuLoad(object sender, EventArgs e)
		{
	
		}

		//METODOS
		
		// Método para agregar un nuevo auditor
        private void GuardarAuditor(Auditor auditor)
        {
            auditoresList.Add(auditor);
            GuardarAuditores();
            MessageBox.Show("Auditor guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        	LimpiarCampos();
        }

		
		// Método para guardar la lista de auditores en el archivo binario
        private void GuardarAuditores()
        {
		            using (FileStream stream = new FileStream(arch_auditores, FileMode.Create))
		            {
		                BinaryFormatter formatter = new BinaryFormatter();
		                formatter.Serialize(stream, auditoresList);
		            }
		        }
								
					// Método para cargar auditores desde el archivo binario
		        private void CargarAuditores()
		        {
		             try
		        {
		            using (FileStream stream = new FileStream(arch_auditores, FileMode.Open))
		            {
		                BinaryFormatter formatter = new BinaryFormatter();
		                auditoresList = (List<Auditor>)formatter.Deserialize(stream);
		            }
		        }
		        catch (Exception ex)
		        {
		            MessageBox.Show("Error al cargar auditores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		            
		            // Eliminar el archivo si hay un error
		            try
		            {
		                File.Delete(arch_auditores);
		                MessageBox.Show("El archivo de auditores ha sido eliminado debido a un error de carga.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
		            }
		            catch (Exception deleteEx)
		            {
		                MessageBox.Show("Error al eliminar el archivo: " + deleteEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		            }
		        }
        }
        
        
        // Método para buscar un auditor por cédula
        private Auditor BuscarAuditor(string cedula)
        {
            return auditoresList.FirstOrDefault(a => a.Cedula == cedula);
        }
        
        
	    // Método para eliminar un auditor
        private void EliminarAuditor(string cedula)
        {
            var auditorToRemove = BuscarAuditor(cedula);
            if (auditorToRemove != null)
            {
                auditoresList.Remove(auditorToRemove);
                GuardarAuditores();
                MessageBox.Show("Auditor eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Auditor no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
		
		//METOD LIMPIAR
		private void LimpiarCampos()
				{
				    cedulatb.Clear();
				    nombretb.Clear();
				    apellidotb.Clear();
				    direcciontb.Clear();
				    titulotb.Clear();
				    fechanacido.Value = DateTime.Parse("01/01/2003");
				    fechaingreso.Value = DateTime.Now;
				    sexotb.Clear();
				    activo.Checked = false;
				    inactivo.Checked = false;
				 }
		
		
						
		//boton eliminar
		void EliminarbtClick(object sender, EventArgs e)
		{
			string cedula = cedulatb.Text;
            // Verificar que la cédula no esté vacía
		    if (!string.IsNullOrWhiteSpace(cedula))
		    {
                EliminarAuditor(cedula);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una cédula válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
		
		//boton guardar auditor
		void GuardarAuditorClick(object sender, EventArgs e)
		
			{
			char sexo;

			    if (string.IsNullOrWhiteSpace(cedulatb.Text) ||
			        string.IsNullOrWhiteSpace(nombretb.Text) ||
			        string.IsNullOrWhiteSpace(apellidotb.Text) ||
			        string.IsNullOrWhiteSpace(direcciontb.Text) ||
			        string.IsNullOrWhiteSpace(titulotb.Text) ||
			        string.IsNullOrWhiteSpace(cedulatb.Text) ||
			        !char.TryParse(sexotb.Text, out  sexo) || (sexo != 'M' && sexo != 'F'))
			    {
			        MessageBox.Show("Por favor, complete todos los campos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			        return;
			    }
			
			Auditor nuevoAuditor = new Auditor()
			    {
					Cedula = cedulatb.Text,
			        Nombre = nombretb.Text,
			        Apellido = apellidotb.Text,
			        Direccion = direcciontb.Text,
			        Sexo = sexo,
			        Fc_nacido = fechanacido.Value.Date.ToString("dd/MM/yyyy"),
			        Fc_ingreso = fechaingreso.Value.Date.ToString("dd/MM/yyyy"),
			        Titulo = titulotb.Text
			    };
			GuardarAuditor(nuevoAuditor);
			LimpiarCampos();
			
		}
		        		

		//boton buscar
		void BuscaraauditorbtClick(object sender, EventArgs e)
		{
				if (string.IsNullOrWhiteSpace(cedulatb.Text))
			    {
			        MessageBox.Show("Por favor, ingrese la cédula del auditor a buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			        return;
			    }
				string cedula = cedulatb.Text;
				// Buscar el auditor usando la cédula
   				 Auditor auditor = BuscarAuditor(cedula);

			        if (auditor != null)
			        {
			        	cedulatb.Text = auditor.Cedula;
			            nombretb.Text = auditor.Nombre;
			            apellidotb.Text = auditor.Apellido;
			            direcciontb.Text = auditor.Direccion;
			            titulotb.Text = auditor.Titulo;
			           
			            
			            // Convertir las fechas de string a DateTime
			            DateTime fechaNacido;
			            DateTime fechaIngreso;
				        if (DateTime.TryParse(auditor.Fc_nacido, out  fechaNacido))
				        {
				            fechanacido.Value = fechaNacido; // Asignar al DateTimePicker
				        }
				        else
				        {
				            MessageBox.Show("La fecha de nacimiento no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				        }
				
				        if (DateTime.TryParse(auditor.Fc_ingreso, out  fechaIngreso))
				        {
				            fechaingreso.Value = fechaIngreso; // Asignar al DateTimePicker
				        }
				        else
				        {
				            MessageBox.Show("La fecha de ingreso no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				        }
			            sexotb.Text = auditor.Sexo.ToString();
			            
			            
			
			            guardarAuditor.Enabled = false;
			            eliminarbt.Enabled = true;
			            modificarbt.Enabled = true;
			            buscaraauditorbt.Enabled = false;
			            limpiarauditorbt.Enabled = true;
			        }
			        else
			        {
			            MessageBox.Show("Auditor no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			            LimpiarCampos();
			        }
		}
		
		
		//boton modificar
		void ModificarbtClick(object sender, EventArgs e)
		{
			// Validar que la cédula esté ingresada
			    if (string.IsNullOrWhiteSpace(cedulatb.Text))
			    {
			        MessageBox.Show("Por favor, ingrese la cédula del auditor a modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			        return;
			    }
				string cedula = cedulatb.Text;
			    // Leer el archivo y buscar el auditor
			    string[] lines = File.ReadAllLines(arch_auditores);
			    MessageBox.Show(lines.Length.ToString());
			    string auditorData = lines.FirstOrDefault(line => line.StartsWith(cedula + ","));
			
			    if (auditorData != null)
			    {
			        // Separar los datos del auditor
			        string[] data = auditorData.Split(',');
			
			        // Modificar el título y la dirección
			        data[3] = direcciontb.Text; // Nueva dirección
			        data[4] = titulotb.Text; // Nuevo título
			
			        // Crear una nueva línea con los datos modificados
			        string modifiedAuditorData = string.Join(",", data);
			
			        // Reemplazar la línea en el archivo
			        lines[Array.IndexOf(lines, auditorData)] = modifiedAuditorData;
			        File.WriteAllLines(arch_auditores, lines);
			
			        MessageBox.Show("Auditor modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);			         
			        
			    }
			    else
			    {
			        MessageBox.Show("Auditor no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			    }
			    eliminarbt.Enabled = true;
    			buscaraauditorbt.Enabled = false;
    			guardarAuditor.Enabled = true;
			}
		
		
		//boton limpiar
		void LimpiarauditorbtClick(object sender, EventArgs e)
		{
			LimpiarCampos();
			buscaraauditorbt.Enabled = true;
			buscaraauditorbt.Enabled = true;
		}
		
		//bototon volver submenu
		void VolverbtClick(object sender, EventArgs e)
		{
		this.Hide();
		submenu1 ventana = new submenu1();
		ventana.Show();
		}
		
	}
	
}
