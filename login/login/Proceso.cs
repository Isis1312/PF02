using System;

namespace login
{
	[Serializable]
	public class Proceso
	{
		    private string descripcion;
			private string auditor;
			private string sistema;
			private DateTime fecha;
			private int hora;
			private string resultado; 
			private bool fallas;
			
			public string Descripcion{get{return descripcion;}set{descripcion = value;}}
			public string Auditor{get{return auditor;}set{auditor = value;}}
		    public string Sistema{get{return sistema;}set{sistema = value;}}
		    public DateTime Fecha { get { return fecha; } set { fecha = value;}} 
		    public int Hora { get { return hora; } set { hora = value;}}
 			public string Resultado { get { return resultado; } set { resultado = value; }} 
 			public bool Fallas { get { return fallas; } set { fallas = value; }}
 			
		    
		public Proceso(string descripcion,string auditor,string sistema,DateTime fecha,int hora,string resultado,bool fallas)
		{
			 Descripcion = descripcion;
			 Auditor = auditor;
			 Sistema = sistema;
			 Fecha = fecha; 
			 Hora = hora;
			 Resultado = resultado;
			 Fallas = fallas;
		}
	}
}
