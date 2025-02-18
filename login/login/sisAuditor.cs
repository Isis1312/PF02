using System.Runtime.Serialization.Formatters.Binary;
using System;

namespace sisAuditor
{
	[Serializable]
	public class Auditor
	{
		private string cedula;
		private string nombre;
		private string apellido;
		private string direccion;
		private string titulo;
		private string fc_nacido;
		private string fc_ingreso;
		private char sexo;
		private Boolean estado;
		
		public string Cedula {get{ return cedula;} set{ cedula = value;}}
		public string Nombre  {get{ return nombre ;} set{ nombre = value;}}
		public string Apellido  {get{ return apellido ;} set{ apellido  = value;}}
		public string Direccion  {get{ return direccion ;} set{ direccion  = value;}}
		public string Titulo  {get{  return titulo;} set{ titulo = value;}}
		public string Fc_nacido  {get{ return fc_nacido ;} set{ fc_nacido = value;}}
		public string Fc_ingreso  {get{ return fc_ingreso;} set{ fc_ingreso  = value;}}
		public char Sexo   {get{ return sexo ;} set{ sexo = value;}}
		public Boolean Estado   {get{ return estado;} set{ estado  = value;}}
		
		
		
		public Auditor()
	    {
	        
	    }
		
	}
}
