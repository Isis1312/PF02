using System;

namespace PF01
{
	[Serializable] 
	public class Class1
	{
		private string usuario;
		private string contraseña;

		public string Usuario {get{return usuario;}set{usuario=value;}}
		public string Contraseña{get{return contraseña;}set{contraseña=value;}}
		
		public Class1(string usuario, string contraseña)
		{
			Usuario= usuario;
			Contraseña= contraseña;
		}
	}
}
