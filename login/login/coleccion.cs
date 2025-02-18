using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;


namespace login
{
	
	public class coleccion
	{
		private List<Sistema> sistemas = new List<Sistema>();
		private string archivo = "sistema.txt"; // Archivo binario para guardar los sistemas
		
		public 	void agregar(Sistema sistema)
		{
			// Verifica si ya existe un sistema con el mismo RIF para evitar duplicados
			if (sistemas.Any(s => s.RIF == sistema.RIF))
				throw new Exception("El sistema ya esta registrado con este RIF.");
			
			// Agrega el nuevo sistema a la lista y guarda los cambios en el archivo binario
			sistemas.Add(sistema);
			Guardar(); // Guardar cambios en archivo
		}
		
		public void Actualizar(string rif, Sistema nuevoSistema)
		{
			var sistema = sistemas.FirstOrDefault(s => s.RIF == rif);
			if (sistema == null) throw new Exception("Sistema no encotrado.");
			
			// Se actualizan los datos del sistema
			sistema.Empresa = nuevoSistema.Empresa;
			sistema.Direccion = nuevoSistema.Direccion;
			sistema.Auditoria = nuevoSistema.Auditoria;
			sistema.Inicio = nuevoSistema.Inicio;
			sistema.Final = nuevoSistema.Final;
			
			Guardar();
		}
		
		public Sistema Consultar(string rif)
		{
			return sistemas.FirstOrDefault(s => s.RIF == rif);
		}
		public List<Sistema> ObtenerTodos()
		{
			return sistemas;
		}
		
		private void Guardar()
		{
			using (FileStream fs = new FileStream(archivo, FileMode.Create))
    		{
        		BinaryFormatter bf = new BinaryFormatter();
        		bf.Serialize(fs, sistemas); 
   			 }
		}
		public void Cargar()
		{
    		if (File.Exists(archivo)) // Verifica si el archivo existe antes de abrirlo
   	 		{
        		using (FileStream fs = new FileStream(archivo, FileMode.Open))
        		{
            		BinaryFormatter bf = new BinaryFormatter();
            		sistemas = (List<Sistema>)bf.Deserialize(fs); 
        		}
    		}
		}
		
	
	}
}
