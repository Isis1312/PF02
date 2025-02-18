
using System;

namespace login
{
	[Serializable] 
	public class Inicio
	
	{
		private string usuario;
		private string contraseña;

		public string Usuario {get{return usuario;}set{usuario=value;}}
		public string Contraseña{get{return contraseña;}set{contraseña=value;}}
		
		public Inicio(string usuario, string contraseña)
		{
		Usuario= usuario;
		Contraseña= contraseña;	
		}
	}
}
