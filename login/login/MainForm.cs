
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization;
using login;

namespace login
{

	public partial class MainForm : Form
	{
		//lista de suario
			private List<Inicio> usuarios;
			//ruta de archivo de datos
			private string filePath = "username.dat";
			//generar numero aleatorio
				private Random random = new Random();
		
		public MainForm()
		{
			InitializeComponent();
			CargarUsuarios();
			
		}
		
		private void ValidarYAcceder()
		{
			string usuario = txtUsuario.Text;
			string contraseña = txtcontraseña.Text;
			
			MessageBox.Show("Intentando validar: ${usuario} / ${contraseña}", "Depuración", MessageBoxButtons.OK, MessageBoxIcon.Information);
			
			if(ValidarUsuario(usuario, contraseña))
			{
				
				
				this.DialogResult = DialogResult.OK;
				this.Hide();
				submenu1 ventana = new submenu1();
				ventana.Show();
				
			}
			else
			{
				MessageBox.Show("usuario o contraseña incorrecta","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		private bool ValidarUsuario(string usuario, string contraseña)
		{
		bool usuarioEncontrado = usuarios.Exists(u => u.Usuario == usuario && u.Contraseña == contraseña);

    	MessageBox.Show(usuarioEncontrado ? "Usuario encontrado" : "Usuario NO encontrado", "Depuración", MessageBoxButtons.OK, MessageBoxIcon.Information);

    	return usuarioEncontrado;
		}
		
		private void MoverBoton()
		{
			int maxX = this.ClientSize.Width - btnAcceso.Width;
			int maxY = this.ClientSize.Height - btnAcceso.Height;	

			btnAcceso.Location = new Point(random.Next(0, maxX), random.Next(0, maxY));			
		}
		
		private void CargarUsuarios()
		{
    		if (File.Exists(filePath))
    		{
        		try
        		{
            		using (FileStream fs = new FileStream(filePath, FileMode.Open))
           			{
                		BinaryFormatter bf = new BinaryFormatter();
                		usuarios = (List<Inicio>)bf.Deserialize(fs);
            		}
       			}
        		catch (SerializationException)
       		 	{
            		MessageBox.Show("Error al cargar usuarios. El archivo puede estar corrupto. Se inicializará una lista vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           		 	usuarios = new List<Inicio>(); // Se reinicia la lista
            		File.Delete(filePath); //  Elimina el archivo corrupto
            		GuardarUsuario(); //  Crea uno nuevo con usuario por defecto
        		}
        		catch (IOException ex)
        		{
            		MessageBox.Show("Error al acceder al archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            		usuarios = new List<Inicio>(); // Se inicializa lista vacía en caso de error
        		}
    	}
    		else
    		{
    			usuarios = new List<Inicio>(){new Inicio("admin", "1234")}; //  Usuario por defecto
        		GuardarUsuario(); // Se guarda correctamente el archivo
   	 		}
    		
    		MessageBox.Show("Usuarios cargados: {usuarios.Count}", "Depuración", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		
		private void GuardarUsuario()
			{
		
				using (FileStream fs = new FileStream(filePath, FileMode.Create))
            	{
                	BinaryFormatter bf = new BinaryFormatter();
                	bf.Serialize(fs, usuarios);
            	}
		}
		
		private void CrearUsuario()
		{
			
            string nuevoUsuario = MostrarInputBox("Ingrese el nombre de usuario:", "Crear Usuario");
   			string nuevaContraseña = MostrarInputBox("Ingrese la contraseña:", "Crear Usuario");
   			
            if (!string.IsNullOrWhiteSpace(nuevoUsuario) && !string.IsNullOrWhiteSpace(nuevaContraseña))
            {
            usuarios.Add(new Inicio(nuevoUsuario, nuevaContraseña));
            GuardarUsuario();
            MessageBox.Show("Usuario creado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Los campos no pueden estar vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
		}
		
		private string MostrarInputBox(string mensaje, string titulo)
		{
    		Form prompt = new Form()
    	{
        	Width = 300,
        	Height = 150,
        	FormBorderStyle = FormBorderStyle.FixedDialog,
        	Text = titulo,
        	StartPosition = FormStartPosition.CenterScreen
   		 };

    		Label textLabel = new Label() { Left = 10, Top = 20, Text = mensaje };
    		TextBox textBox = new TextBox() { Left = 10, Top = 50, Width = 260 };
    		Button confirmation = new Button() { Text = "Aceptar", Left = 100, Width = 100, Top = 80 };

    		confirmation.Click += (sender, e) => { prompt.Close(); };
   			prompt.Controls.Add(textLabel);
    		prompt.Controls.Add(textBox);
    		prompt.Controls.Add(confirmation);
    		prompt.AcceptButton = confirmation; // Permite cerrar con Enter
    		prompt.ShowDialog();

    		return textBox.Text;
		}
		
		
		
		void BtnAccesoClick(object sender, EventArgs e)
		{
			MoverBoton();
		}
		void BtnAccesoMouseEnter(object sender, EventArgs e)
		{
			if(string.IsNullOrWhiteSpace(txtcontraseña.Text))
			{
				MoverBoton();
			}
		}
		
		void BtnCrearClick(object sender, EventArgs e)
		{
		CrearUsuario();
		}
		void BtnIngresarClick(object sender, EventArgs e)
		{
			
		ValidarYAcceder();
		}
	}
}

