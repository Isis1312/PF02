using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;

namespace login
{
	public class ColeccionProcesos
	{
		
		private List<Proceso> procesos = new List<Proceso>();
		private string archivo = "procesos.dat";
		
		private List<string> _datos;

		
		
		public void AgregarProceso(Proceso proceso)
		{
			procesos.Add(proceso);
			Guardar();
		}
		 
		public List<Proceso> ObtenerTodos()
		{
			return procesos;
		}
		public List<Proceso> ConsultarAuditoria(string auditor)
		{
			return procesos.Where(p => p.Auditor == auditor).ToList();
		}
		public List<Proceso> ConsultarPorFecha(DateTime inicio, DateTime fin)
		{
			return procesos.Where(p => p.Fecha >= inicio && p.Fecha <= fin).ToList();
		}
		private void Guardar()
		{
			 using (FileStream fs = new FileStream(archivo, FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, procesos);
            }
		}
		public void Cargar()
		{
			if (File.Exists(archivo))
            {
                using (FileStream fs = new FileStream(archivo, FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    procesos = (List<Proceso>)bf.Deserialize(fs);
                }
			}
		}
		
		
		
		public ColeccionProcesos()
		{
		}
	}
}