using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;

namespace login
{
	[Serializable] // Permite serializar la clase para guardarla en un archivo
	public class Sistema
	{
		
  
        private string empresa; // Nombre de la empresa
        private string rif; // el numero de RIF
        private string direccion; // Dirección de la auditoria
        private string auditoria; // Sistema de la auditoría 
        private string inicio; // Fecha de inicio 
        private string final; // Fecha final
            
        public string Empresa { get { return empresa; } set { empresa = value; } }
        public string RIF { get { return rif; } set { rif = value; } }
        public string Direccion { get { return direccion; } set { direccion = value; } }
        public string Auditoria { get { return auditoria; } set { auditoria = value; } }
        public string Inicio { get { return inicio; } set { inicio = value; } } // Corrección aquí
        public string Final { get { return final; } set { final = value; } }
            
        public Sistema()
        {
            
        }
    }
	
	}

